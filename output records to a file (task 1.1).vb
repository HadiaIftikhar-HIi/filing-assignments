Module Module1

    Sub Main()
        Dim name As String
        Dim memberID As Integer
        Dim more As Char
        more = "N"
        name = ""
        memberID = 0
        FileOpen(1, "studentinfo.txt", OpenMode.Output)
        Do
            Console.Write("Enter name:")
            name = Console.ReadLine
            Console.Write("Enter memberID:")
            memberID = Console.ReadLine
            WriteLine(1, name)
            WriteLine(1, memberID)

            Console.Write("Do you want to enter another record?(y/n):")
            more = Console.ReadLine
        Loop Until UCase(more) = "N"
        FileClose(1)
    End Sub

End Module
