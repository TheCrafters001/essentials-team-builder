Imports AutoUpdaterDotNET

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Look for different versions, and then add them to the list
        ' Version 18 & 19 is a completely different version in this update,
        ' the old launcher needs to be available for the old versions
        If My.Computer.FileSystem.FileExists(".\Showdown to Essentials 18 and 19 Converter.exe") Then
            convertersList.Items.Add("Showdown to Essentials 18 & 19 Converter")
        End If
        If My.Computer.FileSystem.FileExists(".\Showdown to Essentials 17 Converter.exe") Then
            convertersList.Items.Add("Showdown to Essentials 17 Converter")
        End If
        If My.Computer.FileSystem.FileExists(".\Launcher.exe") Then
            convertersList.Items.Add("Classic Launcher")
        End If
        launch_btn.Enabled = False

        ' Check for Updates
#If DEBUG Then
        AutoUpdater.ShowSkipButton = True
        AutoUpdater.ShowRemindLaterButton = True
        AutoUpdater.ReportErrors = False
        AutoUpdater.RunUpdateAsAdmin = True
        AutoUpdater.LetUserSelectRemindLater = True
        AutoUpdater.DownloadPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "Temp\StEC-Update-Temp\"
        AutoUpdater.UpdateFormSize = New System.Drawing.Size(800, 600)
        AutoUpdater.Start("https://raw.githubusercontent.com/TheCrafters001/showdown-to-essentials/master/src/autoUpdate-PreRelease.xml")
#Else
        AutoUpdater.ShowSkipButton = True
        AutoUpdater.ShowRemindLaterButton = True
        AutoUpdater.ReportErrors = False
        AutoUpdater.RunUpdateAsAdmin = True
        AutoUpdater.LetUserSelectRemindLater = True
        AutoUpdater.DownloadPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "Temp\StEC-Update-Temp\"
        AutoUpdater.UpdateFormSize = New System.Drawing.Size(800, 600)
        AutoUpdater.Start("https://raw.githubusercontent.com/TheCrafters001/showdown-to-essentials/master/src/autoUpdate-Stable.xml")
#End If
    End Sub

    Private Sub convertersList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles convertersList.SelectedIndexChanged
        ' If the selected index gets changed, it will update
        ' the information shown on screen.
        ' To do this, check SelectedItem
        If convertersList.SelectedItem = "Showdown to Essentials 18 & 19 Converter" Then
            logo_picBox.Image = My.Resources.Essentials18_19Only
            convertersInfo_txt.Text = "Showdown to Essentials 18 && 19 Converter will let you convert Pokémon created in the Showdown format, and turn it into the Essentials format. This only works for Pokémon Essentials 18, 18.1, 19, and 19.1"
            launch_btn.Enabled = True
        ElseIf convertersList.SelectedItem = "Showdown to Essentials 17 Converter" Then
            logo_picBox.Image = My.Resources.Essentials17Only
            convertersInfo_txt.Text = "[DISCONTINUED] Showdown to Essentials 17 Converter will let you convert Pokémon created in the Showdown format, and turn it into the Essentials format. This only works for Pokémon Essentials 17, 17.1, and 17.2"
            launch_btn.Enabled = True
        ElseIf convertersList.SelectedItem = "Classic Launcher" Then
            logo_picBox.Image = My.Resources.Showdown_to_Essentials_Logo
            convertersInfo_txt.Text = "This will launch the old launcher so you can gain access an older versions of Showdown to Essentials Converter."
        Else
            convertersInfo_txt.Text = "Select a version on the left to get started." & vbCrLf & "<--------------"
            launch_btn.Enabled = False
        End If
    End Sub

    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        Application.Exit()
    End Sub
End Class
