Imports System.Windows.Forms

Public Class wizard_pageOne

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Form1.trainerName_txtBox.Text = Me.trainerName_txtBox.Text
        Form1.trainerType_txtBox.Text = Me.trainerType_txtBox.Text
        ' If existingBattle_chkBox.checked = true, then
        ' go to a special page to enter in the id.
        ' Otherwise, move on.
        If existingBattle_chkBox.Checked = True Then
            wizard_specialPage_TrainerTeams.Show()
        Else
            wizard_pageTwo.Show()
        End If
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub wizard_pageOne_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Debug.WriteLine("Trainer Infromation Page Loaded.")
    End Sub
End Class
