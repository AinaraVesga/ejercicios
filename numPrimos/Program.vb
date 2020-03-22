Imports System

Module Program

    Public Function esPrimo(x As Integer)
        Dim i = x - 1
        Dim primo = True

        While i > 1 And primo = True
            Console.WriteLine(i)
            If x Mod i = 0 Then
                primo = False
            Else
                i -= 1
            End If
        End While

        Return primo
    End Function

    Public Sub Main(args As String())
        Dim x = 8
        Console.WriteLine(esPrimo(x))
    End Sub
End Module
