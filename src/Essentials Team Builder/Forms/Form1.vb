﻿Imports teamGen

Public Class Form1


    Public Sub New()

        ' Get the language stuff BEFORE InitializeComponent() so
        ' that it can, you know, display the saved language.
        If My.Settings.Lang = 0 Then
            Threading.Thread.CurrentThread.CurrentCulture = Globalization.CultureInfo.GetCultureInfo("en")
            Threading.Thread.CurrentThread.CurrentUICulture = Globalization.CultureInfo.GetCultureInfo("en")
        ElseIf My.Settings.Lang = 1 Then
            ' I borrowed English (World) for Leet Speak. Don't mind me.
            Threading.Thread.CurrentThread.CurrentCulture = Globalization.CultureInfo.GetCultureInfo("en-001")
            Threading.Thread.CurrentThread.CurrentUICulture = Globalization.CultureInfo.GetCultureInfo("en-001")
        End If

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
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


    Private Sub allowSuperShiny_chk_CheckedChanged(sender As Object, e As EventArgs) Handles allowSuperShiny_chk.CheckedChanged
        ObjectCheck.SuperShiny()
    End Sub

    Private Sub GeneratePreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneratePreviewToolStripMenuItem.Click
        'Show the form
        Preview.Show()

        'Do the thing - Generate the teams.
        If essVersion_cmb.SelectedIndex = 0 Then

            ' Trainer Generator
            Dim TrainerItems As List(Of String) = New List(Of String)
            For Each Items As String In items_lst.Items
                TrainerItems.Add(Items)
            Next

            Preview.output_rchTxt.Text = Generator.trainer17(trainerName_txtBox.Text, trainerType_txtBox.Text, loseText_txt.Text, loseTextQuotes_chkBox.Checked, battleTeamID_nbr.Value,
                                                             TrainerItems)

            If numPoké_cmb.SelectedIndex = 0 Then
                ' Pokemon 1
                Preview.output_rchTxt.Text &= Generator.essentials17(pokemon1Name_txtBox.Text, pokemon1HeldItem_txtBox.Text, pokemon1Level_nbr.Value, pokemon1Ability_cmb.Text,
                                                                     pokemon1Gender_cmb.SelectedIndex, pokemon1Form_nbr.Value, pokemon1Nature_cmb.Text, pokemon1Happiness_nbr.Value,
                                                                     pokemon1Nickname_txtBox.Text, pokemon1PokeballID_cmb.Text, pokemon1Shiny_rad.Checked, pokemon1Shadow_rad.Checked,
                                                                     {pokemon1Move1_txtBox.Text, pokemon1Move2_txtBox.Text, pokemon1Move3_txtBox.Text, pokemon1Move4_txtBox.Text},
                                                                     pokemon1IVsHP_txt.Text)

            ElseIf numPoké_cmb.SelectedIndex = 1 Then
                ' Pokemon 1
                Preview.output_rchTxt.Text &= Generator.essentials17(pokemon1Name_txtBox.Text, pokemon1HeldItem_txtBox.Text, pokemon1Level_nbr.Value, pokemon1Ability_cmb.Text,
                                                                     pokemon1Gender_cmb.SelectedIndex, pokemon1Form_nbr.Value, pokemon1Nature_cmb.Text, pokemon1Happiness_nbr.Value,
                                                                     pokemon1Nickname_txtBox.Text, pokemon1PokeballID_cmb.Text, pokemon1Shiny_rad.Checked, pokemon1Shadow_rad.Checked,
                                                                     {pokemon1Move1_txtBox.Text, pokemon1Move2_txtBox.Text, pokemon1Move3_txtBox.Text, pokemon1Move4_txtBox.Text},
                                                                     pokemon1IVsHP_txt.Text)
                ' Pokemon 2
                Preview.output_rchTxt.Text &= Generator.essentials17(pokemon2Name_txt.Text, pokemon2HeldItem_txt.Text, pokemon2Level_nbr.Value, pokemon2Ability_cmb.Text,
                                                                     pokemon2Gender_cmb.SelectedIndex, pokemon2Form_nbr.Value, pokemon2Nature_cmb.Text, pokemon2Happiness_nbr.Value,
                                                                     pokemon2Nickname_txt.Text, pokemon2PokeballID_cmb.Text, pokemon2Shiny_rad.Checked, pokemon2Shadow_rad.Checked,
                                                                     {pokemon2Move1_txtBox.Text, pokemon2Move2_txtBox.Text, pokemon2Move3_txtBox.Text, pokemon2Move4_txtBox.Text},
                                                                     pokemon2IVsHP_txt.Text)

            ElseIf numPoké_cmb.SelectedIndex = 2 Then
                ' Pokemon 1
                Preview.output_rchTxt.Text &= Generator.essentials17(pokemon1Name_txtBox.Text, pokemon1HeldItem_txtBox.Text, pokemon1Level_nbr.Value, pokemon1Ability_cmb.Text,
                                                                     pokemon1Gender_cmb.SelectedIndex, pokemon1Form_nbr.Value, pokemon1Nature_cmb.Text, pokemon1Happiness_nbr.Value,
                                                                     pokemon1Nickname_txtBox.Text, pokemon1PokeballID_cmb.Text, pokemon1Shiny_rad.Checked, pokemon1Shadow_rad.Checked,
                                                                     {pokemon1Move1_txtBox.Text, pokemon1Move2_txtBox.Text, pokemon1Move3_txtBox.Text, pokemon1Move4_txtBox.Text},
                                                                     pokemon1IVsHP_txt.Text)
                ' Pokemon 2
                Preview.output_rchTxt.Text &= Generator.essentials17(pokemon2Name_txt.Text, pokemon2HeldItem_txt.Text, pokemon2Level_nbr.Value, pokemon2Ability_cmb.Text,
                                                                     pokemon2Gender_cmb.SelectedIndex, pokemon2Form_nbr.Value, pokemon2Nature_cmb.Text, pokemon2Happiness_nbr.Value,
                                                                     pokemon2Nickname_txt.Text, pokemon2PokeballID_cmb.Text, pokemon2Shiny_rad.Checked, pokemon2Shadow_rad.Checked,
                                                                     {pokemon2Move1_txtBox.Text, pokemon2Move2_txtBox.Text, pokemon2Move3_txtBox.Text, pokemon2Move4_txtBox.Text},
                                                                     pokemon2IVsHP_txt.Text)
                ' Pokemon 3
                Preview.output_rchTxt.Text &= Generator.essentials17(pokemon3Name_txt.Text, pokemon3HeldItem_txt.Text, pokemon3Level_nbr.Value, pokemon3Ability_cmb.Text,
                                                                     pokemon3Gender_cmb.SelectedIndex, pokemon3Form_nbr.Value, pokemon3Nature_cmb.Text, pokemon3Happiness_nbr.Value,
                                                                     pokemon3Nickname_txt.Text, pokemon3PokeballID_cmb.Text, pokemon3Shiny_rad.Checked, pokemon3Shadow_rad.Checked,
                                                                     {pokemon3Move1_txtBox.Text, pokemon3Move2_txtBox.Text, pokemon3Move3_txtBox.Text, pokemon3Move4_txtBox.Text},
                                                                     pokemon3IVsHP_txt.Text)
            ElseIf numPoké_cmb.SelectedIndex = 3 Then
                ' Pokemon 1
                Preview.output_rchTxt.Text &= Generator.essentials17(pokemon1Name_txtBox.Text, pokemon1HeldItem_txtBox.Text, pokemon1Level_nbr.Value, pokemon1Ability_cmb.Text,
                                                                     pokemon1Gender_cmb.SelectedIndex, pokemon1Form_nbr.Value, pokemon1Nature_cmb.Text, pokemon1Happiness_nbr.Value,
                                                                     pokemon1Nickname_txtBox.Text, pokemon1PokeballID_cmb.Text, pokemon1Shiny_rad.Checked, pokemon1Shadow_rad.Checked,
                                                                     {pokemon1Move1_txtBox.Text, pokemon1Move2_txtBox.Text, pokemon1Move3_txtBox.Text, pokemon1Move4_txtBox.Text},
                                                                     pokemon1IVsHP_txt.Text)
                ' Pokemon 2
                Preview.output_rchTxt.Text &= Generator.essentials17(pokemon2Name_txt.Text, pokemon2HeldItem_txt.Text, pokemon2Level_nbr.Value, pokemon2Ability_cmb.Text,
                                                                     pokemon2Gender_cmb.SelectedIndex, pokemon2Form_nbr.Value, pokemon2Nature_cmb.Text, pokemon2Happiness_nbr.Value,
                                                                     pokemon2Nickname_txt.Text, pokemon2PokeballID_cmb.Text, pokemon2Shiny_rad.Checked, pokemon2Shadow_rad.Checked,
                                                                     {pokemon2Move1_txtBox.Text, pokemon2Move2_txtBox.Text, pokemon2Move3_txtBox.Text, pokemon2Move4_txtBox.Text},
                                                                     pokemon2IVsHP_txt.Text)
                ' Pokemon 3
                Preview.output_rchTxt.Text &= Generator.essentials17(pokemon3Name_txt.Text, pokemon3HeldItem_txt.Text, pokemon3Level_nbr.Value, pokemon3Ability_cmb.Text,
                                                                     pokemon3Gender_cmb.SelectedIndex, pokemon3Form_nbr.Value, pokemon3Nature_cmb.Text, pokemon3Happiness_nbr.Value,
                                                                     pokemon3Nickname_txt.Text, pokemon3PokeballID_cmb.Text, pokemon3Shiny_rad.Checked, pokemon3Shadow_rad.Checked,
                                                                     {pokemon3Move1_txtBox.Text, pokemon3Move2_txtBox.Text, pokemon3Move3_txtBox.Text, pokemon3Move4_txtBox.Text},
                                                                     pokemon3IVsHP_txt.Text)
                ' Pokemon 4
                Preview.output_rchTxt.Text &= Generator.essentials17(pokemon4Name_txt.Text, pokemon4HeldItem_txt.Text, pokemon4Level_nbr.Value, pokemon4Ability_cmb.Text,
                                                                     pokemon4Gender_cmb.SelectedIndex, pokemon4Form_nbr.Value, pokemon4Nature_cmb.Text, pokemon4Happiness_nbr.Value,
                                                                     pokemon4Nickname_txt.Text, pokemon4PokeballID_cmb.Text, pokemon4Shiny_rad.Checked, pokemon4Shadow_rad.Checked,
                                                                     {pokemon4Move1_txtBox.Text, pokemon4Move2_txtBox.Text, pokemon4Move3_txtBox.Text, pokemon4Move4_txtBox.Text},
                                                                     pokemon4IVsHP_txt.Text)
            ElseIf numPoké_cmb.SelectedIndex = 4 Then
                ' Pokemon 1
                Preview.output_rchTxt.Text &= Generator.essentials17(pokemon1Name_txtBox.Text, pokemon1HeldItem_txtBox.Text, pokemon1Level_nbr.Value, pokemon1Ability_cmb.Text,
                                                                     pokemon1Gender_cmb.SelectedIndex, pokemon1Form_nbr.Value, pokemon1Nature_cmb.Text, pokemon1Happiness_nbr.Value,
                                                                     pokemon1Nickname_txtBox.Text, pokemon1PokeballID_cmb.Text, pokemon1Shiny_rad.Checked, pokemon1Shadow_rad.Checked,
                                                                     {pokemon1Move1_txtBox.Text, pokemon1Move2_txtBox.Text, pokemon1Move3_txtBox.Text, pokemon1Move4_txtBox.Text},
                                                                     pokemon1IVsHP_txt.Text)
                ' Pokemon 2
                Preview.output_rchTxt.Text &= Generator.essentials17(pokemon2Name_txt.Text, pokemon2HeldItem_txt.Text, pokemon2Level_nbr.Value, pokemon2Ability_cmb.Text,
                                                                     pokemon2Gender_cmb.SelectedIndex, pokemon2Form_nbr.Value, pokemon2Nature_cmb.Text, pokemon2Happiness_nbr.Value,
                                                                     pokemon2Nickname_txt.Text, pokemon2PokeballID_cmb.Text, pokemon2Shiny_rad.Checked, pokemon2Shadow_rad.Checked,
                                                                     {pokemon2Move1_txtBox.Text, pokemon2Move2_txtBox.Text, pokemon2Move3_txtBox.Text, pokemon2Move4_txtBox.Text},
                                                                     pokemon2IVsHP_txt.Text)
                ' Pokemon 3
                Preview.output_rchTxt.Text &= Generator.essentials17(pokemon3Name_txt.Text, pokemon3HeldItem_txt.Text, pokemon3Level_nbr.Value, pokemon3Ability_cmb.Text,
                                                                     pokemon3Gender_cmb.SelectedIndex, pokemon3Form_nbr.Value, pokemon3Nature_cmb.Text, pokemon3Happiness_nbr.Value,
                                                                     pokemon3Nickname_txt.Text, pokemon3PokeballID_cmb.Text, pokemon3Shiny_rad.Checked, pokemon3Shadow_rad.Checked,
                                                                     {pokemon3Move1_txtBox.Text, pokemon3Move2_txtBox.Text, pokemon3Move3_txtBox.Text, pokemon3Move4_txtBox.Text},
                                                                     pokemon3IVsHP_txt.Text)
                ' Pokemon 4
                Preview.output_rchTxt.Text &= Generator.essentials17(pokemon4Name_txt.Text, pokemon4HeldItem_txt.Text, pokemon4Level_nbr.Value, pokemon4Ability_cmb.Text,
                                                                     pokemon4Gender_cmb.SelectedIndex, pokemon4Form_nbr.Value, pokemon4Nature_cmb.Text, pokemon4Happiness_nbr.Value,
                                                                     pokemon4Nickname_txt.Text, pokemon4PokeballID_cmb.Text, pokemon4Shiny_rad.Checked, pokemon4Shadow_rad.Checked,
                                                                     {pokemon4Move1_txtBox.Text, pokemon4Move2_txtBox.Text, pokemon4Move3_txtBox.Text, pokemon4Move4_txtBox.Text},
                                                                     pokemon4IVsHP_txt.Text)
                ' Pokemon 5
                Preview.output_rchTxt.Text &= Generator.essentials17(pokemon5Name_txt.Text, pokemon5HeldItem_txt.Text, pokemon5Level_nbr.Value, pokemon5Ability_cmb.Text,
                                                                     pokemon5Gender_cmb.SelectedIndex, pokemon5Form_nbr.Value, pokemon5Nature_cmb.Text, pokemon5Happiness_nbr.Value,
                                                                     pokemon5Nickname_txt.Text, pokemon5PokeballID_cmb.Text, pokemon5Shiny_rad.Checked, pokemon5Shadow_rad.Checked,
                                                                     {pokemon5Move1_txt.Text, pokemon5Move2_txt.Text, pokemon5Move3_txt.Text, pokemon5Move4_txt.Text},
                                                                     pokemon5IVsHP_txt.Text)

            ElseIf numPoké_cmb.SelectedIndex = 5 Then
                ' Pokemon 1
                Preview.output_rchTxt.Text &= Generator.essentials17(pokemon1Name_txtBox.Text, pokemon1HeldItem_txtBox.Text, pokemon1Level_nbr.Value, pokemon1Ability_cmb.Text,
                                                                     pokemon1Gender_cmb.SelectedIndex, pokemon1Form_nbr.Value, pokemon1Nature_cmb.Text, pokemon1Happiness_nbr.Value,
                                                                     pokemon1Nickname_txtBox.Text, pokemon1PokeballID_cmb.Text, pokemon1Shiny_rad.Checked, pokemon1Shadow_rad.Checked,
                                                                     {pokemon1Move1_txtBox.Text, pokemon1Move2_txtBox.Text, pokemon1Move3_txtBox.Text, pokemon1Move4_txtBox.Text},
                                                                     pokemon1IVsHP_txt.Text)
                ' Pokemon 2
                Preview.output_rchTxt.Text &= Generator.essentials17(pokemon2Name_txt.Text, pokemon2HeldItem_txt.Text, pokemon2Level_nbr.Value, pokemon2Ability_cmb.Text,
                                                                     pokemon2Gender_cmb.SelectedIndex, pokemon2Form_nbr.Value, pokemon2Nature_cmb.Text, pokemon2Happiness_nbr.Value,
                                                                     pokemon2Nickname_txt.Text, pokemon2PokeballID_cmb.Text, pokemon2Shiny_rad.Checked, pokemon2Shadow_rad.Checked,
                                                                     {pokemon2Move1_txtBox.Text, pokemon2Move2_txtBox.Text, pokemon2Move3_txtBox.Text, pokemon2Move4_txtBox.Text},
                                                                     pokemon2IVsHP_txt.Text)
                ' Pokemon 3
                Preview.output_rchTxt.Text &= Generator.essentials17(pokemon3Name_txt.Text, pokemon3HeldItem_txt.Text, pokemon3Level_nbr.Value, pokemon3Ability_cmb.Text,
                                                                     pokemon3Gender_cmb.SelectedIndex, pokemon3Form_nbr.Value, pokemon3Nature_cmb.Text, pokemon3Happiness_nbr.Value,
                                                                     pokemon3Nickname_txt.Text, pokemon3PokeballID_cmb.Text, pokemon3Shiny_rad.Checked, pokemon3Shadow_rad.Checked,
                                                                     {pokemon3Move1_txtBox.Text, pokemon3Move2_txtBox.Text, pokemon3Move3_txtBox.Text, pokemon3Move4_txtBox.Text},
                                                                     pokemon3IVsHP_txt.Text)
                ' Pokemon 4
                Preview.output_rchTxt.Text &= Generator.essentials17(pokemon4Name_txt.Text, pokemon4HeldItem_txt.Text, pokemon4Level_nbr.Value, pokemon4Ability_cmb.Text,
                                                                     pokemon4Gender_cmb.SelectedIndex, pokemon4Form_nbr.Value, pokemon4Nature_cmb.Text, pokemon4Happiness_nbr.Value,
                                                                     pokemon4Nickname_txt.Text, pokemon4PokeballID_cmb.Text, pokemon4Shiny_rad.Checked, pokemon4Shadow_rad.Checked,
                                                                     {pokemon4Move1_txtBox.Text, pokemon4Move2_txtBox.Text, pokemon4Move3_txtBox.Text, pokemon4Move4_txtBox.Text},
                                                                     pokemon4IVsHP_txt.Text)
                ' Pokemon 5
                Preview.output_rchTxt.Text &= Generator.essentials17(pokemon5Name_txt.Text, pokemon5HeldItem_txt.Text, pokemon5Level_nbr.Value, pokemon5Ability_cmb.Text,
                                                                     pokemon5Gender_cmb.SelectedIndex, pokemon5Form_nbr.Value, pokemon5Nature_cmb.Text, pokemon5Happiness_nbr.Value,
                                                                     pokemon5Nickname_txt.Text, pokemon5PokeballID_cmb.Text, pokemon5Shiny_rad.Checked, pokemon5Shadow_rad.Checked,
                                                                     {pokemon5Move1_txt.Text, pokemon5Move2_txt.Text, pokemon5Move3_txt.Text, pokemon5Move4_txt.Text},
                                                                     pokemon5IVsHP_txt.Text)
                ' Pokemon 6
                Preview.output_rchTxt.Text &= Generator.essentials17(pokemon6Name_txt.Text, pokemon6HeldItem_txt.Text, pokemon6Level_nbr.Value, pokemon6Ability_cmb.Text,
                                                                     pokemon6Gender_cmb.SelectedIndex, pokemon6Form_nbr.Value, pokemon6Nature_cmb.Text, pokemon6Happiness_nbr.Value,
                                                                     pokemon6Nickname_txt.Text, pokemon6PokeballID_cmb.Text, pokemon6Shiny_rad.Checked, pokemon6Shadow_rad.Checked,
                                                                     {pokemon6Move1_txt.Text, pokemon6Move2_txt.Text, pokemon6Move3_txt.Text, pokemon6Move4_txt.Text},
                                                                     pokemon6IVsHP_txt.Text)

            End If


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
            ElseIf numPoké_cmb.SelectedIndex = 2 Then
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
                ' Pokemon 3
                Preview.output_rchTxt.Text &= Generator.essentials18(pokemon3Name_txt.Text, pokemon3HeldItem_txt.Text, pokemon3Level_nbr.Value, pokemon3Ability_cmb.Text, pokemon3Gender_cmb.Text, pokemon3Form_nbr.Value,
                                       pokemon3Nature_cmb.Text, pokemon3Happiness_nbr.Value, pokemon3Nickname_txt.Text, pokemon3PokeballID_cmb.Text, pokemon3Shiny_rad.Checked,
                                       pokemon3SuperShiny_chkBox.Checked, pokemon3Shadow_rad.Checked,
                                       {pokemon3Move1_txtBox.Text, pokemon3Move2_txtBox.Text, pokemon3Move3_txtBox.Text, pokemon3Move4_txtBox.Text},
                                       {pokemon3IVsHP_txt.Text, pokemon3IVsATK_txt.Text, pokemon3IVsDEF_txt.Text, pokemon3IVsSPD_txt.Text, pokemon3IVsSPATK_txt.Text, pokemon3IVsSPDEF_txt.Text},
                                       {pokemon3EVsHP_txt.Text, pokemon3EVsATK_txt.Text, pokemon3EVsDEF_txt.Text, pokemon3EVsSPD_txt.Text, pokemon3EVsSPATK_txt.Text, pokemon3EVsSPDEF_txt.Text})
            ElseIf numPoké_cmb.SelectedIndex = 3 Then
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
                ' Pokemon 3
                Preview.output_rchTxt.Text &= Generator.essentials18(pokemon3Name_txt.Text, pokemon3HeldItem_txt.Text, pokemon3Level_nbr.Value, pokemon3Ability_cmb.Text, pokemon3Gender_cmb.Text, pokemon3Form_nbr.Value,
                                       pokemon3Nature_cmb.Text, pokemon3Happiness_nbr.Value, pokemon3Nickname_txt.Text, pokemon3PokeballID_cmb.Text, pokemon3Shiny_rad.Checked,
                                       pokemon3SuperShiny_chkBox.Checked, pokemon3Shadow_rad.Checked,
                                       {pokemon3Move1_txtBox.Text, pokemon3Move2_txtBox.Text, pokemon3Move3_txtBox.Text, pokemon3Move4_txtBox.Text},
                                       {pokemon3IVsHP_txt.Text, pokemon3IVsATK_txt.Text, pokemon3IVsDEF_txt.Text, pokemon3IVsSPD_txt.Text, pokemon3IVsSPATK_txt.Text, pokemon3IVsSPDEF_txt.Text},
                                       {pokemon3EVsHP_txt.Text, pokemon3EVsATK_txt.Text, pokemon3EVsDEF_txt.Text, pokemon3EVsSPD_txt.Text, pokemon3EVsSPATK_txt.Text, pokemon3EVsSPDEF_txt.Text})
                ' Pokemon 4
                Preview.output_rchTxt.Text &= Generator.essentials18(pokemon4Name_txt.Text, pokemon4HeldItem_txt.Text, pokemon4Level_nbr.Value, pokemon4Ability_cmb.Text, pokemon4Gender_cmb.Text, pokemon4Form_nbr.Value,
                                       pokemon4Nature_cmb.Text, pokemon4Happiness_nbr.Value, pokemon4Nickname_txt.Text, pokemon4PokeballID_cmb.Text, pokemon4Shiny_rad.Checked,
                                       pokemon4SuperShiny_chkBox.Checked, pokemon4Shadow_rad.Checked,
                                       {pokemon4Move1_txtBox.Text, pokemon4Move2_txtBox.Text, pokemon4Move3_txtBox.Text, pokemon4Move4_txtBox.Text},
                                       {pokemon4IVsHP_txt.Text, pokemon4IVsATK_txt.Text, pokemon4IVsDEF_txt.Text, pokemon4IVsSPD_txt.Text, pokemon4IVsSPATK_txt.Text, pokemon4IVsSPDEF_txt.Text},
                                       {pokemon4EVsHP_txt.Text, pokemon4EVsATK_txt.Text, pokemon4EVsDEF_txt.Text, pokemon4EVsSPD_txt.Text, pokemon4EVsSPATK_txt.Text, pokemon4EVsSPDEF_txt.Text})
            ElseIf numPoké_cmb.SelectedIndex = 4 Then
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
                ' Pokemon 3
                Preview.output_rchTxt.Text &= Generator.essentials18(pokemon3Name_txt.Text, pokemon3HeldItem_txt.Text, pokemon3Level_nbr.Value, pokemon3Ability_cmb.Text, pokemon3Gender_cmb.Text, pokemon3Form_nbr.Value,
                                       pokemon3Nature_cmb.Text, pokemon3Happiness_nbr.Value, pokemon3Nickname_txt.Text, pokemon3PokeballID_cmb.Text, pokemon3Shiny_rad.Checked,
                                       pokemon3SuperShiny_chkBox.Checked, pokemon3Shadow_rad.Checked,
                                       {pokemon3Move1_txtBox.Text, pokemon3Move2_txtBox.Text, pokemon3Move3_txtBox.Text, pokemon3Move4_txtBox.Text},
                                       {pokemon3IVsHP_txt.Text, pokemon3IVsATK_txt.Text, pokemon3IVsDEF_txt.Text, pokemon3IVsSPD_txt.Text, pokemon3IVsSPATK_txt.Text, pokemon3IVsSPDEF_txt.Text},
                                       {pokemon3EVsHP_txt.Text, pokemon3EVsATK_txt.Text, pokemon3EVsDEF_txt.Text, pokemon3EVsSPD_txt.Text, pokemon3EVsSPATK_txt.Text, pokemon3EVsSPDEF_txt.Text})
                ' Pokemon 4
                Preview.output_rchTxt.Text &= Generator.essentials18(pokemon4Name_txt.Text, pokemon4HeldItem_txt.Text, pokemon4Level_nbr.Value, pokemon4Ability_cmb.Text, pokemon4Gender_cmb.Text, pokemon4Form_nbr.Value,
                                       pokemon4Nature_cmb.Text, pokemon4Happiness_nbr.Value, pokemon4Nickname_txt.Text, pokemon4PokeballID_cmb.Text, pokemon4Shiny_rad.Checked,
                                       pokemon4SuperShiny_chkBox.Checked, pokemon4Shadow_rad.Checked,
                                       {pokemon4Move1_txtBox.Text, pokemon4Move2_txtBox.Text, pokemon4Move3_txtBox.Text, pokemon4Move4_txtBox.Text},
                                       {pokemon4IVsHP_txt.Text, pokemon4IVsATK_txt.Text, pokemon4IVsDEF_txt.Text, pokemon4IVsSPD_txt.Text, pokemon4IVsSPATK_txt.Text, pokemon4IVsSPDEF_txt.Text},
                                       {pokemon4EVsHP_txt.Text, pokemon4EVsATK_txt.Text, pokemon4EVsDEF_txt.Text, pokemon4EVsSPD_txt.Text, pokemon4EVsSPATK_txt.Text, pokemon4EVsSPDEF_txt.Text})
                ' Pokemon 5
                Preview.output_rchTxt.Text &= Generator.essentials18(pokemon5Name_txt.Text, pokemon5HeldItem_txt.Text, pokemon5Level_nbr.Value, pokemon5Ability_cmb.Text, pokemon5Gender_cmb.Text, pokemon5Form_nbr.Value,
                                       pokemon5Nature_cmb.Text, pokemon5Happiness_nbr.Value, pokemon5Nickname_txt.Text, pokemon5PokeballID_cmb.Text, pokemon5Shiny_rad.Checked,
                                       pokemon5SuperShiny_chkBox.Checked, pokemon5Shadow_rad.Checked,
                                       {pokemon5Move1_txt.Text, pokemon5Move2_txt.Text, pokemon5Move3_txt.Text, pokemon5Move4_txt.Text},
                                       {pokemon5IVsHP_txt.Text, pokemon5IVsATK_txt.Text, pokemon5IVsDEF_txt.Text, pokemon5IVsSPD_txt.Text, pokemon5IVsSPATK_txt.Text, pokemon5IVsSPDEF_txt.Text},
                                       {pokemon5EVsHP_txt.Text, pokemon5EVsATK_txt.Text, pokemon5EVsDEF_txt.Text, pokemon5EVsSPD_txt.Text, pokemon5EVsSPATK_txt.Text, pokemon5EVsSPDEF_txt.Text})
            ElseIf numPoké_cmb.SelectedIndex = 5 Then
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
                ' Pokemon 3
                Preview.output_rchTxt.Text &= Generator.essentials18(pokemon3Name_txt.Text, pokemon3HeldItem_txt.Text, pokemon3Level_nbr.Value, pokemon3Ability_cmb.Text, pokemon3Gender_cmb.Text, pokemon3Form_nbr.Value,
                                       pokemon3Nature_cmb.Text, pokemon3Happiness_nbr.Value, pokemon3Nickname_txt.Text, pokemon3PokeballID_cmb.Text, pokemon3Shiny_rad.Checked,
                                       pokemon3SuperShiny_chkBox.Checked, pokemon3Shadow_rad.Checked,
                                       {pokemon3Move1_txtBox.Text, pokemon3Move2_txtBox.Text, pokemon3Move3_txtBox.Text, pokemon3Move4_txtBox.Text},
                                       {pokemon3IVsHP_txt.Text, pokemon3IVsATK_txt.Text, pokemon3IVsDEF_txt.Text, pokemon3IVsSPD_txt.Text, pokemon3IVsSPATK_txt.Text, pokemon3IVsSPDEF_txt.Text},
                                       {pokemon3EVsHP_txt.Text, pokemon3EVsATK_txt.Text, pokemon3EVsDEF_txt.Text, pokemon3EVsSPD_txt.Text, pokemon3EVsSPATK_txt.Text, pokemon3EVsSPDEF_txt.Text})
                ' Pokemon 4
                Preview.output_rchTxt.Text &= Generator.essentials18(pokemon4Name_txt.Text, pokemon4HeldItem_txt.Text, pokemon4Level_nbr.Value, pokemon4Ability_cmb.Text, pokemon4Gender_cmb.Text, pokemon4Form_nbr.Value,
                                       pokemon4Nature_cmb.Text, pokemon4Happiness_nbr.Value, pokemon4Nickname_txt.Text, pokemon4PokeballID_cmb.Text, pokemon4Shiny_rad.Checked,
                                       pokemon4SuperShiny_chkBox.Checked, pokemon4Shadow_rad.Checked,
                                       {pokemon4Move1_txtBox.Text, pokemon4Move2_txtBox.Text, pokemon4Move3_txtBox.Text, pokemon4Move4_txtBox.Text},
                                       {pokemon4IVsHP_txt.Text, pokemon4IVsATK_txt.Text, pokemon4IVsDEF_txt.Text, pokemon4IVsSPD_txt.Text, pokemon4IVsSPATK_txt.Text, pokemon4IVsSPDEF_txt.Text},
                                       {pokemon4EVsHP_txt.Text, pokemon4EVsATK_txt.Text, pokemon4EVsDEF_txt.Text, pokemon4EVsSPD_txt.Text, pokemon4EVsSPATK_txt.Text, pokemon4EVsSPDEF_txt.Text})
                ' Pokemon 5
                Preview.output_rchTxt.Text &= Generator.essentials18(pokemon5Name_txt.Text, pokemon5HeldItem_txt.Text, pokemon5Level_nbr.Value, pokemon5Ability_cmb.Text, pokemon5Gender_cmb.Text, pokemon5Form_nbr.Value,
                                       pokemon5Nature_cmb.Text, pokemon5Happiness_nbr.Value, pokemon5Nickname_txt.Text, pokemon5PokeballID_cmb.Text, pokemon5Shiny_rad.Checked,
                                       pokemon5SuperShiny_chkBox.Checked, pokemon5Shadow_rad.Checked,
                                       {pokemon5Move1_txt.Text, pokemon5Move2_txt.Text, pokemon5Move3_txt.Text, pokemon5Move4_txt.Text},
                                       {pokemon5IVsHP_txt.Text, pokemon5IVsATK_txt.Text, pokemon5IVsDEF_txt.Text, pokemon5IVsSPD_txt.Text, pokemon5IVsSPATK_txt.Text, pokemon5IVsSPDEF_txt.Text},
                                       {pokemon5EVsHP_txt.Text, pokemon5EVsATK_txt.Text, pokemon5EVsDEF_txt.Text, pokemon5EVsSPD_txt.Text, pokemon5EVsSPATK_txt.Text, pokemon5EVsSPDEF_txt.Text})
                ' Pokemon 6
                Preview.output_rchTxt.Text &= Generator.essentials18(pokemon6Name_txt.Text, pokemon6HeldItem_txt.Text, pokemon6Level_nbr.Value, pokemon6Ability_cmb.Text, pokemon6Gender_cmb.Text, pokemon6Form_nbr.Value,
                                       pokemon6Nature_cmb.Text, pokemon6Happiness_nbr.Value, pokemon6Nickname_txt.Text, pokemon6PokeballID_cmb.Text, pokemon6Shiny_rad.Checked,
                                       pokemon6SuperShiny_chkBox.Checked, pokemon6Shadow_rad.Checked,
                                       {pokemon6Move1_txt.Text, pokemon6Move2_txt.Text, pokemon6Move3_txt.Text, pokemon6Move4_txt.Text},
                                       {pokemon6IVsHP_txt.Text, pokemon6IVsATK_txt.Text, pokemon6IVsDEF_txt.Text, pokemon6IVsSPD_txt.Text, pokemon6IVsSPATK_txt.Text, pokemon6IVsSPDEF_txt.Text},
                                       {pokemon6EVsHP_txt.Text, pokemon6EVsATK_txt.Text, pokemon6EVsDEF_txt.Text, pokemon6EVsSPD_txt.Text, pokemon6EVsSPATK_txt.Text, pokemon6EVsSPDEF_txt.Text})
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
        AddItem(Input.ToUpper)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        LangManager()

    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
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

        ' Load this from startup
        lang_cmb.SelectedIndex = My.Settings.Lang

        ' Now check language
        LangManager()

    End Sub

