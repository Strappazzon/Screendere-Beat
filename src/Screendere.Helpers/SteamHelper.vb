Imports Microsoft.Win32

Public Class SteamHelper
    Public Shared Property SteamPath As String

    Public Shared Sub GetSteamInstall()
        Using SteamRegKey As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\WOW6432Node\Valve\Steam")
            Try
                SteamPath = SteamRegKey.GetValue("InstallPath")
            Catch ex As Exception
                MessageBox.Show("Screendere Beat was unable to detect the Steam installation folder: " & ex.Message(), "Steam is not installed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Application.Exit()
            End Try
        End Using
    End Sub
End Class
