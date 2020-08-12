Public Class Startup
    Public Shared Sub Init()
        Form1.numPoké_cmb.SelectedIndex = 0
        Form1.pokemonOneGender_cmb.SelectedIndex = 2
        Form1.pokemonOneNature_cmb.SelectedIndex = 0
        Form1.pokemonOneAbility_cmb.SelectedIndex = 0
        Form1.Timer1.Start()
    End Sub
    Public Shared Sub TimerChecker()
        If Form1.existingBattle_chkBox.Checked = True Then
            Form1.battleTeamID_lbl.Enabled = True
            Form1.battleTeamID_txtBox.Enabled = True
        ElseIf Form1.existingBattle_chkBox.Checked = False Then
            Form1.battleTeamID_lbl.Enabled = False
            Form1.battleTeamID_txtBox.Enabled = False
        End If
        If Form1.trainerUsesItems_chkBox.Checked = True Then
            Form1.trainerItems_grp.Enabled = True
        ElseIf Form1.trainerUsesItems_chkBox.Checked = False Then
            Form1.trainerItems_grp.Enabled = False
        End If
#Region "Page Enabler"
        If Form1.numPoké_cmb.Text = "1" Then
            Form1.pokemonOne_grp.Enabled = True
            Form1.pokemonTwo_grp.Enabled = False
            Form1.pokemonThree_grp.Enabled = False
            Form1.pokemonFour_grp.Enabled = False
            Form1.pokemonFive_grp.Enabled = False
            Form1.pokemonSix_grp.Enabled = False
        ElseIf Form1.numPoké_cmb.Text = "2" Then
            Form1.pokemonOne_grp.Enabled = True
            Form1.pokemonTwo_grp.Enabled = True
            Form1.pokemonThree_grp.Enabled = False
            Form1.pokemonFour_grp.Enabled = False
            Form1.pokemonFive_grp.Enabled = False
            Form1.pokemonSix_grp.Enabled = False
        ElseIf Form1.numPoké_cmb.Text = "3" Then
            Form1.pokemonOne_grp.Enabled = True
            Form1.pokemonTwo_grp.Enabled = True
            Form1.pokemonThree_grp.Enabled = True
            Form1.pokemonFour_grp.Enabled = False
            Form1.pokemonFive_grp.Enabled = False
            Form1.pokemonSix_grp.Enabled = False
        ElseIf Form1.numPoké_cmb.Text = "4" Then
            Form1.pokemonOne_grp.Enabled = True
            Form1.pokemonTwo_grp.Enabled = True
            Form1.pokemonThree_grp.Enabled = True
            Form1.pokemonFour_grp.Enabled = True
            Form1.pokemonFive_grp.Enabled = False
            Form1.pokemonSix_grp.Enabled = False
        ElseIf Form1.numPoké_cmb.Text = "5" Then
            Form1.pokemonOne_grp.Enabled = True
            Form1.pokemonTwo_grp.Enabled = True
            Form1.pokemonThree_grp.Enabled = True
            Form1.pokemonFour_grp.Enabled = True
            Form1.pokemonFive_grp.Enabled = True
            Form1.pokemonSix_grp.Enabled = False
        ElseIf Form1.numPoké_cmb.Text = "6" Then
            Form1.pokemonOne_grp.Enabled = True
            Form1.pokemonTwo_grp.Enabled = True
            Form1.pokemonThree_grp.Enabled = True
            Form1.pokemonFour_grp.Enabled = True
            Form1.pokemonFive_grp.Enabled = True
            Form1.pokemonSix_grp.Enabled = True
        End If
#End Region
    End Sub
End Class
