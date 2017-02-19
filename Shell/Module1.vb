Module Module1

    ' //////////
    ' Variables
    ' //////////
    Dim input As String
    Dim running As Boolean = True
    Dim debug As Boolean = False
    Dim defaultcolor As ConsoleColor = ConsoleColor.Gray
    Dim exampleprog As New exampleprog
    Dim print As New print

    Sub Main()
        prepstart(debug)
    End Sub
    ' ///////////
    ' Core Stuff
    ' ///////////
    Function GetInput()
        Console.Write(">")
        input = Console.ReadLine()
        If input = "" Then
            Return False
        End If
        Return True
    End Function
    Function SetInput(ByRef s As String)
        s = input
    End Function
    Function GetInputYesNo()
        GetInput()
        If input = "y" Then
            Return True
        ElseIf input = "n" Then
            Return False
        Else
            ctext("You did not answer [Y/N] properly. Assuming yes.", ConsoleColor.Red)
            Return True
        End If
    End Function
    Function ctext(text As String, color As ConsoleColor)
        Console.ForegroundColor = color
        Console.WriteLine(text)
        Console.ForegroundColor = defaultcolor
    End Function
    Function prepstart(debug As Boolean)
        If debug Then ctext("Debug", ConsoleColor.Green)
        Console.Title = "Shell"
        If debug Then Console.Title = "Shell (Debug)"
        Shell() 'All set, lets launch the shell.
        Return True
    End Function
    '//////
    'Shell
    '//////
    'Programs are in their own vb files. We execute them in the shell.
    'Above are not programs. They are core functions.

    Function Shell()
        While running
            GetInput()
            If input.ToLower = "print" Then
                print.exec()
            Else
                ctext(input, ConsoleColor.Blue)
            End If
        End While
        running = False
        Return True
        Environment.Exit(0)
    End Function

End Module
