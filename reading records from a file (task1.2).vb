﻿Module Module1

    Sub Main()
        Dim name As String
        Dim memberID As Integer
        name = ""
        memberID = 0
        FileOpen(1, "memberinfo.txt", OpenMode.Input)
        While Not EOF(1)
            Input(1, name)
            Input(1, memberID)
            Console.WriteLine("member name:" & name)
            Console.WriteLine(" memberID:" & memberID)
        End While
        FileClose(1)
        Console.ReadKey()
    End Sub

End Module
