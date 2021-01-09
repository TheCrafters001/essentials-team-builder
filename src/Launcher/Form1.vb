Public Class Form1
    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pe17_pic.Click
        Try
            Dim pHelp As New ProcessStartInfo
            pHelp.FileName = ".\Showdown to Essentials 17 Converter.exe"
            pHelp.Arguments = ""
            pHelp.UseShellExecute = True
            pHelp.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(pHelp)
            Application.Exit()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error")
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles pe18_pic.Click
        Try
            Dim pHelp As New ProcessStartInfo
            pHelp.FileName = ".\Showdown to Essentials 18 Converter.exe"
            pHelp.Arguments = ""
            pHelp.UseShellExecute = True
            pHelp.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(pHelp)
            Application.Exit()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error")
        End Try
    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles pe17_pic.MouseHover
        pe17_pic.BackColor = Color.Gray
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles pe17_pic.MouseLeave
        pe17_pic.BackColor = SystemColors.Control
    End Sub
    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles pe18_pic.MouseHover
        pe18_pic.BackColor = Color.Gray
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles pe18_pic.MouseLeave
        pe18_pic.BackColor = SystemColors.Control
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
