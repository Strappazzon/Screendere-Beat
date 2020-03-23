Imports System.IO
Imports IniParser
Imports IniParser.Model

Public Class Settings
    Private Shared ReadOnly SettingsFile As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Screendere\settings.ini"
    Private Shared ReadOnly IniParser = New FileIniDataParser()

    Public Shared Sub Init()
        If Not File.Exists(SettingsFile) Then
            'Create directory
            Directory.CreateDirectory(SettingsFile.Replace("\settings.ini", ""))

            'Create default settings
            Dim SettingsData As IniData = New IniData()
            SettingsData("screendere")("steamid") = Nothing
            SettingsData("screendere")("playsound") = "True"
            SettingsData("screendere")("checkupdates") = "False"

            'Write settings to file
            File.WriteAllText(SettingsFile, SettingsData.ToString())
        Else
            'Load settings
            Form1.UIDTextBox.Text = SteamID()
            Form1.SoundChkBox.Checked = PlaySound()
            Form1.UpdatesChkBox.Checked = CheckUpdates()
        End If
    End Sub

    Public Shared Sub Save()
        'Save settings

        'Get settings
        Dim SettingsData As IniData = New IniData()
        SettingsData("screendere")("steamid") = Form1.UIDTextBox.Text
        SettingsData("screendere")("playsound") = Form1.SoundChkBox.Checked
        SettingsData("screendere")("checkupdates") = Form1.UpdatesChkBox.Checked

        'Create directory if it's been deleted
        If Not Directory.Exists(SettingsFile.Replace("\settings.ini", "")) Then
            Directory.CreateDirectory(SettingsFile.Replace("\settings.ini", ""))
        End If

        'Write settings to file
        File.WriteAllText(SettingsFile, SettingsData.ToString())
    End Sub

#Region "Settings"
    Private Shared Function SteamID() As String
        Dim Data As IniData = IniParser.ReadFile(SettingsFile)

        Dim SteamUID As String = Data("screendere")("steamid")
        Return SteamUID
    End Function

    Private Shared Function PlaySound() As Boolean
        Dim Data As IniData = IniParser.ReadFile(SettingsFile)

        Dim PlayScreenshotSound As String = Data("screendere")("playsound")
        If PlayScreenshotSound <> Nothing Then
            Return Boolean.Parse(PlayScreenshotSound)
        Else
            Return True
        End If
    End Function

    Private Shared Function CheckUpdates() As Boolean
        Dim Data As IniData = IniParser.ReadFile(SettingsFile)

        Dim UpdatesEnabled As String = Data("screendere")("checkupdates")
        If UpdatesEnabled <> Nothing Then
            Return Boolean.Parse(UpdatesEnabled)
        Else
            Return False
        End If
    End Function
#End Region
End Class
