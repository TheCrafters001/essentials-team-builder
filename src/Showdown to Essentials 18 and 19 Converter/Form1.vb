Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Start the Discord RPC
        DiscordRPCHandler.InitRPC.Setup(861016966855786516, "Using StEC!", "Creating a Battle Team")

#Region "Startup Stuff"
#Region "Trainer"
        ' Disable Trainer Items by Default
        items_grp.Enabled = False
        ' Set number of Pokemon to 1 by Default
        pokeNum_cmb.SelectedIndex = 0

        Debug.WriteLine("Trainer Defaults Set")
#End Region

#Region "Pokemon 1"
        ' Set Gender to Random
        pokemonOneGender_cmb.SelectedIndex = 2
        ' Set ability to 0
        pokemonOneAbility_cmb.SelectedIndex = 0
        ' Set happiness to 70
        pokemonOneHappieness_cmb.SelectedIndex = 70
        ' Set nature to Random
        pokemonOneNature_cmb.SelectedIndex = 0
        ' Set Default PokeBall to Pokeball (0)
        pokemonOnePokeballID_cmb.SelectedIndex = 0
        ' Set IVs to 0
        pokemonOneIV_HP_cmb.SelectedIndex = 0
        pokemonOneIV_ATK_cmb.SelectedIndex = 0
        pokemonOneIV_DEF_cmb.SelectedIndex = 0
        pokemonOneIV_SPD_cmb.SelectedIndex = 0
        pokemonOneIV_SPATK_cmb.SelectedIndex = 0
        pokemonOneIV_SPDEF_cmb.SelectedIndex = 0
        ' Set EVs to 0
        pokemonOneEV_HP_cmb.SelectedIndex = 0
        pokemonOneEV_ATK_cmb.SelectedIndex = 0
        pokemonOneEV_DEF_cmb.SelectedIndex = 0
        pokemonOneEV_SPD_cmb.SelectedIndex = 0
        pokemonOneEV_SPATK_cmb.SelectedIndex = 0
        pokemonOneEV_SPDEF_cmb.SelectedIndex = 0

        Debug.WriteLine("Pokemon 1 Defaults Set")
#End Region

#End Region
    End Sub

    Private Sub Third_Party_btn_Click(sender As Object, e As EventArgs) Handles Third_Party_btn.Click
        ' On click, open the license
        ' window.
        ThirdPartyLicenses.Show()
    End Sub

#Region "Recommended Settings"
    Private Sub essn18RecSet_btn_Click(sender As Object, e As EventArgs) Handles essn18RecSet_btn.Click
        ' Turn on Recommended Settings
        internalBallNames_chk.Checked = True
        abilityIndex_chkBox.Checked = False
        ' Disable Check Boxes
        internalBallNames_chk.Enabled = False
        abilityIndex_chkBox.Enabled = False

        Debug.WriteLine("Recommended Settings Set")
    End Sub
    Private Sub essn19RecSet_btn_Click(sender As Object, e As EventArgs) Handles essn19RecSet_btn.Click
        ' Turn on Recommended Settings
        internalBallNames_chk.Checked = True
        abilityIndex_chkBox.Checked = True
        ' Disable Check Boxes
        internalBallNames_chk.Enabled = False
        abilityIndex_chkBox.Enabled = False

        Debug.WriteLine("Recommended Settings Set")
    End Sub
#End Region

