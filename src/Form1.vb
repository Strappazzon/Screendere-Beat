Imports Microsoft.Win32
Imports System.Drawing.Imaging
Imports System.IO

Public Class Form1
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Integer
    Private WithEvents kTimer As New Timer
    Private steamPath As String
    Private Shared ReadOnly Quality As Encoder

    Private Sub UpgradeSettings()
        'Migrate settings to the new version
        'Unfortunately, settings migrate only if the new version is installed in the same directory as the old version
        '//bytes.com/topic/visual-basic-net/answers/854235-my-settings-upgrade-doesnt-upgrade#post3426232
        If My.Settings.MustUpgrade = True Then
            My.Settings.Upgrade()
            My.Settings.MustUpgrade = False
        End If
    End Sub

    Private Shared Function GetEncoderInfo(ByVal format As ImageFormat) As ImageCodecInfo
        Dim encoders() As ImageCodecInfo = ImageCodecInfo.GetImageEncoders()

        Dim j As Integer = 0
        While j < encoders.Length
            If encoders(j).FormatID = format.Guid Then
                Return encoders(j)
            End If

            j += 1
        End While

        Return Nothing
    End Function

    Private Sub CaptureScreenshot()
        Using S As New Bitmap(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
            Using G = Graphics.FromImage(S)
                Dim screen As Size = New Size(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
                G.CopyFromScreen(New Point(0, 0), New Point(0, 0), screen)
            End Using

            'Screenshot quality
            '//docs.microsoft.com/en-us/dotnet/api/system.drawing.imaging.encoderparameter
            Dim sEncoderParams As EncoderParameters = New EncoderParameters(1)
            sEncoderParams.Param(0) = New EncoderParameter(Encoder.Quality, 100L)

            'Screenshot folder
            Dim sPath As String = steamPath & "\userdata\" & UIDTextBox.Text & "\760\remote\759220\screenshots\"

            'Create the screenshots folder if it doesn't exist
            If Not Directory.Exists(sPath) Then
                Directory.CreateDirectory(sPath)
            End If

            'Save the screenshot
            S.Save(sPath & Now.ToString("yyyyMMddHHmmss_fff") & ".jpg", GetEncoderInfo(ImageFormat.Jpeg), sEncoderParams)

            'Play screenshot sound
            If SoundChkBox.Checked = True Then
                My.Computer.Audio.Play(My.Resources.screenshot, AudioPlayMode.Background)
            End If
        End Using
    End Sub

    Private Sub Tooltip_Draw(sender As Object, e As DrawToolTipEventArgs) Handles Tooltip.Draw
        'Draw tooltip with custom colors
        e.DrawBackground()
        e.DrawBorder()
        e.DrawText()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Migrate settings from old version
        UpgradeSettings()

        'Load settings
        UIDTextBox.Text = My.Settings.SteamUID
        SoundChkBox.Checked = My.Settings.PlaySound

        'Check if Steam is installed
        Dim steamReg As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\WOW6432Node\Valve\Steam")
        Try
            steamPath = steamReg.GetValue("InstallPath")
            steamReg.Close()

            kTimer.Interval = 100
            kTimer.Start()
        Catch nullValue As NullReferenceException
            MessageBox.Show("Screendere Beat requires Steam. If you are trying to use this software with a DRM-free version of the game, you don't need it.", "Steam is not installed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
        End Try
    End Sub

    Private Sub Form1_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Save settings
        My.Settings.SteamUID = UIDTextBox.Text
        My.Settings.PlaySound = SoundChkBox.Checked
    End Sub

    Private Sub kTimer_Tick(sender As Object, ByVal e As EventArgs) Handles kTimer.Tick
        'Capture a screenshot whenever F12 key is pressed, but only if the user typed in a Steam user ID
        If GetAsyncKeyState(Keys.F12) And UIDTextBox.Text <> "" Then
            CaptureScreenshot()
        End If
    End Sub

    Private Sub AboutVersion_Click(sender As Object, e As EventArgs) Handles aboutVersion.Click
        FormAbout.ShowDialog()
    End Sub

    Private Sub PlayImage_Click(sender As Object, e As EventArgs) Handles PlayImage.Click
        Process.Start("steam://run/759220")
    End Sub

    Private Sub UIDHelpLabel_Click(sender As Object, e As EventArgs) Handles UIDHelpLabel.Click
        MessageBox.Show("Screendere Beat needs your Steam ID to know where to save your Hinedere Beat screenshots to." & Environment.NewLine & Environment.NewLine & "Click the Help button or see the Readme file for more information.",
                        "Steam ID", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1,
                        0, "https://strappazzon.xyz/Screendere-Beat/")
    End Sub

    Private Sub UIDTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UIDTextBox.KeyPress
        'Accept only numbers
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub
End Class
