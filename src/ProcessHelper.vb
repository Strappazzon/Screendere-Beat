'//stackoverflow.com/a/41882415
Public NotInheritable Class ProcessHelper
    Private Sub New()
    End Sub

    Private Declare Function GetForegroundWindow Lib "user32" () As IntPtr
    Private Declare Function GetWindowThreadProcessId Lib "user32" (ByVal hWnd As IntPtr, ByRef lpdwProcessId As UInteger) As Integer

    Public Shared Function GetActiveProcess() As Process
        Dim FocusedWindow As IntPtr = GetForegroundWindow()
        If FocusedWindow = IntPtr.Zero Then
            Return Nothing
        End If

        Dim FocusedWindowPID As UInteger = 0
        GetWindowThreadProcessId(FocusedWindow, FocusedWindowPID)

        If FocusedWindowPID = 0 Then
            Return Nothing
        End If

        Return Process.GetProcessById(FocusedWindowPID)
    End Function
End Class
