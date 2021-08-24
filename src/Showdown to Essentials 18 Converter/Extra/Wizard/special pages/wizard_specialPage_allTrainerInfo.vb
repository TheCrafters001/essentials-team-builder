Imports System.Windows.Forms

Public Class wizard_specialPage_allTrainerInfo

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub wizard_specialPage_allTrainerInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Debug.WriteLine("Finalizing changes. Waiting for user to confirm.")
        If Form1.trainerName_txtBox.Text = "" Then
            trainerName_lbl.Text = "Trainer Name: (Not Entered)"
        Else
            trainerName_lbl.Text = ("Trainer Name: {0}", Form1.trainerName_txtBox.Text)
        End If
    End Sub
End Class
