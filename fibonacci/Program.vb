Imports System

Module Program

    Public Function fibonacci(n As Integer)
        If n = 1 Then
            Return 1
        ElseIf n = 2 Then
            Return 1
        Else
            Return fibonacci(n - 1) + fibonacci(n - 2)
        End If
    End Function

    Public Sub Main(args As String())

        Dim n = 30
        Dim res As Integer
        Dim resul = ""

        For i As Integer = n To 1 Step -1
            res = fibonacci(i)
            resul = CStr(res) + " - " + resul
        Next

        Console.WriteLine(resul)

    End Sub
End Module
