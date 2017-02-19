Public Class print
    Dim input As String
    Function exec()
        Console.WriteLine("Blue [Y/N]")
        If GetInputYesNo() = True Then
            Console.Write("write")
            GetInput()
            ctext(input, ConsoleColor.Blue)
        Else
            Console.Write("write")
            GetInput()
            SetInput(input)
            Console.WriteLine(input)
        End If
    End Function


End Class
