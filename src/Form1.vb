Imports Microsoft.Win32
Imports System.Drawing.Imaging
Imports System.IO

Public Class Form1
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Integer
    Private WithEvents KeyTimer As New Timer
    Private SteamPath As String
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
        Dim Encoders() As ImageCodecInfo = ImageCodecInfo.GetImageEncoders()

        Dim j As Integer = 0
        While j < Encoders.Length
            If Encoders(j).FormatID = format.Guid Then
                Return Encoders(j)
            End If

            j += 1
        End While

        Return Nothing
    End Function

    Private Sub CaptureScreenshot()
        Using S As New Bitmap(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
            Using G = Graphics.FromImage(S)
                Dim Screen As Size = New Size(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
                G.CopyFromScreen(New Point(0, 0), New Point(0, 0), Screen)
            End Using

            'Screenshot quality
            '//docs.microsoft.com/en-us/dotnet/api/system.drawing.imaging.encoderparameter
            Dim EncoderParams As EncoderParameters = New EncoderParameters(1)
            EncoderParams.Param(0) = New EncoderParameter(Encoder.Quality, 100L)

            'Screenshot folder
            Dim ScreenshotPath As String = SteamPath & "\userdata\" & UIDTextBox.Text & "\760\remote\759220\screenshots\"

            'Create the screenshots folder if it doesn't exist
            If Not Directory.Exists(ScreenshotPath) Then
                Directory.CreateDirectory(ScreenshotPath)
            End If

            'Save the screenshot
            S.Save(ScreenshotPath & Now.ToString("yyyyMMddHHmmss_fff") & ".jpg", GetEncoderInfo(ImageFormat.Jpeg), EncoderParams)

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
        Using SteamRegKey As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\WOW6432Node\Valve\Steam")
            Try
                SteamPath = SteamRegKey.GetValue("InstallPath")

                KeyTimer.Interval = 100
                KeyTimer.Start()
            Catch ex As Exception
                MessageBox.Show(("Screendere Beat was unable to detect the Steam installation folder: " & ex.Message()).Replace("..", "."), "Steam is not installed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Application.Exit()
            End Try
        End Using
    End Sub

    Private Sub Form1_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Save settings
        My.Settings.SteamUID = UIDTextBox.Text
        My.Settings.PlaySound = SoundChkBox.Checked
    End Sub

    Private Sub KeyTimer_Tick(sender As Object, ByVal e As EventArgs) Handles KeyTimer.Tick
        'Capture a screenshot whenever F12 key is pressed if the user typed in a Steam user ID and the game has focus
        If GetAsyncKeyState(Keys.F12) AndAlso (UIDTextBox.Text <> "" And (ProcessHelper.GetActiveProcess() IsNot Nothing AndAlso String.Equals(ProcessHelper.GetActiveProcess().ProcessName, "Hinedere Beat", StringComparison.OrdinalIgnoreCase))) Then
            CaptureScreenshot()
        End If
    End Sub

    Private Sub AboutLabel_Click(sender As Object, e As EventArgs) Handles AboutLabel.Click
        FormAbout.ShowDialog()
    End Sub

    Private Sub PlayImage_Click(sender As Object, e As EventArgs) Handles PlayImage.Click
        Process.Start("steam://run/759220")
    End Sub

    Private Sub UIDHelpLabel_Click(sender As Object, e As EventArgs) Handles UIDHelpLabel.Click
        MessageBox.Show("Screendere Beat needs your Steam ID to know where to save your Hinedere Beat screenshots to." & Environment.NewLine & Environment.NewLine & "Click the Help button or consult the Readme file for more information.",
                        "Steam ID", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                        0, "https://strappazzon.xyz/Screendere-Beat/#getting-started")
    End Sub

    Private Sub UIDTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UIDTextBox.KeyPress
        'Accept only numbers
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub
End Class
