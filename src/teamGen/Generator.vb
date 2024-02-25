Imports System.CodeDom.Compiler

Public Class Generator

    ''' <summary>
    ''' Used for generating the Pokemon. This generates in the format of Essentials 18, or higher.
    ''' </summary>
    ''' <param name="pkmnName">Get the name of the Pokemon</param>
    ''' <param name="heldItem">Get the Held Item of the Pokemon</param>
    ''' <param name="lvl">Get the Level of the Pokemon</param>
    ''' <param name="ability">Get the Ability of the Pokemon</param>
    ''' <param name="pkmnGender">Get the gender of the Pokemon</param>
    ''' <param name="form">Get the form of the Pokemon. Pass only an integer.</param>
    ''' <param name="nature">Get the nature of the Pokemon.</param>
    ''' <param name="happiness">Get the Happiness of the Pokemon. Pass only an integer.</param>
    ''' <param name="nickname">Get the nickname of the Pokemon</param>
    ''' <param name="pokeBall">Get the PokeBall of the Pokemon</param>
    ''' <param name="shiny">Get the Shiny of the Pokemon. Pass only a Boolean.</param>
    ''' <param name="superShiny">Get the Super Shiny of the Pokemon. Pass only a Boolean.</param>
    ''' <param name="shadow">Get the shadow of the Pokemon. Pass only a Boolean.</param>
    ''' 
    ''' <param name="Moves">Get the First Move of the Pokemon</param>
    ''' 
    ''' <param name="IVs">Get the IVs for the Pokemon. Pass as array.</param>
    ''' 
    ''' <param name="EVs">Get the EVs for the Pokemon. Pass as array.</param>
    ''' <returns>A formatted string that should be added to the output.</returns>
    Public Shared Function essentials18(ByVal pkmnName As String, ByVal heldItem As String, ByVal lvl As Integer,
                                   ByVal ability As String, ByVal pkmnGender As String, ByVal form As String,
                                   ByVal nature As String, ByVal happiness As Integer, ByVal nickname As String,
                                   ByVal pokeBall As String, ByVal shiny As Boolean, ByVal superShiny As Boolean,
                                   ByVal shadow As Boolean, ByVal Moves As String(), ByVal IVs As Integer(),
                                   ByVal EVs As Integer())
        Dim output As String = ""
        ' Used for indenting stuff.
        ' Honestly makes soring easier for me.
        Dim Indent As String = "    "

        ' Pokemon = POKEMON,lvl
        Dim pkmn As String = "Pokemon = " & pkmnName.ToUpper & "," & lvl & vbCrLf

        ' Form = form
        Dim pkmnForm As String = If(Not String.IsNullOrEmpty(form), Indent & "Form = " & form & vbCrLf, "")

        ' Name = nickname
        Dim name As String = If(Not String.IsNullOrEmpty(nickname), Indent & "Nickname = " & nickname & vbCrLf, "")

        ' Item = heldItem
        Dim item As String = If(Not String.IsNullOrEmpty(heldItem), Indent & "Item = " & heldItem & vbCrLf, "")

        ' Gender = pkmnGender
        Dim gender As String = If(pkmnGender <> "Random", Indent & "Gender = " & pkmnGender & vbCrLf, "")

        ' Ability = ability
        Dim PKMNAbility As String = If(Not String.IsNullOrEmpty(ability), Indent & "Item = " & ability & vbCrLf, "")

        ' Moves = Move1,Move2,Move3,Move4
        Dim MoveString As String = ""
        Dim validMoves As New List(Of String)
        For Each move As String In Moves
            If Not String.IsNullOrEmpty(move) AndAlso validMoves.Count < 4 Then
                validMoves.Add(move)
            End If
        Next

        ' Print MoveString
        If validMoves.Count > 0 Then
            MoveString = Indent & "Moves = " & String.Join(",", validMoves) & vbCrLf
        Else
            Return "Failed to get moves. Make sure they are a part of an array."
        End If

        'IV = HP,ATK,DEF,SPD,SPATK,SPDEF
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''HP,ATK,DEF,SPD,SPATK,SPDEF
        Dim IVsString As String = String.Format(Indent & "IV = {0},{1},{2},{3},{4},{5}" & vbCrLf,
                                                IVs(0), IVs(1), IVs(2), IVs(3), IVs(4), IVs(5))

        'EV = HP,ATK,DEF,SPD,SPATK,SPDEF
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''HP,ATK,DEF,SPD,SPATK,SPDEF
        Dim EVsString As String = String.Format(Indent & "EV = {0},{1},{2},{3},{4},{5}" & vbCrLf,
                                                EVs(0), EVs(1), EVs(2), EVs(3), EVs(4), EVs(5))

        output = pkmn & pkmnForm & name & gender & item & PKMNAbility & MoveString & EVsString & IVsString

        Return output
    End Function


    ''' <summary>
    ''' Used for generating the Pokemon. This generates in the format of Essentials 17, or higher.
    ''' </summary>
    ''' <param name="pkmnName">Get the name of the Pokemon</param>
    ''' <param name="heldItem">Get the Held Item of the Pokemon</param>
    ''' <param name="lvl">Get the Level of the Pokemon</param>
    ''' <param name="ability">Get the Ability of the Pokemon</param>
    ''' <param name="pkmnGender">Get the gender of the Pokemon</param>
    ''' <param name="form">Get the form of the Pokemon. Pass only an integer.</param>
    ''' <param name="nature">Get the nature of the Pokemon.</param>
    ''' <param name="happiness">Get the Happiness of the Pokemon. Pass only an integer.</param>
    ''' <param name="nickname">Get the nickname of the Pokemon</param>
    ''' <param name="pokeBall">Get the PokeBall of the Pokemon</param>
    ''' <param name="shiny">Get the Shiny of the Pokemon. Pass only a Boolean.</param>
    ''' <param name="shadow">Get the shadow of the Pokemon. Pass only a Boolean.</param>
    ''' 
    ''' <param name="ivHP">Get the HP IV for the Pokemon. Pass only an integer.</param>
    ''' <param name="ivATK">Get the ATK IV for the Pokemon. Pass only an integer.</param>
    ''' <param name="ivDEF">Get the DEF IV for the Pokemon. Pass only an integer.</param>
    ''' <param name="ivSPD">Get the SPD IV for the Pokemon. Pass only an integer.</param>
    ''' <param name="ivSPATK">Get the SPATK IV for the Pokemon. Pass only an integer.</param>
    ''' <param name="ivSPDEF">Get the SPDEF IV for the Pokemon. Pass only an integer.</param>
    ''' 
    ''' <param name="evHP">Get the HP EV for the Pokemon. Pass only an integer.</param>
    ''' <param name="evATK">Get the ATK EV for the Pokemon. Pass only an integer.</param>
    ''' <param name="evDEF">Get the DEF EV for the Pokemon. Pass only an integer.</param>
    ''' <param name="evSPD">Get the SPD EV for the Pokemon. Pass only an integer.</param>
    ''' <param name="evSPATK">Get the SPATK EV for the Pokemon. Pass only an integer.</param>
    ''' <param name="evSPDEF">Get the SPDEF EV for the Pokemon. Pass only an integer.</param>
    ''' <returns>A formatted string that should be added to the output.</returns>
    Public Shared Function essentials17(ByVal pkmnName As String, ByVal heldItem As String, ByVal lvl As Integer,
                                   ByVal ability As String, ByVal pkmnGender As String, ByVal form As String,
                                   ByVal nature As String, ByVal happiness As Integer, ByVal nickname As String,
                                   ByVal pokeBall As String, ByVal shiny As Boolean, ByVal shadow As Boolean,
                                   ByVal ivHP As Integer, ByVal ivATK As Integer, ByVal ivDEF As Integer,
                                   ByVal ivSPD As Integer, ByVal ivSPATK As Integer, ByVal ivSPDEF As Integer,
                                   ByVal evHP As Integer, ByVal evATK As Integer, ByVal evDEF As Integer,
                                   ByVal evSPD As Integer, ByVal evSPATK As Integer, ByVal evSPDEF As Integer)

    End Function


    Public Shared Function trainer18(ByVal trainerName As String, ByVal trainerType As String, ByVal loseText As String,
                                     ByVal loseTextQuotes As Boolean, Optional ByVal battleTeamID As Integer = 0)
        Dim Output As String = ""

        ' [trainerType,trainerName,battleID]
        Dim name As String = ""
        Dim type As String = ""
        Dim id As String = ""

        ' Battle Team ID
        If battleTeamID = 0 Then
            id = ""
        Else
            id = "," & battleTeamID
        End If

        ' Trainer Type and name
        type = "[" & trainerType.ToUpper & ","
        name = trainerName & id & "]"

        Output = type & name

        Return Output
    End Function

    Public Shared Function trainer17(ByVal trainerName As String, ByVal trainerType As String, ByVal loseText As String,
                                     ByVal pokeNumber As Integer, Optional ByVal battleTeamID As Integer = 0)
        Dim output As String = ""

        output = trainerType.ToUpper & vbCrLf & trainerName & vbCrLf & pokeNumber.ToString

        Return output
    End Function

End Class
