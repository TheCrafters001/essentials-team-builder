Imports teamGen

Module Program
    Sub Main(args As String())

        Console.WriteLine(Generator.essentials18("Bulbasaur", "", 5, "Overgrow", "male", 0, "Nature", 256, "Nickname", "PokeBall", True, False, False, {"move1", "move2", "Move3", "move4"}, {1, 2, 3, 4, 5, 6}, {7, 8, 9, 10, 11, 12}))
        Console.WriteLine(Generator.essentials17("Bulbasaur", "", 5, 1, 1, 0, "Nature", 256, "Nickname", 1, True, False, {"move1", "move2", "Move3", "move4"}, 31))
        Console.WriteLine("Test Success!")

    End Sub
End Module
