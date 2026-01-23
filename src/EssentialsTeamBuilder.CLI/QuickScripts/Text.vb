Public Class Text
    Public Shared Sub Write(ByVal text As String)
        Console.Write(text)
    End Sub

    Public Shared Sub WriteLine(ByVal text As String)
        Console.WriteLine(text)
    End Sub

    Public Shared Sub Color(ByVal Color As ConsoleColor)
        Console.ForegroundColor = Color
    End Sub

    Public Shared Sub BGColor(ByVal Color As ConsoleColor)
        Console.BackgroundColor = Color
    End Sub

    Public Shared Sub ResetColor()

        'Use Foreground Color after to prevent issues with colors not resetting correctly.

        Console.ResetColor()
        Console.ForegroundColor = ConsoleColor.White
    End Sub
End Class
