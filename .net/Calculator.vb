Imports System

Namespace Test
    Public Class Calculator
        Public Shared Sub Main(ByVal args As String())
            Dim a As Integer
            Dim b As Integer
            Dim result As Integer
            Dim operation As String
            Console.Write("enter the first num")
            a = Convert.ToInt32(Console.ReadLine())
            Console.Write("enter the second num")
            b = Convert.ToInt32(Console.ReadLine())
            Console.Write("enter the operation x + - *")
            operation = Console.ReadLine()

            Select Case operation
                Case "x"
                    result = a * b
                    Console.WriteLine(a & "/" & b & "=" & result)
                    Console.ReadLine()
                Case "/"
                    result = a / b
                    Console.WriteLine(a & "/" & b & "=" & result)
                    Console.ReadLine()
                Case "+"
                    result = a + b
                    Console.WriteLine(a & "+" & b & "=" & result)
                    Console.ReadLine()
                Case "-"
                    result = a - b
                    Console.WriteLine(a & "-" & b & "=" & result)
                    Console.ReadLine()
            End Select
        End Sub
    End Class
End Namespace
