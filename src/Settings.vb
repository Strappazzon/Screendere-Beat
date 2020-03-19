Imports System.IO
Imports IniParser
Imports IniParser.Model

Public Class Settings
    Private Shared ReadOnly SettingsFile As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Screendere\settings.ini"
    Private Shared ReadOnly IniParser = New FileIniDataParser()

    Public Shared Sub InitSettings()
        If File.Exists(SettingsFile) Then
            Form1.UIDTextBox.Text = SteamID()
            Form1.SoundChkBox.Checked = PlaySound()
        Else
            Dim Data As IniData = New IniData()
            Data("screendere")("steamid") = Nothing
            Data("screendere")("playsound") = False

            File.WriteAllText(SettingsFile, Data.ToString())
        End If
    End Sub

    Public Shared Sub SaveSettings()
        Dim Data As IniData = New IniData()
        Data("screendere")("steamid") = Form1.UIDTextBox.Text
        Data("screendere")("playsound") = Form1.SoundChkBox.Checked

        File.WriteAllText(SettingsFile, Data.ToString())
    End Sub

    Public Shared Function SteamID() As String
        Dim Data As IniData = IniParser.ReadFile(SettingsFile)

        Dim SteamUID As String = Data("screendere")("steamid")
        Return SteamUID
    End Function

    Public Shared Function PlaySound() As Boolean
        Dim Data As IniData = IniParser.ReadFile(SettingsFile)

        Dim PlayScreenshotSound As String = Data("screendere")("playsound")
        Return Boolean.Parse(PlayScreenshotSound)
    End Function
End Class
