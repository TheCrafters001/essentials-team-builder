﻿Public Class Form1
#Region "Initialization"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Startup.Init()
        trainerItems_grp.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Startup.TimerChecker()
    End Sub
#End Region

#Region "Buttons"
    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        If codeExporter_dialog.ShowDialog = DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(codeExporter_dialog.FileName, outputBox_rchBox.Text, False)
            MessageBox.Show("File Saved at: " & codeExporter_dialog.FileName)
        End If
    End Sub

    Private Sub generate_btn_Click(sender As Object, e As EventArgs) Handles generate_btn.Click
        Generator.Trainer()
        Generator.NewGen()
    End Sub

    Private Sub example_btn_Click(sender As Object, e As EventArgs) Handles example_btn.Click
        trainerName_txtBox.Text = "Trainer"
        trainerType_txtBox.Text = "Rival"
        numPoké_cmb.SelectedIndex = 0
        trainerUsesItems_chkBox.Checked = True
        trainerItemsList_lstbox.Items.Clear()
        trainerItemsList_lstbox.Items.Add("potion")
        pokemonOneName_txtBox.Text = "Weezing"
        pokemonOneMoves_lst.Items.Clear()
        pokemonOneMoves_lst.Items.Add("FireBlast")
        pokemonOneGender_cmb.SelectedIndex = 0
        pokemonOneNickName_txtBox.Text = "Gonzalos"
        pokemonOneLvl_txtBox.Text = "20"
    End Sub


    Private Sub save_to_trainers_btn_Click(sender As Object, e As EventArgs) Handles save_to_trainers_btn.Click
        Try
            If trainer_txt_file_dialog.ShowDialog() = DialogResult.OK Then
                My.Computer.FileSystem.WriteAllText(trainer_txt_file_dialog.FileName, vbCrLf & outputBox_rchBox.Text, True)
            End If
        Catch ex As Exception
            MessageBox.Show("Something went wrong. The error details will now be displayed." & vbCrLf & vbCrLf & ex.ToString)
        End Try
    End Sub

    Private Sub trainerItemsList_btn_Click(sender As Object, e As EventArgs) Handles trainerItemsList_btn.Click
        ' Create Input Box
        Dim input As String = InputBox("Please enter an item you want this trainer to use", "Add Item", "Potion")
        ' Once they hit okay, then add item
        If input = "" Then
            MessageBox.Show("You cannot leave the box blank.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If trainerItemsList_lstbox.Items.Count = 8 Then
                MessageBox.Show("You cannot add more than 8 items.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                trainerItemsList_lstbox.Items.Add(input)
            End If
        End If
    End Sub
#End Region

#Region "Add Move Handlers"
    Private Sub pokemonOneAddMove_btn_Click(sender As Object, e As EventArgs) Handles pokemonOneAddMove_btn.Click
        ' Create Input Box
        Dim input As String = InputBox("Please enter a move to add", "Add Item", "Tackle")
        ' Once they hit okay, then add item
        If input = "" Then
            MessageBox.Show("You cannot leave the box blank.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If pokemonOneMoves_lst.Items.Count = 4 Then
                MessageBox.Show("You cannot add more than 4 moves.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                pokemonOneMoves_lst.Items.Add(input.ToUpper)
            End If
        End If
    End Sub
    Private Sub pokemonTwoAddMove_btn_Click(sender As Object, e As EventArgs) Handles pokemonTwoAddMove_btn.Click
        ' Create Input Box
        Dim input As String = InputBox("Please enter a move to add", "Add Item", "Tackle")
        ' Once they hit okay, then add item
        If input = "" Then
            MessageBox.Show("You cannot leave the box blank.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If pokemonTwoMoves_lst.Items.Count = 4 Then
                MessageBox.Show("You cannot add more than 4 moves.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                pokemonTwoMoves_lst.Items.Add(input.ToUpper)
            End If
        End If
    End Sub
    Private Sub pokemonThreeAddMove_btn_Click(sender As Object, e As EventArgs) Handles pokemonThreeAddMove_btn.Click
        ' Create Input Box
        Dim input As String = InputBox("Please enter a move to add", "Add Item", "Tackle")
        ' Once they hit okay, then add item
        If input = "" Then
            MessageBox.Show("You cannot leave the box blank.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If pokemonThreeMoves_lst.Items.Count = 4 Then
                MessageBox.Show("You cannot add more than 4 moves.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                pokemonThreeMoves_lst.Items.Add(input.ToUpper)
            End If
        End If
    End Sub
    Private Sub pokemonFourAddMove_btn_Click(sender As Object, e As EventArgs) Handles pokemonFourAddMove_btn.Click
        ' Create Input Box
        Dim input As String = InputBox("Please enter a move to add", "Add Item", "Tackle")
        ' Once they hit okay, then add item
        If input = "" Then
            MessageBox.Show("You cannot leave the box blank.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If pokemonFourMoves_lst.Items.Count = 4 Then
                MessageBox.Show("You cannot add more than 4 moves.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                pokemonFourMoves_lst.Items.Add(input.ToUpper)
            End If
        End If
    End Sub
    Private Sub pokemonFiveAddMove_btn_Click(sender As Object, e As EventArgs) Handles pokemonFiveAddMove_btn.Click
        ' Create Input Box
        Dim input As String = InputBox("Please enter a move to add", "Add Item", "Tackle")
        ' Once they hit okay, then add item
        If input = "" Then
            MessageBox.Show("You cannot leave the box blank.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If pokemonFiveMoves_lst.Items.Count = 4 Then
                MessageBox.Show("You cannot add more than 4 moves.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                pokemonFiveMoves_lst.Items.Add(input.ToUpper)
            End If
        End If
    End Sub
    Private Sub pokemonSixAddMove_btn_Click(sender As Object, e As EventArgs) Handles pokemonSixAddMove_btn.Click
        ' Create Input Box
        Dim input As String = InputBox("Please enter a move to add", "Add Item", "Tackle")
        ' Once they hit okay, then add item
        If input = "" Then
            MessageBox.Show("You cannot leave the box blank.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If pokemonSixMoves_lst.Items.Count = 4 Then
                MessageBox.Show("You cannot add more than 4 moves.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                pokemonSixMoves_lst.Items.Add(input.ToUpper)
            End If
        End If
    End Sub

#End Region

#Region "Listbox DoubleClick Remover"
    Private Sub trainerItemsList_lstbox_DoubleClick(sender As Object, e As EventArgs) Handles trainerItemsList_lstbox.DoubleClick
        trainerItemsList_lstbox.Items.Remove(trainerItemsList_lstbox.SelectedItem)
    End Sub

    Private Sub pokemonOneMoves_lst_DoubleClick(sender As Object, e As EventArgs) Handles pokemonOneMoves_lst.DoubleClick
        pokemonOneMoves_lst.Items.Remove(pokemonOneMoves_lst.SelectedItem)
    End Sub
    Private Sub pokemonTwoMoves_lst_DoubleClick(sender As Object, e As EventArgs) Handles pokemonTwoMoves_lst.DoubleClick
        pokemonTwoMoves_lst.Items.Remove(pokemonTwoMoves_lst.SelectedItem)
    End Sub
    Private Sub pokemonThreeMoves_lst_DoubleClick(sender As Object, e As EventArgs) Handles pokemonThreeMoves_lst.DoubleClick
        pokemonThreeMoves_lst.Items.Remove(pokemonThreeMoves_lst.SelectedItem)
    End Sub
    Private Sub pokemonFourMoves_lst_DoubleClick(sender As Object, e As EventArgs) Handles pokemonFourMoves_lst.DoubleClick
        pokemonFourMoves_lst.Items.Remove(pokemonFourMoves_lst.SelectedItem)
    End Sub
    Private Sub pokemonFiveMoves_lst_DoubleClick(sender As Object, e As EventArgs) Handles pokemonFiveMoves_lst.DoubleClick
        pokemonFiveMoves_lst.Items.Remove(pokemonFiveMoves_lst.SelectedItem)
    End Sub
    Private Sub pokemonSixMoves_lst_DoubleClick(sender As Object, e As EventArgs) Handles pokemonSixMoves_lst.DoubleClick
        pokemonSixMoves_lst.Items.Remove(pokemonSixMoves_lst.SelectedItem)
    End Sub
#End Region

#Region "Checkbox CheckedChanged"
    Private Sub internalBallNames_chk_CheckedChanged(sender As Object, e As EventArgs) Handles internalBallNames_chk.CheckedChanged
        If internalBallNames_chk.Checked = True Then
            ' Clear all Items first
            pokemonOnePokeballID_cmb.Items.Clear()
            pokemonTwoPokeballID_cmb.Items.Clear()
            pokemonThreePokeballID_cmb.Items.Clear()
            pokemonFourPokeballID_cmb.Items.Clear()
            pokemonFivePokeballID_cmb.Items.Clear()
            pokemonSixPokeballID_cmb.Items.Clear()
            ' Add all known ball types via Range
            pokemonOnePokeballID_cmb.Items.AddRange({"POKEBALL", "GREATBALL", "SAFARIBALL", "ULTRABALL", "MASTERBALL", "NETBALL", "DIVEBALL", "NESTBALL", "REPEATBALL", "TIMERBALL",
                                                          "LUXURYBALL", "PREMIERBALL", "DUSKBALL", "HEALBALL", "QUICKBALL", "CHERISHBALL", "FASTBALL", "LEVELBALL", "LUREBALL", "HEAVYBALL",
                                                          "LOVEBALL", "FRIENDBALL", "MOONBALL", "SPORTBALL", "DREAMBALL", "BEASTBALL"})
            pokemonTwoPokeballID_cmb.Items.AddRange({"POKEBALL", "GREATBALL", "SAFARIBALL", "ULTRABALL", "MASTERBALL", "NETBALL", "DIVEBALL", "NESTBALL", "REPEATBALL", "TIMERBALL",
                                              "LUXURYBALL", "PREMIERBALL", "DUSKBALL", "HEALBALL", "QUICKBALL", "CHERISHBALL", "FASTBALL", "LEVELBALL", "LUREBALL", "HEAVYBALL",
                                              "LOVEBALL", "FRIENDBALL", "MOONBALL", "SPORTBALL", "DREAMBALL", "BEASTBALL"})
            pokemonThreePokeballID_cmb.Items.AddRange({"POKEBALL", "GREATBALL", "SAFARIBALL", "ULTRABALL", "MASTERBALL", "NETBALL", "DIVEBALL", "NESTBALL", "REPEATBALL", "TIMERBALL",
                                              "LUXURYBALL", "PREMIERBALL", "DUSKBALL", "HEALBALL", "QUICKBALL", "CHERISHBALL", "FASTBALL", "LEVELBALL", "LUREBALL", "HEAVYBALL",
                                              "LOVEBALL", "FRIENDBALL", "MOONBALL", "SPORTBALL", "DREAMBALL", "BEASTBALL"})
            pokemonFourPokeballID_cmb.Items.AddRange({"POKEBALL", "GREATBALL", "SAFARIBALL", "ULTRABALL", "MASTERBALL", "NETBALL", "DIVEBALL", "NESTBALL", "REPEATBALL", "TIMERBALL",
                                              "LUXURYBALL", "PREMIERBALL", "DUSKBALL", "HEALBALL", "QUICKBALL", "CHERISHBALL", "FASTBALL", "LEVELBALL", "LUREBALL", "HEAVYBALL",
                                              "LOVEBALL", "FRIENDBALL", "MOONBALL", "SPORTBALL", "DREAMBALL", "BEASTBALL"})
            pokemonFivePokeballID_cmb.Items.AddRange({"POKEBALL", "GREATBALL", "SAFARIBALL", "ULTRABALL", "MASTERBALL", "NETBALL", "DIVEBALL", "NESTBALL", "REPEATBALL", "TIMERBALL",
                                              "LUXURYBALL", "PREMIERBALL", "DUSKBALL", "HEALBALL", "QUICKBALL", "CHERISHBALL", "FASTBALL", "LEVELBALL", "LUREBALL", "HEAVYBALL",
                                              "LOVEBALL", "FRIENDBALL", "MOONBALL", "SPORTBALL", "DREAMBALL", "BEASTBALL"})
            pokemonSixPokeballID_cmb.Items.AddRange({"POKEBALL", "GREATBALL", "SAFARIBALL", "ULTRABALL", "MASTERBALL", "NETBALL", "DIVEBALL", "NESTBALL", "REPEATBALL", "TIMERBALL",
                                              "LUXURYBALL", "PREMIERBALL", "DUSKBALL", "HEALBALL", "QUICKBALL", "CHERISHBALL", "FASTBALL", "LEVELBALL", "LUREBALL", "HEAVYBALL",
                                              "LOVEBALL", "FRIENDBALL", "MOONBALL", "SPORTBALL", "DREAMBALL", "BEASTBALL"})
            ' Select the first Pokeball in the list. (Usually 0 or POKEBALL)
            pokemonOnePokeballID_cmb.SelectedIndex = 0
            pokemonTwoPokeballID_cmb.SelectedIndex = 0
            pokemonThreePokeballID_cmb.SelectedIndex = 0
            pokemonFourPokeballID_cmb.SelectedIndex = 0
            pokemonFivePokeballID_cmb.SelectedIndex = 0
            pokemonSixPokeballID_cmb.SelectedIndex = 0
        ElseIf internalBallNames_chk.Checked = False Then
            ' Clear all Items first
            pokemonOnePokeballID_cmb.Items.Clear()
            pokemonTwoPokeballID_cmb.Items.Clear()
            pokemonThreePokeballID_cmb.Items.Clear()
            pokemonFourPokeballID_cmb.Items.Clear()
            pokemonFivePokeballID_cmb.Items.Clear()
            pokemonSixPokeballID_cmb.Items.Clear()
            ' Add all known ball IDs via Range
            pokemonOnePokeballID_cmb.Items.AddRange({"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25"})
            pokemonTwoPokeballID_cmb.Items.AddRange({"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25"})
            pokemonThreePokeballID_cmb.Items.AddRange({"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25"})
            pokemonFourPokeballID_cmb.Items.AddRange({"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25"})
            pokemonFivePokeballID_cmb.Items.AddRange({"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25"})
            pokemonSixPokeballID_cmb.Items.AddRange({"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25"})
            ' Select the first Pokeball in the list. (Usually 0 or POKEBALL)
            pokemonOnePokeballID_cmb.SelectedIndex = 0
            pokemonTwoPokeballID_cmb.SelectedIndex = 0
            pokemonThreePokeballID_cmb.SelectedIndex = 0
            pokemonFourPokeballID_cmb.SelectedIndex = 0
            pokemonFivePokeballID_cmb.SelectedIndex = 0
            pokemonSixPokeballID_cmb.SelectedIndex = 0
        End If
    End Sub

#End Region

End Class
