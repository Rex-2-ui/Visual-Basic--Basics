Imports System

Module Program
    Sub Main(args As String())

        ' Console.WriteLine("Hello World!")
        ' Console.Write("GRRR POOOWWW POOWWW")
        ' Console.WriteLine("I am Batman Who are you:")


        ' Dim Name As String = Console.ReadLine()
        'Console.WriteLine("Hello" & Name)

        'Dim Num1, Num2 As Double
        'Console.WriteLine("Enter First Number")
        'Num1 = Console.ReadLine()

        'Console.WriteLine("Enter Second Number")
        'Num2 = Console.ReadLine()

        ' Dim Sum As Double = Num1 + Num2
        'Console.WriteLine("The sum of " & Num1 & Num2 & "is " & Sum)




        'conslo.WriteLine(" Enter Your Name ")
        '   Name = Console.ReadLine()

        '   Console.WriteLine(" How old are You")
        '  Age = Console.ReadLine()

        '  If Age < 18 Then
        ' Console.WriteLine("Wa kyi gu hor, Bare back paaa")
        'Else
        ' Console.WriteLine(" You are elegible for 18+ activities ")
        ' End If

        ' Console.WriteLine(" Mrs / Miss" & Name & " Your age is " & Age)











        Dim Name As String
        Dim Age As Integer


        For i As Integer = 1 To 10


            Console.WriteLine(" Enter Age for Canditate " & i)
            Age = Console.ReadLine()

            If Age < 18 Then
                Console.WriteLine("Wa kyi gu hor, Bare back paaa")
            Else
                Console.WriteLine(" You are elegible for 18+ activities ")
            End If

        Next




        For i As Integer = 1 To 10
            Console.WriteLine("Enter your Exam score for Student " & i)
            Dim ExamScore As Double = Console.ReadLine()

            Console.WriteLine("Enter the Midsem Score for Student " & i)
            Dim MidSemScore As Double = Console.ReadLine()

            Dim finalExam As Integer = ExamScore * 0.7
            Dim FinalMidsem As Integer = MidSemScore * 0.3

            Dim TotalScore As Double = FinalMidsem + finalExam

            If TotalScore > 70 Then
                Console.WriteLine("Excellent " & " Grade = A ")

            ElseIf TotalScore > 60 Then
                Console.WriteLine("Very Good" & " Grade = B ")

            ElseIf TotalScore > 50 Then
                Console.WriteLine("Good " & " Grade = C ")

            ElseIf TotalScore > 50 Then
                Console.WriteLine(d " & " Grade = D ")


            End If


        Next

    End Sub
End Module
