Imports System.Net

Public Class Updater
    Private Const VersionCode As Integer = 1

    Public Shared Sub CheckUpdates()
        'Check for updates
        '//docs.microsoft.com/en-us/dotnet/api/system.net.downloadstringcompletedeventargs
        If Form1.UpdatesChkBox.Checked = True Then
            Using Updater As New WebClient
                Updater.Headers.Add("User-Agent", "Screendere Beat (+https://strappazzon.xyz/Screendere-Beat)")
                Dim VersionURI As New Uri("https://raw.githubusercontent.com/Strappazzon/Screendere-Beat/master/version")
                Updater.DownloadStringAsync(VersionURI)
                'Call updater_DownloadStringCompleted when the download completes
                AddHandler Updater.DownloadStringCompleted, AddressOf Updater_DownloadStringCompleted
            End Using
        End If
    End Sub

    Private Shared Sub Updater_DownloadStringCompleted(ByVal sender As Object, ByVal e As DownloadStringCompletedEventArgs)
        If e.Error() Is Nothing Then
            Dim FetchedVer As Short = e.Result

            'Compare downloaded Screendere Beat version number with the current one
            If FetchedVer > VersionCode Then
                Dim choice = MessageBox.Show("A newer version of Screendere Beat is available. Do you want to visit the download page now?", "Update available", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                If choice = DialogResult.Yes Then
                    Process.Start("https://github.com/Strappazzon/Screendere-Beat/releases/latest")
                End If
            End If
        End If
    End Sub
End Class
