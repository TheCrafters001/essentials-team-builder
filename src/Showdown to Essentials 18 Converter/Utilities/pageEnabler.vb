Public Class pageEnabler
    Public Shared Sub Enabler()
        If Form1.numPoké_cmb.Text = "1" Then
            Form1.pokemonOne_grp.Enabled = True
            Form1.pokemonTwo_grp.Enabled = False
            Form1.pokemonThree_grp.Enabled = False
            Form1.pokemonFour_grp.Enabled = False
            Form1.pokemonFive_grp.Enabled = False
            Form1.pokemonSix_grp.Enabled = False
        ElseIf Form1.numPoké_cmb.Text = "2" Then
            Form1.pokemonOne_grp.Enabled = True
            Form1.pokemonTwo_grp.Enabled = True
            Form1.pokemonThree_grp.Enabled = False
            Form1.pokemonFour_grp.Enabled = False
            Form1.pokemonFive_grp.Enabled = False
            Form1.pokemonSix_grp.Enabled = False
        ElseIf Form1.numPoké_cmb.Text = "3" Then
            Form1.pokemonOne_grp.Enabled = True
            Form1.pokemonTwo_grp.Enabled = True
            Form1.pokemonThree_grp.Enabled = True
            Form1.pokemonFour_grp.Enabled = False
            Form1.pokemonFive_grp.Enabled = False
            Form1.pokemonSix_grp.Enabled = False
        ElseIf Form1.numPoké_cmb.Text = "4" Then
            Form1.pokemonOne_grp.Enabled = True
            Form1.pokemonTwo_grp.Enabled = True
            Form1.pokemonThree_grp.Enabled = True
            Form1.pokemonFour_grp.Enabled = True
            Form1.pokemonFive_grp.Enabled = False
            Form1.pokemonSix_grp.Enabled = False
        ElseIf Form1.numPoké_cmb.Text = "5" Then
            Form1.pokemonOne_grp.Enabled = True
            Form1.pokemonTwo_grp.Enabled = True
            Form1.pokemonThree_grp.Enabled = True
            Form1.pokemonFour_grp.Enabled = True
            Form1.pokemonFive_grp.Enabled = True
            Form1.pokemonSix_grp.Enabled = False
        ElseIf Form1.numPoké_cmb.Text = "6" Then
            Form1.pokemonOne_grp.Enabled = True
            Form1.pokemonTwo_grp.Enabled = True
            Form1.pokemonThree_grp.Enabled = True
            Form1.pokemonFour_grp.Enabled = True
            Form1.pokemonFive_grp.Enabled = True
            Form1.pokemonSix_grp.Enabled = True
        End If
    End Sub
End Class