Imports System.Net.Security

Public Class MainMenu
    Public Shared Sub Show()

        'Reset in case the menu is called
        Text.ResetColor()

        'Padding
        Text.WriteLine("")
        Text.WriteLine("")

        'Welcome Text
        Text.WriteLine("Welcome! What do you want to do?")
        Text.WriteLine("Red = Not Implimented")
        Text.WriteLine("")

        'Menu
        MenuOption.WithColor("1", "Create New Team", ConsoleColor.Green)
        MenuOption.WithColor("2", "Update Existing Team", ConsoleColor.Red)
        MenuOption.WithColor("0", "Quit", ConsoleColor.Green)

        'Splitter
        Text.WriteLine("===========================")

        'Menu Selection. Use Console.ReadLine in Try to catch in case there is an invalid string entry.

        Select Case MenuOption.InputHandler
            Case 1
                Console.Clear()
                CreateNewTeam.Menu()

            Case Else
                ' Clear Console For Cleaner Menu
                Console.Clear()
                Console.ForegroundColor = ConsoleColor.DarkRed
                Text.WriteLine("You entered an option that is not listed above, left the field empty, or is not a number.")
                Text.WriteLine("(Error: Invalid_Main_Menu_Input)")
                Show()

        End Select

    End Sub
End Class
