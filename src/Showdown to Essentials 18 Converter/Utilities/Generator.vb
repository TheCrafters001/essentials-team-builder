Public Class Generator
    '
    ' WARNING: THIS GENERATOR MAY BE COMPLETELY REWRITTEN AT SOME POINT.
    ' PLEASE KEEP THIS IN MIND.
    '
    ' Generator Code Sample
    ' 
    ' [TYPE,Name,ID]
    ' Items = ITEM,ITEM2,ITEM3,ITEM4,ITEM5,ITEM6,ITEM7,ITEM8
    ' LoseText = "Lose Text"
    ' Pokemon = PKMN1,LVL
    '     Name = NickName
    '     Form = FormID
    '     Gender = GENDER
    '     Shiny = YESNO
    '     Shadow = YESNO
    '     Moves = MOVE,MOVE2,MOVE3,MOVE4
    '     Ability = NUMBER (Between 0-5)
    '     Item = HELDITEM
    '     Nature = NATURE
    '     IV = HP,ATK,DEF,SPD,SPATK,SPDEF
    '     EV = HP,ATK,DEF,SPD,SPATK,SPDEF
    '     Happiness = NUMBER (1-255)
    '     Ball = ID (0-25)
    ' Pokemon = MELMETAL,10
    ' Pokemon = BULBASAUR,10
    ' Pokemon = BULBASAUR,10
    ' Pokemon = BULBASAUR,10
    ' Pokemon = BULBASAUR,10

    Public Shared Sub Generate()
        Dim pokemonName As String
        Dim heldItem As String
        Dim move1 As String
        Dim move2 As String
        Dim move3 As String
        Dim move4 As String
        Dim AllMoves As String
        Dim pokemonAbility As String
        Dim gender As String
        Dim pokemonForm As String
        Dim shinyString As String
        Dim pokemonNature As String
        Dim pokemonIVs As String
        Dim pokemonEVs As String
        Dim pokemonHappyness As String
        Dim pokemonNickname As String
        Dim shadowString As String
        Dim pokeballID As String
        Dim numPoke As Integer
        numPoke = Form1.numPoké_cmb.SelectedItem
        Dim output As String
