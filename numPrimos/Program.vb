Imports System

Module Program

    Public Function esPrimo(x As Integer)
        Dim i = x - 1
        Dim primo = True

        While i > 1 And primo = True
            ' Console.WriteLine(i)
            If x Mod i = 0 Then
                primo = False
            Else
                i -= 1
            End If
        End While

        Return primo

    End Function

    Public Function primos(num As Integer)

        Dim count = 0

        For i As Integer = 1 To num
            If esPrimo(i) Then
                count += 1
            End If
        Next

        Return count

    End Function

    Public Sub Main(args As String())

        Dim num As Integer

        Console.WriteLine("Introduzca un número: ")
        num = Console.ReadLine()

        Dim count = primos(num)
        Console.WriteLine("Hay " + CStr(count) + " números primos desde 1 hasta " + CStr(num) + ".")


    End Sub
End Module
