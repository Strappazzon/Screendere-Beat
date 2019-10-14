Imports System.Drawing.Imaging
Imports Microsoft.Win32

Public Class Form1
    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Integer
    Public WithEvents kTimer As New Timer
    Public Property steamPath As String
    Public Shared ReadOnly Quality As Encoder

    Private Shared Function GetEncoderInfo(ByVal format As ImageFormat) As ImageCodecInfo
        Dim j As Integer
        Dim encoders() As ImageCodecInfo
        encoders = ImageCodecInfo.GetImageEncoders()

        j = 0

        While j < encoders.Length
            If encoders(j).FormatID = format.Guid Then
                Return encoders(j)
            End If

            j += 1
        End While
        Return Nothing
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load settings
        UIDTextBox.Text = My.Settings.SteamUID
        SoundChkBox.Checked = My.Settings.PlaySound

        'Check if Steam is installed
        Dim steamReg As RegistryKey
        steamReg = Registry.LocalMachine.OpenSubKey("SOFTWARE\WOW6432Node\Valve\Steam")
        Try
            steamPath = steamReg.GetValue("InstallPath")
            steamReg.Close()
        Catch nullValue As NullReferenceException
            MessageBox.Show("Screendere Beat requires Steam. If you are trying to use this software with a DRM-free version of the game, you don't need it.", "Steam is not installed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
        End Try

        kTimer.Interval = 100
        kTimer.Start()
    End Sub

    Private Sub Form1_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Save settings
        My.Settings.SteamUID = UIDTextBox.Text
        My.Settings.PlaySound = SoundChkBox.Checked
    End Sub

    Public Function CaptureScreenshot()
        Dim screen As Size = New Size(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
        Using s As New Bitmap(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
            Using g = Graphics.FromImage(s)
                g.CopyFromScreen(New Point(0, 0), New Point(0, 0), screen)
            End Using

            Dim sCodecInfo As ImageCodecInfo
            Dim sEncoder As Encoder
            Dim sEncoderParam As EncoderParameter
            Dim sEncoderParams As EncoderParameters
            Dim sPath As String = steamPath & "\userdata\" & UIDTextBox.Text & "\760\remote\759220\screenshots\"

            sCodecInfo = GetEncoderInfo(ImageFormat.Jpeg)
            sEncoder = Encoder.Quality
            sEncoderParams = New EncoderParameters(1)
            sEncoderParam = New EncoderParameter(sEncoder, 100L)
            sEncoderParams.Param(0) = sEncoderParam
            's.Save(sPath & Date.Now.ToString("yyyyMMddHHmmss_fff") & ".jpg", sCodecInfo, sEncoderParams)
            s.Save("C:\Users\Root\Desktop\" & Date.Now.ToString("yyyyMMddHHmmss_fff") & ".jpg", sCodecInfo, sEncoderParams)
        End Using

        If SoundChkBox.Checked = True Then
            My.Computer.Audio.Play(My.Resources.screenshot, AudioPlayMode.Background)
        End If
    End Function

    Private Sub kTimer_Tick(sender As Object, ByVal e As EventArgs) Handles kTimer.Tick
        If GetAsyncKeyState(Keys.F12) And UIDTextBox.Text <> "" Then
            CaptureScreenshot()
        End If
    End Sub

    Private Sub AboutVersion_Click(sender As Object, e As EventArgs) Handles aboutVersion.Click
        Enabled = False
        FormAbout.Show()
    End Sub

    Private Sub PlayImage_Click(sender As Object, e As EventArgs) Handles PlayImage.Click
        Process.Start("steam://run/759220")
    End Sub

    Private Sub UIDHelpLabel_Click(sender As Object, e As EventArgs) Handles UIDHelpLabel.Click
        MessageBox.Show("Screendere Beat needs your Steam ID to know where to save your Hinedere Beat screenshots to." _
                        & Environment.NewLine & Environment.NewLine & "Click the Help button or see the Readme file for more information.",
                        "Steam ID", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1,
                        0, "https://strappazzon.github.io/Screendere-Beat/index.html")
    End Sub

    Private Sub UIDTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UIDTextBox.KeyPress
        'Accept only numbers
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub Tooltip_Draw(sender As Object, e As DrawToolTipEventArgs) Handles Tooltip.Draw
        e.DrawBackground()
        e.DrawBorder()
        e.DrawText()
    End Sub
End Class
