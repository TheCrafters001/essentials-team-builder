Imports System.Windows.Forms

Public Class wizard_pageTwo

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Form1.numPoké_cmb.SelectedIndex = Me.numPoké_cmb.SelectedIndex
        wizard_pageThree.Show()
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        If Form1.existingBattle_chkBox.Checked = True Then
            wizard_specialPage_TrainerTeams.Show()
        ElseIf Form1.existingBattle_chkBox.Checked = False Then
            wizard_pageOne.Show()
        End If
        Me.Close()
    End Sub

    Private Sub wizard_pageTwo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Debug.WriteLine("Number of Pokemon Page Loaded.")

        ' Set the numPoke combo box
        Me.numPoké_cmb.SelectedIndex = Form1.numPoké_cmb.SelectedIndex
        Debug.WriteLine("Number of Pokemon Set.")
    End Sub
End Class
