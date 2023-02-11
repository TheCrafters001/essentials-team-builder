Public Class Form1
    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Application.Exit()
    End Sub

    Private Sub v17_picBox_Click(sender As Object, e As EventArgs) Handles v17_picBox.Click
        Dim diagResult As DialogResult = MessageBox.Show("Are you sure you want to launch the legacy version?" & vbCr & "It will be removed in a later version.", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)

        If diagResult = DialogResult.Yes Then
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
        End If
    End Sub

    Private Sub v18up_picBox_Click(sender As Object, e As EventArgs) Handles v18up_picBox.Click
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
    End Sub
End Class
