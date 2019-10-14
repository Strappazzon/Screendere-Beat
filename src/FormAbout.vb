Public Class FormAbout
    Private Sub FormAbout_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.Closing
        Form1.Enabled = True
        Dispose()
    End Sub

    Private Sub HomepageLabel_Click(sender As Object, e As EventArgs) Handles HomepageLabel.Click
        Process.Start("https://strappazzon.github.io/Screendere-Beat/index.html")
    End Sub

    Private Sub Support_Click(sender As Object, e As EventArgs) Handles Support.Click
        Process.Start("https://github.com/Strappazzon/Screendere-Beat/issues")
    End Sub

    Private Sub Changelog_Click(sender As Object, e As EventArgs) Handles ChangelogLabel.Click
        Process.Start("https://github.com/Strappazzon/Screendere-Beat/blob/master/CHANGELOG.txt")
    End Sub

    Private Sub LicenseLabel_Click(sender As Object, e As EventArgs) Handles LicenseLabel.Click
        Process.Start("https://github.com/Strappazzon/Screendere-Beat/blob/master/LICENSE.txt")
    End Sub
End Class
