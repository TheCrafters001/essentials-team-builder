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
        Dim numPoke As Integer = Form1.numPoké_cmb.SelectedItem
        'Trainer Items
        Dim item As Object
        Dim TrainerItems As String
        'Pokemon Moves
        Dim move As Object
        Dim output As String
#Region "Trainer"

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
        End If



        Form1.outputBox_rchBox.Text = "#-------------------------------"
        If Form1.existingBattle_chkBox.Checked = True Then
            If Form1.trainerUsesItems_chkBox.Checked = False Then
                Form1.outputBox_rchBox.Text &= vbCrLf & "[" & Form1.trainerType_txtBox.Text().ToUpper & "," & Form1.trainerName_txtBox.Text & "," & Form1.battleTeamID_txtBox.Text() & "]" _
                     & vbCrLf & "LoseText = """ & Form1.loseText_txt.Text & """" & vbCrLf
            ElseIf Form1.trainerUsesItems_chkBox.Checked = True Then
                Form1.outputBox_rchBox.Text &= vbCrLf & "[" & Form1.trainerType_txtBox.Text().ToUpper & "," & Form1.trainerName_txtBox.Text & "," & Form1.battleTeamID_txtBox.Text() & "]" _
                     & vbCrLf & "Items = " & TrainerItems & vbCrLf &
                     "LoseText = """ & Form1.loseText_txt.Text & """" & vbCrLf
            End If
        ElseIf Form1.existingBattle_chkBox.Checked = False Then
            If Form1.trainerUsesItems_chkBox.Checked = False Then
                Form1.outputBox_rchBox.Text &= vbCrLf & "[" & Form1.trainerType_txtBox.Text().ToUpper & "," & Form1.trainerName_txtBox.Text & "]" _
                     & vbCrLf & "LoseText = """ & Form1.loseText_txt.Text & """" & vbCrLf
            ElseIf Form1.trainerUsesItems_chkBox.Checked = True Then
                Form1.outputBox_rchBox.Text &= vbCrLf & "[" & Form1.trainerType_txtBox.Text().ToUpper & "," & Form1.trainerName_txtBox.Text & "]" _
                     & vbCrLf & "Items = " & TrainerItems & vbCrLf &
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

                ' Move Handler
                For Each move In Form1.pokemonOneMoves_lst.Items
                    AllMoves &= move.ToString.ToUpper & ","
                Next

                If Form1.pokemonOneMoves_lst.Items.Count = 0 Then
                    MessageBox.Show("You need to add at least one move to " & Form1.pokemonOneName_txtBox.Text.ToUpper & " (Pokemon 1).", "Cannot Create Team", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    AllMoves = AllMoves.Substring(0, AllMoves.Length - 1)
                End If

                'Take all moves, and turn it into the move format
                AllMoves = "    Moves = " & AllMoves & vbCrLf

                pokemonAbility = "    Ability = " & Form1.pokemonOneAbility_cmb.SelectedItem.ToString & vbCrLf
                If Form1.pokemonOneNature_cmb.SelectedItem = "(random)" Then
                    pokemonNature = ""
                ElseIf Not Form1.pokemonOneNature_cmb.SelectedItem = "(random)" Then
                    pokemonNature = "    Nature = " & Form1.pokemonOneNature_cmb.SelectedItem & vbCrLf
                End If
                pokemonIVs = "    IVs = " & Form1.pokemonOneIVsHP_txt.Text & "," & Form1.pokemonOneIVsATK_txt.Text & "," & Form1.pokemonOneIVsDEF_txt.Text & "," & Form1.pokemonOneIVsSPD_txt.Text & "," & Form1.pokemonOneIVsSPATK_txt.Text & "," & Form1.pokemonOneIVsSPDEF_txt.Text & vbCrLf
                pokemonEVs = "    EVs = " & Form1.pokemonOneEVsHP_txt.Text & "," & Form1.pokemonOneEVsATK_txt.Text & "," & Form1.pokemonOneEVsDEF_txt.Text & "," & Form1.pokemonOneEVsSPD_txt.Text & "," & Form1.pokemonOneEVsSPATK_txt.Text & "," & Form1.pokemonOneEVsSPDEF_txt.Text & vbCrLf
                If Form1.pokemonOneHappyness_txtBox.Text = "" Then
                    pokemonHappyness = "    Happiness = 70" & vbCrLf
                ElseIf Not Form1.pokemonOneHappyness_txtBox.Text = "" Then
                    pokemonHappyness = "    Happiness = " & Form1.pokemonOneHappyness_txtBox.Text & vbCrLf
                End If
                pokeballID = "    Ball = " & Form1.pokemonOnePokeballID_cmb.SelectedItem & vbCrLf
                output = pokemonName & pokemonForm & pokemonNickname & heldItem & gender & pokemonAbility & AllMoves & pokemonNature & pokemonIVs & pokemonEVs & pokemonHappyness & pokeballID
                Form1.outputBox_rchBox.Text &= output & vbCrLf
            End If
#End Region
#Region "Pokemon 2"
            If numPoke >= 2 Then
                pokemonName = "Pokemon = " & Form1.pokemonTwoName_txtBox.Text.ToUpper & "," & Form1.pokemonTwoLvl_txtBox.Text & vbCrLf
                If Form1.pokemonTwoForm_txtBox.Text = "" Then
                    pokemonForm = ""
                ElseIf Not Form1.pokemonTwoForm_txtBox.Text = "" Then
                    pokemonForm = "    Form = " & Form1.pokemonTwoForm_txtBox.Text & vbCrLf
                End If
                If Form1.pokemonTwoNickName_txtBox.Text = "" Then
                    pokemonNickname = ""
                ElseIf Not Form1.pokemonTwoNickName_txtBox.Text = "" Then
                    pokemonNickname = "    Name = " & Form1.pokemonTwoNickName_txtBox.Text & vbCrLf
                End If
                If Form1.pokemonTwoItem_txtBox.Text.ToUpper = "" Then
                    heldItem = ""
                ElseIf Not Form1.pokemonTwoItem_txtBox.Text.ToUpper = "" Then
                    heldItem = "    Item = " & Form1.pokemonTwoItem_txtBox.Text.ToUpper & vbCrLf
                End If
                If Form1.pokemonTwoGender_cmb.SelectedItem = "(random)" Then
                    gender = ""
                ElseIf Not Form1.pokemonTwoGender_cmb.SelectedItem = "(random)" Then
                    gender = "    Gender = " & Form1.pokemonTwoGender_cmb.SelectedItem & vbCrLf
                End If
                If Form1.pokemonTwoShiny_rad.Checked = True And Form1.pokemonTwoShinyFalse_rad.Checked = False Then
                    shinyString = "    Shiny = yes" & vbCrLf
                ElseIf Form1.pokemonTwoShiny_rad.Checked = False And Form1.pokemonTwoShinyFalse_rad.Checked = True Then
                    shinyString = "    Shiny = no" & vbCrLf
                End If
                If Form1.pokemonTwoShadow_rad.Checked = True And Form1.pokemonTwoShadowFalse_rad.Checked = False Then
                    shadowString = "    Shadow = yes" & vbCrLf
                ElseIf Form1.pokemonTwoShadow_rad.Checked = False And Form1.pokemonTwoShadowFalse_rad.Checked = True Then
                    shadowString = "    Shadow = no" & vbCrLf
                End If

                ' Move Handler
                For Each move In Form1.pokemonTwoMoves_lst.Items
                    AllMoves &= move.ToString.ToUpper & ","
                Next

                If Form1.pokemonTwoMoves_lst.Items.Count = 0 Then
                    MessageBox.Show("You need to add at least one move to " & Form1.pokemonTwoName_txtBox.Text.ToUpper & " (Pokemon 2).", "Cannot Create Team", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    AllMoves = AllMoves.Substring(0, AllMoves.Length - 1)
                End If

                'Take all moves, and turn it into the move format
                AllMoves = "    Moves = " & AllMoves & vbCrLf

                pokemonAbility = "    Ability = " & Form1.pokemonTwoAbility_cmb.SelectedItem.ToString & vbCrLf
                If Form1.pokemonTwoNature_cmb.SelectedItem = "(random)" Then
                    pokemonNature = ""
                ElseIf Not Form1.pokemonTwoNature_cmb.SelectedItem = "(random)" Then
                    pokemonNature = "    Nature = " & Form1.pokemonTwoNature_cmb.SelectedItem & vbCrLf
                End If
                pokemonIVs = "    IVs = " & Form1.pokemonTwoIVsHP_txt.Text & "," & Form1.pokemonTwoIVsATK_txt.Text & "," & Form1.pokemonTwoIVsDEF_txt.Text & "," & Form1.pokemonTwoIVsSPD_txt.Text & "," & Form1.pokemonTwoIVsSPATK_txt.Text & "," & Form1.pokemonTwoIVsSPDEF_txt.Text & vbCrLf
                pokemonEVs = "    EVs = " & Form1.pokemonTwoEVsHP_txt.Text & "," & Form1.pokemonTwoEVsATK_txt.Text & "," & Form1.pokemonTwoEVsDEF_txt.Text & "," & Form1.pokemonTwoEVsSPD_txt.Text & "," & Form1.pokemonTwoEVsSPATK_txt.Text & "," & Form1.pokemonTwoEVsSPDEF_txt.Text & vbCrLf
                If Form1.pokemonTwoHappyness_txtBox.Text = "" Then
                    pokemonHappyness = "    Happiness = 70" & vbCrLf
                ElseIf Not Form1.pokemonTwoHappyness_txtBox.Text = "" Then
                    pokemonHappyness = "    Happiness = " & Form1.pokemonTwoHappyness_txtBox.Text & vbCrLf
                End If
                pokeballID = "    Ball = " & Form1.pokemonTwoPokeballID_cmb.SelectedItem & vbCrLf
                output = pokemonName & pokemonForm & pokemonNickname & heldItem & gender & pokemonAbility & AllMoves & pokemonNature & pokemonIVs & pokemonEVs & pokemonHappyness & pokeballID
                Form1.outputBox_rchBox.Text &= output & vbCrLf
            End If
#End Region
#Region "Pokemon 3"
            If numPoke >= 3 Then
                pokemonName = "Pokemon = " & Form1.pokemonThreeName_txtBox.Text.ToUpper & "," & Form1.pokemonThreeLvl_txtBox.Text & vbCrLf
                If Form1.pokemonThreeForm_txtBox.Text = "" Then
                    pokemonForm = ""
                ElseIf Not Form1.pokemonThreeForm_txtBox.Text = "" Then
                    pokemonForm = "    Form = " & Form1.pokemonThreeForm_txtBox.Text & vbCrLf
                End If
                If Form1.pokemonThreeNickname_txtBox.Text = "" Then
                    pokemonNickname = ""
                ElseIf Not Form1.pokemonThreeNickname_txtBox.Text = "" Then
                    pokemonNickname = "    Name = " & Form1.pokemonThreeNickname_txtBox.Text & vbCrLf
                End If
                If Form1.pokemonThreeItem_txtBox.Text.ToUpper = "" Then
                    heldItem = ""
                ElseIf Not Form1.pokemonThreeItem_txtBox.Text.ToUpper = "" Then
                    heldItem = "    Item = " & Form1.pokemonThreeItem_txtBox.Text.ToUpper & vbCrLf
                End If
                If Form1.pokemonThreeGender_cmb.SelectedItem = "(random)" Then
                    gender = ""
                ElseIf Not Form1.pokemonThreeGender_cmb.SelectedItem = "(random)" Then
                    gender = "    Gender = " & Form1.pokemonThreeGender_cmb.SelectedItem & vbCrLf
                End If
                If Form1.pokemonThreeShiny_rad.Checked = True And Form1.pokemonThreeShinyFalse_Rad.Checked = False Then
                    shinyString = "    Shiny = yes" & vbCrLf
                ElseIf Form1.pokemonThreeShiny_rad.Checked = False And Form1.pokemonThreeShinyFalse_Rad.Checked = True Then
                    shinyString = "    Shiny = no" & vbCrLf
                End If
                If Form1.pokemonThreeShadow_rad.Checked = True And Form1.pokemonThreeShadowFalse_rad.Checked = False Then
                    shadowString = "    Shadow = yes" & vbCrLf
                ElseIf Form1.pokemonThreeShadow_rad.Checked = False And Form1.pokemonThreeShadowFalse_rad.Checked = True Then
                    shadowString = "    Shadow = no" & vbCrLf
                End If

                ' Move Handler
                For Each move In Form1.pokemonThreeMoves_lst.Items
                    AllMoves &= move.ToString.ToUpper & ","
                Next

                If Form1.pokemonThreeMoves_lst.Items.Count = 0 Then
                    MessageBox.Show("You need to add at least one move to " & Form1.pokemonThreeName_txtBox.Text.ToUpper & " (Pokemon 3).", "Cannot Create Team", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    AllMoves = AllMoves.Substring(0, AllMoves.Length - 1)
                End If

                'Take all moves, and turn it into the move format
                AllMoves = "    Moves = " & AllMoves & vbCrLf

                pokemonAbility = "    Ability = " & Form1.pokemonThreeAbility_cmb.SelectedItem.ToString & vbCrLf
                If Form1.pokemonThreeNature_cmb.SelectedItem = "(random)" Then
                    pokemonNature = ""
                ElseIf Not Form1.pokemonThreeNature_cmb.SelectedItem = "(random)" Then
                    pokemonNature = "    Nature = " & Form1.pokemonThreeNature_cmb.SelectedItem & vbCrLf
                End If
                pokemonIVs = "    IVs = " & Form1.pokemonThreeIVsHP_txt.Text & "," & Form1.pokemonThreeIVsATK_txt.Text & "," & Form1.pokemonThreeIVsDEF_txt.Text & "," & Form1.pokemonThreeIVsSPD_txt.Text & "," & Form1.pokemonThreeIVsSPATK_txt.Text & "," & Form1.pokemonThreeIVsSPDEF_txt.Text & vbCrLf
                pokemonEVs = "    EVs = " & Form1.pokemonThreeEVsHP_txt.Text & "," & Form1.pokemonThreeEVsATK_txt.Text & "," & Form1.pokemonThreeEVsDEF_txt.Text & "," & Form1.pokemonThreeEVsSPD_txt.Text & "," & Form1.pokemonThreeEVsSPATK_txt.Text & "," & Form1.pokemonThreeEVsSPDEF_txt.Text & vbCrLf
                If Form1.pokemonThreeHappyness_txtBox.Text = "" Then
                    pokemonHappyness = "    Happiness = 70" & vbCrLf
                ElseIf Not Form1.pokemonThreeHappyness_txtBox.Text = "" Then
                    pokemonHappyness = "    Happiness = " & Form1.pokemonThreeHappyness_txtBox.Text & vbCrLf
                End If
                pokeballID = "    Ball = " & Form1.pokemonThreePokeballID_cmb.SelectedItem & vbCrLf
                output = pokemonName & pokemonForm & pokemonNickname & heldItem & gender & pokemonAbility & AllMoves & pokemonNature & pokemonIVs & pokemonEVs & pokemonHappyness & pokeballID
                Form1.outputBox_rchBox.Text &= output & vbCrLf
            End If
#End Region
#Region "Pokemon 4"
            If numPoke >= 4 Then
                pokemonName = "Pokemon = " & Form1.pokemonFourName_txtBox.Text.ToUpper & "," & Form1.pokemonFourlvl_txtBox.Text & vbCrLf
                If Form1.pokemonFourForm_txtBox.Text = "" Then
                    pokemonForm = ""
                ElseIf Not Form1.pokemonFourForm_txtBox.Text = "" Then
                    pokemonForm = "    Form = " & Form1.pokemonFourForm_txtBox.Text & vbCrLf
                End If
                If Form1.pokemonFourNickname_txtBox.Text = "" Then
                    pokemonNickname = ""
                ElseIf Not Form1.pokemonFourNickname_txtBox.Text = "" Then
                    pokemonNickname = "    Name = " & Form1.pokemonFourNickname_txtBox.Text & vbCrLf
                End If
                If Form1.pokemonFourItem_txtBox.Text.ToUpper = "" Then
                    heldItem = ""
                ElseIf Not Form1.pokemonFourItem_txtBox.Text.ToUpper = "" Then
                    heldItem = "    Item = " & Form1.pokemonFourItem_txtBox.Text.ToUpper & vbCrLf
                End If
                If Form1.pokemonFourGender_cmb.SelectedItem = "(random)" Then
                    gender = ""
                ElseIf Not Form1.pokemonFourGender_cmb.SelectedItem = "(random)" Then
                    gender = "    Gender = " & Form1.pokemonFourGender_cmb.SelectedItem & vbCrLf
                End If
                If Form1.pokemonFourShiny_rad.Checked = True And Form1.pokemonFourShinyFalse_rad.Checked = False Then
                    shinyString = "    Shiny = yes" & vbCrLf
                ElseIf Form1.pokemonFourShiny_rad.Checked = False And Form1.pokemonFourShinyFalse_rad.Checked = True Then
                    shinyString = "    Shiny = no" & vbCrLf
                End If
                If Form1.pokemonFourShadow_rad.Checked = True And Form1.pokemonFourShadowFalse_rad.Checked = False Then
                    shadowString = "    Shadow = yes" & vbCrLf
                ElseIf Form1.pokemonFourShadow_rad.Checked = False And Form1.pokemonFourShadowFalse_rad.Checked = True Then
                    shadowString = "    Shadow = no" & vbCrLf
                End If

                ' Move Handler
                For Each move In Form1.pokemonFourMoves_lst.Items
                    AllMoves &= move.ToString.ToUpper & ","
                Next

                If Form1.pokemonFourMoves_lst.Items.Count = 0 Then
                    MessageBox.Show("You need to add at least one move to " & Form1.pokemonFourName_txtBox.Text.ToUpper & " (Pokemon 4).", "Cannot Create Team", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    AllMoves = AllMoves.Substring(0, AllMoves.Length - 1)
                End If

                'Take all moves, and turn it into the move format
                AllMoves = "    Moves = " & AllMoves & vbCrLf

                pokemonAbility = "    Ability = " & Form1.pokemonFourAbility_cmb.SelectedItem.ToString & vbCrLf
                If Form1.pokemonFourNature_cmb.SelectedItem = "(random)" Then
                    pokemonNature = ""
                ElseIf Not Form1.pokemonFourNature_cmb.SelectedItem = "(random)" Then
                    pokemonNature = "    Nature = " & Form1.pokemonFourNature_cmb.SelectedItem & vbCrLf
                End If
                pokemonIVs = "    IVs = " & Form1.pokemonFourIVsHP_txt.Text & "," & Form1.pokemonFourIVsATK_txt.Text & "," & Form1.pokemonFourIVsDEF_txt.Text & "," & Form1.pokemonFourIVsSPD_txt.Text & "," & Form1.pokemonFourIVsSPATK_txt.Text & "," & Form1.pokemonFourIVsSPDEF_txt.Text & vbCrLf
                pokemonEVs = "    EVs = " & Form1.pokemonFourEVsHP_txt.Text & "," & Form1.pokemonFourEVsATK_txt.Text & "," & Form1.pokemonFourEVsDEF_txt.Text & "," & Form1.pokemonFourEVsSPD_txt.Text & "," & Form1.pokemonFourEVsSPATK_txt.Text & "," & Form1.pokemonFourEVsSPDEF_txt.Text & vbCrLf
                If Form1.pokemonFourHappyness_txtBox.Text = "" Then
                    pokemonHappyness = "    Happiness = 70" & vbCrLf
                ElseIf Not Form1.pokemonFourHappyness_txtBox.Text = "" Then
                    pokemonHappyness = "    Happiness = " & Form1.pokemonFourHappyness_txtBox.Text & vbCrLf
                End If
                pokeballID = "    Ball = " & Form1.pokemonFourPokeballID_cmb.SelectedItem & vbCrLf
                output = pokemonName & pokemonForm & pokemonNickname & heldItem & gender & pokemonAbility & AllMoves & pokemonNature & pokemonIVs & pokemonEVs & pokemonHappyness & pokeballID
                Form1.outputBox_rchBox.Text &= output & vbCrLf
            End If
#End Region
#Region "Pokemon 5"
            If numPoke >= 5 Then
                pokemonName = "Pokemon = " & Form1.pokemonFiveName_txtBox.Text.ToUpper & "," & Form1.pokemonFivelvl_txtBox.Text & vbCrLf
                If Form1.pokemonFiveForm_txtBox.Text = "" Then
                    pokemonForm = ""
                ElseIf Not Form1.pokemonFiveForm_txtBox.Text = "" Then
                    pokemonForm = "    Form = " & Form1.pokemonFiveForm_txtBox.Text & vbCrLf
                End If
                If Form1.pokemonFiveNickname_txtBox.Text = "" Then
                    pokemonNickname = ""
                ElseIf Not Form1.pokemonFiveNickname_txtBox.Text = "" Then
                    pokemonNickname = "    Name = " & Form1.pokemonFiveNickname_txtBox.Text & vbCrLf
                End If
                If Form1.pokemonFiveItem_txtBox.Text.ToUpper = "" Then
                    heldItem = ""
                ElseIf Not Form1.pokemonFiveItem_txtBox.Text.ToUpper = "" Then
                    heldItem = "    Item = " & Form1.pokemonFiveItem_txtBox.Text.ToUpper & vbCrLf
                End If
                If Form1.pokemonFiveGender_cmb.SelectedItem = "(random)" Then
                    gender = ""
                ElseIf Not Form1.pokemonFiveGender_cmb.SelectedItem = "(random)" Then
                    gender = "    Gender = " & Form1.pokemonFiveGender_cmb.SelectedItem & vbCrLf
                End If
                If Form1.pokemonFiveShiny_rad.Checked = True And Form1.pokemonFiveShinyFalse_rad.Checked = False Then
                    shinyString = "    Shiny = yes" & vbCrLf
                ElseIf Form1.pokemonFiveShiny_rad.Checked = False And Form1.pokemonFiveShinyFalse_rad.Checked = True Then
                    shinyString = "    Shiny = no" & vbCrLf
                End If
                If Form1.pokemonFiveShadow_rad.Checked = True And Form1.pokemonFiveShadowFalse_rad.Checked = False Then
                    shadowString = "    Shadow = yes" & vbCrLf
                ElseIf Form1.pokemonFiveShadow_rad.Checked = False And Form1.pokemonFiveShadowFalse_rad.Checked = True Then
                    shadowString = "    Shadow = no" & vbCrLf
                End If

                ' Move Handler
                For Each move In Form1.pokemonFiveMoves_lst.Items
                    AllMoves &= move.ToString.ToUpper & ","
                Next

                If Form1.pokemonFiveMoves_lst.Items.Count = 0 Then
                    MessageBox.Show("You need to add at least one move to " & Form1.pokemonFiveName_txtBox.Text.ToUpper & " (Pokemon 5).", "Cannot Create Team", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    AllMoves = AllMoves.Substring(0, AllMoves.Length - 1)
                End If

                'Take all moves, and turn it into the move format
                AllMoves = "    Moves = " & AllMoves & vbCrLf

                pokemonAbility = "    Ability = " & Form1.pokemonFiveAbility_cmb.SelectedItem.ToString & vbCrLf
                If Form1.pokemonFiveNature_cmb.SelectedItem = "(random)" Then
                    pokemonNature = ""
                ElseIf Not Form1.pokemonFiveNature_cmb.SelectedItem = "(random)" Then
                    pokemonNature = "    Nature = " & Form1.pokemonFiveNature_cmb.SelectedItem & vbCrLf
                End If
                pokemonIVs = "    IVs = " & Form1.pokemonFiveIVsHP_txt.Text & "," & Form1.pokemonFiveIVsATK_txt.Text & "," & Form1.pokemonFiveIVsDEF_txt.Text & "," & Form1.pokemonFiveIVsSPD_txt.Text & "," & Form1.pokemonFiveIVsSPATK_txt.Text & "," & Form1.pokemonFiveIVsSPDEF_txt.Text & vbCrLf
                pokemonEVs = "    EVs = " & Form1.pokemonFiveEVsHP_txt.Text & "," & Form1.pokemonFiveEVsATK_txt.Text & "," & Form1.pokemonFiveEVsDEF_txt.Text & "," & Form1.pokemonFiveEVsSPD_txt.Text & "," & Form1.pokemonFiveEVsSPATK_txt.Text & "," & Form1.pokemonFiveEVsSPDEF_txt.Text & vbCrLf
                If Form1.pokemonFiveHappyness_txtBox.Text = "" Then
                    pokemonHappyness = "    Happiness = 70" & vbCrLf
                ElseIf Not Form1.pokemonFiveHappyness_txtBox.Text = "" Then
                    pokemonHappyness = "    Happiness = " & Form1.pokemonFiveHappyness_txtBox.Text & vbCrLf
                End If
                pokeballID = "    Ball = " & Form1.pokemonFivePokeballID_cmb.SelectedItem & vbCrLf
                output = pokemonName & pokemonForm & pokemonNickname & heldItem & gender & pokemonAbility & AllMoves & pokemonNature & pokemonIVs & pokemonEVs & pokemonHappyness & pokeballID
                Form1.outputBox_rchBox.Text &= output & vbCrLf
            End If
#End Region
#Region "Pokemon 6"
            If numPoke >= 6 Then
                pokemonName = "Pokemon = " & Form1.pokemonSixName_txtBox.Text.ToUpper & "," & Form1.pokemonSixLvl_txtBox.Text & vbCrLf
                If Form1.pokemonSixForm_txtBox.Text = "" Then
                    pokemonForm = ""
                ElseIf Not Form1.pokemonSixForm_txtBox.Text = "" Then
                    pokemonForm = "    Form = " & Form1.pokemonSixForm_txtBox.Text & vbCrLf
                End If
                If Form1.pokemonSixNickname_txtBox.Text = "" Then
                    pokemonNickname = ""
                ElseIf Not Form1.pokemonSixNickname_txtBox.Text = "" Then
                    pokemonNickname = "    Name = " & Form1.pokemonSixNickname_txtBox.Text & vbCrLf
                End If
                If Form1.pokemonSixItem_txtBox.Text.ToUpper = "" Then
                    heldItem = ""
                ElseIf Not Form1.pokemonSixItem_txtBox.Text.ToUpper = "" Then
                    heldItem = "    Item = " & Form1.pokemonSixItem_txtBox.Text.ToUpper & vbCrLf
                End If
                If Form1.pokemonSixGender_cmb.SelectedItem = "(random)" Then
                    gender = ""
                ElseIf Not Form1.pokemonSixGender_cmb.SelectedItem = "(random)" Then
                    gender = "    Gender = " & Form1.pokemonSixGender_cmb.SelectedItem & vbCrLf
                End If
                If Form1.pokemonSixShiny_rad.Checked = True And Form1.pokemonSixShinyFalse_rad.Checked = False Then
                    shinyString = "    Shiny = yes" & vbCrLf
                ElseIf Form1.pokemonSixShiny_rad.Checked = False And Form1.pokemonSixShinyFalse_rad.Checked = True Then
                    shinyString = "    Shiny = no" & vbCrLf
                End If
                If Form1.pokemonSixShadow_rad.Checked = True And Form1.pokemonSixShadowFalse_rad.Checked = False Then
                    shadowString = "    Shadow = yes" & vbCrLf
                ElseIf Form1.pokemonSixShadow_rad.Checked = False And Form1.pokemonSixShadowFalse_rad.Checked = True Then
                    shadowString = "    Shadow = no" & vbCrLf
                End If

                ' Move Handler
                For Each move In Form1.pokemonSixMoves_lst.Items
                    AllMoves &= move.ToString.ToUpper & ","
                Next

                If Form1.pokemonSixMoves_lst.Items.Count = 0 Then
                    MessageBox.Show("You need to add at least one move to " & Form1.pokemonSixName_txtBox.Text.ToUpper & " (Pokemon 6).", "Cannot Create Team", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    AllMoves = AllMoves.Substring(0, AllMoves.Length - 1)
                End If

                'Take all moves, and turn it into the move format
                AllMoves = "    Moves = " & AllMoves & vbCrLf

                pokemonAbility = "    Ability = " & Form1.pokemonSixAbility_cmb.SelectedItem.ToString & vbCrLf
                If Form1.pokemonSixNature_cmb.SelectedItem = "(random)" Then
                    pokemonNature = ""
                ElseIf Not Form1.pokemonSixNature_cmb.SelectedItem = "(random)" Then
                    pokemonNature = "    Nature = " & Form1.pokemonSixNature_cmb.SelectedItem & vbCrLf
                End If
                pokemonIVs = "    IVs = " & Form1.pokemonSixIVsHP_txt.Text & "," & Form1.pokemonSixIVsATK_txt.Text & "," & Form1.pokemonSixIVsDEF_txt.Text & "," & Form1.pokemonSixIVsSPD_txt.Text & "," & Form1.pokemonSixIVsSPATK_txt.Text & "," & Form1.pokemonSixIVsSPDEF_txt.Text & vbCrLf
                pokemonEVs = "    EVs = " & Form1.pokemonSixEVsHP_txt.Text & "," & Form1.pokemonSixEVsATK_txt.Text & "," & Form1.pokemonSixEVsDEF_txt.Text & "," & Form1.pokemonSixEVsSPD_txt.Text & "," & Form1.pokemonSixEVsSPATK_txt.Text & "," & Form1.pokemonSixEVsSPDEF_txt.Text & vbCrLf
                If Form1.pokemonSixHappyness_txtBox.Text = "" Then
                    pokemonHappyness = "    Happiness = 70" & vbCrLf
                ElseIf Not Form1.pokemonSixHappyness_txtBox.Text = "" Then
                    pokemonHappyness = "    Happiness = " & Form1.pokemonSixHappyness_txtBox.Text & vbCrLf
                End If
                pokeballID = "    Ball = " & Form1.pokemonSixPokeballID_cmb.SelectedItem & vbCrLf
                output = pokemonName & pokemonForm & pokemonNickname & heldItem & gender & pokemonAbility & AllMoves & pokemonNature & pokemonIVs & pokemonEVs & pokemonHappyness & pokeballID
                Form1.outputBox_rchBox.Text &= output & vbCrLf
            End If
#End Region
        Catch ex As Exception
            MessageBox.Show("Oh no!" & vbCrLf & ex.ToString, "Error")
        End Try
    End Sub

End Class
