Imports System.Windows.Forms

Public Class wizard_pageThree

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        If trainerItemsList_lstbox.Items.Count = 0 Then
            Form1.trainerUsesItems_chkBox.Checked = False
            Debug.WriteLine("No items selected. Skipping page...")
        Else
            Debug.WriteLine("Items selected. Adding them...")
            ' Collect information from this listbox
            ' Once collected, copy it over to Form1
            Form1.trainerUsesItems_chkBox.Checked = True
            Dim i As Integer = 0
            Form1.trainerItemsList_lstbox.Items.Clear()

            For i = 0 To trainerItemsList_lstbox.Items.Count - 1
                Form1.trainerItemsList_lstbox.Items.Add(Me.trainerItemsList_lstbox.Items(i).ToString.ToUpper)
                Debug.WriteLine("Item " & trainerItemsList_lstbox.Items(i).ToString & " added")
            Next
            Debug.WriteLine("Items added, moving to next page.")
        End If
        wizard_pageFour.Show()
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        wizard_pageTwo.Show()
        Me.Close()
    End Sub

    Private Sub wizard_pageThree_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Debug.WriteLine("Items Page Loaded.")

        ' Collect information from Form1
        ' Once collected, copy it over to this listbox
        Dim i As Integer = 0
        trainerItemsList_lstbox.Items.Clear()

        For i = 0 To Form1.trainerItemsList_lstbox.Items.Count - 1
            trainerItemsList_lstbox.Items.Add(Form1.trainerItemsList_lstbox.Items(i).ToString.ToUpper)
            Debug.WriteLine("Item " & Form1.trainerItemsList_lstbox.Items(i).ToString & " added")
        Next
    End Sub

    Private Sub trainerItemsList_btn_Click(sender As Object, e As EventArgs) Handles trainerItemsList_btn.Click
        Try
            Form1.Darkness = True
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
            Form1.Darkness = False
        End Try
    End Sub

    Private Sub trainerItemsList_lstbox_DoubleClick(sender As Object, e As EventArgs) Handles trainerItemsList_lstbox.DoubleClick
        trainerItemsList_lstbox.Items.Remove(trainerItemsList_lstbox.SelectedItem)
    End Sub
End Class
