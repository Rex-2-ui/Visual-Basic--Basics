'Imports System.Math
'Public Class Form1

'Private Function f(x As Double) As Double
'    Return Cos(x) - x
'End Function

'Private Function fprime(x As Double) As Double
'    Return -Sin(x) - 1
'End Function

'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles SecantButton.Click

'    Dim p0 As Double = CDbl(InitialApproxP0TextBox.Text)
'    Dim p1 As Double = CDbl(InitialApprox1TextBox.Text)
'    Dim tol As Double = CDbl(ToleranceTextBox.Text)
'    Dim N0 As Integer = CInt(MaxIterarationTextBox.Text)

'    Dim q0 As Double = f(p0)
'    Dim q1 As Double = f(p1)
'    Dim p As Double
'    Dim i As Integer = 2

'    ResultsTextBox.Clear()
'    ResultsTextBox.AppendText("Secant Method Iterations:" & vbCrLf)
'    ResultsTextBox.AppendText(String.Format("i={0}, p0={1:F6}, f(p0)={2:F6}" & vbCrLf, 0, p0, q0))
'    ResultsTextBox.AppendText(String.Format("i={0}, p1={1:F6}, f(p1)={2:F6}" & vbCrLf, 1, p1, q1))

'    While i < N0
'        p = p1 - q1 * (p1 - p0) / (q1 - q0)
'        ResultsTextBox.AppendText(String.Format("i={0}, p={1:F6}, f(p)={2:F6}" & vbCrLf, i, p, f(p)))

'        If Abs(p - p1) < tol Then
'            ResultsTextBox.AppendText(String.Format("Procedure completed successfully. Root ≈ {0:F6}" & vbCrLf, p))
'            Exit Sub
'        End If

'        i += 1
'        p0 = p1 : q0 = q1
'        p1 = p : q1 = f(p)
'    End While

'    ResultsTextBox.AppendText("Method failed after " & N0 & " iterations." & vbCrLf)
'End Sub

'Private Sub NewtonButton_Click(sender As Object, e As EventArgs) Handles NewtonButton.Click
'    Dim p0 As Double = CDbl(InitialApproxP0TextBox.Text)
'    Dim tol As Double = CDbl(ToleranceTextBox.Text)
'    Dim N0 As Integer = CInt(MaxIterarationTextBox.Text)

'    Dim p As Double
'    Dim i As Integer = 1

'    ResultsTextBox.Clear()
'    ResultsTextBox.AppendText("Newton-Raphson Iterations:" & vbCrLf)
'    ResultsTextBox.AppendText(String.Format("i={0}, p0={1:F6}, f(p0)={2:F6}" & vbCrLf, 0, p0, f(p0)))

'    While i <= N0
'        p = p0 - f(p0) / fprime(p0)
'        ResultsTextBox.AppendText(String.Format("i={0}, p={1:F6}, f(p)={2:F6}" & vbCrLf, i, p, f(p)))

'        If Abs(p - p0) < tol Then
'            ResultsTextBox.AppendText(String.Format("Procedure completed successfully. Root ≈ {0:F6}" & vbCrLf, p))
'            Exit Sub
'        End If

'        i += 1
'        p0 = p
'    End While

'    ResultsTextBox.AppendText("Method failed after " & N0 & " iterations." & vbCrLf)
'End Sub








Public Class Form1
    Private Function Fx(ByVal x As Double) As Double
        Return Math.Cos(x) - x
    End Function

    Private Function DFx(ByVal x As Double) As Double

        Return -Math.Sin(x) - 1
    End Function



    Private Sub NRbtn_Click(sender As Object, e As EventArgs) Handles NewtonButton.Click
        Dim PO As Double = CDbl(InitialApproxP0TextBox.Text)
        Dim TOL As Double = CDbl(ToleranceTextBox.Text)
        Dim MaxIter As Integer = CInt(MaxIterarationTextBox.Text)

        Dim P As Double
        Dim i As Integer = 1

        ResultsTextBox.Clear()
        ResultsTextBox.AppendText("Newton-Raphson Iterations:" & vbCrLf)

        While i < MaxIter
            P = PO - (Fx(PO) / DFx(PO))
            ResultsTextBox.AppendText("i=" & i & vbTab & "P=" & P.ToString("F8") & vbCrLf)

            If Math.Abs(P - PO) < TOL Then
                MessageBox.Show("Procedure Completed Successfully", "Newton-Raphson")
                Exit Sub
            End If

            PO = P
            i += 1
        End While

        MessageBox.Show("Method failed after " & MaxIter & " iterations.", "Newton-Raphson")
    End Sub






    Private Sub SecantButton_Click(sender As Object, e As EventArgs) Handles SecantButton.Click
        Dim p0 As Double = CDbl(InitialApproxP0TextBox.Text)
        Dim p1 As Double = CDbl(InitialApprox1TextBox.Text)
        Dim Tol As Double = CDbl(ToleranceTextBox.Text)
        Dim MaxIter As Integer = CInt(MaxIterarationTextBox.Text)

        Dim q0 As Double = Fx(p0)
        Dim q1 As Double = Fx(p1)
        Dim P As Double
        Dim i As Integer = 2

        ResultsTextBox.Clear()
        ResultsTextBox.AppendText("Secant Method Iterations:" & vbCrLf)

        While i <= MaxIter
            P = p1 - q1 * (p1 - p0) / (q1 - q0)
            ResultsTextBox.AppendText("Iteration " & i & " P = " & P.ToString("F8") & vbCrLf)

            If Math.Abs(P - p1) < Tol Then
                MessageBox.Show("Procedure Completed Successfully", "Secant Method", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            p0 = p1
            q0 = q1
            p1 = P
            q1 = Fx(P)

            i += 1
        End While

        MessageBox.Show("Method failed after " & MaxIter & " iterations.", "Secant Method", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub




End Class
