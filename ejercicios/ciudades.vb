Module ciudades
    Private i As Integer
    Private j As Integer

    Public Function mismasLetras(palabra1 As String, palabra2 As String)
        i = 0
        j = 0
        If (palabra1.Length <> palabra2.Length) Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub Main(args As String())
        Dim iguales = mismasLetras("ainara", "elena")
        Console.WriteLine(iguales)
    End Sub

End Module
