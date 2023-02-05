Public Class Generator
    ' Okay, so, I know there is a perfectly good generator in the other projects, but it has a problem with the
    ' "Don't Repeat Yourself". Like, a big problem, so this new generator is supposed to fix that,
    ' Where you can just input the info for the same DIMs above.
    ' Example:
    '       create18Team("PokemonName", "HeldItems", "AllMoves", ...)
    '
    ' There will also be a separate function for the Trainer info specifically, this new code also
    ' is going to have a much different way of handling errors.

    ''' <summary>
    ''' Create a team for Pokemon Essentials 18-20.
    ''' </summary>
    ''' <param name="pokemonName"></param>
    ''' <param name="pokemonLevel"></param>
    ''' <param name="moves"></param>
    ''' <param name="pokemonAbility"></param>
    ''' <param name="pokemonGender"></param>
    ''' <param name="pokemonForm"></param>
    ''' <param name="isShiny"></param>
    ''' <param name="pokemonNature"></param>
    ''' <param name="pokemonIVsHP"></param>
    ''' <param name="pokemonIVsATT"></param>
    ''' <param name="pokemonIVsDEF"></param>
    ''' <param name="pokemonIVsSPATT"></param>
    ''' <param name="pokemonIVsSPDEF"></param>
    ''' <param name="pokemonIVsSPD"></param>
    ''' <param name="pokemonEVsHP"></param>
    ''' <param name="pokemonEVsATT"></param>
    ''' <param name="pokemonEVsDEF"></param>
    ''' <param name="pokemonEVsSPATT"></param>
    ''' <param name="pokemonEVsSPDEF"></param>
    ''' <param name="pokemonEVsSPD"></param>
    ''' <param name="pokemonHappyness"></param>
    ''' <param name="pokemonNickname"></param>
    ''' <param name="isShadow"></param>
    ''' <param name="pokeballID"></param>
    Public Shared Function create18Team(ByVal pokemonName As String, ByVal pokemonLevel As String, ByVal moves As IList, ByVal pokemonAbility As String,
                                   ByVal pokemonGender As String, ByVal pokemonForm As String, ByVal isShiny As Boolean, ByVal pokemonNature As String,
                                   ByVal pokemonIVsHP As String, ByVal pokemonIVsATT As String, ByVal pokemonIVsDEF As String, ByVal pokemonIVsSPATT As String,
                                   ByVal pokemonIVsSPDEF As String, ByVal pokemonIVsSPD As String,
                                   ByVal pokemonEVsHP As String, ByVal pokemonEVsATT As String, ByVal pokemonEVsDEF As String, ByVal pokemonEVsSPATT As String,
                                   ByVal pokemonEVsSPDEF As String, ByVal pokemonEVsSPD As String,
                                   ByVal pokemonHappyness As String, ByVal pokemonNickname As String, ByVal isShadow As Boolean, ByVal pokeballID As String)
        '
        ' WARNING: THIS GENERATOR MAY BE COMPLETELY REWRITTEN AT SOME POINT.
        ' PLEASE KEEP THIS IN MIND.
        '
        ' Generator Code Sample
        ' 
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

        Dim output As String = ""

        ' Add all the easy stuff first.
        output = "Pokemon = " & pokemonName & "," & pokemonLevel & vbCrLf
        output &= "    Name = " & pokemonNickname & vbCrLf
        output &= "    Form = " & pokemonForm & vbCrLf
        output &= "    Gender = " & pokemonGender & vbCrLf

        ' Check to see if Shiny and Shadow are enabled.
        Dim shadowString As String = ""
        Dim shinyString As String = ""

        If isShiny = False Then
            shinyString = "No"
        ElseIf isShiny = True Then
            shinyString = "Yes"
        End If

        If isShadow = False Then
            shadowString = "No"
        ElseIf isShadow = True Then
            shadowString = "Yes"
        End If

        ' Get back to the easy stuff,
        output &= "    Shiny = " & shinyString & vbCrLf
        output &= "    Shadow = " & shadowString & vbCrLf


        Return output

    End Function

    Public Shared Function create17Team()

    End Function

    Public Shared Function createTrainer()
        '
        ' Trainer Code Example
        '
        ' [TYPE,Name,ID]
        ' Items = ITEM,ITEM2,ITEM3,ITEM4,ITEM5,ITEM6,ITEM7,ITEM8
        ' LoseText = "Lose Text"
        ' # If Essentials 20, don't use quotes for lose text.
    End Function

End Class
