Imports System.Drawing.Drawing2D
Imports System.ComponentModel

Public Class FormNotification
    Private WithEvents CloseTimer As New Timer() With {.Interval = 3000}

    Private Sub CloseTimer_Tick(sender As Object, e As EventArgs) Handles CloseTimer.Tick
        Close()
    End Sub

    'Gradient background
    '//stackoverflow.com/a/10845953
    Private Sub FormNotification_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim G As Graphics = e.Graphics
        Dim L As Point = ClientRectangle.Location
        Dim P As Point = New Point(ClientRectangle.Bottom, ClientRectangle.Right)
        Using Gradient As New LinearGradientBrush(L, P, Color.FromArgb(255, 20, 28, 43), Color.FromArgb(255, 42, 46, 51))
            G.FillRectangle(Gradient, e.ClipRectangle)
        End Using
    End Sub

    Private Sub FormNotification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Position notification in the bottom right corner of the screen
        Location = New Point(My.Computer.Screen.Bounds.Width - Width, My.Computer.Screen.Bounds.Height - Height)

        'Close the notification automatically
        CloseTimer.Start()
    End Sub

    Private Sub FormNotification_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'Fade out
        '//www.codeproject.com/questions/601579/howplustoplusmakeplusaplusformplusfadeinplusandplu
        For i = 90 To 10 Step -10
            Opacity = i / 100
            Refresh()
            Threading.Thread.Sleep(50)
        Next

        'Dispose screenshot preview when closing notification
        ThumbnailBox.Image.Dispose()
    End Sub
End Class
