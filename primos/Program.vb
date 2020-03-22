Imports System

Module Program

    Public Function esPrimo(x As Integer)
        Dim i = x - 1
        Dim primo = True

        While x > 1 And primo = True
            If x Mod i = 0 Then
                primo = False
            Else
                x -= 1
            End If
        End While

        Return primo
    End Function

    Public Sub Main(args As String())

        Dim num = 7

        Console.WriteLine(esPrimo(num))

    End Sub
End Module
