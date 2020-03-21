Imports System

Module Program
    Private i As Integer
    Private j As Integer


    ' Funcion para saber si dos palabra están compuestas por las mismas letras
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
                        ' Console.WriteLine("PALABRA1: " + palabra1 + " PALABRA2: " + palabra2)
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

    Public Function separar(ciudades As String())

        Dim iguales As Boolean
        Dim multiLista As New List(Of List(Of String))
        Dim lista As New List(Of String)

        lista.Add(ciudades(0))
        multiLista.Add(lista)

        ' Console.WriteLine(multiLista(0)(0))

        For i As Integer = 1 To ciudades.Length - 1
            Dim j = 0
            Dim salir = False
            While j < multiLista.Count And salir = False
                iguales = mismasLetras(ciudades(i), multiLista(j)(0))
                If iguales = True Then
                    multiLista(j).Add(ciudades(i))
                    salir = True
                Else
                    j += 1
                End If

            End While

            If salir = False Then
                multiLista.Add(New List(Of String) From {ciudades(i)})
            End If

        Next

        Return multiLista

    End Function

    Public Sub Main(args As String())
        ' Dim iguales = mismasLetras("tokyo", "kyoto")

        Dim ciudades = New String() {"tokyo", "london", "rome", "donlon", "kyoto", "paris"}

        Dim res As List(Of List(Of String))
        res = separar(ciudades)

        For i As Integer = 0 To res.Count - 1
            Dim ciu = ""
            For j As Integer = 0 To res(i).Count - 1
                ciu = ciu + res(i)(j) + " "
            Next
            Console.WriteLine(ciu)
        Next
    End Sub
End Module