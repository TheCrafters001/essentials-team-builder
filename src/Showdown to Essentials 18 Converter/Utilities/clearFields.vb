Public Class clearFields
    Public Shared Sub Clear()
        Dim DiagResult As DialogResult = MessageBox.Show("Are you sure you want to clear all the fields? This will even clear out Pokémon Data.", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If DiagResult = DialogResult.Yes Then
            ' Set the title of the Trainer Info box, just in case it takes a while.
            Form1.trainerInfoTitle_lbl.Text = "Please wait... Clearing Fields..."

            ' Clear & Reset All Fields

            ' Trainer Info Page
            Form1.trainerName_txtBox.Text = ""
            Form1.trainerType_txtBox.Text = ""
            Form1.loseText_txt.Text = ""
            Form1.numPoké_cmb.SelectedIndex = 0
            Form1.battleTeamID_txtBox.Text = ""
            Form1.existingBattle_chkBox.Checked = False
            Form1.customBallIDs_chkBox.Checked = False
            Form1.trainerUsesItems_chkBox.Checked = False
            Form1.itemOne_txtBox.Text = ""
            Form1.itemTwo_txtBox.Text = ""
            Form1.itemThree_txtBox.Text = ""
            Form1.itemFour_txtBox.Text = ""
            Form1.itemFive_txtBox.Text = ""
            Form1.itemSix_txtBox.Text = ""
            Form1.itemSeven_txtBox.Text = ""
            Form1.itemEight_txtBox.Text = ""

            ' Pokemon One
            Form1.pokemonOneName_txtBox.Text = ""
            Form1.pokemonOneItem_txtBox.Text = ""
            Form1.pokemonOneLvl_txtBox.Text = ""
            Form1.pokemonOneMove1_txtBox.Text = ""
            Form1.pokemonOneMove2_txtBox.Text = ""
            Form1.pokemonOneMove3_txtBox.Text = ""
            Form1.pokemonOneMove4_txtBox.Text = ""
            Form1.pokemonOneGender_cmb.SelectedIndex = 2
            Form1.pokemonOneNature_cmb.SelectedIndex = 0
            Form1.pokemonOneAbility_cmb.SelectedIndex = 0
            Form1.pokemonOneShinyFalse_rad.Checked = True
            Form1.pokemonOneShadowFalse_rad.Checked = True
            Form1.pokemonOnePokeballID_cmb.SelectedIndex = 0
            Form1.pokemonOneForm_txtBox.Text = ""
            Form1.pokemonOneHappyness_txtBox.Text = ""
            Form1.pokemonOneIVsHP_txt.Text = ""
            Form1.pokemonOneIVsATK_txt.Text = ""
            Form1.pokemonOneIVsDEF_txt.Text = ""
            Form1.pokemonOneIVsSPD_txt.Text = ""
            Form1.pokemonOneIVsSPATK_txt.Text = ""
            Form1.pokemonOneIVsSPDEF_txt.Text = ""
            Form1.pokemonOneEVsHP_txt.Text = ""
            Form1.pokemonOneEVsATK_txt.Text = ""
            Form1.pokemonOneEVsDEF_txt.Text = ""
            Form1.pokemonOneEVsSPD_txt.Text = ""
            Form1.pokemonOneEVsSPATK_txt.Text = ""
            Form1.pokemonOneEVsSPDEF_txt.Text = ""
            Form1.pokemonOneNickName_txtBox.Text = ""

            ' Pokemon Two
            Form1.pokemonTwoName_txtBox.Text = ""
            Form1.pokemonTwoItem_txtBox.Text = ""
            Form1.pokemonTwoLvl_txtBox.Text = ""
            Form1.pokemonTwoMove1_txtBox.Text = ""
            Form1.pokemonTwoMove2_txtBox.Text = ""
            Form1.pokemonTwoMove3_txtBox.Text = ""
            Form1.pokemonTwoMove4_txtBox.Text = ""
            Form1.pokemonTwoGender_cmb.SelectedIndex = 2
            Form1.pokemonTwoNature_cmb.SelectedIndex = 0
            Form1.pokemonTwoAbility_cmb.SelectedIndex = 0
            Form1.pokemonTwoShinyFalse_rad.Checked = True
            Form1.pokemonTwoShadowFalse_rad.Checked = True
            Form1.pokemonTwoPokeballID_cmb.SelectedIndex = 0
            Form1.pokemonTwoForm_txtBox.Text = ""
            Form1.pokemonTwoHappyness_txtBox.Text = ""
            Form1.pokemonTwoIVsHP_txt.Text = ""
            Form1.pokemonTwoIVsATK_txt.Text = ""
            Form1.pokemonTwoIVsDEF_txt.Text = ""
            Form1.pokemonTwoIVsSPD_txt.Text = ""
            Form1.pokemonTwoIVsSPATK_txt.Text = ""
            Form1.pokemonTwoIVsSPDEF_txt.Text = ""
            Form1.pokemonTwoEVsHP_txt.Text = ""
            Form1.pokemonTwoEVsATK_txt.Text = ""
            Form1.pokemonTwoEVsDEF_txt.Text = ""
            Form1.pokemonTwoEVsSPD_txt.Text = ""
            Form1.pokemonTwoEVsSPATK_txt.Text = ""
            Form1.pokemonTwoEVsSPDEF_txt.Text = ""
            Form1.pokemonTwoNickName_txtBox.Text = ""

            ' Pokemon Three
            Form1.pokemonThreeName_txtBox.Text = ""
            Form1.pokemonThreeItem_txtBox.Text = ""
            Form1.pokemonThreeLvl_txtBox.Text = ""
            Form1.pokemonThreeMove1_txtBox.Text = ""
            Form1.pokemonThreeMove2_txtBox.Text = ""
            Form1.pokemonThreeMove3_txtBox.Text = ""
            Form1.pokemonThreeMove4_txtBox.Text = ""
            Form1.pokemonThreeGender_cmb.SelectedIndex = 2
            Form1.pokemonThreeNature_cmb.SelectedIndex = 0
            Form1.pokemonThreeAbility_cmb.SelectedIndex = 0
            Form1.pokemonThreeShinyFalse_Rad.Checked = True
            Form1.pokemonThreeShadowFalse_rad.Checked = True
            Form1.pokemonThreePokeballID_cmb.SelectedIndex = 0
            Form1.pokemonThreeForm_txtBox.Text = ""
            Form1.pokemonThreeHappyness_txtBox.Text = ""
            Form1.pokemonThreeIVsHP_txt.Text = ""
            Form1.pokemonThreeIVsATK_txt.Text = ""
            Form1.pokemonThreeIVsDEF_txt.Text = ""
            Form1.pokemonThreeIVsSPD_txt.Text = ""
            Form1.pokemonThreeIVsSPATK_txt.Text = ""
            Form1.pokemonThreeIVsSPDEF_txt.Text = ""
            Form1.pokemonThreeEVsHP_txt.Text = ""
            Form1.pokemonThreeEVsATK_txt.Text = ""
            Form1.pokemonThreeEVsDEF_txt.Text = ""
            Form1.pokemonThreeEVsSPD_txt.Text = ""
            Form1.pokemonThreeEVsSPATK_txt.Text = ""
            Form1.pokemonThreeEVsSPDEF_txt.Text = ""
            Form1.pokemonThreeNickname_txtBox.Text = ""

            ' Pokemon Four
            Form1.pokemonFourName_txtBox.Text = ""
            Form1.pokemonFourItem_txtBox.Text = ""
            Form1.pokemonFourlvl_txtBox.Text = ""
            Form1.pokemonFourMove1_txtBox.Text = ""
            Form1.pokemonFourMove2_txtBox.Text = ""
            Form1.pokemonFourMove3_txtBox.Text = ""
            Form1.pokemonFourMove4_txtBox.Text = ""
            Form1.pokemonFourGender_cmb.SelectedIndex = 2
            Form1.pokemonFourNature_cmb.SelectedIndex = 0
            Form1.pokemonFourAbility_cmb.SelectedIndex = 0
            Form1.pokemonFourShinyFalse_rad.Checked = True
            Form1.pokemonFourShadowFalse_rad.Checked = True
            Form1.pokemonFourPokeballID_cmb.SelectedIndex = 0
            Form1.pokemonFourForm_txtBox.Text = ""
            Form1.pokemonFourHappyness_txtBox.Text = ""
            Form1.pokemonFourIVsHP_txt.Text = ""
            Form1.pokemonFourIVsATK_txt.Text = ""
            Form1.pokemonFourIVsDEF_txt.Text = ""
            Form1.pokemonFourIVsSPD_txt.Text = ""
            Form1.pokemonFourIVsSPATK_txt.Text = ""
            Form1.pokemonFourIVsSPDEF_txt.Text = ""
            Form1.pokemonFourEVsHP_txt.Text = ""
            Form1.pokemonFourEVsATK_txt.Text = ""
            Form1.pokemonFourEVsDEF_txt.Text = ""
            Form1.pokemonFourEVsSPD_txt.Text = ""
            Form1.pokemonFourEVsSPATK_txt.Text = ""
            Form1.pokemonFourEVsSPDEF_txt.Text = ""
            Form1.pokemonFourNickname_txtBox.Text = ""

            ' Pokemon Five
            Form1.pokemonFiveName_txtBox.Text = ""
            Form1.pokemonFiveItem_txtBox.Text = ""
            Form1.pokemonFivelvl_txtBox.Text = ""
            Form1.pokemonFiveMove1_txtBox.Text = ""
            Form1.pokemonFiveMove2_txtBox.Text = ""
            Form1.pokemonFiveMove3_txtBox.Text = ""
            Form1.pokemonFiveMove4_txtBox.Text = ""
            Form1.pokemonFiveGender_cmb.SelectedIndex = 2
            Form1.pokemonFiveNature_cmb.SelectedIndex = 0
            Form1.pokemonFiveAbility_cmb.SelectedIndex = 0
            Form1.pokemonFiveShinyFalse_rad.Checked = True
            Form1.pokemonFiveShadowFalse_rad.Checked = True
            Form1.pokemonFivePokeballID_cmb.SelectedIndex = 0
            Form1.pokemonFiveForm_txtBox.Text = ""
            Form1.pokemonFiveHappyness_txtBox.Text = ""
            Form1.pokemonFiveIVsHP_txt.Text = ""
            Form1.pokemonFiveIVsATK_txt.Text = ""
            Form1.pokemonFiveIVsDEF_txt.Text = ""
            Form1.pokemonFiveIVsSPD_txt.Text = ""
            Form1.pokemonFiveIVsSPATK_txt.Text = ""
            Form1.pokemonFiveIVsSPDEF_txt.Text = ""
            Form1.pokemonFiveEVsHP_txt.Text = ""
            Form1.pokemonFiveEVsATK_txt.Text = ""
            Form1.pokemonFiveEVsDEF_txt.Text = ""
            Form1.pokemonFiveEVsSPD_txt.Text = ""
            Form1.pokemonFiveEVsSPATK_txt.Text = ""
            Form1.pokemonFiveEVsSPDEF_txt.Text = ""
            Form1.pokemonFiveNickname_txtBox.Text = ""

            ' Pokemon Six
            Form1.pokemonSixName_txtBox.Text = ""
            Form1.pokemonSixItem_txtBox.Text = ""
            Form1.pokemonSixLvl_txtBox.Text = ""
            Form1.pokemonSixMove1_txtBox.Text = ""
            Form1.pokemonSixMove2_txtBox.Text = ""
            Form1.pokemonSixMove3_txtBox.Text = ""
            Form1.pokemonSixMove4_txtBox.Text = ""
            Form1.pokemonSixGender_cmb.SelectedIndex = 2
            Form1.pokemonSixNature_cmb.SelectedIndex = 0
            Form1.pokemonSixAbility_cmb.SelectedIndex = 0
            Form1.pokemonSixShinyFalse_rad.Checked = True
            Form1.pokemonSixShadowFalse_rad.Checked = True
            Form1.pokemonSixPokeballID_cmb.SelectedIndex = 0
            Form1.pokemonSixForm_txtBox.Text = ""
            Form1.pokemonSixHappyness_txtBox.Text = ""
            Form1.pokemonSixIVsHP_txt.Text = ""
            Form1.pokemonSixIVsATK_txt.Text = ""
            Form1.pokemonSixIVsDEF_txt.Text = ""
            Form1.pokemonSixIVsSPD_txt.Text = ""
            Form1.pokemonSixIVsSPATK_txt.Text = ""
            Form1.pokemonSixIVsSPDEF_txt.Text = ""
            Form1.pokemonSixEVsHP_txt.Text = ""
            Form1.pokemonSixEVsATK_txt.Text = ""
            Form1.pokemonSixEVsDEF_txt.Text = ""
            Form1.pokemonSixEVsSPD_txt.Text = ""
            Form1.pokemonSixEVsSPATK_txt.Text = ""
            Form1.pokemonSixEVsSPDEF_txt.Text = ""
            Form1.pokemonSixNickname_txtBox.Text = ""

            ' Output Box
            Form1.outputBox_rchBox.Text = ""

            ' Return Trainer Info Text Back To Normal
            Form1.trainerInfoTitle_lbl.Text = "Trainer Info"
        ElseIf DiagResult = DialogResult.No Then
            MessageBox.Show("Fields have not been clearned.", "Not Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
