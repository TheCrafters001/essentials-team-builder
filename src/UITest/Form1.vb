Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim newPanel As New TrainerInfo With {.TopMost = False, .AutoSize = False, .TopLevel = False, .WindowState = FormWindowState.Maximized, .FormBorderStyle = FormBorderStyle.None, .Dock = DockStyle.Fill}
        Me.TrainerInfoPanel.Controls.Add(newPanel)
        newPanel.Show()

        Dim newPanel2 As New PokemonInfo With {.TopMost = False, .AutoSize = False, .TopLevel = False, .WindowState = FormWindowState.Maximized, .FormBorderStyle = FormBorderStyle.None, .Dock = DockStyle.Fill}
        Me.Pokemon.Controls.Add(newPanel2)
        newPanel2.Show()

        TrainerInfoPanel.Visible = True
        Pokemon.Visible = False

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        TrainerInfoPanel.Visible = False
        Pokemon.Visible = True
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        TrainerInfoPanel.Visible = True
        Pokemon.Visible = False
    End Sub
End Class