#Region "Item Handler"
    Private Sub trainerItems_chkBox_CheckedChanged(sender As Object, e As EventArgs) Handles trainerItems_chkBox.CheckedChanged
        ' If trainerItems_chkBox is checked, enable items_grp
        ' if it isn't disable it.
        If trainerItems_chkBox.Checked = True Then
            items_grp.Enabled = True
            Debug.WriteLine("Enabled Items")
        ElseIf trainerItems_chkBox.Checked = False Then
            items_grp.Enabled = False
            Debug.WriteLine("Disabled Items")
        End If
    End Sub

    Private Sub trainerItemsList_btn_Click(sender As Object, e As EventArgs) Handles trainerItemsList_btn.Click
        ' Create Input Box
        Dim input As String = InputBox("Please enter an item you want this trainer to use", "Add Item", "Potion")
        ' Once they hit okay, then add item
        If input = "" Then
            MessageBox.Show("You cannot leave the box blank.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Debug.WriteLine("Failed to add item. Reason: You cannot leave the box blank.")
        Else
            If trainerItemsList_lstbox.Items.Count = 8 Then
                MessageBox.Show("You cannot add more than 8 items.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Debug.WriteLine("Failed to add item. Reason: You cannot add more than 8 items.")
            Else
                trainerItemsList_lstbox.Items.Add(input.ToUpper)
                Debug.WriteLine("Added Item: " & input.ToUpper)
            End If
        End If
    End Sub

    Private Sub itemQuickPotion_btn_Click(sender As Object, e As EventArgs) Handles itemQuickPotion_btn.Click
        If trainerItems_chkBox.Checked = False Then
            trainerItems_chkBox.Checked = True
        End If
        If trainerItemsList_lstbox.Items.Count = 8 Then
            MessageBox.Show("You cannot add more than 8 items.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Debug.WriteLine("Failed to add item. Reason: You cannot add more than 8 items.")
        Else
            trainerItemsList_lstbox.Items.Add("POTION")
            Debug.WriteLine("Added Item: POTION")
        End If
    End Sub

    Private Sub itemQuickSuperPotion_btn_Click(sender As Object, e As EventArgs) Handles itemQuickSuperPotion_btn.Click
        If trainerItems_chkBox.Checked = False Then
            trainerItems_chkBox.Checked = True
        End If
        If trainerItemsList_lstbox.Items.Count = 8 Then
            MessageBox.Show("You cannot add more than 8 items.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Debug.WriteLine("Failed to add item. Reason: You cannot add more than 8 items.")
        Else
            trainerItemsList_lstbox.Items.Add("SUPERPOTION")
            Debug.WriteLine("Added Item: SUPERPOTION")
        End If
    End Sub

    Private Sub itemQuickHyperPotion_btn_Click(sender As Object, e As EventArgs) Handles itemQuickHyperPotion_btn.Click
        If trainerItems_chkBox.Checked = False Then
            trainerItems_chkBox.Checked = True
        End If
        If trainerItemsList_lstbox.Items.Count = 8 Then
            MessageBox.Show("You cannot add more than 8 items.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Debug.WriteLine("Failed to add item. Reason: You cannot add more than 8 items.")
        Else
            trainerItemsList_lstbox.Items.Add("HYPERPOTION")
            Debug.WriteLine("Added Item: HYPERPOTION")
        End If
    End Sub

    Private Sub itemQuickFullRestore_btn_Click(sender As Object, e As EventArgs) Handles itemQuickFullRestore_btn.Click
        If trainerItems_chkBox.Checked = False Then
            trainerItems_chkBox.Checked = True
        End If
        If trainerItemsList_lstbox.Items.Count = 8 Then
            MessageBox.Show("You cannot add more than 8 items.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Debug.WriteLine("Failed to add item. Reason: You cannot add more than 8 items.")
        Else
            trainerItemsList_lstbox.Items.Add("FULLRESTORE")
            Debug.WriteLine("Added Item: FULLRESTORE")
        End If
    End Sub

    Private Sub trainerItemsList_lstbox_DoubleClick(sender As Object, e As EventArgs) Handles trainerItemsList_lstbox.DoubleClick
        trainerItemsList_lstbox.Items.Remove(trainerItemsList_lstbox.SelectedItem)
        Debug.WriteLine("Removed an item.")
    End Sub

#End Region

#Region "Misc Info"
    Private Sub existingBattle_chkBox_CheckedChanged(sender As Object, e As EventArgs) Handles existingBattle_chkBox.CheckedChanged
        ' Check to see if existingBattle_chkBox is checked.
        ' If it is not checked, disable trainerBattleTeamID_txtBox
        ' and trainerBattleTeamID_lbl
        ' If it is checked, enable trainerBattleTeamID_txtBox
        ' and trainerBattleTeamID_lbl
        If existingBattle_chkBox.Checked = True Then
            trainerBattleTeamID_txtBox.Enabled = True
            trainerBattleTeamID_lbl.Enabled = True
        ElseIf existingBattle_chkBox.Checked = False Then
            trainerBattleTeamID_txtBox.Enabled = False
            trainerBattleTeamID_lbl.Enabled = False
        End If
    End Sub
#End Region

End Class
