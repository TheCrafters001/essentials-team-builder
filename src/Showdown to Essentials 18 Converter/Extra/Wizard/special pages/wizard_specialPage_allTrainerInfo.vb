Imports System.Windows.Forms

Public Class wizard_specialPage_allTrainerInfo
    Private Sub wizard_specialPage_allTrainerInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Debug.WriteLine("Finalizing changes. Waiting for user to confirm.")
        If Form1.trainerName_txtBox.Text = "" Then
            trainerName_lbl.Text = "Trainer Name: (Not Entered)"
        Else
            trainerName_lbl.Text = "Trainer Name: " & Form1.trainerName_txtBox.Text
        End If

        If Form1.trainerType_txtBox.Text = "" Then
            trainerClass_lbl.Text = "Trainer Class: (Not Entered)"
        Else
            trainerClass_lbl.Text = "Trainer Class: " & Form1.trainerType_txtBox.Text
        End If

        If Form1.trainerUsesItems_chkBox.Checked = True And Form1.trainerItemsList_lstbox.Items.Count >= 1 Then
            trainerUsesItems_lbl.Text = "This trainer uses items: Yes"
        Else
            trainerUsesItems_lbl.Text = "This trainer uses items: No"
        End If

        If Form1.existingBattle_chkBox.Checked = True Then
            trainerExisting_lbl.Text = "Trainer has a Existing Battle: Yes"
        Else
            trainerExisting_lbl.Text = "Trainer has a Existing Battle: No"
        End If

        numOfPoké_lbl.Text = "Number of Pokémon: " & Form1.numPoké_cmb.SelectedItem.ToString
    End Sub

    Private Sub Cancel_Button_Click_1(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        wizard_pageFour.Show()
        Me.Close()
    End Sub

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        Form1.Darkness = True
        Me.Close()
        MessageBox.Show("This Wizard only fills out the Trainer Information at the moment. I am working on adding the Pokémon Selection and the exporting.", "That is all for now.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Form1.Darkness = False
    End Sub
End Class
