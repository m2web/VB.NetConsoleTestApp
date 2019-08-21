Public Module HelloBIS305

    Sub Main()
        Dim message As New Message()
        Console.WriteLine(message.CreateMessage())
        Console.Write("What is your name? ")
        Dim strName As String = Console.ReadLine()
        Console.WriteLine(message.SayHello(strName))
        Console.WriteLine("Press any key to exit.")
        Console.ReadKey()
    End Sub

End Module
