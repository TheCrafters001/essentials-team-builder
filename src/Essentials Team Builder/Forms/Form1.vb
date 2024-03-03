Imports System.IO
Imports System.Windows.Controls.Primitives
Imports teamGen

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Essentials Version
        essVersion_cmb.SelectedIndex = 4 ' Essentials 21

        ' Amount of Pokemon
        numPoké_cmb.SelectedIndex = 0

        ' Gender
        ' This works like numPoké_cmb_SelectedIndexChanged, but because of it
        ' being a little less complex, it requires a different way to write it,
        ' so here is the new way to do this.
        For Index As Integer = 0 To 5
            ' Get the name via the Index + 1
            Dim pokemonGender As String = "pokemon" & (Index + 1) & "Gender_cmb"
            'Create a ComboBox that acts as a DirectCast that is FirstOrDefault
            Dim Combo As ComboBox = DirectCast(Me.Controls.Find(pokemonGender, True).FirstOrDefault(), ComboBox)

            ' Make sure the comboBox isn't nothing. If it is nothing, it doesn't exist.
            If Combo IsNot Nothing Then
                Combo.SelectedIndex = 2
            Else
                Debug.WriteLine("Could not find ComboBox: " & pokemonGender)
            End If
        Next

        ' Copyright
        copyright_lbl.Text = My.Application.Info.Copyright
    End Sub

    Private Sub existingBattle_chkBox_CheckedChanged(sender As Object, e As EventArgs) Handles existingBattle_chkBox.CheckedChanged
        If existingBattle_chkBox.Checked = True Then
            battleTeamID_lbl.Enabled = True
            battleTeamID_nbr.Enabled = True
        Else
            battleTeamID_lbl.Enabled = False
            battleTeamID_nbr.Enabled = False
        End If
    End Sub

    Private Sub essVersion_cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles essVersion_cmb.SelectedIndexChanged
        ObjectCheck.EssVersion()
    End Sub

    Private Sub numPoké_cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles numPoké_cmb.SelectedIndexChanged
        ' New Function, this doesn't touch pokemon1_grp as it doesn't need to.
        ' This new one works dynamically and took me forever to figure out. It
        ' isn't the prettiest thing, but it does the job.

        'Get the Index of NumPoke and set it as SelIndex
        Dim SelIndex As Integer = numPoké_cmb.SelectedIndex + 1

        For Index As Integer = 0 To 5
            ' Dynamically create the control names.
            Dim grpBoxName As String = "pokemon" & (Index + 1) & "_grp"

            ' Making sure they exists
            Dim controlArray() As Control = Me.Controls.Find(grpBoxName, True)

            ' Making Sure that the array is more than zero
            ' but also making sure that the is a groupbox so
            ' I don't accidently blow anything up.
            If controlArray.Length > 0 AndAlso TypeOf controlArray(0) Is GroupBox Then
                'Create a groupBox that acts as a DirectCast
                Dim Grps As GroupBox = DirectCast(controlArray(0), GroupBox)

                ' Now enable by the selindex, making it act as a bool
                Grps.Enabled = (Index < SelIndex)

                Debug.WriteLine(Grps.Name & "=" & (Index < SelIndex))
            End If
        Next
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

    Private Sub GeneratePreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneratePreviewToolStripMenuItem.Click
        'Show the form
        Preview.Show()

        'Do the thing - Generate the teams.
        If essVersion_cmb.SelectedIndex = 0 Then

        Else
            ' Trainer Generator
            Dim TrainerItems As List(Of String) = New List(Of String)
            For Each Items As String In items_lst.Items
                TrainerItems.Add(Items)
            Next

            Preview.output_rchTxt.Text = Generator.trainer18(trainerName_txtBox.Text, trainerType_txtBox.Text, loseText_txt.Text, loseTextQuotes_chkBox.Checked, battleTeamID_nbr.Value,
                                                             TrainerItems)

            If numPoké_cmb.SelectedIndex = 0 Then
                ' Pokemon 1
                Preview.output_rchTxt.Text &= Generator.essentials18(pokemon1Name_txtBox.Text, pokemon1HeldItem_txtBox.Text, pokemon1Level_nbr.Value, pokemon1Ability_cmb.Text, pokemon1Gender_cmb.Text, pokemon1Form_nbr.Value,
                                       pokemon1Nature_cmb.Text, pokemon1Happiness_nbr.Value, pokemon1Nickname_txtBox.Text, pokemon1PokeballID_cmb.Text, pokemon1Shiny_rad.Checked,
                                       pokemon1SuperShiny_chkBox.Checked, pokemon1Shadow_rad.Checked,
                                       {pokemon1Move1_txtBox.Text, pokemon1Move2_txtBox.Text, pokemon1Move3_txtBox.Text, pokemon1Move4_txtBox.Text},
                                       {pokemon1IVsHP_txt.Text, pokemon1IVsATK_txt.Text, pokemon1IVsDEF_txt.Text, pokemon1IVsSPD_txt.Text, pokemon1IVsSPATK_txt.Text, pokemon1IVsSPDEF_txt.Text},
                                       {pokemon1EVsHP_txt.Text, pokemon1EVsATK_txt.Text, pokemon1EVsDEF_txt.Text, pokemon1EVsSPD_txt.Text, pokemon1EVsSPATK_txt.Text, pokemon1EVsSPDEF_txt.Text})
            ElseIf numPoké_cmb.SelectedIndex = 1 Then
                ' Pokemon 1
                Preview.output_rchTxt.Text &= Generator.essentials18(pokemon1Name_txtBox.Text, pokemon1HeldItem_txtBox.Text, pokemon1Level_nbr.Value, pokemon1Ability_cmb.Text, pokemon1Gender_cmb.Text, pokemon1Form_nbr.Value,
                                       pokemon1Nature_cmb.Text, pokemon1Happiness_nbr.Value, pokemon1Nickname_txtBox.Text, pokemon1PokeballID_cmb.Text, pokemon1Shiny_rad.Checked,
                                       pokemon1SuperShiny_chkBox.Checked, pokemon1Shadow_rad.Checked,
                                       {pokemon1Move1_txtBox.Text, pokemon1Move2_txtBox.Text, pokemon1Move3_txtBox.Text, pokemon1Move4_txtBox.Text},
                                       {pokemon1IVsHP_txt.Text, pokemon1IVsATK_txt.Text, pokemon1IVsDEF_txt.Text, pokemon1IVsSPD_txt.Text, pokemon1IVsSPATK_txt.Text, pokemon1IVsSPDEF_txt.Text},
                                       {pokemon1EVsHP_txt.Text, pokemon1EVsATK_txt.Text, pokemon1EVsDEF_txt.Text, pokemon1EVsSPD_txt.Text, pokemon1EVsSPATK_txt.Text, pokemon1EVsSPDEF_txt.Text})
                ' Pokemon 2
                Preview.output_rchTxt.Text &= Generator.essentials18(pokemon2Name_txt.Text, pokemon2HeldItem_txt.Text, pokemon2Level_nbr.Value, pokemon2Ability_cmb.Text, pokemon2Gender_cmb.Text, pokemon2Form_nbr.Value,
                                       pokemon2Nature_cmb.Text, pokemon2Happiness_nbr.Value, pokemon2Nickname_txt.Text, pokemon2PokeballID_cmb.Text, pokemon2Shiny_rad.Checked,
                                       pokemon2SuperShiny_chkBox.Checked, pokemon2Shadow_rad.Checked,
                                       {pokemon2Move1_txtBox.Text, pokemon2Move2_txtBox.Text, pokemon2Move3_txtBox.Text, pokemon2Move4_txtBox.Text},
                                       {pokemon2IVsHP_txt.Text, pokemon2IVsATK_txt.Text, pokemon2IVsDEF_txt.Text, pokemon2IVsSPD_txt.Text, pokemon2IVsSPATK_txt.Text, pokemon2IVsSPDEF_txt.Text},
                                       {pokemon2EVsHP_txt.Text, pokemon2EVsATK_txt.Text, pokemon2EVsDEF_txt.Text, pokemon2EVsSPD_txt.Text, pokemon2EVsSPATK_txt.Text, pokemon2EVsSPDEF_txt.Text})
            End If

        End If
    End Sub

    Private Sub customBallIDs_chkBox_CheckedChanged(sender As Object, e As EventArgs) Handles customBallIDs_chkBox.CheckedChanged
        If customBallIDs_chkBox.Checked = True Then
            For Index As Integer = 0 To 5
                ' Get the name via the Index + 1
                Dim pokemonName As String = "pokemon" & (Index + 1) & "PokeballID_cmb"
                'Create a ComboBox that acts as a DirectCast that is FirstOrDefault
                Dim Combo As ComboBox = DirectCast(Me.Controls.Find(pokemonName, True).FirstOrDefault(), ComboBox)

                ' Make sure the comboBox isn't nothing. If it is nothing, it doesn't exist.
                If Combo IsNot Nothing Then
                    Combo.DropDownStyle = ComboBoxStyle.DropDown
                Else
                    Debug.WriteLine("Could not find ComboBox: " & pokemonName)
                End If
            Next
        Else
            For Index As Integer = 0 To 5
                ' Get the name via the Index + 1
                Dim pokemonName As String = "pokemon" & (Index + 1) & "PokeballID_cmb"
                'Create a ComboBox that acts as a DirectCast that is FirstOrDefault
                Dim Combo As ComboBox = DirectCast(Me.Controls.Find(pokemonName, True).FirstOrDefault(), ComboBox)

                ' Make sure the comboBox isn't nothing. If it is nothing, it doesn't exist.
                If Combo IsNot Nothing Then
                    Combo.DropDownStyle = ComboBoxStyle.DropDownList
                Else
                    Debug.WriteLine("Could not find ComboBox: " & pokemonName)
                End If
            Next
        End If
    End Sub

    Private Sub addItem_btn_Click(sender As Object, e As EventArgs) Handles addItem_btn.Click
        Dim Input As String = InputBox("Enter an Item Name", "Add Item")
        AddItem(Input)
    End Sub

    Private Sub removeItem_btn_Click(sender As Object, e As EventArgs) Handles removeItem_btn.Click
        items_lst.Items.Remove(items_lst.SelectedItem)
    End Sub

    Private Shared Sub AddItem(ByVal item As String)
        If Form1.items_lst.Items.Count < 8 Then
            Form1.items_lst.Items.Add(item)
        ElseIf Form1.items_lst.Items.Count >= 8 Then
            MessageBox.Show("You can only have 8 items max. Remove an item before adding a new one.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub thirdPartyLicenses_btn_Click(sender As Object, e As EventArgs) Handles thirdPartyLicenses_btn.Click
        ThirdPartyLicenses.Show()
    End Sub
End Class
