Imports System.Windows.Forms

Public Class wizard_specialPage_TrainerTeams

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Form1.battleTeamID_txtBox.Text = Me.battleTeamID_txtBox.Text
        wizard_pageTwo.Show()
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        wizard_pageOne.Show()
        Me.Close()
    End Sub

    Private Sub wizard_specialPage_TrainerTeams_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Debug.WriteLine("Other Trainer Teams Page Loaded.")

        ' Get the ID from the main form.
        battleTeamID_txtBox.Text = Form1.battleTeamID_txtBox.Text
        Debug.WriteLine("Battle ID Set.")
    End Sub
End Class
