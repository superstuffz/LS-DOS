Module Module1
    Sub Main()
        System.Console.WriteLine("Starting LS-DOS...")
        Threading.Thread.Sleep(1000)
        System.Console.Clear()
        System.Console.ForegroundColor = ConsoleColor.Green
        System.Console.WriteLine("Welcome to LS-DOS, " & My.Settings.username & " Check out all of the commands by using help!")
        Terminal.Main()
    End Sub
End Module
