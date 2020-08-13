Public Class Generator
    ' Generator Code Sample
    ' 
    ' #-------------------------------
    ' TRAINERTYPE
    ' Trainer Name,ID
    ' # of PKMN
    ' POKEMON,LVL,HELDITEM,MOVE1,MOVE2,MOVE3,MOVE4,ABILITY#,M/F,FORM#,shiny,NATURE,IVs,HAPPYNESS,NickName,SHADOW (true/false),POKEBALLID
#Region "One Pokemon"
    Public Shared Sub OnePokemon()
        Try
            Dim pokemonName As String
            Dim heldItem As String
            Dim lvl As String
            Dim move1 As String
            Dim move2 As String
            Dim move3 As String
            Dim move4 As String
            Dim pokemonAbility As Integer
            Dim gender As String
            Dim pokemonForm As Integer
            Dim shiny As Boolean
            Dim pokemonNature As String
            Dim pokemonIVs As Integer
            Dim pokemonHappyness As Integer
            Dim pokemonNickname As String
            Dim shadow As Boolean
            Dim pokeballID As Integer

        Catch ex As Exception
            MessageBox.Show("Oh no!" & vbCrLf & ex.ToString, "Error")
        End Try
    End Sub
#End Region

End Class
