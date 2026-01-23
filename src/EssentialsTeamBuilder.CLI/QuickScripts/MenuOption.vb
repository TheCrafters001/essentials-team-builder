Public Class MenuOption
    Public Shared Sub WithColor(ByVal menuNumber As String, ByVal inputText As String, ByVal Color As ConsoleColor)
        Console.Write(" " & menuNumber & ") ")

        Console.ForegroundColor = Color
        Console.WriteLine(inputText)

        Text.ResetColor()
    End Sub


    ''' <summary>
    ''' Use for menu inputs.
    ''' </summary>
    ''' <returns> Returns inputed Integer, otherwise Returns -1 if invalid input, like if a string is detected.</returns>
    Public Shared Function InputHandler()

        'Create new Dim for Menu Selection
        Dim SelectedMenuOption As Integer = Nothing

        Text.Write("Enter an option: ")
        Text.Color(ConsoleColor.Green)
        Try
            SelectedMenuOption = Console.ReadLine()
        Catch ex As Exception
            SelectedMenuOption = -1
        End Try
        Console.ForegroundColor = ConsoleColor.White
        Console.ResetColor()

        Return SelectedMenuOption
    End Function
End Class
