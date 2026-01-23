Public Class TrainerHandler
    Public Shared Sub Trainer(ByVal inputText As String, ByVal trainerValue As String)
        Text.Write("Trainer " & inputText & ": ")
        Text.Color(ConsoleColor.Green)

        If trainerValue = "" Then
            Text.WriteLine("(empty)")
        Else
            Text.WriteLine(trainerValue)
        End If

        Text.ResetColor()

    End Sub

    Public Shared Function ChangeName()
        Text.ResetColor()
        Text.Write("Enter new Trainer Name: ")
        Text.Color(ConsoleColor.Blue)

        Dim name As String = Console.ReadLine()

        Return name
    End Function

    Public Shared Function ChangeType()
        Text.ResetColor()
        Text.Write("Enter new Trainer Type: ")
        Text.Color(ConsoleColor.Blue)

        Dim type As String = Console.ReadLine()

        Return type
    End Function


    Public Shared Function ChangeLoseText()
        Text.ResetColor()
        Text.Write("Enter new Trainer Lose Text: ")
        Text.Color(ConsoleColor.Blue)

        Dim loseText As String = Console.ReadLine()

        Return loseText
    End Function

    Public Shared Function ChangePkmnNmb()
        Text.ResetColor()
        Text.Write("Enter new Number of Pokemon: ")
        Text.Color(ConsoleColor.Blue)

        Dim nmb As Integer
        Try
            nmb = Console.ReadLine()
        Catch ex As Exception
            nmb = -1
        End Try

        If nmb >= 7 Or nmb <= 0 Then
            Text.WriteLine("You have entered an invalid number. Please enter in a number between 1 and 6.")
            ChangePkmnNmb()
        End If


        Return nmb
    End Function
End Class
