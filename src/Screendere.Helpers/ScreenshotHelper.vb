Imports System.Drawing.Imaging
Imports System.IO
Imports Screendere.SteamHelper

Public Class ScreenshotHelper
    Public Shared Property ScreenshotPath As String = SteamPath & "\userdata\" & Form1.UIDTextBox.Text & "\760\remote\759220\screenshots\"

    Public Shared Sub CaptureScreenshot()
        Using Img As Image = New Bitmap(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height, PixelFormat.Format24bppRgb)
            Using G As Graphics = Graphics.FromImage(Img)
                Dim ScreenSize As Size = New Size(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
                G.CopyFromScreen(New Point(0, 0), New Point(0, 0), ScreenSize, CopyPixelOperation.SourceCopy)
            End Using

            'Create the screenshots folder if it doesn't exist
            If Not Directory.Exists(ScreenshotPath) Then
                Directory.CreateDirectory(ScreenshotPath)
            End If

            'Save the screenshot
            Img.Save(ScreenshotPath & Now.ToString("yyyyMMddHHmmss_fff") & ".png", ImageFormat.Png)

            'Play screenshot sound
            If FormSettings.SoundChkBox.Checked = True Then
                My.Computer.Audio.Play(My.Resources.Screenshot, AudioPlayMode.Background)
            End If

            'Display notification and a thumbnail of the screenshot
            If FormSettings.NotificationChkBox.Checked = True Then
                FormNotification.ThumbnailBox.Image = New Bitmap(Img, New Size(FormNotification.ThumbnailBox.Width, FormNotification.ThumbnailBox.Height))
                FormNotification.Show()
            End If
        End Using
    End Sub
End Class