#Region "Item Buttons"

    ' These get their own #Region because I don't want to have to look
    ' at them all the time.

    Private Sub itemAddPotion_btn_Click(sender As Object, e As EventArgs) Handles itemAddPotion_btn.Click
        AddItem("POTION")
    End Sub

    Private Sub itemAddEther_btn_Click(sender As Object, e As EventArgs) Handles itemAddEther_btn.Click
        AddItem("ETHER")
    End Sub

    Private Sub itemAddElixir_btn_Click(sender As Object, e As EventArgs) Handles itemAddElixir_btn.Click
        AddItem("ELIXIR")
    End Sub

    Private Sub itemAddSuperPotion_btn_Click(sender As Object, e As EventArgs) Handles itemAddSuperPotion_btn.Click
        AddItem("SUPERPOTION")
    End Sub

    Private Sub itemAddHyperPotion_btn_Click(sender As Object, e As EventArgs) Handles itemAddHyperPotion_btn.Click
        AddItem("HYPERPOTION")
    End Sub

    Private Sub itemAddMaxPotion_btn_Click(sender As Object, e As EventArgs) Handles itemAddMaxPotion_btn.Click
        AddItem("MAXPOTION")
    End Sub

    Private Sub itemAddMaxEther_btn_Click(sender As Object, e As EventArgs) Handles itemAddMaxEther_btn.Click
        AddItem("MAXETHER")
    End Sub

    Private Sub itemAddMaxElixir_btn_Click(sender As Object, e As EventArgs) Handles itemAddMaxElixir_btn.Click
        AddItem("MAXELIXIR")
    End Sub

    Private Sub itemAddFullRestore_btn_Click(sender As Object, e As EventArgs) Handles itemAddFullRestore_btn.Click
        AddItem("FULLRESTORE")
    End Sub

#End Region

    Private Sub LangManager()


        If Not lang_cmb.SelectedIndex = My.Settings.Lang Then
            ' Set Display Language
            If lang_cmb.SelectedIndex = 0 Then
                Threading.Thread.CurrentThread.CurrentCulture = Globalization.CultureInfo.GetCultureInfo("en")
                Threading.Thread.CurrentThread.CurrentUICulture = Globalization.CultureInfo.GetCultureInfo("en")
            ElseIf lang_cmb.SelectedIndex = 1 Then
                Threading.Thread.CurrentThread.CurrentCulture = Globalization.CultureInfo.GetCultureInfo("en-001")
                Threading.Thread.CurrentThread.CurrentUICulture = Globalization.CultureInfo.GetCultureInfo("en-001")
            End If

            ' Save the settings
            My.Settings.Lang = lang_cmb.SelectedIndex
            My.Settings.Save()

            Debug.WriteLine("Reloading Language...")

            ' These three lines wasted 30 minutes of my life
            ' because they were not inside the if statement.
            Me.Controls.Clear()
            InitializeComponent()
            Form1_Activated(Nothing, Nothing)
        End If
    End Sub
End Class
