Imports System

Module Program

    Public Function producto(m1 As Integer(,), m2 As Integer(,))

        Dim m3 = {{0, 0, 0}, {0, 0, 0}, {0, 0, 0}}

        For i As Integer = 0 To 2
            For j As Integer = 0 To 2
                For k As Integer = 0 To 2
                    m3(i, j) += m1(i, k) * m2(k, j)
                Next
            Next
        Next

        Return m3

    End Function


    Sub Main(args As String())
        Dim m1 = {{1, 2, 3}, {2, 3, 4}, {4, 5, 6}}
        Dim m2 = {{1, 2, 3}, {2, 3, 4}, {4, 5, 6}}
        Dim res = ""

        Dim m3 = producto(m1, m2)

        For i As Integer = 0 To 2
            For j As Integer = 0 To 2
                res += " | " + CStr(m3(i, j)) + " | "
            Next
            Console.WriteLine(res)
            res = ""
        Next


    End Sub
End Module
