Module Module1

    Sub Main()
        Dim name As String
        Dim memberID As Integer
        Dim teleno As Integer
        Dim address As String
        name = ""
        memberID = 0
        teleno = 0
        address = ""

        FileOpen(1, "memberinfo.txt", OpenMode.Input)
        FileOpen(2, "memberinfo2.txt", OpenMode.Output)
        While Not EOF(1)

            Input(1, name)
            Input(1, memberID)
            Console.WriteLine("member name:" & name)
            Console.WriteLine("member ID:" & memberID)

            Console.Write("enter telephone number:")
            teleno = Console.ReadLine
            Console.Write("enter address:")
            address = Console.ReadLine
            Console.WriteLine()

            WriteLine(2, name)
            WriteLine(2, memberID)
            WriteLine(2, teleno)
            WriteLine(2, address)

        End While
        FileClose(1)
        FileClose(2)

    End Sub

End Module
