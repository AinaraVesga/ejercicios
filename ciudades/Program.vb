Imports System

Module Program
    Private i As Integer
    Private j As Integer

    Public Function mismasLetras(palabra1 As String, palabra2 As String)

        If (palabra1.Length <> palabra2.Length) Then
            Return False
        Else
            i = 1
            j = 1
            Dim iguales As Boolean
            Dim esta As Boolean

            iguales = True

            While i < palabra1.Length + 1 And iguales = True
                Dim letra1 = GetChar(palabra1, i)
                esta = False
                j = 1
                While j < palabra2.Length + 1 And esta = False
                    Dim letra2 = GetChar(palabra2, j)
                    If letra1 <> letra2 Then
                        j += 1
                    Else
                        palabra2 = Replace(palabra2, letra2, "", 1, 1)
                        Console.WriteLine("PALABRA1: " + palabra1 + " PALABRA2: " + palabra2)
                        esta = True
                    End If
                End While
                If esta = False Then
                    iguales = False
                End If

                i += 1
            End While

            If palabra2 Like "" Then
                Return True
            Else
                Return False
            End If

        End If
    End Function

    Public Sub Main(args As String())
        Dim iguales = mismasLetras("tokyo", "kyoto")
        Console.WriteLine(iguales)
    End Sub
End Module
