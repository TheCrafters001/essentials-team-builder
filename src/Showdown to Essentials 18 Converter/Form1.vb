﻿Imports System.ComponentModel
Imports DiscordRPCHandler

Public Class Form1

#Region "Initialization"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Startup.Init()
        trainerItems_grp.Enabled = False
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
        Generator.createTeam()
    End Sub

    Private Sub ess18Settings_btn_Click(sender As Object, e As EventArgs) Handles ess18Settings_btn.Click
        useAbilityIndex_chkBox.Checked = False
        internalBallNames_chk.Checked = False
    End Sub

    Private Sub ess19Settings_btn_Click(sender As Object, e As EventArgs) Handles ess19Settings_btn.Click
        useAbilityIndex_chkBox.Checked = True
        internalBallNames_chk.Checked = True
        loseTextQuotes_chkBox.Checked = True
    End Sub

    Private Sub ess20Settings_btn_Click(sender As Object, e As EventArgs) Handles ess20Settings_btn.Click
        useAbilityIndex_chkBox.Checked = True
        internalBallNames_chk.Checked = True
        loseTextQuotes_chkBox.Checked = False
    End Sub

    Private Sub example_btn_Click(sender As Object, e As EventArgs) Handles example_btn.Click
        Darkness = True
        Dim DiagRes As DialogResult = MessageBox.Show("Are you sure you want to use the example? It will override any changed you have already made.", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If DiagRes = DialogResult.Yes Then
            trainerName_txtBox.Text = "Trainer"
            trainerType_txtBox.Text = "Rival"
            loseText_txt.Text = "You beat me?!"
            numPoké_cmb.SelectedIndex = 0
            trainerUsesItems_chkBox.Checked = True
            trainerItemsList_lstbox.Items.Clear()
            trainerItemsList_lstbox.Items.Add("potion")
            pokemonOneName_txtBox.Text = "Koffing"
            pokemonOneMoves_lst.Items.Clear()
            pokemonOneMoves_lst.Items.AddRange({"PoisonGas", "Tackle", "smoG"})
            pokemonOneGender_cmb.SelectedIndex = 0
            pokemonOneNickName_txtBox.Text = "Gonzalos"
            pokemonOneLvl_txtBox.Text = "5"
        ElseIf DiagRes = DialogResult.No Then
            'Do Nothing
        End If
        Darkness = False
    End Sub

    Private Sub save_to_trainers_btn_Click(sender As Object, e As EventArgs) Handles save_to_trainers_btn.Click
        Try
            If trainer_txt_file_dialog.ShowDialog() = DialogResult.OK Then
                My.Computer.FileSystem.WriteAllText(trainer_txt_file_dialog.FileName, vbCrLf & outputBox_rchBox.Text, True)
            End If
        Catch ex As Exception
            Darkness = True
            MessageBox.Show("Something went wrong. The error details will now be displayed." & vbCrLf & vbCrLf & ex.ToString)
        Finally
            Darkness = False
        End Try
    End Sub

    Private Sub clearInputs_btn_Click(sender As Object, e As EventArgs) Handles clearInputs_btn.Click
        clearFields.Clear()
    End Sub

#Region "Items"
    Private Sub trainerItemsList_btn_Click(sender As Object, e As EventArgs)
        Try
            Darkness = True
            ' Create Input Box
            Dim input As String = InputBox("Please enter an item you want this trainer to use", "Add Item", "Potion")
            ' Once they hit okay, then add item
            If input = "" Then
                MessageBox.Show("You cannot leave the box blank.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If trainerItemsList_lstbox.Items.Count = 8 Then
                    MessageBox.Show("You cannot add more than 8 items.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    trainerItemsList_lstbox.Items.Add(input.ToUpper)
                End If
            End If
        Finally
            Darkness = False
        End Try
    End Sub


    Private Sub itemPotion_btn_Click(sender As Object, e As EventArgs) Handles itemPotion_btn.Click
        If trainerItemsList_lstbox.Items.Count = 8 Then
            MessageBox.Show("You cannot add more than 8 items.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            trainerItemsList_lstbox.Items.Add("POTION")
        End If
    End Sub

    Private Sub itemSuperPotion_btn_Click(sender As Object, e As EventArgs) Handles itemSuperPotion_btn.Click
        If trainerItemsList_lstbox.Items.Count = 8 Then
            MessageBox.Show("You cannot add more than 8 items.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            trainerItemsList_lstbox.Items.Add("SUPERPOTION")
        End If
    End Sub

    Private Sub itemHyperPotion_btn_Click(sender As Object, e As EventArgs) Handles itemHyperPotion_btn.Click
        If trainerItemsList_lstbox.Items.Count = 8 Then
            MessageBox.Show("You cannot add more than 8 items.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            trainerItemsList_lstbox.Items.Add("HYPERPOTION")
        End If
    End Sub

    Private Sub itemFullRestore_btn_Click(sender As Object, e As EventArgs) Handles itemFullRestore_btn.Click
        If trainerItemsList_lstbox.Items.Count = 8 Then
            MessageBox.Show("You cannot add more than 8 items.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            trainerItemsList_lstbox.Items.Add("FULLRESTORE")
        End If
    End Sub

#End Region

    Private Sub wizard_btn_Click(sender As Object, e As EventArgs) Handles wizard_btn.Click
        wizard_startDialog.Show()
    End Sub
#End Region

#Region "Deinitialization"
    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Disp.Dispose()
    End Sub
#End Region

#Region "Checkbox CheckedChanged"
    Private Sub customBallIDs_chkBox_CheckedChanged(sender As Object, e As EventArgs) Handles customBallIDs_chkBox.CheckedChanged
        If customBallIDs_chkBox.Checked = False Then
            pokemonOnePokeballID_cmb.DropDownStyle = ComboBoxStyle.DropDownList
            pokemonTwoPokeballID_cmb.DropDownStyle = ComboBoxStyle.DropDownList
            pokemonThreePokeballID_cmb.DropDownStyle = ComboBoxStyle.DropDownList
            pokemonFourPokeballID_cmb.DropDownStyle = ComboBoxStyle.DropDownList
            pokemonFivePokeballID_cmb.DropDownStyle = ComboBoxStyle.DropDownList
            pokemonSixPokeballID_cmb.DropDownStyle = ComboBoxStyle.DropDownList
        ElseIf customBallIDs_chkBox.Checked = True Then
            pokemonOnePokeballID_cmb.DropDownStyle = ComboBoxStyle.DropDown
            pokemonTwoPokeballID_cmb.DropDownStyle = ComboBoxStyle.DropDown
            pokemonThreePokeballID_cmb.DropDownStyle = ComboBoxStyle.DropDown
            pokemonFourPokeballID_cmb.DropDownStyle = ComboBoxStyle.DropDown
            pokemonFivePokeballID_cmb.DropDownStyle = ComboBoxStyle.DropDown
            pokemonSixPokeballID_cmb.DropDownStyle = ComboBoxStyle.DropDown
        End If
    End Sub

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

    Private Sub trainerUsesItems_chkBox_CheckedChanged(sender As Object, e As EventArgs)
        If trainerUsesItems_chkBox.Checked = True Then
            trainerItems_grp.Enabled = True
        ElseIf trainerUsesItems_chkBox.Checked = False Then
            trainerItems_grp.Enabled = False
        End If
    End Sub

    Private Sub existingBattle_chkBox_CheckedChanged(sender As Object, e As EventArgs) Handles existingBattle_chkBox.CheckedChanged
        If existingBattle_chkBox.Checked = True Then
            battleTeamID_lbl.Enabled = True
            battleTeamID_txtBox.Enabled = True
        ElseIf existingBattle_chkBox.Checked = False Then
            battleTeamID_lbl.Enabled = False
            battleTeamID_txtBox.Enabled = False
        End If
    End Sub
#End Region

#Region "Add Move Handlers"
    Private Sub pokemonOneAddMove_btn_Click(sender As Object, e As EventArgs) Handles pokemonOneAddMove_btn.Click
        Try
            Darkness = True
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
        Finally
            Darkness = False
        End Try
    End Sub
    Private Sub pokemonTwoAddMove_btn_Click(sender As Object, e As EventArgs) Handles pokemonTwoAddMove_btn.Click
        Try
            Darkness = True
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
        Finally
            Darkness = False
        End Try
    End Sub
    Private Sub pokemonThreeAddMove_btn_Click(sender As Object, e As EventArgs) Handles pokemonThreeAddMove_btn.Click
        Try
            Darkness = True
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
        Finally
            Darkness = False
        End Try
    End Sub
    Private Sub pokemonFourAddMove_btn_Click(sender As Object, e As EventArgs) Handles pokemonFourAddMove_btn.Click
        Try
            Darkness = True
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
        Finally
            Darkness = False
        End Try
    End Sub
    Private Sub pokemonFiveAddMove_btn_Click(sender As Object, e As EventArgs) Handles pokemonFiveAddMove_btn.Click
        Try
            Darkness = True
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
        Finally
            Darkness = False
        End Try
    End Sub
    Private Sub pokemonSixAddMove_btn_Click(sender As Object, e As EventArgs) Handles pokemonSixAddMove_btn.Click
        Try
            Darkness = True
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
        Finally
            Darkness = False
        End Try
    End Sub

#End Region

#Region "Listbox DoubleClick Remover"
    Private Sub trainerItemsList_lstbox_DoubleClick(sender As Object, e As EventArgs)
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

#Region "Popup Window Handeler"

    ' Credit: Kratz - Stack Overflow
    ' https://stackoverflow.com/a/12865938/7799766

    Private _PB As PictureBox

    Public WriteOnly Property Darkness
        Set(value)
            If value Then
                Dim Bmp = New Bitmap(Bounds.Size.Width, Bounds.Size.Height)
                Me.DrawToBitmap(Bmp, New Rectangle(Point.Empty, Bounds.Size))
                Using g = Graphics.FromImage(Bmp)
                    Dim Brush As New SolidBrush(Color.FromArgb(125, Color.Black))
                    g.FillRectangle(Brush, New Rectangle(Point.Empty, Bmp.Size))
                End Using
                _PB = New PictureBox
                Me.Controls.Add(_PB)
                _PB.Size = Bounds.Size
                _PB.Location = Bounds.Location - PointToScreen(Point.Empty)
                _PB.Image = Bmp
                _PB.BringToFront()
            Else
                If _PB IsNot Nothing Then
                    Me.Controls.Remove(_PB)
                    _PB.Dispose()
                End If
            End If
        End Set
    End Property
#End Region

    Private Sub thirdPartyLicenses_lnk_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles thirdPartyLicenses_lnk.LinkClicked
        ThirdPartyLicenses.Show()
    End Sub

    Private Sub numPoké_cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles numPoké_cmb.SelectedIndexChanged
        pageEnabler.Enabler()
    End Sub

    Private Sub gnuGPL3_picBox_Click(sender As Object, e As EventArgs) Handles gnuGPL3_picBox.Click
        Process.Start("https://www.gnu.org/licenses/gpl-3.0.html")
    End Sub
End Class
