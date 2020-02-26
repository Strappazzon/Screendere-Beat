Imports System.Runtime.InteropServices
Imports Screendere.ProcessHelper
Imports Screendere.ScreenshotHelper

Public Class SuppressKeys
    'Low-level keyboard input event
    <StructLayout(LayoutKind.Sequential)>
    Private Structure KBDLLHOOKSTRUCT
        Public KEY As Keys
        Public SCANCODE As Integer
        Public FLAGS As Integer
        Public TIME As Integer
        Public EXTRA As IntPtr
    End Structure

    Public Delegate Function LowLevelKeyboardProc(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Shared Function SetWindowsHookEx(
        ByVal idHook As Integer,
        ByVal lpfn As LowLevelKeyboardProc,
        ByVal hMod As IntPtr,
        ByVal dwThreadId As UInteger) As IntPtr
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Shared Function CallNextHookEx(
        ByVal hhk As IntPtr,
        ByVal nCode As Integer,
        ByVal wParam As IntPtr,
        ByVal lParam As IntPtr) As IntPtr
    End Function

    <DllImport("kernel32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Shared Function GetModuleHandle(
        ByVal lpModuleName As String) As IntPtr
    End Function

    Public Shared PTRHOOK As IntPtr
    Public Shared OBJKEYBOARDPROCESS As LowLevelKeyboardProc
    Private Const WM_KEYDOWN As Integer = &H100

    Public Shared Function CaptureKey(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
        '//stackoverflow.com/a/28073683
        If nCode >= 0 AndAlso wParam = CType(WM_KEYDOWN, IntPtr) Then
            Dim OBJKEYINFO As KBDLLHOOKSTRUCT = Marshal.PtrToStructure(lParam, GetType(KBDLLHOOKSTRUCT))
            If OBJKEYINFO.KEY = Keys.F12 Then
                If Form1.UIDTextBox.Text <> "" And (GetActiveProcess() IsNot Nothing AndAlso String.Equals(GetActiveProcess().ProcessName, "Hinedere Beat", StringComparison.OrdinalIgnoreCase)) Then
                    CaptureScreenshot()
                    Return CType(1, IntPtr)
                End If
            End If
        End If

        Return CallNextHookEx(PTRHOOK, nCode, wParam, lParam)
    End Function
End Class
