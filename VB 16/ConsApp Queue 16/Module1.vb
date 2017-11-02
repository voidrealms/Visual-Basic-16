Module Module1

    Sub Main()

        'queue - first in is first out. like a bank line
        Dim Line As Queue(Of String) = New Queue(Of String)

        Line.Enqueue("bob")
        Line.Enqueue("mary")
        Line.Enqueue("chad")


        Console.WriteLine("count =" & Line.Count)
        Console.WriteLine(Line.Dequeue)
        Console.WriteLine("count =" & Line.Count)


        Console.ReadLine()
    End Sub

End Module
