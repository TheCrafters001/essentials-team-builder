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

        Dim item As Object
        Dim TrainerItems As String

        ' This took me longer than I would like to admit to make.
        ' Thanks to Mary on Stack Overflow for the help
        ' https://stackoverflow.com/a/68794434/7799766
        For Each item In Form1.trainerItemsList_lstbox.Items
            TrainerItems &= item.ToString.ToUpper & ","
        Next

        ' If Trainer Uses Items = True
        ' Remove comma at end, otherwise, ignore.
        If Form1.trainerUsesItems_chkBox.Checked = True Then
            TrainerItems = TrainerItems.Substring(0, TrainerItems.Length - 1)
        End If

        Form1.outputBox_rchBox.Text = "#-------------------------------"
        If Form1.existingBattle_chkBox.Checked = True Then
            If Form1.trainerUsesItems_chkBox.Checked = False Then
                Form1.outputBox_rchBox.Text &= vbCrLf & Form1.trainerType_txtBox.Text.ToUpper & vbCrLf & Form1.trainerName_txtBox.Text & "," & Form1.battleTeamID_txtBox.Text & vbCrLf & Form1.numPoké_cmb.Text & vbCrLf
            ElseIf Form1.trainerUsesItems_chkBox.Checked = True Then
                Form1.outputBox_rchBox.Text &= vbCrLf & Form1.trainerType_txtBox.Text.ToUpper & vbCrLf & Form1.trainerName_txtBox.Text & "," & Form1.battleTeamID_txtBox.Text & vbCrLf & Form1.numPoké_cmb.Text & "," & TrainerItems & vbCrLf
            End If
        ElseIf Form1.existingBattle_chkBox.Checked = False Then
            If Form1.trainerUsesItems_chkBox.Checked = False Then
                Form1.outputBox_rchBox.Text &= vbCrLf & Form1.trainerType_txtBox.Text.ToUpper & vbCrLf & Form1.trainerName_txtBox.Text & vbCrLf & Form1.numPoké_cmb.Text & vbCrLf
            ElseIf Form1.trainerUsesItems_chkBox.Checked = True Then
                Form1.outputBox_rchBox.Text &= vbCrLf & Form1.trainerType_txtBox.Text.ToUpper & vbCrLf & Form1.trainerName_txtBox.Text & vbCrLf & Form1.numPoké_cmb.Text & "," & TrainerItems & vbCrLf
            End If
        End If

    End Sub
#End Region

