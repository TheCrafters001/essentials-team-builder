﻿Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Essentials Version
        essVersion_cmb.SelectedIndex = 4 ' Essentials 21

        ' Amount of Pokemon
        numPoké_cmb.SelectedIndex = 0

        ' Copyright
        copyright_lbl.Text = My.Application.Info.Copyright
    End Sub

    Private Sub existingBattle_chkBox_CheckedChanged(sender As Object, e As EventArgs) Handles existingBattle_chkBox.CheckedChanged
        If existingBattle_chkBox.Checked = True Then
            battleTeamID_lbl.Enabled = True
            battleTeamID_txtBox.Enabled = True
        Else
            battleTeamID_lbl.Enabled = False
            battleTeamID_txtBox.Enabled = False
        End If
    End Sub

    Private Sub essVersion_cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles essVersion_cmb.SelectedIndexChanged
        If essVersion_cmb.SelectedIndex = 0 Then ' Essentials 17
            ' Custom Pokeball IDs
            customBallIDs_chkBox.Enabled = True
            ' customBallIDs_chkBox.Checked = False

            ' Use Ability Index
            useAbilityIndex_chkBox.Enabled = False
            useAbilityIndex_chkBox.Checked = False

            ' Quotes for Lose Text
            loseTextQuotes_chkBox.Enabled = False
            loseTextQuotes_chkBox.Checked = False

            ' Super Shiny
            allowSuperShiny_chk.Enabled = False
            allowSuperShiny_chk.Checked = False


        ElseIf essVersion_cmb.SelectedIndex = 1 Then ' Essentials 18
            ' Custom Pokeball IDs
            customBallIDs_chkBox.Enabled = True
            ' customBallIDs_chkBox.Checked = False

            ' Use Ability Index
            useAbilityIndex_chkBox.Enabled = False
            useAbilityIndex_chkBox.Checked = False

            ' Quotes for Lose Text
            loseTextQuotes_chkBox.Enabled = False
            loseTextQuotes_chkBox.Checked = False

            ' Super Shiny
            allowSuperShiny_chk.Enabled = False
            allowSuperShiny_chk.Checked = False


        ElseIf essVersion_cmb.SelectedIndex = 2 Then ' Essentials 19
            ' Custom Pokeball IDs
            customBallIDs_chkBox.Enabled = True
            ' customBallIDs_chkBox.Checked = False

            ' Use Ability Index
            useAbilityIndex_chkBox.Enabled = True
            useAbilityIndex_chkBox.Checked = True

            ' Quotes for Lose Text
            loseTextQuotes_chkBox.Enabled = True
            loseTextQuotes_chkBox.Checked = True

            ' Super Shiny
            allowSuperShiny_chk.Enabled = False
            allowSuperShiny_chk.Checked = False


        ElseIf essVersion_cmb.SelectedIndex = 3 Then ' Essentials 20
            ' Custom Pokeball IDs
            customBallIDs_chkBox.Enabled = True
            ' customBallIDs_chkBox.Checked = False

            ' Use Ability Index
            useAbilityIndex_chkBox.Enabled = True
            useAbilityIndex_chkBox.Checked = True

            ' Quotes for Lose Text
            loseTextQuotes_chkBox.Enabled = False
            loseTextQuotes_chkBox.Checked = False

            ' Super Shiny
            allowSuperShiny_chk.Enabled = False
            allowSuperShiny_chk.Checked = False


        ElseIf essVersion_cmb.SelectedIndex = 4 Then ' Essentials 21
            ' Custom Pokeball IDs
            customBallIDs_chkBox.Enabled = True
            ' customBallIDs_chkBox.Checked = False

            ' Use Ability Index
            useAbilityIndex_chkBox.Enabled = True
            useAbilityIndex_chkBox.Checked = True

            ' Quotes for Lose Text
            loseTextQuotes_chkBox.Enabled = False
            loseTextQuotes_chkBox.Checked = False

            ' Super Shiny
            allowSuperShiny_chk.Enabled = True
            allowSuperShiny_chk.Checked = False
        End If
    End Sub

    Private Sub numPoké_cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles numPoké_cmb.SelectedIndexChanged
        If numPoké_cmb.SelectedIndex = 0 Then
            pokemon1_grp.Enabled = True
            pokemon2_grp.Enabled = False
            pokemon3_grp.Enabled = False
            pokemon4_grp.Enabled = False
            pokemon5_grp.Enabled = False
            pokemon6_grp.Enabled = False

        ElseIf numPoké_cmb.SelectedIndex = 1 Then
            pokemon1_grp.Enabled = True
            pokemon2_grp.Enabled = True
            pokemon3_grp.Enabled = False
            pokemon4_grp.Enabled = False
            pokemon5_grp.Enabled = False
            pokemon6_grp.Enabled = False

        ElseIf numPoké_cmb.SelectedIndex = 2 Then
            pokemon1_grp.Enabled = True
            pokemon2_grp.Enabled = True
            pokemon3_grp.Enabled = True
            pokemon4_grp.Enabled = False
            pokemon5_grp.Enabled = False
            pokemon6_grp.Enabled = False

        ElseIf numPoké_cmb.SelectedIndex = 3 Then
            pokemon1_grp.Enabled = True
            pokemon2_grp.Enabled = True
            pokemon3_grp.Enabled = True
            pokemon4_grp.Enabled = True
            pokemon5_grp.Enabled = False
            pokemon6_grp.Enabled = False

        ElseIf numPoké_cmb.SelectedIndex = 4 Then
            pokemon1_grp.Enabled = True
            pokemon2_grp.Enabled = True
            pokemon3_grp.Enabled = True
            pokemon4_grp.Enabled = True
            pokemon5_grp.Enabled = True
            pokemon6_grp.Enabled = False

        ElseIf numPoké_cmb.SelectedIndex = 5 Then
            pokemon1_grp.Enabled = True
            pokemon2_grp.Enabled = True
            pokemon3_grp.Enabled = True
            pokemon4_grp.Enabled = True
            pokemon5_grp.Enabled = True
            pokemon6_grp.Enabled = True
        End If
    End Sub

    Private Sub useAbilityIndex_chkBox_CheckedChanged(sender As Object, e As EventArgs) Handles useAbilityIndex_chkBox.CheckedChanged
        If useAbilityIndex_chkBox.Checked = True Then
            'pokemon1Ability_cmb.Items.Remove
        Else

        End If
    End Sub
End Class
