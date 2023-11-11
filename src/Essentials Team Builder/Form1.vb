Public Class Form1
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
        ObjectCheck.EssVersion()
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

    Private Sub allowSuperShiny_chk_CheckedChanged(sender As Object, e As EventArgs) Handles allowSuperShiny_chk.CheckedChanged
        ObjectCheck.SuperShiny()
    End Sub

    Private Sub customBallIDs_chkBox_CheckedChanged(sender As Object, e As EventArgs) Handles customBallIDs_chkBox.CheckedChanged

    End Sub
End Class
