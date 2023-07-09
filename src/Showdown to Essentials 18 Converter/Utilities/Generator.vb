Public Class Generator
    Public Shared Sub createTeam()
        '
        ' WARNING: THIS GENERATOR MAY BE COMPLETELY REWRITTEN AT SOME POINT.
        ' PLEASE KEEP THIS IN MIND.
        '
        ' Generator Code Sample
        ' 
        ' [TYPE,Name,ID]
        ' Items = ITEM,ITEM2,ITEM3,ITEM4,ITEM5,ITEM6,ITEM7,ITEM8
        ' LoseText = "Lose Text"
        ' # If Essentials 20, don't use quotes for lose text.
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


        'Reset the output box
        Form1.outputBox_rchBox.Text = ""

        ' I finally got around to commenting on this stupid script.
        ' Trust me, I hate myself for not creating code comments either.


#Region "Trainer Code"
        Form1.outputBox_rchBox.Text &= "#-------------------------------" & vbCrLf

        Dim trainerPrefix As String = "[]"
        Dim items As String = ""
        Dim TrainerItems As String = ""
        Dim loseText As String = ""

        ' Item Handler
        ' ========================
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
            items = "Items = " & TrainerItems & vbCrLf
        ElseIf Form1.trainerUsesItems_chkBox.Checked = False Then
            items = ""
        Else
            items = "Items = POTION"
        End If

        'Check if trainer can be generated without errors
        If Form1.trainerType_txtBox.Text.ToUpper = "" Then

            ' If fails
            MessageBox.Show("You need to enter a trainer name.", "Cannot Create Team", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Form1.existingBattle_chkBox.Checked = True Then 'Check if existingBattle_chkBox is checked
            If Form1.battleTeamID_txtBox.Text = "" Then 'check if the user has entered a battle team id
                MessageBox.Show("You need to enter a battle team id.", "Cannot Create Team", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else ' If no errors, proceed with trainer generation
            ' Check if Battle Team ID is isn't checked
            If Form1.existingBattle_chkBox.Checked = False Then
                ' Create Trainer Prefix
                trainerPrefix = "[" & Form1.trainerType_txtBox.Text.ToUpper & "," & Form1.trainerName_txtBox.Text & "]"
                'check if it is checked
            ElseIf Form1.existingBattle_chkBox.Checked = True Then
                trainerPrefix = "[" & Form1.trainerType_txtBox.Text.ToUpper & "," & Form1.trainerName_txtBox.Text & "," & Form1.battleTeamID_txtBox.Text & "]"
            End If

            ' Check if Lose Text has quotes or not.
            If Form1.loseTextQuotes_chkBox.Checked = False Then
                loseText = "LoseText = " & Form1.loseText_txt.Text
            ElseIf Form1.loseTextQuotes_chkBox.Checked = True Then
                loseText = "LoseText = """ & Form1.loseText_txt.Text & """"
            Else
                loseText = "LoseText = ""..."""
            End If

            ' Send code to Output Box
            Form1.outputBox_rchBox.Text &= trainerPrefix & vbCrLf & items & loseText & vbCrLf
        End If

#End Region

        Dim pokemonName As String = ""
        Dim heldItem As String = ""
        Dim AllMoves As String = ""
        Dim pokemonAbility As String = ""
        Dim gender As String = ""
        Dim pokemonForm As String = ""
        Dim shinyString As String = ""
        ' Dim superShiny As Boolean = False
        Dim pokemonNature As String = ""
        Dim pokemonIVs As String = ""
        Dim pokemonEVs As String = ""
        Dim pokemonHappyness As String = ""
        Dim pokemonNickname As String = ""
        Dim shadowString As String = ""
        Dim pokeballID As String = ""
        Dim numPoke As Integer = Form1.numPoké_cmb.SelectedItem
        'Pokemon Moves
        Dim move As Object = ""
        Dim output As String = ""

        Try
#Region "Pokemon 1"
            If numPoke >= 1 Then
                If Form1.pokemonOneName_txtBox.Text.ToUpper = "" Then

                    'If Pokemon Fails
                    MessageBox.Show("You need to enter a Pokémon (Pokémon 1).", "Cannot Create Team", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf Form1.pokemonOneMoves_lst.Items.Count = 0 Then

                    'If Moves Fail
                    MessageBox.Show("You need to add at least one move to " & Form1.pokemonOneName_txtBox.Text.ToUpper & " (Pokémon 1).", "Cannot Create Team", MessageBoxButtons.OK, MessageBoxIcon.Error)

                ElseIf Form1.pokemonOneLvl_txtBox.Text.ToUpper = "" Then

                    'If Level Fail
                    MessageBox.Show(Form1.pokemonOneName_txtBox.Text.ToUpper & " (Pokémon 1) needs to have a level set.", "Cannot Create Team", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    ' Set pokemon name & level in the following format:
                    ' Pokemon = {0},{1}
                    pokemonName = String.Format("Pokemon = {0},{1}" & vbCrLf, Form1.pokemonOneName_txtBox.Text.ToUpper, Form1.pokemonOneLvl_txtBox.Text)

                    ' Check to see if form = nothing
                    ' If it doesn't = nothing,
                    ' Set form using the following format:
                    ' Form = {0}
                    If Not Form1.pokemonOneForm_txtBox.Text = "" Then
                        pokemonForm = String.Format("    Form = {0}" & vbCrLf, Form1.pokemonOneForm_txtBox.Text)
                    End If

                    ' Check to see if name = nothing
                    ' If it doesn't = nothing,
                    ' Set name using the following format:
                    ' Name = {0}
                    If Not Form1.pokemonOneNickName_txtBox.Text = "" Then
                        pokemonNickname = String.Format("    Name = {0}" & vbCrLf, Form1.pokemonOneNickName_txtBox.Text)
                    End If

                    ' Check to see if heldItem = nothing
                    ' If it doesn't = nothing,
                    ' Set heldItem using the following format:
                    ' Item = {0}
                    If Not Form1.pokemonOneItem_txtBox.Text.ToUpper = "" Then
                        heldItem = String.Format("    Item = {0}" & vbCrLf, Form1.pokemonOneItem_txtBox.Text.ToUpper)
                    End If

                    ' Check to see if Gender = (random)
                    ' If it doesn't = (random),
                    ' Set Gender using the following format:
                    ' Gender = {0}
                    If Not Form1.pokemonOneGender_cmb.SelectedItem = "(random)" Then
                        gender = String.Format("    Gender = " & vbCrLf, Form1.pokemonOneGender_cmb.SelectedItem)
                    End If

                    ' Check to see if shiny = disabled
                    ' If it doesn't = disabled,
                    ' Set shiny using the following format:
                    ' Shiny = {0}
                    If Form1.pokemonOneShiny_rad.Checked = True Then
                        shinyString = String.Format("    Shiny = {0}" & vbCrLf, "Yes")
                    ElseIf Form1.pokemonOneSuperShiny_chk.Checked = True Then
                        shinyString = String.Format("    SuperShiny = {0}" & vbCrLf, "true")
                    End If

                    ' Check to see if shadow = disabled
                    ' If it doesn't = disabled,
                    ' Set shadow using the following format:
                    ' Shadow = {0}
                    If Form1.pokemonOneShadow_rad.Checked = True And Form1.pokemonOneShadowFalse_rad.Checked = False Then
                        shadowString = String.Format("    Shadow = {0}" & vbCrLf, "Yes")
                    End If


                    ' The new String.Format method doesn't work on the move handler.
                    ' Leave that as is.

                    ' Move Handler
                    For Each move In Form1.pokemonOneMoves_lst.Items
                        AllMoves &= move.ToString.ToUpper & ","
                    Next

                    AllMoves = AllMoves.Substring(0, AllMoves.Length - 1)

                    'Take all moves, and turn it into the move format
                    AllMoves = "    Moves = " & AllMoves & vbCrLf


                    ' Check if useAbilityIndex_chkBox is checked.
                    ' If it is, use ability index instead of ability
                    If Form1.useAbilityIndex_chkBox.Checked = True Then
                        pokemonAbility = "AbilityIndex"
                    ElseIf Form1.useAbilityIndex_chkBox.Checked = False Then
                        pokemonAbility = "Ability"
                    End If

                    ' Use the string set from above to set the format here
                    pokemonAbility = String.Format("    {0} = {1}" & vbCrLf, pokemonAbility, Form1.pokemonOneAbility_cmb.SelectedItem.ToString)

                    ' Check to see if Nature = (random)
                    ' If it doesn't = (random),
                    ' Set Nature using the following format:
                    ' Nature = {0}
                    If Not Form1.pokemonOneNature_cmb.SelectedItem = "(random)" Then
                        pokemonNature = String.Format("    Nature = {0}" & vbCrLf, Form1.pokemonOneNature_cmb.SelectedItem)
                    End If

                    ' IVs = {0},{1},{2},{3},{4},{5}
                    ' EVs use the same format as IVs
                    pokemonIVs = String.Format("    IVs = {0},{1},{2},{3},{4},{5}" & vbCrLf, Form1.pokemonOneIVsHP_txt.Text, Form1.pokemonOneIVsATK_txt.Text, Form1.pokemonOneIVsDEF_txt.Text, Form1.pokemonOneIVsSPD_txt.Text, Form1.pokemonOneIVsSPATK_txt.Text, Form1.pokemonOneIVsSPDEF_txt.Text)
                    pokemonEVs = String.Format("    EVs = {0},{1},{2},{3},{4},{5}" & vbCrLf, Form1.pokemonOneEVsHP_txt.Text, Form1.pokemonOneEVsATK_txt.Text, Form1.pokemonOneEVsDEF_txt.Text, Form1.pokemonOneEVsSPD_txt.Text, Form1.pokemonOneEVsSPATK_txt.Text, Form1.pokemonOneEVsSPDEF_txt.Text)

                    ' Check to see if heldItem = nothing
                    ' If it doesn't = nothing,
                    ' Set heldItem using the following format:
                    ' Item = {0}
                    If Not Form1.pokemonOneHappyness_txtBox.Text = "" Then
                        pokemonHappyness = String.Format("    Happiness = {0}" & vbCrLf, Form1.pokemonOneHappyness_txtBox.Text)
                    End If

                    'Get Ball ID
                    pokeballID = String.Format("    Ball = {0}" & vbCrLf, Form1.pokemonOnePokeballID_cmb.SelectedItem)

                    ' Use dims from above to generate output
                    output = pokemonName & pokemonForm & pokemonNickname & heldItem & gender & pokemonAbility & shinyString & shadowString & AllMoves & pokemonNature & pokemonIVs & pokemonEVs & pokemonHappyness & pokeballID

                    ' put the output in the thing
                    Form1.outputBox_rchBox.Text &= output & vbCrLf
                End If
            End If
#End Region
#Region "Pokemon 2"
            If numPoke >= 2 Then
                If Form1.pokemonTwoName_txtBox.Text.ToUpper = "" Then

                    'If Pokemon Fails
                    MessageBox.Show("You need to enter a Pokémon (Pokémon 2).", "Cannot Create Team", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf Form1.pokemonTwoMoves_lst.Items.Count = 0 Then

                    'If Moves Fail
                    MessageBox.Show("You need to add at least one move to " & Form1.pokemonTwoName_txtBox.Text.ToUpper & " (Pokémon 2).", "Cannot Create Team", MessageBoxButtons.OK, MessageBoxIcon.Error)

                ElseIf Form1.pokemonTwoLvl_txtBox.Text.ToUpper = "" Then

                    'If Level Fail
                    MessageBox.Show(Form1.pokemonTwoName_txtBox.Text.ToUpper & " (Pokémon 2) needs to have a level set.", "Cannot Create Team", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    ' Set pokemon name & level in the following format:
                    ' Pokemon = {0},{1}
                    pokemonName = String.Format("Pokemon = {0},{1}" & vbCrLf, Form1.pokemonTwoName_txtBox.Text.ToUpper, Form1.pokemonTwoLvl_txtBox.Text)

                    ' Check to see if form = nothing
                    ' If it doesn't = nothing,
                    ' Set form using the following format:
                    ' Form = {0}
                    If Not Form1.pokemonTwoForm_txtBox.Text = "" Then
                        pokemonForm = String.Format("    Form = {0}" & vbCrLf, Form1.pokemonTwoForm_txtBox.Text)
                    End If

                    ' Check to see if name = nothing
                    ' If it doesn't = nothing,
                    ' Set name using the following format:
                    ' Name = {0}
                    If Not Form1.pokemonTwoNickName_txtBox.Text = "" Then
                        pokemonNickname = String.Format("    Name = {0}" & vbCrLf, Form1.pokemonTwoNickName_txtBox.Text)
                    End If

                    ' Check to see if heldItem = nothing
                    ' If it doesn't = nothing,
                    ' Set heldItem using the following format:
                    ' Item = {0}
                    If Not Form1.pokemonTwoItem_txtBox.Text.ToUpper = "" Then
                        heldItem = String.Format("    Item = {0}" & vbCrLf, Form1.pokemonTwoItem_txtBox.Text.ToUpper)
                    End If

                    ' Check to see if Gender = (random)
                    ' If it doesn't = (random),
                    ' Set Gender using the following format:
                    ' Gender = {0}
                    If Not Form1.pokemonTwoGender_cmb.SelectedItem = "(random)" Then
                        gender = String.Format("    Gender = " & vbCrLf, Form1.pokemonTwoGender_cmb.SelectedItem)
                    End If

                    ' Check to see if shiny = disabled
                    ' If it doesn't = disabled,
                    ' Set shiny using the following format:
                    ' Shiny = {0}
                    If Form1.pokemonTwoShiny_rad.Checked = True Then
                        shinyString = String.Format("    Shiny = {0}" & vbCrLf, "Yes")
                    ElseIf Form1.pokemonTwoSuperShiny_chk.Checked = True Then
                        shinyString = String.Format("    SuperShiny = {0}" & vbCrLf, "true")
                    End If

                    ' Check to see if shadow = disabled
                    ' If it doesn't = disabled,
                    ' Set shadow using the following format:
                    ' Shadow = {0}
                    If Form1.pokemonTwoShadow_rad.Checked = True And Form1.pokemonTwoShadowFalse_rad.Checked = False Then
                        shadowString = String.Format("    Shadow = {0}" & vbCrLf, "Yes")
                    End If


                    ' The new String.Format method doesn't work on the move handler.
                    ' Leave that as is.

                    ' Move Handler
                    For Each move In Form1.pokemonTwoMoves_lst.Items
                        AllMoves &= move.ToString.ToUpper & ","
                    Next

                    AllMoves = AllMoves.Substring(0, AllMoves.Length - 1)

                    'Take all moves, and turn it into the move format
                    AllMoves = "    Moves = " & AllMoves & vbCrLf


                    ' Check if useAbilityIndex_chkBox is checked.
                    ' If it is, use ability index instead of ability
                    If Form1.useAbilityIndex_chkBox.Checked = True Then
                        pokemonAbility = "AbilityIndex"
                    ElseIf Form1.useAbilityIndex_chkBox.Checked = False Then
                        pokemonAbility = "Ability"
                    End If

                    ' Use the string set from above to set the format here
                    pokemonAbility = String.Format("    {0} = {1}" & vbCrLf, pokemonAbility, Form1.pokemonTwoAbility_cmb.SelectedItem.ToString)

                    ' Check to see if Nature = (random)
                    ' If it doesn't = (random),
                    ' Set Nature using the following format:
                    ' Nature = {0}
                    If Not Form1.pokemonTwoNature_cmb.SelectedItem = "(random)" Then
                        pokemonNature = String.Format("    Nature = {0}" & vbCrLf, Form1.pokemonTwoNature_cmb.SelectedItem)
                    End If

                    ' IVs = {0},{1},{2},{3},{4},{5}
                    ' EVs use the same format as IVs
                    pokemonIVs = String.Format("    IVs = {0},{1},{2},{3},{4},{5}" & vbCrLf, Form1.pokemonTwoIVsHP_txt.Text, Form1.pokemonTwoIVsATK_txt.Text, Form1.pokemonTwoIVsDEF_txt.Text, Form1.pokemonTwoIVsSPD_txt.Text, Form1.pokemonTwoIVsSPATK_txt.Text, Form1.pokemonTwoIVsSPDEF_txt.Text)
                    pokemonEVs = String.Format("    EVs = {0},{1},{2},{3},{4},{5}" & vbCrLf, Form1.pokemonTwoEVsHP_txt.Text, Form1.pokemonTwoEVsATK_txt.Text, Form1.pokemonTwoEVsDEF_txt.Text, Form1.pokemonTwoEVsSPD_txt.Text, Form1.pokemonTwoEVsSPATK_txt.Text, Form1.pokemonTwoEVsSPDEF_txt.Text)

                    ' Check to see if heldItem = nothing
                    ' If it doesn't = nothing,
                    ' Set heldItem using the following format:
                    ' Item = {0}
                    If Not Form1.pokemonTwoHappyness_txtBox.Text = "" Then
                        pokemonHappyness = String.Format("    Happiness = {0}" & vbCrLf, Form1.pokemonTwoHappyness_txtBox.Text)
                    End If

                    'Get Ball ID
                    pokeballID = String.Format("    Ball = {0}" & vbCrLf, Form1.pokemonTwoPokeballID_cmb.SelectedItem)

                    ' Use dims from above to generate output
                    output = pokemonName & pokemonForm & pokemonNickname & heldItem & gender & pokemonAbility & shinyString & shadowString & AllMoves & pokemonNature & pokemonIVs & pokemonEVs & pokemonHappyness & pokeballID

                    ' put the output in the thing
                    Form1.outputBox_rchBox.Text &= output & vbCrLf
                End If
            End If
#End Region
#Region "Pokemon 3"
            If numPoke >= 3 Then
                If Form1.pokemonThreeName_txtBox.Text.ToUpper = "" Then

                    'If Pokemon Fails
                    MessageBox.Show("You need to enter a Pokémon (Pokémon 3).", "Cannot Create Team", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf Form1.pokemonThreeMoves_lst.Items.Count = 0 Then

                    'If Moves Fail
                    MessageBox.Show("You need to add at least one move to " & Form1.pokemonThreeName_txtBox.Text.ToUpper & " (Pokémon 3).", "Cannot Create Team", MessageBoxButtons.OK, MessageBoxIcon.Error)

                ElseIf Form1.pokemonThreeLvl_txtBox.Text.ToUpper = "" Then

                    'If Level Fail
                    MessageBox.Show(Form1.pokemonThreeName_txtBox.Text.ToUpper & " (Pokémon 3) needs to have a level set.", "Cannot Create Team", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    ' Set pokemon name & level in the following format:
                    ' Pokemon = {0},{1}
                    pokemonName = String.Format("Pokemon = {0},{1}" & vbCrLf, Form1.pokemonThreeName_txtBox.Text.ToUpper, Form1.pokemonThreeLvl_txtBox.Text)

                    ' Check to see if form = nothing
                    ' If it doesn't = nothing,
                    ' Set form using the following format:
                    ' Form = {0}
                    If Not Form1.pokemonThreeForm_txtBox.Text = "" Then
                        pokemonForm = String.Format("    Form = {0}" & vbCrLf, Form1.pokemonThreeForm_txtBox.Text)
                    End If

                    ' Check to see if name = nothing
                    ' If it doesn't = nothing,
                    ' Set name using the following format:
                    ' Name = {0}
                    If Not Form1.pokemonThreeNickname_txtBox.Text = "" Then
                        pokemonNickname = String.Format("    Name = {0}" & vbCrLf, Form1.pokemonThreeNickname_txtBox.Text)
                    End If

                    ' Check to see if heldItem = nothing
                    ' If it doesn't = nothing,
                    ' Set heldItem using the following format:
                    ' Item = {0}
                    If Not Form1.pokemonThreeItem_txtBox.Text.ToUpper = "" Then
                        heldItem = String.Format("    Item = {0}" & vbCrLf, Form1.pokemonThreeItem_txtBox.Text.ToUpper)
                    End If

                    ' Check to see if Gender = (random)
                    ' If it doesn't = (random),
                    ' Set Gender using the following format:
                    ' Gender = {0}
                    If Not Form1.pokemonThreeGender_cmb.SelectedItem = "(random)" Then
                        gender = String.Format("    Gender = " & vbCrLf, Form1.pokemonThreeGender_cmb.SelectedItem)
                    End If

                    ' Check to see if shiny = disabled
                    ' If it doesn't = disabled,
                    ' Set shiny using the following format:
                    ' Shiny = {0}
                    If Form1.pokemonThreeShiny_rad.Checked = True Then
                        shinyString = String.Format("    Shiny = {0}" & vbCrLf, "Yes")
                    ElseIf Form1.pokemonThreeSuperShiny_chk.Checked = True Then
                        shinyString = String.Format("    SuperShiny = {0}" & vbCrLf, "true")
                    End If

                    ' Check to see if shadow = disabled
                    ' If it doesn't = disabled,
                    ' Set shadow using the following format:
                    ' Shadow = {0}
                    If Form1.pokemonThreeShadow_rad.Checked = True And Form1.pokemonThreeShadowFalse_rad.Checked = False Then
                        shadowString = String.Format("    Shadow = {0}" & vbCrLf, "Yes")
                    End If


                    ' The new String.Format method doesn't work on the move handler.
                    ' Leave that as is.

                    ' Move Handler
                    For Each move In Form1.pokemonThreeMoves_lst.Items
                        AllMoves &= move.ToString.ToUpper & ","
                    Next

                    AllMoves = AllMoves.Substring(0, AllMoves.Length - 1)

                    'Take all moves, and turn it into the move format
                    AllMoves = "    Moves = " & AllMoves & vbCrLf


                    ' Check if useAbilityIndex_chkBox is checked.
                    ' If it is, use ability index instead of ability
                    If Form1.useAbilityIndex_chkBox.Checked = True Then
                        pokemonAbility = "AbilityIndex"
                    ElseIf Form1.useAbilityIndex_chkBox.Checked = False Then
                        pokemonAbility = "Ability"
                    End If

                    ' Use the string set from above to set the format here
                    pokemonAbility = String.Format("    {0} = {1}" & vbCrLf, pokemonAbility, Form1.pokemonThreeAbility_cmb.SelectedItem.ToString)

                    ' Check to see if Nature = (random)
                    ' If it doesn't = (random),
                    ' Set Nature using the following format:
                    ' Nature = {0}
                    If Not Form1.pokemonThreeNature_cmb.SelectedItem = "(random)" Then
                        pokemonNature = String.Format("    Nature = {0}" & vbCrLf, Form1.pokemonThreeNature_cmb.SelectedItem)
                    End If

                    ' IVs = {0},{1},{2},{3},{4},{5}
                    ' EVs use the same format as IVs
                    pokemonIVs = String.Format("    IVs = {0},{1},{2},{3},{4},{5}" & vbCrLf, Form1.pokemonThreeIVsHP_txt.Text, Form1.pokemonThreeIVsATK_txt.Text, Form1.pokemonThreeIVsDEF_txt.Text, Form1.pokemonThreeIVsSPD_txt.Text, Form1.pokemonThreeIVsSPATK_txt.Text, Form1.pokemonThreeIVsSPDEF_txt.Text)
                    pokemonEVs = String.Format("    EVs = {0},{1},{2},{3},{4},{5}" & vbCrLf, Form1.pokemonThreeEVsHP_txt.Text, Form1.pokemonThreeEVsATK_txt.Text, Form1.pokemonThreeEVsDEF_txt.Text, Form1.pokemonThreeEVsSPD_txt.Text, Form1.pokemonThreeEVsSPATK_txt.Text, Form1.pokemonThreeEVsSPDEF_txt.Text)

                    ' Check to see if heldItem = nothing
                    ' If it doesn't = nothing,
                    ' Set heldItem using the following format:
                    ' Item = {0}
                    If Not Form1.pokemonThreeHappyness_txtBox.Text = "" Then
                        pokemonHappyness = String.Format("    Happiness = {0}" & vbCrLf, Form1.pokemonThreeHappyness_txtBox.Text)
                    End If

                    'Get Ball ID
                    pokeballID = String.Format("    Ball = {0}" & vbCrLf, Form1.pokemonThreePokeballID_cmb.SelectedItem)

                    ' Use dims from above to generate output
                    output = pokemonName & pokemonForm & pokemonNickname & heldItem & gender & pokemonAbility & shinyString & shadowString & AllMoves & pokemonNature & pokemonIVs & pokemonEVs & pokemonHappyness & pokeballID

                    ' put the output in the thing
                    Form1.outputBox_rchBox.Text &= output & vbCrLf
                End If
            End If
#End Region
#Region "Pokemon 4"
            If numPoke >= 4 Then
                If Form1.pokemonFourName_txtBox.Text.ToUpper = "" Then

                    'If Pokemon Fails
                    MessageBox.Show("You need to enter a Pokémon (Pokémon 4).", "Cannot Create Team", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf Form1.pokemonFourMoves_lst.Items.Count = 0 Then

                    'If Moves Fail
                    MessageBox.Show("You need to add at least one move to " & Form1.pokemonFourName_txtBox.Text.ToUpper & " (Pokémon 4).", "Cannot Create Team", MessageBoxButtons.OK, MessageBoxIcon.Error)

                ElseIf Form1.pokemonFourLvl_txtBox.Text.ToUpper = "" Then

                    'If Level Fail
                    MessageBox.Show(Form1.pokemonFourName_txtBox.Text.ToUpper & " (Pokémon 4) needs to have a level set.", "Cannot Create Team", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    ' Set pokemon name & level in the following format:
                    ' Pokemon = {0},{1}
                    pokemonName = String.Format("Pokemon = {0},{1}" & vbCrLf, Form1.pokemonFourName_txtBox.Text.ToUpper, Form1.pokemonFourlvl_txtBox.Text)

                    ' Check to see if form = nothing
                    ' If it doesn't = nothing,
                    ' Set form using the following format:
                    ' Form = {0}
                    If Not Form1.pokemonFourForm_txtBox.Text = "" Then
                        pokemonForm = String.Format("    Form = {0}" & vbCrLf, Form1.pokemonFourForm_txtBox.Text)
                    End If

                    ' Check to see if name = nothing
                    ' If it doesn't = nothing,
                    ' Set name using the following format:
                    ' Name = {0}
                    If Not Form1.pokemonFourNickname_txtBox.Text = "" Then
                        pokemonNickname = String.Format("    Name = {0}" & vbCrLf, Form1.pokemonFourNickname_txtBox.Text)
                    End If

                    ' Check to see if heldItem = nothing
                    ' If it doesn't = nothing,
                    ' Set heldItem using the following format:
                    ' Item = {0}
                    If Not Form1.pokemonFourItem_txtBox.Text.ToUpper = "" Then
                        heldItem = String.Format("    Item = {0}" & vbCrLf, Form1.pokemonFourItem_txtBox.Text.ToUpper)
                    End If

                    ' Check to see if Gender = (random)
                    ' If it doesn't = (random),
                    ' Set Gender using the following format:
                    ' Gender = {0}
                    If Not Form1.pokemonFourGender_cmb.SelectedItem = "(random)" Then
                        gender = String.Format("    Gender = " & vbCrLf, Form1.pokemonFourGender_cmb.SelectedItem)
                    End If

                    ' Check to see if shiny = disabled
                    ' If it doesn't = disabled,
                    ' Set shiny using the following format:
                    ' Shiny = {0}
                    If Form1.pokemonFourShiny_rad.Checked = True Then
                        shinyString = String.Format("    Shiny = {0}" & vbCrLf, "Yes")
                    ElseIf Form1.pokemonFourSuperShiny_chk.Checked = True Then
                        shinyString = String.Format("    SuperShiny = {0}" & vbCrLf, "true")
                    End If

                    ' Check to see if shadow = disabled
                    ' If it doesn't = disabled,
                    ' Set shadow using the following format:
                    ' Shadow = {0}
                    If Form1.pokemonFourShadow_rad.Checked = True And Form1.pokemonFourShadowFalse_rad.Checked = False Then
                        shadowString = String.Format("    Shadow = {0}" & vbCrLf, "Yes")
                    End If


                    ' The new String.Format method doesn't work on the move handler.
                    ' Leave that as is.

                    ' Move Handler
                    For Each move In Form1.pokemonFourMoves_lst.Items
                        AllMoves &= move.ToString.ToUpper & ","
                    Next

                    AllMoves = AllMoves.Substring(0, AllMoves.Length - 1)

                    'Take all moves, and turn it into the move format
                    AllMoves = "    Moves = " & AllMoves & vbCrLf


                    ' Check if useAbilityIndex_chkBox is checked.
                    ' If it is, use ability index instead of ability
                    If Form1.useAbilityIndex_chkBox.Checked = True Then
                        pokemonAbility = "AbilityIndex"
                    ElseIf Form1.useAbilityIndex_chkBox.Checked = False Then
                        pokemonAbility = "Ability"
                    End If

                    ' Use the string set from above to set the format here
                    pokemonAbility = String.Format("    {0} = {1}" & vbCrLf, pokemonAbility, Form1.pokemonFourAbility_cmb.SelectedItem.ToString)

                    ' Check to see if Nature = (random)
                    ' If it doesn't = (random),
                    ' Set Nature using the following format:
                    ' Nature = {0}
                    If Not Form1.pokemonFourNature_cmb.SelectedItem = "(random)" Then
                        pokemonNature = String.Format("    Nature = {0}" & vbCrLf, Form1.pokemonFourNature_cmb.SelectedItem)
                    End If

                    ' IVs = {0},{1},{2},{3},{4},{5}
                    ' EVs use the same format as IVs
                    pokemonIVs = String.Format("    IVs = {0},{1},{2},{3},{4},{5}" & vbCrLf, Form1.pokemonFourIVsHP_txt.Text, Form1.pokemonFourIVsATK_txt.Text, Form1.pokemonFourIVsDEF_txt.Text, Form1.pokemonFourIVsSPD_txt.Text, Form1.pokemonFourIVsSPATK_txt.Text, Form1.pokemonFourIVsSPDEF_txt.Text)
                    pokemonEVs = String.Format("    EVs = {0},{1},{2},{3},{4},{5}" & vbCrLf, Form1.pokemonFourEVsHP_txt.Text, Form1.pokemonFourEVsATK_txt.Text, Form1.pokemonFourEVsDEF_txt.Text, Form1.pokemonFourEVsSPD_txt.Text, Form1.pokemonFourEVsSPATK_txt.Text, Form1.pokemonFourEVsSPDEF_txt.Text)

                    ' Check to see if heldItem = nothing
                    ' If it doesn't = nothing,
                    ' Set heldItem using the following format:
                    ' Item = {0}
                    If Not Form1.pokemonFourHappyness_txtBox.Text = "" Then
                        pokemonHappyness = String.Format("    Happiness = {0}" & vbCrLf, Form1.pokemonFourHappyness_txtBox.Text)
                    End If

                    'Get Ball ID
                    pokeballID = String.Format("    Ball = {0}" & vbCrLf, Form1.pokemonFourPokeballID_cmb.SelectedItem)

                    ' Use dims from above to generate output
                    output = pokemonName & pokemonForm & pokemonNickname & heldItem & gender & pokemonAbility & shinyString & shadowString & AllMoves & pokemonNature & pokemonIVs & pokemonEVs & pokemonHappyness & pokeballID

                    ' put the output in the thing
                    Form1.outputBox_rchBox.Text &= output & vbCrLf
                End If
            End If
#End Region
#Region "Pokemon 5"
            If numPoke >= 5 Then
                If Form1.pokemonFiveName_txtBox.Text.ToUpper = "" Then

                    'If Pokemon Fails
                    MessageBox.Show("You need to enter a Pokémon (Pokémon 5).", "Cannot Create Team", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf Form1.pokemonFiveMoves_lst.Items.Count = 0 Then

                    'If Moves Fail
                    MessageBox.Show("You need to add at least one move to " & Form1.pokemonFiveName_txtBox.Text.ToUpper & " (Pokémon 5).", "Cannot Create Team", MessageBoxButtons.OK, MessageBoxIcon.Error)

                ElseIf Form1.pokemonFivelvl_txtBox.Text.ToUpper = "" Then

                    'If Level Fail
                    MessageBox.Show(Form1.pokemonFiveName_txtBox.Text.ToUpper & " (Pokémon 5) needs to have a level set.", "Cannot Create Team", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    ' Set pokemon name & level in the following format:
                    ' Pokemon = {0},{1}
                    pokemonName = String.Format("Pokemon = {0},{1}" & vbCrLf, Form1.pokemonFiveName_txtBox.Text.ToUpper, Form1.pokemonFivelvl_txtBox.Text)

                    ' Check to see if form = nothing
                    ' If it doesn't = nothing,
                    ' Set form using the following format:
                    ' Form = {0}
                    If Not Form1.pokemonFiveForm_txtBox.Text = "" Then
                        pokemonForm = String.Format("    Form = {0}" & vbCrLf, Form1.pokemonFiveForm_txtBox.Text)
                    End If

                    ' Check to see if name = nothing
                    ' If it doesn't = nothing,
                    ' Set name using the following format:
                    ' Name = {0}
                    If Not Form1.pokemonFiveNickname_txtBox.Text = "" Then
                        pokemonNickname = String.Format("    Name = {0}" & vbCrLf, Form1.pokemonFiveNickname_txtBox.Text)
                    End If

                    ' Check to see if heldItem = nothing
                    ' If it doesn't = nothing,
                    ' Set heldItem using the following format:
                    ' Item = {0}
                    If Not Form1.pokemonFiveItem_txtBox.Text.ToUpper = "" Then
                        heldItem = String.Format("    Item = {0}" & vbCrLf, Form1.pokemonFiveItem_txtBox.Text.ToUpper)
                    End If

                    ' Check to see if Gender = (random)
                    ' If it doesn't = (random),
                    ' Set Gender using the following format:
                    ' Gender = {0}
                    If Not Form1.pokemonFiveGender_cmb.SelectedItem = "(random)" Then
                        gender = String.Format("    Gender = " & vbCrLf, Form1.pokemonFiveGender_cmb.SelectedItem)
                    End If

                    ' Check to see if shiny = disabled
                    ' If it doesn't = disabled,
                    ' Set shiny using the following format:
                    ' Shiny = {0}
                    If Form1.pokemonFiveShiny_rad.Checked = True Then
                        shinyString = String.Format("    Shiny = {0}" & vbCrLf, "Yes")
                    ElseIf Form1.pokemonFiveSuperShiny_chk.Checked = True Then
                        shinyString = String.Format("    SuperShiny = {0}" & vbCrLf, "true")
                    End If

                    ' Check to see if shadow = disabled
                    ' If it doesn't = disabled,
                    ' Set shadow using the following format:
                    ' Shadow = {0}
                    If Form1.pokemonFiveShadow_rad.Checked = True And Form1.pokemonFiveShadowFalse_rad.Checked = False Then
                        shadowString = String.Format("    Shadow = {0}" & vbCrLf, "Yes")
                    End If


                    ' The new String.Format method doesn't work on the move handler.
                    ' Leave that as is.

                    ' Move Handler
                    For Each move In Form1.pokemonFiveMoves_lst.Items
                        AllMoves &= move.ToString.ToUpper & ","
                    Next

                    AllMoves = AllMoves.Substring(0, AllMoves.Length - 1)

                    'Take all moves, and turn it into the move format
                    AllMoves = "    Moves = " & AllMoves & vbCrLf


                    ' Check if useAbilityIndex_chkBox is checked.
                    ' If it is, use ability index instead of ability
                    If Form1.useAbilityIndex_chkBox.Checked = True Then
                        pokemonAbility = "AbilityIndex"
                    ElseIf Form1.useAbilityIndex_chkBox.Checked = False Then
                        pokemonAbility = "Ability"
                    End If

                    ' Use the string set from above to set the format here
                    pokemonAbility = String.Format("    {0} = {1}" & vbCrLf, pokemonAbility, Form1.pokemonFiveAbility_cmb.SelectedItem.ToString)

                    ' Check to see if Nature = (random)
                    ' If it doesn't = (random),
                    ' Set Nature using the following format:
                    ' Nature = {0}
                    If Not Form1.pokemonFiveNature_cmb.SelectedItem = "(random)" Then
                        pokemonNature = String.Format("    Nature = {0}" & vbCrLf, Form1.pokemonFiveNature_cmb.SelectedItem)
                    End If

                    ' IVs = {0},{1},{2},{3},{4},{5}
                    ' EVs use the same format as IVs
                    pokemonIVs = String.Format("    IVs = {0},{1},{2},{3},{4},{5}" & vbCrLf, Form1.pokemonFiveIVsHP_txt.Text, Form1.pokemonFiveIVsATK_txt.Text, Form1.pokemonFiveIVsDEF_txt.Text, Form1.pokemonFiveIVsSPD_txt.Text, Form1.pokemonFiveIVsSPATK_txt.Text, Form1.pokemonFiveIVsSPDEF_txt.Text)
                    pokemonEVs = String.Format("    EVs = {0},{1},{2},{3},{4},{5}" & vbCrLf, Form1.pokemonFiveEVsHP_txt.Text, Form1.pokemonFiveEVsATK_txt.Text, Form1.pokemonFiveEVsDEF_txt.Text, Form1.pokemonFiveEVsSPD_txt.Text, Form1.pokemonFiveEVsSPATK_txt.Text, Form1.pokemonFiveEVsSPDEF_txt.Text)

                    ' Check to see if heldItem = nothing
                    ' If it doesn't = nothing,
                    ' Set heldItem using the following format:
                    ' Item = {0}
                    If Not Form1.pokemonFiveHappyness_txtBox.Text = "" Then
                        pokemonHappyness = String.Format("    Happiness = {0}" & vbCrLf, Form1.pokemonFiveHappyness_txtBox.Text)
                    End If

                    'Get Ball ID
                    pokeballID = String.Format("    Ball = {0}" & vbCrLf, Form1.pokemonFivePokeballID_cmb.SelectedItem)

                    ' Use dims from above to generate output
                    output = pokemonName & pokemonForm & pokemonNickname & heldItem & gender & pokemonAbility & shinyString & shadowString & AllMoves & pokemonNature & pokemonIVs & pokemonEVs & pokemonHappyness & pokeballID

                    ' put the output in the thing
                    Form1.outputBox_rchBox.Text &= output & vbCrLf
                End If
            End If
#End Region
#Region "Pokemon 6"
            If numPoke >= 6 Then
                If Form1.pokemonSixName_txtBox.Text.ToUpper = "" Then

                    'If Pokemon Fails
                    MessageBox.Show("You need to enter a Pokémon (Pokémon 6).", "Cannot Create Team", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf Form1.pokemonSixMoves_lst.Items.Count = 0 Then

                    'If Moves Fail
                    MessageBox.Show("You need to add at least one move to " & Form1.pokemonSixName_txtBox.Text.ToUpper & " (Pokémon 6).", "Cannot Create Team", MessageBoxButtons.OK, MessageBoxIcon.Error)

                ElseIf Form1.pokemonSixlvl_txtBox.Text.ToUpper = "" Then

                    'If Level Fail
                    MessageBox.Show(Form1.pokemonSixName_txtBox.Text.ToUpper & " (Pokémon 6) needs to have a level set.", "Cannot Create Team", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    ' Set pokemon name & level in the following format:
                    ' Pokemon = {0},{1}
                    pokemonName = String.Format("Pokemon = {0},{1}" & vbCrLf, Form1.pokemonSixName_txtBox.Text.ToUpper, Form1.pokemonSixLvl_txtBox.Text)

                    ' Check to see if form = nothing
                    ' If it doesn't = nothing,
                    ' Set form using the following format:
                    ' Form = {0}
                    If Not Form1.pokemonSixForm_txtBox.Text = "" Then
                        pokemonForm = String.Format("    Form = {0}" & vbCrLf, Form1.pokemonSixForm_txtBox.Text)
                    End If

                    ' Check to see if name = nothing
                    ' If it doesn't = nothing,
                    ' Set name using the following format:
                    ' Name = {0}
                    If Not Form1.pokemonSixNickname_txtBox.Text = "" Then
                        pokemonNickname = String.Format("    Name = {0}" & vbCrLf, Form1.pokemonSixNickname_txtBox.Text)
                    End If

                    ' Check to see if heldItem = nothing
                    ' If it doesn't = nothing,
                    ' Set heldItem using the following format:
                    ' Item = {0}
                    If Not Form1.pokemonSixItem_txtBox.Text.ToUpper = "" Then
                        heldItem = String.Format("    Item = {0}" & vbCrLf, Form1.pokemonSixItem_txtBox.Text.ToUpper)
                    End If

                    ' Check to see if Gender = (random)
                    ' If it doesn't = (random),
                    ' Set Gender using the following format:
                    ' Gender = {0}
                    If Not Form1.pokemonSixGender_cmb.SelectedItem = "(random)" Then
                        gender = String.Format("    Gender = " & vbCrLf, Form1.pokemonSixGender_cmb.SelectedItem)
                    End If

                    ' Check to see if shiny = disabled
                    ' If it doesn't = disabled,
                    ' Set shiny using the following format:
                    ' Shiny = {0}
                    If Form1.pokemonSixShiny_rad.Checked = True Then
                        shinyString = String.Format("    Shiny = {0}" & vbCrLf, "Yes")
                    ElseIf Form1.pokemonSixSuperShiny_chk.Checked = True Then
                        shinyString = String.Format("    SuperShiny = {0}" & vbCrLf, "true")
                    End If

                    ' Check to see if shadow = disabled
                    ' If it doesn't = disabled,
                    ' Set shadow using the following format:
                    ' Shadow = {0}
                    If Form1.pokemonSixShadow_rad.Checked = True And Form1.pokemonSixShadowFalse_rad.Checked = False Then
                        shadowString = String.Format("    Shadow = {0}" & vbCrLf, "Yes")
                    End If


                    ' The new String.Format method doesn't work on the move handler.
                    ' Leave that as is.

                    ' Move Handler
                    For Each move In Form1.pokemonSixMoves_lst.Items
                        AllMoves &= move.ToString.ToUpper & ","
                    Next

                    AllMoves = AllMoves.Substring(0, AllMoves.Length - 1)

                    'Take all moves, and turn it into the move format
                    AllMoves = "    Moves = " & AllMoves & vbCrLf


                    ' Check if useAbilityIndex_chkBox is checked.
                    ' If it is, use ability index instead of ability
                    If Form1.useAbilityIndex_chkBox.Checked = True Then
                        pokemonAbility = "AbilityIndex"
                    ElseIf Form1.useAbilityIndex_chkBox.Checked = False Then
                        pokemonAbility = "Ability"
                    End If

                    ' Use the string set from above to set the format here
                    pokemonAbility = String.Format("    {0} = {1}" & vbCrLf, pokemonAbility, Form1.pokemonSixAbility_cmb.SelectedItem.ToString)

                    ' Check to see if Nature = (random)
                    ' If it doesn't = (random),
                    ' Set Nature using the following format:
                    ' Nature = {0}
                    If Not Form1.pokemonSixNature_cmb.SelectedItem = "(random)" Then
                        pokemonNature = String.Format("    Nature = {0}" & vbCrLf, Form1.pokemonSixNature_cmb.SelectedItem)
                    End If

                    ' IVs = {0},{1},{2},{3},{4},{5}
                    ' EVs use the same format as IVs
                    pokemonIVs = String.Format("    IVs = {0},{1},{2},{3},{4},{5}" & vbCrLf, Form1.pokemonSixIVsHP_txt.Text, Form1.pokemonSixIVsATK_txt.Text, Form1.pokemonSixIVsDEF_txt.Text, Form1.pokemonSixIVsSPD_txt.Text, Form1.pokemonSixIVsSPATK_txt.Text, Form1.pokemonSixIVsSPDEF_txt.Text)
                    pokemonEVs = String.Format("    EVs = {0},{1},{2},{3},{4},{5}" & vbCrLf, Form1.pokemonSixEVsHP_txt.Text, Form1.pokemonSixEVsATK_txt.Text, Form1.pokemonSixEVsDEF_txt.Text, Form1.pokemonSixEVsSPD_txt.Text, Form1.pokemonSixEVsSPATK_txt.Text, Form1.pokemonSixEVsSPDEF_txt.Text)

                    ' Check to see if heldItem = nothing
                    ' If it doesn't = nothing,
                    ' Set heldItem using the following format:
                    ' Item = {0}
                    If Not Form1.pokemonSixHappyness_txtBox.Text = "" Then
                        pokemonHappyness = String.Format("    Happiness = {0}" & vbCrLf, Form1.pokemonSixHappyness_txtBox.Text)
                    End If

                    'Get Ball ID
                    pokeballID = String.Format("    Ball = {0}" & vbCrLf, Form1.pokemonSixPokeballID_cmb.SelectedItem)

                    ' Use dims from above to generate output
                    output = pokemonName & pokemonForm & pokemonNickname & heldItem & gender & pokemonAbility & shinyString & shadowString & AllMoves & pokemonNature & pokemonIVs & pokemonEVs & pokemonHappyness & pokeballID

                    ' put the output in the thing
                    Form1.outputBox_rchBox.Text &= output & vbCrLf
                End If
            End If
#End Region
        Catch ex As Exception
            MessageBox.Show("Oh no!" & vbCrLf & ex.ToString, "Error")
        End Try


    End Sub

End Class
