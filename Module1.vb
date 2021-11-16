Module Module1

    Sub Main()

        Dim Str1, VowStr As String
        Dim ThisChar As Char
        Dim VowTimes As Integer

        VowStr = "AEIOUaeiou"
        VowTimes = 0

        Console.Write("Enter string to be processed: ")
        Str1 = Console.ReadLine

        For a = 1 To Len(Str1)
            ThisChar = Mid(Str1, a, 1)
            If InStr(VowStr, ThisChar) Then
                VowTimes = VowTimes + 1

            End If
        Next

        Console.WriteLine(" Number of vowels in entered string are: " & VowTimes)
        Console.ReadKey()
    End Sub

End Module
