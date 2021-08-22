Public Class ThemeHandler

    'This whole script is currently unused. There is no better way (that I have found)
    'to apply a dark theme. I will have to find a skin at some point, but if I do, it will
    'require me to recode the whole UI.

    Public Shared Sub Light()

    End Sub

    Public Shared Sub Dark()
        ' Set Back color for all things
        ' Maybe not the best method, but whatever.
        ' If anyone has a better way to do this, feel free to make a pull request.
        Form1.BackColor = Color.FromArgb(255, 68, 68, 68)
        Form1.pg_About.BackColor = Color.FromArgb(255, 68, 68, 68)
        Form1.pg_Trainer.BackColor = Color.FromArgb(255, 68, 68, 68)
        Form1.pg_POne.BackColor = Color.FromArgb(255, 68, 68, 68)
        Form1.pg_PTwo.BackColor = Color.FromArgb(255, 68, 68, 68)
        Form1.pg_PThree.BackColor = Color.FromArgb(255, 68, 68, 68)
        Form1.pg_PFour.BackColor = Color.FromArgb(255, 68, 68, 68)
        Form1.pg_PFive.BackColor = Color.FromArgb(255, 68, 68, 68)
        Form1.pg_PSix.BackColor = Color.FromArgb(255, 68, 68, 68)
        Form1.pg_Output.BackColor = Color.FromArgb(255, 68, 68, 68)
        Form1.pg_PBallIDRef.BackColor = Color.FromArgb(255, 68, 68, 68)

        ' Set Fore color for all things
        ' Maybe not the best method, but whatever.
        ' If anyone has a better way to do this, feel free to make a pull request.
        Form1.ForeColor = Color.FromArgb(255, 190, 190, 190)
        Form1.pg_About.ForeColor = Color.FromArgb(255, 190, 190, 190)
        Form1.pg_Trainer.ForeColor = Color.FromArgb(255, 190, 190, 190)
        Form1.pg_POne.ForeColor = Color.FromArgb(255, 190, 190, 190)
        Form1.pg_PTwo.ForeColor = Color.FromArgb(255, 190, 190, 190)
        Form1.pg_PThree.ForeColor = Color.FromArgb(255, 190, 190, 190)
        Form1.pg_PFour.ForeColor = Color.FromArgb(255, 190, 190, 190)
        Form1.pg_PFive.ForeColor = Color.FromArgb(255, 190, 190, 190)
        Form1.pg_PSix.ForeColor = Color.FromArgb(255, 190, 190, 190)
        Form1.pg_Output.ForeColor = Color.FromArgb(255, 190, 190, 190)
        Form1.pg_PBallIDRef.ForeColor = Color.FromArgb(255, 190, 190, 190)

#Region "Buttons"
        For Each btn In Form1.pg_About.Controls.OfType(Of Button)
            btn.BackColor = Color.FromArgb(255, 0, 0, 0)
            btn.ForeColor = Color.FromArgb(255, 190, 190, 190)
        Next

        For Each btn In Form1.pg_Trainer.Controls.OfType(Of Button)
            btn.BackColor = Color.FromArgb(255, 0, 0, 0)
            btn.ForeColor = Color.FromArgb(255, 190, 190, 190)
        Next

        For Each btn In Form1.pg_POne.Controls.OfType(Of Button)
            btn.BackColor = Color.FromArgb(255, 0, 0, 0)
            btn.ForeColor = Color.FromArgb(255, 190, 190, 190)
        Next

        For Each btn In Form1.pg_PTwo.Controls.OfType(Of Button)
            btn.BackColor = Color.FromArgb(255, 0, 0, 0)
            btn.ForeColor = Color.FromArgb(255, 190, 190, 190)
        Next

        For Each btn In Form1.pg_PThree.Controls.OfType(Of Button)
            btn.BackColor = Color.FromArgb(255, 0, 0, 0)
            btn.ForeColor = Color.FromArgb(255, 190, 190, 190)
        Next

        For Each btn In Form1.pg_PFour.Controls.OfType(Of Button)
            btn.BackColor = Color.FromArgb(255, 0, 0, 0)
            btn.ForeColor = Color.FromArgb(255, 190, 190, 190)
        Next

        For Each btn In Form1.pg_PFive.Controls.OfType(Of Button)
            btn.BackColor = Color.FromArgb(255, 0, 0, 0)
            btn.ForeColor = Color.FromArgb(255, 190, 190, 190)
        Next

        For Each btn In Form1.pg_PSix.Controls.OfType(Of Button)
            btn.BackColor = Color.FromArgb(255, 0, 0, 0)
            btn.ForeColor = Color.FromArgb(255, 190, 190, 190)
        Next

        For Each btn In Form1.pg_PBallIDRef.Controls.OfType(Of Button)
            btn.BackColor = Color.FromArgb(255, 0, 0, 0)
            btn.ForeColor = Color.FromArgb(255, 190, 190, 190)
        Next

