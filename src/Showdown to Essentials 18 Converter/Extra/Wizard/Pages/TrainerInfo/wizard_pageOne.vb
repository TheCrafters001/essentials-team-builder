Imports System.Windows.Forms

Public Class wizard_pageOne

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Form1.trainerName_txtBox.Text = Me.trainerName_txtBox.Text
        Form1.trainerType_txtBox.Text = Me.trainerType_txtBox.Text
        ' If existingBattle_chkBox.checked = true, then
        ' go to a special page to enter in the id.
        ' Otherwise, move on.
        If existingBattle_chkBox.Checked = True Then
            Form1.existingBattle_chkBox.Checked = True
            wizard_specialPage_TrainerTeams.Show()
        ElseIf existingBattle_chkBox.Checked = False Then
            Form1.existingBattle_chkBox.Checked = False
            wizard_pageTwo.Show()
        End If
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub wizard_pageOne_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Debug.WriteLine("Trainer Information Page Loaded.")

        ' Pull Trainer Name, Trainer Type, and Existing Battle
        ' then, set it. This is so they can make changes.
        trainerName_txtBox.Text = Form1.trainerName_txtBox.Text
        Debug.WriteLine("Trainer Name Set.")
        trainerType_txtBox.Text = Form1.trainerType_txtBox.Text
        Debug.WriteLine("Trainer Type Set.")

        ' If checkbox 'existingBattle_chkBox' is checked on main form,
        ' Set it so the user can change their mind.
        If Form1.existingBattle_chkBox.Checked = True Then
            existingBattle_chkBox.Checked = True
            Debug.WriteLine("existingBattle_chkBox is checked in main form.")
        ElseIf Form1.existingBattle_chkBox.Checked = False Then
            Debug.WriteLine("existingBattle_chkBox is not checked in main form.")
        End If
    End Sub
End Class