#Region "Trainer"
        Form1.outputBox_rchBox.Text = "#-------------------------------"
        If Form1.existingBattle_chkBox.Checked = True Then
            If Form1.trainerUsesItems_chkBox.Checked = False Then
                Form1.outputBox_rchBox.Text &= vbCrLf & "[" & Form1.trainerType_txtBox.Text().ToUpper & "," & Form1.trainerName_txtBox.Text & "," & Form1.battleTeamID_txtBox.Text() & "]" _
                     & vbCrLf & "LoseText = """ & Form1.loseText_txt.Text & """" & vbCrLf
            ElseIf Form1.trainerUsesItems_chkBox.Checked = True Then
                Form1.outputBox_rchBox.Text &= vbCrLf & "[" & Form1.trainerType_txtBox.Text().ToUpper & "," & Form1.trainerName_txtBox.Text & "," & Form1.battleTeamID_txtBox.Text() & "]" _
                     & vbCrLf & "Items = " & Form1.itemOne_txtBox.Text.ToUpper & "," & Form1.itemTwo_txtBox.Text.ToUpper & "," & Form1.itemThree_txtBox.Text.ToUpper & "," & Form1.itemFour_txtBox.Text.ToUpper & "," & Form1.itemFive_txtBox.Text.ToUpper & "," & Form1.itemSix_txtBox.Text.ToUpper & "," & Form1.itemSeven_txtBox.Text.ToUpper & "," & Form1.itemEight_txtBox.Text.ToUpper & vbCrLf &
                     "LoseText = """ & Form1.loseText_txt.Text & """" & vbCrLf
            End If
        ElseIf Form1.existingBattle_chkBox.Checked = False Then
            If Form1.trainerUsesItems_chkBox.Checked = False Then
                Form1.outputBox_rchBox.Text &= vbCrLf & "[" & Form1.trainerType_txtBox.Text().ToUpper & "," & Form1.trainerName_txtBox.Text & "]" _
                     & vbCrLf & "LoseText = """ & Form1.loseText_txt.Text & """" & vbCrLf
            ElseIf Form1.trainerUsesItems_chkBox.Checked = True Then
                Form1.outputBox_rchBox.Text &= vbCrLf & "[" & Form1.trainerType_txtBox.Text().ToUpper & "," & Form1.trainerName_txtBox.Text & "]" _
                     & vbCrLf & "Items = " & Form1.itemOne_txtBox.Text.ToUpper & "," & Form1.itemTwo_txtBox.Text.ToUpper & "," & Form1.itemThree_txtBox.Text.ToUpper & "," & Form1.itemFour_txtBox.Text.ToUpper & "," & Form1.itemFive_txtBox.Text.ToUpper & "," & Form1.itemSix_txtBox.Text.ToUpper & "," & Form1.itemSeven_txtBox.Text.ToUpper & "," & Form1.itemEight_txtBox.Text.ToUpper & vbCrLf &
                     "LoseText = """ & Form1.loseText_txt.Text & """" & vbCrLf
            End If
        End If
#End Region
        Try
#Region "Pokemon 1"
            If numPoke >= 1 Then
                pokemonName = "Pokemon = " & Form1.pokemonOneName_txtBox.Text.ToUpper & "," & Form1.pokemonOneLvl_txtBox.Text & vbCrLf
                If Form1.pokemonOneForm_txtBox.Text = "" Then
                    pokemonForm = ""
                ElseIf Not Form1.pokemonOneForm_txtBox.Text = "" Then
                    pokemonForm = "    Form = " & Form1.pokemonOneForm_txtBox.Text & vbCrLf
                End If
                If Form1.pokemonOneNickName_txtBox.Text = "" Then
                    pokemonNickname = ""
                ElseIf Not Form1.pokemonOneNickName_txtBox.Text = "" Then
                    pokemonNickname = "    Name = " & Form1.pokemonOneNickName_txtBox.Text & vbCrLf
                End If
                If Form1.pokemonOneItem_txtBox.Text.ToUpper = "" Then
                    heldItem = ""
                ElseIf Not Form1.pokemonOneItem_txtBox.Text.ToUpper = "" Then
                    heldItem = "    Item = " & Form1.pokemonOneItem_txtBox.Text.ToUpper & vbCrLf
                End If
                If Form1.pokemonOneGender_cmb.SelectedItem = "(random)" Then
                    gender = ""
                ElseIf Not Form1.pokemonOneGender_cmb.SelectedItem = "(random)" Then
                    gender = "    Gender = " & Form1.pokemonOneGender_cmb.SelectedItem & vbCrLf
                End If
                If Form1.pokemonOneShiny_rad.Checked = True And Form1.pokemonOneShinyFalse_rad.Checked = False Then
                    shinyString = "    Shiny = yes" & vbCrLf
                ElseIf Form1.pokemonOneShiny_rad.Checked = False And Form1.pokemonOneShinyFalse_rad.Checked = True Then
                    shinyString = "    Shiny = no" & vbCrLf
                End If
                If Form1.pokemonOneShadow_rad.Checked = True And Form1.pokemonOneShadowFalse_rad.Checked = False Then
                    shadowString = "    Shadow = yes" & vbCrLf
                ElseIf Form1.pokemonOneShadow_rad.Checked = False And Form1.pokemonOneShadowFalse_rad.Checked = True Then
                    shadowString = "    Shadow = no" & vbCrLf
                End If

                move1 = Form1.pokemonOneMove1_txtBox.Text.ToUpper
                move2 = Form1.pokemonOneMove2_txtBox.Text.ToUpper
                move3 = Form1.pokemonOneMove3_txtBox.Text.ToUpper
                move4 = Form1.pokemonOneMove4_txtBox.Text.ToUpper
                AllMoves = "    Moves = " & move1 & "," & move2 & "," & move3 & "," & move4 & vbCrLf
                pokemonAbility = "    Ability = " & Form1.pokemonOneAbility_cmb.SelectedItem.ToString & vbCrLf
                If Form1.pokemonOneNature_cmb.SelectedItem = "(random)" Then
                    pokemonNature = ""
                ElseIf Not Form1.pokemonOneNature_cmb.SelectedItem = "(random)" Then
                    pokemonNature = "    Nature = " & Form1.pokemonOneNature_cmb.SelectedItem & vbCrLf
                End If
                pokemonIVs = "    IVs = " & Form1.pokemonOneIVsHP_txt.Text & "," & Form1.pokemonOneIVsATK_txt.Text & "," & Form1.pokemonOneIVsSPD_txt.Text & "," & Form1.pokemonOneIVsSPATK_txt.Text & "," & Form1.pokemonOneIVsSPDEF_txt.Text & vbCrLf
                pokemonEVs = "    EVs = " & Form1.pokemonOneEVsHP_txt.Text & "," & Form1.pokemonOneEVsATK_txt.Text & "," & Form1.pokemonOneEVsSPD_txt.Text & "," & Form1.pokemonOneEVsSPATK_txt.Text & "," & Form1.pokemonOneEVsSPDEF_txt.Text & vbCrLf
                If Form1.pokemonOneHappyness_txtBox.Text = "" Then
                    pokemonHappyness = "    Happiness = 70" & vbCrLf
                ElseIf Not Form1.pokemonOneHappyness_txtBox.Text = "" Then
                    pokemonHappyness = "    Happiness = " & Form1.pokemonOneHappyness_txtBox.Text & vbCrLf
                End If
                pokeballID = "    Ball = " & Form1.pokemonOnePokeballID_cmb.SelectedItem & vbCrLf
                output = pokemonName & pokemonForm & pokemonNickname & heldItem & gender & AllMoves & pokemonNature & pokemonIVs & pokemonEVs & pokemonHappyness & pokeballID
                Form1.outputBox_rchBox.Text &= output & vbCrLf
            End If
#End Region
        Catch ex As Exception
            MessageBox.Show("Oh no!" & vbCrLf & ex.ToString, "Error")
        End Try
    End Sub

End Class
