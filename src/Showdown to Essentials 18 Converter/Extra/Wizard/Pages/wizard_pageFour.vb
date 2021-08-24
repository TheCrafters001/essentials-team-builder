Imports System.Windows.Forms

Public Class wizard_pageFour

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Form1.loseText_txt.Text = Me.loseText_txt.Text
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        wizard_pageThree.Show()
        Me.Close()
    End Sub

    Private Sub wizard_pageFour_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Debug.WriteLine("Lose Text Page Loaded.")
    End Sub
End Class
