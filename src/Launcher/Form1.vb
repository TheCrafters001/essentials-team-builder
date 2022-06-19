Public Class Form1
    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Application.Exit()
    End Sub

    Private Sub v17_picBox_Click(sender As Object, e As EventArgs) Handles v17_picBox.Click
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
    End Sub
End Class