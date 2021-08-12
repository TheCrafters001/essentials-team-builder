Imports System.Windows.Forms

Public Class wizard_startDialog

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Next_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        wizard_pageOne.Show()
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub

    Private Sub wizard_startDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Debug.WriteLine("Wizard Started.")
    End Sub
End Class
