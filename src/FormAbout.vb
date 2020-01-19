Public Class FormAbout
    Private Sub HomepageLabel_Click(sender As Object, e As EventArgs) Handles HomepageLabel.Click
        Process.Start("https://strappazzon.xyz/Screendere-Beat/")
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
