Imports System
Imports System.Drawing

Module Program

    Sub Main(args As String())
        TitleShow()

        MainMenu.Show()
    End Sub


    Private Sub TitleShow()
        'Set Title
        Console.Title = "Essentials Team Builder"
        Text.Color(ConsoleColor.Green)
        Text.WriteLine("Essentials Team Builder")

        Text.ResetColor()
        Text.Write("By ")
        Text.Color(ConsoleColor.Green)
        Text.WriteLine("TheCrafters001")

        Text.ResetColor()
        Text.Write("Version ")
        Text.Color(ConsoleColor.Green)
        Text.WriteLine(System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString)

        Console.ForegroundColor = ConsoleColor.White

    End Sub
End Module
