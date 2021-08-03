Public Class Timer
    Public Shared Sub Ticker()
#Region "Exisitng Battles"
        If Form1.existingBattle_chkBox.Checked = True Then
            Form1.battleTeamID_lbl.Enabled = True
            Form1.battleTeamID_txtBox.Enabled = True
        ElseIf Form1.existingBattle_chkBox.Checked = False Then
            Form1.battleTeamID_lbl.Enabled = False
            Form1.battleTeamID_txtBox.Enabled = False
        End If
#End Region
#Region "Uses Items"
        If Form1.trainerUsesItems_chkBox.Checked = True Then
            Form1.trainerItems_grp.Enabled = True
        ElseIf Form1.trainerUsesItems_chkBox.Checked = False Then
            Form1.trainerItems_grp.Enabled = False
        End If
#End Region
#Region "Allow Custom Ball IDs"
        If Form1.customBallIDs_chkBox.Checked = False Then
            Form1.pokemonOnePokeballID_cmb.DropDownStyle = ComboBoxStyle.DropDownList
            Form1.pokemonTwoPokeballID_cmb.DropDownStyle = ComboBoxStyle.DropDownList
            Form1.pokemonThreePokeballID_cmb.DropDownStyle = ComboBoxStyle.DropDownList
            Form1.pokemonFourPokeballID_cmb.DropDownStyle = ComboBoxStyle.DropDownList
            Form1.pokemonFivePokeballID_cmb.DropDownStyle = ComboBoxStyle.DropDownList
            Form1.pokemonSixPokeballID_cmb.DropDownStyle = ComboBoxStyle.DropDownList
        ElseIf Form1.customBallIDs_chkBox.Checked = True Then
            Form1.pokemonOnePokeballID_cmb.DropDownStyle = ComboBoxStyle.DropDown
            Form1.pokemonTwoPokeballID_cmb.DropDownStyle = ComboBoxStyle.DropDown
            Form1.pokemonThreePokeballID_cmb.DropDownStyle = ComboBoxStyle.DropDown
            Form1.pokemonFourPokeballID_cmb.DropDownStyle = ComboBoxStyle.DropDown
            Form1.pokemonFivePokeballID_cmb.DropDownStyle = ComboBoxStyle.DropDown
            Form1.pokemonSixPokeballID_cmb.DropDownStyle = ComboBoxStyle.DropDown
        End If
#End Region
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
