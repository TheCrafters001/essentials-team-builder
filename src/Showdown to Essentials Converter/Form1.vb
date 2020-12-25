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
            Generator.Trainer()
            Generator.OnePokemon()
        ElseIf numPoké_cmb.Text = "2" Then
            Generator.Trainer()
            Generator.TwoPokemon()
        ElseIf numPoké_cmb.Text = "3" Then
            Generator.Trainer()
            Generator.ThreePokemon()
        ElseIf numPoké_cmb.Text = "4" Then
            Generator.Trainer()
            Generator.FourPokemon()
        ElseIf numPoké_cmb.Text = "5" Then
            Generator.Trainer()
            Generator.FivePokemon()
        ElseIf numPoké_cmb.Text = "6" Then
            Generator.Trainer()
            Generator.SixPokemon()
        End If
    End Sub

    Private Sub example_btn_Click(sender As Object, e As EventArgs) Handles example_btn.Click
        trainerName_txtBox.Text = "Trainer"
        trainerType_txtBox.Text = "Rival"
        numPoké_cmb.SelectedIndex = 0
        trainerUsesItems_chkBox.Checked = True
        itemOne_txtBox.Text = "potion"
        pokemonOneName_txtBox.Text = "Weezing"
        pokemonOneMove1_txtBox.Text = "FireBlast"
        pokemonOneGender_cmb.SelectedIndex = 0
        pokemonOneNickName_txtBox.Text = "Gonzalos"
        pokemonOneLvl_txtBox.Text = "20"
    End Sub
End Class
