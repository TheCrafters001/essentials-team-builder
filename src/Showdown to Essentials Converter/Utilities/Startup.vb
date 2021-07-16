Public Class Startup
    Public Shared Sub Init()
        Form1.numPoké_cmb.SelectedIndex = 0
        '
        ' pokemonOne
        '
        Form1.pokemonOneGender_cmb.SelectedIndex = 2
        Form1.pokemonOneNature_cmb.SelectedIndex = 0
        Form1.pokemonOneAbility_cmb.SelectedIndex = 0
        Form1.pokemonOneShinyFalse_rad.Checked = True
        Form1.pokemonOneShadowFalse_rad.Checked = True
        Form1.pokemonOnePokeballID_cmb.SelectedIndex = 0
        '
        ' pokemonTwo
        '
        Form1.pokemonTwoGender_cmb.SelectedIndex = 2
        Form1.pokemonTwoNature_cmb.SelectedIndex = 0
        Form1.pokemonTwoAbility_cmb.SelectedIndex = 0
        Form1.pokemonTwoShinyFalse_rad.Checked = True
        Form1.pokemonTwoShadowFalse_rad.Checked = True
        Form1.pokemonTwoPokeballID_cmb.SelectedIndex = 0
        '
        ' pokemonThree
        '
        Form1.pokemonThreeGender_cmb.SelectedIndex = 2
        Form1.pokemonThreeNature_cmb.SelectedIndex = 0
        Form1.pokemonThreeAbility_cmb.SelectedIndex = 0
        Form1.pokemonThreeShinyFalse_Rad.Checked = True
        Form1.pokemonThreeShadowFalse_rad.Checked = True
        Form1.pokemonThreePokeballID_cmb.SelectedIndex = 0
        '
        ' pokemonFour
        '
        Form1.pokemonFourGender_cmb.SelectedIndex = 2
        Form1.pokemonFourNature_cmb.SelectedIndex = 0
        Form1.pokemonFourAbility_cmb.SelectedIndex = 0
        Form1.pokemonFourShinyFalse_rad.Checked = True
        Form1.pokemonFourShadowFalse_rad.Checked = True
        Form1.pokemonFourPokeballID_cmb.SelectedIndex = 0
        '
        ' pokemonFive
        '
        Form1.pokemonFiveGender_cmb.SelectedIndex = 2
        Form1.pokemonFiveNature_cmb.SelectedIndex = 0
        Form1.pokemonFiveAbility_cmb.SelectedIndex = 0
        Form1.pokemonFiveShinyFalse_rad.Checked = True
        Form1.pokemonFiveShadowFalse_rad.Checked = True
        Form1.pokemonFivePokeballID_cmb.SelectedIndex = 0
        '
        ' pokemonSix
        '
        Form1.pokemonSixGender_cmb.SelectedIndex = 2
        Form1.pokemonSixNature_cmb.SelectedIndex = 0
        Form1.pokemonSixAbility_cmb.SelectedIndex = 0
        Form1.pokemonSixShinyFalse_rad.Checked = True
        Form1.pokemonSixShadowFalse_rad.Checked = True
        Form1.pokemonSixPokeballID_cmb.SelectedIndex = 0
        '
        ' Load TrainersFile
        '
        Form1.trainers_txt_txt.Text = My.Settings.TrainersFile
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