#Region "New Generator"
    Public Shared Sub NewGen()
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
        If Form1.numPoké_cmb.SelectedItem >= "1" Then
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
                pokemonIVs = Form1.pokemonOneIVs_txtBox.Text
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

                output = pokemonName & "," & lvl & "," & heldItem & "," & move1 & "," & move2 & "," & move3 & "," & move4 & "," & pokemonAbility & "," & gender & "," & pokemonForm & "," & shinyString & "," & pokemonNature & "," & pokemonIVs & "," & pokemonHappyness & "," & pokemonNickname & "," & shadowString & "," & pokeballID & vbCrLf
                Form1.outputBox_rchBox.Text &= output
            Catch ex As Exception
                MessageBox.Show("Oh no!" & vbCrLf & ex.ToString, "Error")
            End Try
        End If
        If Form1.numPoké_cmb.SelectedItem >= "2" Then
            Try

                pokemonName = Form1.pokemonTwoName_txtBox.Text.ToUpper
                heldItem = Form1.pokemonTwoHeldItem_txtBox.Text.ToUpper
                lvl = Form1.pokemonTwoLevel_txtBox.Text
                move1 = Form1.pokemonTwoMove1_txtBox.Text.ToUpper
                move2 = Form1.pokemonTwoMove2_txtBox.Text.ToUpper
                move3 = Form1.pokemonTwoMove3_TextBox.Text.ToUpper
                move4 = Form1.pokemonTwoMove4_TextBox.Text.ToUpper
                pokemonAbility = Form1.pokemonTwoAbility_cmb.Text
                gender = Form1.pokemonTwoGender_cmb.Text
                pokemonForm = Form1.pokemonTwoForm_txtBox.Text
                If Form1.pokemonTwoShinyFalse_rad.Checked = True Then
                    shiny = False
                ElseIf Form1.pokemonTwoShiny_rad.Checked = True Then
                    shiny = True
                End If
                pokemonNature = Form1.pokemonTwoNature_cmb.Text
                pokemonIVs = Form1.pokemonTwoIVs_txtBox.Text
                pokemonHappyness = Form1.pokemonTwoHappyness_txtBox.Text
                pokemonNickname = Form1.pokemonTwoNickName_txtBox.Text
                If Form1.pokemonTwoShadowFalse_rad.Checked = True Then
                    shadow = False
                ElseIf Form1.pokemonTwoShadow_rad.Checked = True Then
                    shadow = True
                End If
                pokeballID = Form1.pokemonTwoPokeballID_cmb.Text

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
                output = pokemonName & "," & lvl & "," & heldItem & "," & move1 & "," & move2 & "," & move3 & "," & move4 & "," & pokemonAbility & "," & gender & "," & pokemonForm & "," & shinyString & "," & pokemonNature & "," & pokemonIVs & "," & pokemonHappyness & "," & pokemonNickname & "," & shadowString & "," & pokeballID & vbCrLf
                Form1.outputBox_rchBox.Text &= output
            Catch ex As Exception
                MessageBox.Show("Oh no!" & vbCrLf & ex.ToString, "Error")
            End Try
        End If
        If Form1.numPoké_cmb.SelectedItem >= "3" Then
            Try
                pokemonName = Form1.pokemonThreeName_txtBox.Text.ToUpper
                heldItem = Form1.pokemonThreeHeldItem_txtBox.Text.ToUpper
                lvl = Form1.pokemonThreeLvl_textBox.Text
                move1 = Form1.pokemonThreeMove1_txtBox.Text.ToUpper
                move2 = Form1.pokemonThreeMove2_txtBox.Text.ToUpper
                move3 = Form1.pokemonThreeMove3_txtBox.Text.ToUpper
                move4 = Form1.pokemonThreeMove4_textBox.Text.ToUpper
                pokemonAbility = Form1.pokemonThreeAbility_cmb.Text
                gender = Form1.pokemonThreeGender_cmb.Text
                pokemonForm = Form1.pokemonThreeForm_txtBox.Text
                If Form1.pokemonThreeShinyFalse_Rad.Checked = True Then
                    shiny = False
                ElseIf Form1.pokemonThreeShiny_rad.Checked = True Then
                    shiny = True
                End If
                pokemonNature = Form1.pokemonThreeNature_cmb.Text
                pokemonIVs = Form1.pokemonThreeIVs_txtBox.Text
                pokemonHappyness = Form1.pokemonThreeHappyness_txtBox.Text
                pokemonNickname = Form1.pokemonThreeNickname_txtBox.Text
                If Form1.pokemonThreeShadowFalse_rad.Checked = True Then
                    shadow = False
                ElseIf Form1.pokemonThreeShadow_rad.Checked = True Then
                    shadow = True
                End If
                pokeballID = Form1.pokemonThreePokeballID_cmb.Text

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
                output = pokemonName & "," & lvl & "," & heldItem & "," & move1 & "," & move2 & "," & move3 & "," & move4 & "," & pokemonAbility & "," & gender & "," & pokemonForm & "," & shinyString & "," & pokemonNature & "," & pokemonIVs & "," & pokemonHappyness & "," & pokemonNickname & "," & shadowString & "," & pokeballID & vbCrLf
                Form1.outputBox_rchBox.Text &= output
            Catch ex As Exception
                MessageBox.Show("Oh no!" & vbCrLf & ex.ToString, "Error")
            End Try
        End If
        If Form1.numPoké_cmb.SelectedItem >= "4" Then
            Try
                pokemonName = Form1.pokemonFourName_txtBox.Text.ToUpper
                heldItem = Form1.pokemonFourHeldItem_txtBox.Text.ToUpper
                lvl = Form1.pokemonFourlvl_txtBox.Text
                move1 = Form1.pokemonFourMove1_txtBox.Text.ToUpper
                move2 = Form1.pokemonFourMove2_txtBox.Text.ToUpper
                move3 = Form1.pokemonFourMove3_txtBox.Text.ToUpper
                move4 = Form1.pokemonFourMove4_txtBox.Text.ToUpper
                pokemonAbility = Form1.pokemonFourAbility_cmb.Text
                gender = Form1.pokemonFourGender_cmb.Text
                pokemonForm = Form1.pokemonFourForm_txtBox.Text
                If Form1.pokemonFourShinyFalse_rad.Checked = True Then
                    shiny = False
                ElseIf Form1.pokemonFourShiny_rad.Checked = True Then
                    shiny = True
                End If
                pokemonNature = Form1.pokemonFourNature_cmb.Text
                pokemonIVs = Form1.pokemonFourIVs_txtBox.Text
                pokemonHappyness = Form1.pokemonFourHappyness_txtBox.Text
                pokemonNickname = Form1.pokemonFourNickname_txtBox.Text
                If Form1.pokemonFourShadowFalse_rad.Checked = True Then
                    shadow = False
                ElseIf Form1.pokemonFourShadow_rad.Checked = True Then
                    shadow = True
                End If
                pokeballID = Form1.pokemonFourPokeballID_cmb.Text

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
                output = pokemonName & "," & lvl & "," & heldItem & "," & move1 & "," & move2 & "," & move3 & "," & move4 & "," & pokemonAbility & "," & gender & "," & pokemonForm & "," & shinyString & "," & pokemonNature & "," & pokemonIVs & "," & pokemonHappyness & "," & pokemonNickname & "," & shadowString & "," & pokeballID & vbCrLf
                Form1.outputBox_rchBox.Text &= output
            Catch ex As Exception
                MessageBox.Show("Oh no!" & vbCrLf & ex.ToString, "Error")
            End Try
        End If
        If Form1.numPoké_cmb.SelectedItem >= "5" Then
            Try
                pokemonName = Form1.pokemonFiveName_txtBox.Text.ToUpper
                heldItem = Form1.pokemonFiveHeldItem_txtBox.Text.ToUpper
                lvl = Form1.pokemonFivelvl_txtBox.Text
                move1 = Form1.pokemonFiveMove1_txtBox.Text.ToUpper
                move2 = Form1.pokemonFiveMove2_txtBox.Text.ToUpper
                move3 = Form1.pokemonFiveMove3_txtBox.Text.ToUpper
                move4 = Form1.pokemonFiveMove4_txtBox.Text.ToUpper
                pokemonAbility = Form1.pokemonFiveAbility_cmb.Text
                gender = Form1.pokemonFiveGender_cmb.Text
                pokemonForm = Form1.pokemonFiveForm_txtBox.Text
                If Form1.pokemonFiveShinyFalse_rad.Checked = True Then
                    shiny = False
                ElseIf Form1.pokemonFiveShiny_rad.Checked = True Then
                    shiny = True
                End If
                pokemonNature = Form1.pokemonFiveNature_cmb.Text
                pokemonIVs = Form1.pokemonFiveIVs_txtBox.Text
                pokemonHappyness = Form1.pokemonFiveHappyness_txtBox.Text
                pokemonNickname = Form1.pokemonFiveNickname_txtBox.Text
                If Form1.pokemonFiveShadowFalse_rad.Checked = True Then
                    shadow = False
                ElseIf Form1.pokemonFiveShadow_rad.Checked = True Then
                    shadow = True
                End If
                pokeballID = Form1.pokemonFivePokeballID_cmb.Text

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
                output = pokemonName & "," & lvl & "," & heldItem & "," & move1 & "," & move2 & "," & move3 & "," & move4 & "," & pokemonAbility & "," & gender & "," & pokemonForm & "," & shinyString & "," & pokemonNature & "," & pokemonIVs & "," & pokemonHappyness & "," & pokemonNickname & "," & shadowString & "," & pokeballID & vbCrLf
                Form1.outputBox_rchBox.Text &= output
            Catch ex As Exception
                MessageBox.Show("Oh no!" & vbCrLf & ex.ToString, "Error")
            End Try
        End If
        If Form1.numPoké_cmb.SelectedItem >= "6" Then
            Try
                pokemonName = Form1.pokemonSixName_txtBox.Text.ToUpper
                heldItem = Form1.pokemonSixHeldItem_txtBox.Text.ToUpper
                lvl = Form1.pokemonSixlvl_TextBox.Text
                move1 = Form1.pokemonSixMove1_txtBox.Text.ToUpper
                move2 = Form1.pokemonSixMove2_txtBox.Text.ToUpper
                move3 = Form1.pokemonSixMove3_txtBox.Text.ToUpper
                move4 = Form1.pokemonSixMove4_txtBox.Text.ToUpper
                pokemonAbility = Form1.pokemonSixAbility_cmb.Text
                gender = Form1.pokemonSixGender_cmb.Text
                pokemonForm = Form1.pokemonSixForm_txtBox.Text
                If Form1.pokemonSixShinyFalse_rad.Checked = True Then
                    shiny = False
                ElseIf Form1.pokemonSixShiny_rad.Checked = True Then
                    shiny = True
                End If
                pokemonNature = Form1.pokemonSixNature_cmb.Text
                pokemonIVs = Form1.pokemonSixIVs_txtBox.Text
                pokemonHappyness = Form1.pokemonSixHappyness_txtBox.Text
                pokemonNickname = Form1.pokemonSixNickname_txtBox.Text
                If Form1.pokemonSixShadowFalse_rad.Checked = True Then
                    shadow = False
                ElseIf Form1.pokemonSixShadow_rad.Checked = True Then
                    shadow = True
                End If
                pokeballID = Form1.pokemonSixPokeballID_cmb.Text

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
                output = pokemonName & "," & lvl & "," & heldItem & "," & move1 & "," & move2 & "," & move3 & "," & move4 & "," & pokemonAbility & "," & gender & "," & pokemonForm & "," & shinyString & "," & pokemonNature & "," & pokemonIVs & "," & pokemonHappyness & "," & pokemonNickname & "," & shadowString & "," & pokeballID & vbCrLf
                Form1.outputBox_rchBox.Text &= output
            Catch ex As Exception
                MessageBox.Show("Oh no!" & vbCrLf & ex.ToString, "Error")
            End Try
        End If
    End Sub

#End Region

End Class
