Imports Microsoft.Win32
Imports System.IO
Imports Screendere.ScreenshotHelper
Imports Screendere.Settings
Imports Screendere.SuppressKeys
Imports Screendere.Updater

Public Class Form1
    Private Sub Tooltip_Draw(sender As Object, e As DrawToolTipEventArgs) Handles Tooltip.Draw
        'Draw tooltip with custom colors
        e.DrawBackground()
        e.DrawBorder()
        e.DrawText()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Check if Steam is installed
        Using SteamRegKey As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\WOW6432Node\Valve\Steam")
            Try
                SteamPath = SteamRegKey.GetValue("InstallPath")
            Catch ex As Exception
                MessageBox.Show("Screendere Beat was unable to detect the Steam installation folder: " & ex.Message(), "Steam is not installed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Application.Exit()
            End Try
        End Using

        'Load settings
        InitSettings()

        'Check for updates
        CheckUpdates()

        'Intercept and suppress the screenshot key
        Using OBJCURRENTMODULE As ProcessModule = Process.GetCurrentProcess().MainModule
            'Assign callback function and set hook
            OBJKEYBOARDPROCESS = New LowLevelKeyboardProc(AddressOf CaptureKey)
            PTRHOOK = SetWindowsHookEx(13, OBJKEYBOARDPROCESS, GetModuleHandle(OBJCURRENTMODULE.ModuleName), 0)
        End Using
    End Sub

    Private Sub Form1_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Save settings
        SaveSettings()
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

    Private Sub ScreenshotsDirBtn_Click(sender As Object, e As EventArgs) Handles ScreenshotsDirBtn.Click
        If Directory.Exists(ScreenshotPath) Then
            Process.Start(ScreenshotPath)
        Else
            MessageBox.Show("The screenshots path doesn't exist.", Text)
        End If
    End Sub
End Class
