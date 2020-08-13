
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Startup.Init()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Startup.TimerChecker()
    End Sub

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        If codeExporter_dialog.ShowDialog = DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(codeExporter_dialog.FileName, outputBox_rchBox.Text, False)
            MessageBox.Show("File Saved at: " & codeExporter_dialog.FileName)
        End If
    End Sub

    Private Sub generate_btn_Click(sender As Object, e As EventArgs) Handles generate_btn.Click
        If numPoké_cmb.Text = "1" Then
            Generator.OnePokemon()
        ElseIf numPoké_cmb.Text = "2" Then

        ElseIf numPoké_cmb.Text = "3" Then

        ElseIf numPoké_cmb.Text = "4" Then

        ElseIf numPoké_cmb.Text = "5" Then

        ElseIf numPoké_cmb.Text = "6" Then

        End If
    End Sub
End Class
