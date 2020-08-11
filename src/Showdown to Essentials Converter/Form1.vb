Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        numPoké_cmb.SelectedIndex = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If existingBattle_chkBox.Checked = True Then
            battleTeamID_lbl.Enabled = True
            battleTeamID_txtBox.Enabled = True
        ElseIf existingBattle_chkBox.Checked = False Then
            battleTeamID_lbl.Enabled = False
            battleTeamID_txtBox.Enabled = False
        End If
        If trainerUsesItems_chkBox.Checked = True Then
            trainerItems_grp.Enabled = True
        ElseIf trainerUsesItems_chkBox.Checked = False Then
            trainerItems_grp.Enabled = False
        End If
    End Sub

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        If codeExporter_dialog.ShowDialog = DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(codeExporter_dialog.FileName, outputBox_rchBox.Text, False)
            MessageBox.Show("File Saved at: " & codeExporter_dialog.FileName)
        End If
    End Sub
End Class
