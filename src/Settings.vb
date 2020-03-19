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
            'Create directory
            Directory.CreateDirectory(SettingsFile.Replace("\settings.ini", ""))

            'Create settings
            Dim Data As IniData = New IniData()
            Data("screendere")("steamid") = Nothing
            Data("screendere")("playsound") = "True"

            'Write settings to file
            File.WriteAllText(SettingsFile, Data.ToString())
        End If
    End Sub

    Public Shared Sub SaveSettings()
        'Add settings to IniData
        Dim Data As IniData = New IniData()
        Data("screendere")("steamid") = Form1.UIDTextBox.Text
        Data("screendere")("playsound") = Form1.SoundChkBox.Checked

        'Create directory if it's been deleted
        If Not Directory.Exists(SettingsFile.Replace("\settings.ini", "")) Then
            Directory.CreateDirectory(SettingsFile.Replace("\settings.ini", ""))
        End If

        'Write settings to file
        File.WriteAllText(SettingsFile, Data.ToString())
    End Sub

    Private Shared Function SteamID() As String
        Dim Data As IniData = IniParser.ReadFile(SettingsFile)

        Dim SteamUID As String = Data("screendere")("steamid")
        Return SteamUID
    End Function

    Private Shared Function PlaySound() As Boolean
        Dim Data As IniData = IniParser.ReadFile(SettingsFile)

        Dim PlayScreenshotSound As String = Data("screendere")("playsound")
        Return Boolean.Parse(PlayScreenshotSound)
    End Function
End Class
