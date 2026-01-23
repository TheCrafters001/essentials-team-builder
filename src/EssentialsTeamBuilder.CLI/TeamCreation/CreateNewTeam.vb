Public Class CreateNewTeam
#Region "Global Project Dims"
    ' Pokemon
    Public Shared pkmn1 As Array = {""}
    Public Shared pkmn2 As Array = {""}
    Public Shared pkmn3 As Array = {""}
    Public Shared pkmn4 As Array = {""}
    Public Shared pkmn5 As Array = {""}
    Public Shared pkmn6 As Array = {""}

    ' Number of Pokemon
    ' Prefer 1 to 6, starting at 0 is not prefered.
    Public Shared pkmnNmb As Integer = 1

    'Trainer
    ''' <summary>
    ''' 0 = Trainer Name
    ''' 1 = Trainer Type
    ''' 2 = Trainer Lose Text
    ''' </summary>
    Public Shared trainer As Array = {"", "", ""}

    ''' <summary>
    ''' 
    ''' </summary>
    Public Shared trainerItems As Array = {""}
#End Region

    Public Shared Sub Menu()
        Text.ResetColor()

        Text.WriteLine("=== Create New Team ===")

        ' Trainer Name
        TrainerHandler.Trainer("Name", trainer(0))

        ' Trainer Type
        TrainerHandler.Trainer("Type", trainer(1))

        ' Lose Text
        TrainerHandler.Trainer("Lose Text", trainer(2))

        ' Number of Pokemon
        Text.Write("Number of Pokemon: ")
        Text.Color(ConsoleColor.Green)
        Text.WriteLine(pkmnNmb.ToString())
        Text.ResetColor()

        Text.WriteLine("=======================")
        MenuOption.WithColor(1, "Change Trainer Name", ConsoleColor.Green)
        MenuOption.WithColor(2, "Change Trainer Type", ConsoleColor.Green)
        MenuOption.WithColor(3, "Change Trainer Lose Text", ConsoleColor.Green)
        MenuOption.WithColor(4, "Change Number of Pokemon", ConsoleColor.Green)

        Select Case MenuOption.InputHandler
            Case 1
                trainer(0) = TrainerHandler.ChangeName()
                Text.ResetColor()
                Text.Write("Changed Trainer Name to: ")
                Text.Color(ConsoleColor.Blue)
                Text.WriteLine(trainer(0))
                Text.WriteLine("")
                Text.WriteLine("")
                Text.ResetColor()
                Text.WriteLine("Press any key to continue.")
                Console.ReadKey()
                Console.Clear()
                Menu()

            Case 2
                trainer(1) = TrainerHandler.ChangeType()
                Text.ResetColor()
                Text.Write("Changed Trainer Type to: ")
                Text.Color(ConsoleColor.Blue)
                Text.WriteLine(trainer(1))
                Text.WriteLine("")
                Text.WriteLine("")
                Text.ResetColor()
                Text.WriteLine("Press any key to continue.")
                Console.ReadKey()
                Console.Clear()
                Menu()


            Case 3
                trainer(2) = TrainerHandler.ChangeLoseText()
                Text.ResetColor()
                Text.Write("Changed Trainer Lose Text to: ")
                Text.Color(ConsoleColor.Blue)
                Text.WriteLine(trainer(2))
                Text.WriteLine("")
                Text.WriteLine("")
                Text.ResetColor()
                Text.WriteLine("Press any key to continue.")
                Console.ReadKey()
                Console.Clear()
                Menu()

            Case 4
                pkmnNmb = TrainerHandler.ChangePkmnNmb()
                Text.ResetColor()
                Text.Write("Changed Number of Pokemon to: ")
                Text.Color(ConsoleColor.Blue)
                Text.WriteLine(pkmnNmb)
                Text.WriteLine("")
                Text.WriteLine("")
                Text.ResetColor()
                Text.WriteLine("Press any key to continue.")
                Console.ReadKey()
                Console.Clear()
                Menu()

            Case Else
                ' Clear Console For Cleaner Menu
                Console.Clear()
                Console.ForegroundColor = ConsoleColor.DarkRed
                Text.WriteLine("You entered an option that is not listed above, left the field empty, or is not a number.")
                Text.WriteLine("(Error: Invalid_Main_Menu_Input)")
                Menu()

        End Select

    End Sub

End Class
