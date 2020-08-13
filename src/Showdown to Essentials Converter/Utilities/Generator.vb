Public Class Generator
    ' Generator Code Sample
    ' 
    ' #-------------------------------
    ' TRAINERTYPE
    ' Trainer Name,ID
    ' # of PKMN,ITEMS
    ' POKEMON,LVL,HELDITEM,MOVE1,MOVE2,MOVE3,MOVE4,ABILITY#,M/F,FORM#,shiny,NATURE,IVs,HAPPYNESS,NickName,SHADOW (true/false),POKEBALLID

#Region "Trainer"
    Public Shared Sub Trainer()
        Form1.outputBox_rchBox.Text = "#-------------------------------"
        If Form1.existingBattle_chkBox.Checked = True Then
            If Form1.trainerUsesItems_chkBox.Checked = False Then
                Form1.outputBox_rchBox.Text &= vbCrLf & Form1.trainerType_txtBox.Text.ToUpper & vbCrLf & Form1.trainerName_txtBox.Text & "," & Form1.battleTeamID_txtBox.Text & vbCrLf & Form1.numPoké_cmb.Text & vbCrLf
            ElseIf Form1.trainerUsesItems_chkBox.Checked = True Then
                Form1.outputBox_rchBox.Text &= vbCrLf & Form1.trainerType_txtBox.Text.ToUpper & vbCrLf & Form1.trainerName_txtBox.Text & "," & Form1.battleTeamID_txtBox.Text & vbCrLf & Form1.numPoké_cmb.Text & "," & Form1.itemOne_txtBox.Text.ToUpper & "," & Form1.itemTwo_txtBox.Text.ToUpper & "," & Form1.itemThree_txtBox.Text.ToUpper & "," & Form1.itemFour_txtBox.Text.ToUpper & "," & Form1.itemFive_txtBox.Text.ToUpper & "," & Form1.itemSix_txtBox.Text.ToUpper & "," & Form1.itemSeven_txtBox.Text.ToUpper & "," & Form1.itemEight_txtBox.Text.ToUpper & vbCrLf
            End If
        ElseIf Form1.existingBattle_chkBox.Checked = False Then
            If Form1.trainerUsesItems_chkBox.Checked = False Then
                Form1.outputBox_rchBox.Text &= vbCrLf & Form1.trainerType_txtBox.Text.ToUpper & vbCrLf & Form1.trainerName_txtBox.Text & vbCrLf & Form1.numPoké_cmb.Text & vbCrLf
            ElseIf Form1.trainerUsesItems_chkBox.Checked = True Then
                Form1.outputBox_rchBox.Text &= vbCrLf & Form1.trainerType_txtBox.Text.ToUpper & vbCrLf & Form1.trainerName_txtBox.Text & vbCrLf & Form1.numPoké_cmb.Text & "," & Form1.itemOne_txtBox.Text.ToUpper & "," & Form1.itemTwo_txtBox.Text.ToUpper & "," & Form1.itemThree_txtBox.Text.ToUpper & "," & Form1.itemFour_txtBox.Text.ToUpper & "," & Form1.itemFive_txtBox.Text.ToUpper & "," & Form1.itemSix_txtBox.Text.ToUpper & "," & Form1.itemSeven_txtBox.Text.ToUpper & "," & Form1.itemEight_txtBox.Text.ToUpper & vbCrLf
            End If
        End If

    End Sub
#End Region

#Region "One Pokemon"
    Public Shared Sub OnePokemon()
#Region "Dims"
        Dim pokemonName As String
        Dim heldItem As String
        Dim lvl As String
        Dim move1 As String
        Dim move2 As String
        Dim move3 As String
        Dim move4 As String
        Dim pokemonAbility As String
        Dim gender As String
        Dim pokemonForm As String
        Dim shiny As Boolean
        Dim shinyString As String
        Dim pokemonNature As String
        Dim pokemonIVs As String
        Dim pokemonHappyness As String
        Dim pokemonNickname As String
        Dim shadow As Boolean
        Dim shadowString As String
        Dim pokeballID As String
        Dim output As String
#End Region
        Try
            pokemonName = Form1.pokemonOneName_txtBox.Text.ToUpper
            heldItem = Form1.pokemonOneItem_txtBox.Text.ToUpper
            lvl = Form1.pokemonOneLvl_txtBox.Text
            move1 = Form1.pokemonOneMove1_txtBox.Text.ToUpper
            move2 = Form1.pokemonOneMove2_txtBox.Text.ToUpper
            move3 = Form1.pokemonOneMove3_txtBox.Text.ToUpper
            move4 = Form1.pokemonOneMove4_txtBox.Text.ToUpper
            pokemonAbility = Form1.pokemonOneAbility_cmb.Text
            gender = Form1.pokemonOneGender_cmb.Text
            pokemonForm = Form1.pokemonOneForm_txtBox.Text
            If Form1.pokemonOneShinyFalse_rad.Checked = True Then
                shiny = False
            ElseIf Form1.pokemonOneShiny_rad.Checked = True Then
                shiny = True
            End If
            pokemonNature = Form1.pokemonOneNature_cmb.Text
            pokemonIVs = Form1.pokemonOneForm_txtBox.Text
            pokemonHappyness = Form1.pokemonOneHappyness_txtBox.Text
            pokemonNickname = Form1.pokemonOneNickName_txtBox.Text
            If Form1.pokemonOneShadowFalse_rad.Checked = True Then
                shadow = False
            ElseIf Form1.pokemonOneShadow_rad.Checked = True Then
                shadow = True
            End If
            pokeballID = Form1.pokemonOnePokeballID_cmb.Text

            If gender = "(random)" Then
                gender = ""
            End If
            If pokemonNature = "(random)" Then
                pokemonNature = ""
            End If
            If shiny = True Then
                shinyString = "shiny"
            ElseIf shiny = False Then
                shinyString = ""
            End If
            If shadow = True Then
                shadowString = "true"
            ElseIf shadow = False Then
                shadowString = ""
            End If

            output = pokemonName & "," & lvl & "," & heldItem & "," & move1 & "," & move2 & "," & move3 & "," & move4 & "," & pokemonAbility & "," & gender & "," & shinyString & "," & pokemonNature & "," & pokemonIVs & "," & pokemonHappyness & "," & pokemonNickname & "," & shadowString & "," & pokeballID
            Form1.outputBox_rchBox.Text &= output
        Catch ex As Exception
            MessageBox.Show("Oh no!" & vbCrLf & ex.ToString, "Error")
        End Try
    End Sub
#End Region

End Class
