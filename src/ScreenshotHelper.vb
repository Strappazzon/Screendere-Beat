Imports System.Drawing.Imaging
Imports System.IO

Public Class ScreenshotHelper
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

    Public Shared Sub CaptureScreenshot()
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
            Dim ScreenshotPath As String = Form1.SteamPath & "\userdata\" & Form1.UIDTextBox.Text & "\760\remote\759220\screenshots\"

            'Create the screenshots folder if it doesn't exist
            If Not Directory.Exists(ScreenshotPath) Then
                Directory.CreateDirectory(ScreenshotPath)
            End If

            'Save the screenshot
            S.Save(ScreenshotPath & Now.ToString("yyyyMMddHHmmss_fff") & ".jpg", GetEncoderInfo(ImageFormat.Jpeg), EncoderParams)

            'Play screenshot sound
            If Form1.SoundChkBox.Checked = True Then
                My.Computer.Audio.Play(My.Resources.screenshot, AudioPlayMode.Background)
            End If
        End Using
    End Sub
End Class
