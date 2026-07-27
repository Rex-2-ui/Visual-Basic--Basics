Imports System

Module Program
    Sub Main(args As String())

        ' Console.WriteLine("Hello World!")
        ' Console.Write("GRRR POOOWWW POOWWW")
        ' Console.WriteLine("I am Batman Who are you:")


        ' Dim Name As String = Console.ReadLine()
        'Console.WriteLine("Hello" & Name)

        Dim Num1, Num2 As Double
        Console.WriteLine("Enter First Number")
        Num1 = Console.ReadLine()

        Console.WriteLine("Enter Second Number")
        Num2 = Console.ReadLine()

        Dim Sum As Double = Num1 + Num2
        Console.WriteLine("The sum of " & Num1 & Num2 & "is " & Sum)


        Dim Name As String
        Dim Age As Integer

        Console.WriteLine(" Enter Your Name ")
        Name = Console.ReadLine()

        Console.WriteLine(" How old are You")
        Age = Console.ReadLine()

        If Age < 18 Then
            Console.WriteLine("Wa kyi gu hor, Bare back paaa")
        Else
            Console.WriteLine(" You are elegible for 18+ activities ")
        End If

        Console.WriteLine(" Mrs / Miss" & Name & " Your age is " & Age)


    End Sub
End Module