#End Region

#Region "Group Boxes"
        Form1.miscInfo_grpBox.ForeColor = Color.FromArgb(255, 190, 190, 190)
        Form1.trainerItems_grp.ForeColor = Color.FromArgb(255, 190, 190, 190)
        Form1.pokemonOne_grp.ForeColor = Color.FromArgb(255, 190, 190, 190)
        Form1.pokemonTwo_grp.ForeColor = Color.FromArgb(255, 190, 190, 190)
        Form1.pokemonThree_grp.ForeColor = Color.FromArgb(255, 190, 190, 190)
        Form1.pokemonFour_grp.ForeColor = Color.FromArgb(255, 190, 190, 190)
        Form1.pokemonFive_grp.ForeColor = Color.FromArgb(255, 190, 190, 190)
        Form1.pokemonSix_grp.ForeColor = Color.FromArgb(255, 190, 190, 190)
        Form1.pokemonOneShadow_grp.ForeColor = Color.FromArgb(255, 190, 190, 190)
#End Region

#Region "Textboxes"
        For Each txt In Form1.pg_About.Controls.OfType(Of TextBox)
            txt.BackColor = Color.FromArgb(255, 0, 0, 0)
            txt.ForeColor = Color.FromArgb(255, 255, 255, 255)
        Next

        For Each txt In Form1.pg_Trainer.Controls.OfType(Of TextBox)
            txt.BackColor = Color.FromArgb(255, 0, 0, 0)
            txt.ForeColor = Color.FromArgb(255, 255, 255, 255)
        Next

        For Each txt In Form1.pg_POne.Controls.OfType(Of TextBox)
            txt.BackColor = Color.FromArgb(255, 0, 0, 0)
            txt.ForeColor = Color.FromArgb(255, 255, 255, 255)
        Next

        For Each txt In Form1.pg_PTwo.Controls.OfType(Of TextBox)
            txt.BackColor = Color.FromArgb(255, 0, 0, 0)
            txt.ForeColor = Color.FromArgb(255, 255, 255, 255)
        Next

        For Each txt In Form1.pg_PThree.Controls.OfType(Of TextBox)
            txt.BackColor = Color.FromArgb(255, 0, 0, 0)
            txt.ForeColor = Color.FromArgb(255, 255, 255, 255)
        Next

        For Each txt In Form1.pg_PFour.Controls.OfType(Of TextBox)
            txt.BackColor = Color.FromArgb(255, 0, 0, 0)
            txt.ForeColor = Color.FromArgb(255, 255, 255, 255)
        Next

        For Each txt In Form1.pg_PFive.Controls.OfType(Of TextBox)
            txt.BackColor = Color.FromArgb(255, 0, 0, 0)
            txt.ForeColor = Color.FromArgb(255, 255, 255, 255)
        Next

        For Each txt In Form1.pg_PSix.Controls.OfType(Of TextBox)
            txt.BackColor = Color.FromArgb(255, 0, 0, 0)
            txt.ForeColor = Color.FromArgb(255, 255, 255, 255)
        Next

        For Each txt In Form1.pg_PBallIDRef.Controls.OfType(Of TextBox)
            txt.BackColor = Color.FromArgb(255, 0, 0, 0)
            txt.ForeColor = Color.FromArgb(255, 255, 255, 255)
        Next
#End Region

    End Sub
End Class
