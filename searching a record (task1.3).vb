Module Module1

    Sub Main()
        Dim name As String
        Dim memberID As Integer
        Dim isfound As Boolean
        Dim searchname As String
        searchname = ""
        isfound = False
        name = ""
        memberID = 0
        Console.Write("enter name to search:")
        searchname = Console.ReadLine
        searchname = UCase(searchname)
        FileOpen(1, "memberinfo.txt", OpenMode.Input)
        While Not EOF(1)
            Input(1, name)
            Input(1, memberID)
            If UCase(name) = searchname Then
                isfound = True
                Console.WriteLine("member name:" & name)
                Console.WriteLine("memberID:" & memberID)
            End If
        End While
        FileClose(1)
        If isfound = False Then
            Console.WriteLine("member name and ID can not be found")
        End If
        Console.ReadKey()
    End Sub

End Module
