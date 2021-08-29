Public Class Form1
    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(".\Showdown to Essentials 18 & 19 Converter.exe") Then
            convertersList.Items.Add("Showdown to Essentials 18 & 19 Converter")
        End If
        If My.Computer.FileSystem.FileExists(".\Showdown to Essentials 17 Converter.exe") Then
            convertersList.Items.Add("Showdown to Essentials 17 Converter")
        End If
        launchSelected_btn.Enabled = False
    End Sub

    Private Sub convertersList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles convertersList.SelectedIndexChanged
        If convertersList.SelectedItem = "Showdown to Essentials 18 && 19 Converter" Then
            PictureBox1.Image = My.Resources.Essentials18_19Only
            convertersInfo_txt.Text = "Showdown to Essentials 18 && 19 Converter will let you convert Pokémon created in the Showdown format, and turn it into the Essentials format. This only works for Pokémon Essentials 18, 18.1, 19, and 19.1"
            launchSelected_btn.Enabled = True
        ElseIf convertersList.SelectedItem = "Showdown to Essentials 17 Converter" Then
            PictureBox1.Image = My.Resources.Essentials17Only
            convertersInfo_txt.Text = "Showdown to Essentials 17 Converter will let you convert Pokémon created in the Showdown format, and turn it into the Essentials format. This only works for Pokémon Essentials 17, 17.1, and 17.2"
            launchSelected_btn.Enabled = True
        Else
            convertersInfo_txt.Text = "Select a version on the left to get started." & vbCrLf & "<--------------"
            launchSelected_btn.Enabled = False
        End If
    End Sub

    Private Sub launchSelected_btn_Click(sender As Object, e As EventArgs) Handles launchSelected_btn.Click
        If convertersList.SelectedItem = "Showdown to Essentials 18 & 19 Converter" Then
            Try
                Dim pHelp As New ProcessStartInfo
                pHelp.FileName = ".\Showdown to Essentials 18 & 19 Converter.exe"
                pHelp.Arguments = ""
                pHelp.UseShellExecute = True
                pHelp.WindowStyle = ProcessWindowStyle.Normal
                Dim proc As Process = Process.Start(pHelp)
                Application.Exit()
            Catch ex As Exception
                MessageBox.Show("Couldn't launch. Is it installed?", "Error")
            End Try
        ElseIf convertersList.SelectedItem = "Showdown to Essentials 17 Converter" Then
            Try
                Dim pHelp As New ProcessStartInfo
                pHelp.FileName = ".\Showdown to Essentials 17 Converter.exe"
                pHelp.Arguments = ""
                pHelp.UseShellExecute = True
                pHelp.WindowStyle = ProcessWindowStyle.Normal
                Dim proc As Process = Process.Start(pHelp)
                Application.Exit()
            Catch ex As Exception
                MessageBox.Show("Couldn't launch. Is it installed?", "Error")
            End Try
        Else
            MessageBox.Show("You have selected an invalid version. Please select a valid version from the list.", "Error")
        End If
    End Sub
End Class
