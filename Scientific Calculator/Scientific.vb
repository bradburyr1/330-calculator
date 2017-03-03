﻿Public Class Scientific

    Public Value1, Value2, Mem As Double
    Public Oper As Char
    Public second As Boolean = True

    Private Sub StandardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StandardToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub ScientificToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScientificToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub ProgrammerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgrammerToolStripMenuItem.Click
        Programmer.Show()
        Me.Hide()
    End Sub

    Private Sub GraphingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GraphingToolStripMenuItem.Click
        Graphing.Show()
        Me.Hide()
    End Sub

    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        ShowValue2(Btn0)
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        ShowValue2(Btn1)
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        ShowValue2(Btn2)
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        ShowValue2(Btn3)
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        ShowValue2(Btn4)
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        ShowValue2(Btn5)
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        ShowValue2(Btn6)
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        ShowValue2(Btn7)
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        ShowValue2(Btn8)
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        ShowValue2(Btn9)
    End Sub

    Private Sub BtnDot_Click(sender As Object, e As EventArgs) Handles BtnDot.Click
        If Not TextBox1.Text.Contains(".") Then
            TextBox1.Text += "."
        End If
    End Sub

    Private Sub BtnDiv_Click(sender As Object, e As EventArgs) Handles BtnDiv.Click
        Arithematic2(BtnDiv)
    End Sub

    Private Sub BtnMultiply_Click(sender As Object, e As EventArgs) Handles BtnMultiply.Click
        Arithematic2(BtnMultiply)
    End Sub

    Private Sub BtnMinus_Click(sender As Object, e As EventArgs) Handles BtnMinus.Click
        Arithematic2(BtnMinus)
    End Sub

    Private Sub BtnPlus_Click(sender As Object, e As EventArgs) Handles BtnPlus.Click
        Arithematic2(BtnPlus)
    End Sub

    Private Sub BtnEqual_Click(sender As Object, e As EventArgs) Handles BtnEqual.Click
        Value2 = Val(TextBox1.Text)
        Calculate2()
        ShowHistory()
        Value2 = 0
        SayIt2()
    End Sub

    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        TextBox1.Text = Val(TextBox1.Text) \ 10
    End Sub

    Private Sub Scientific_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mem = 0
    End Sub

    Private Sub BtnCE_Click(sender As Object, e As EventArgs) Handles BtnCE.Click
        TextBox1.Text = 0
        TextBox2.Text = 0
    End Sub

    Private Sub BtnC_Click(sender As Object, e As EventArgs) Handles BtnC.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub BtnLBracket_Click(sender As Object, e As EventArgs) Handles BtnLBracket.Click
        TextBox1.Text += "("
    End Sub

    Private Sub BtnRBracket_Click(sender As Object, e As EventArgs) Handles BtnRBracket.Click
        TextBox1.Text += ")"
    End Sub

    Private Sub BtnPlusMinus_Click(sender As Object, e As EventArgs) Handles BtnPlusMinus.Click
        TextBox1.Text = Val(TextBox1.Text) * -1
    End Sub

    'Factorial Function'
    Private Function Fact(ByVal n As Integer)
        If (n = 0) Then
            Fact = 1
        Else
            Fact = n * Fact(n - 1)
        End If
    End Function
    Private Sub BtnFactorial_Click(sender As Object, e As EventArgs) Handles BtnFactorial.Click
        Dim n As Integer
        n = TextBox1.Text
        TextBox1.Text = Fact(n).ToString()
    End Sub

    Private Sub BtnSqrRoot_Click(sender As Object, e As EventArgs) Handles BtnSqrRoot.Click
        TextBox1.Text = Math.Sqrt(Val(TextBox1.Text))
    End Sub

    Private Sub Btn10X_Click(sender As Object, e As EventArgs) Handles Btn10X.Click
        TextBox1.Text = 10 ^ TextBox1.Text
    End Sub

    Private Sub BtnLog_Click(sender As Object, e As EventArgs) Handles BtnLog.Click
        TextBox1.Text = Math.Log10(TextBox1.Text)
    End Sub

    Public exp As Boolean = False
    Private Sub BtnExp_Click(sender As Object, e As EventArgs) Handles BtnExp.Click
        Arithematic2(BtnExp)
        TextBox1.Text = Value1 & (".e+") & Value2
        exp = True
    End Sub

    Private Sub BtnMod_Click(sender As Object, e As EventArgs) Handles BtnMod.Click
        Arithematic2(BtnMod)
    End Sub

    Private Sub BtnXSqr_Click(sender As Object, e As EventArgs) Handles BtnXSqr.Click
        TextBox1.Text = Val(TextBox1.Text) ^ 2
    End Sub

    Private Sub BtnXY_Click(sender As Object, e As EventArgs) Handles BtnXY.Click
        Arithematic2(BtnXY)
    End Sub

    Private Sub BtnSin_Click(sender As Object, e As EventArgs) Handles BtnSin.Click
        TextBox1.Text = Math.Sin(TextBox1.Text)
    End Sub

    Private Sub BtnCos_Click(sender As Object, e As EventArgs) Handles BtnCos.Click
        TextBox1.Text = Math.Cos(TextBox1.Text)
    End Sub

    Private Sub BtnTan_Click(sender As Object, e As EventArgs) Handles BtnTan.Click
        TextBox1.Text = Math.Tan(TextBox1.Text)
    End Sub

    Private Sub BtnMC_Click(sender As Object, e As EventArgs) Handles BtnMC.Click
        Mem = 0
    End Sub

    Private Sub BtnMR_Click(sender As Object, e As EventArgs) Handles BtnMR.Click
        TextBox1.Text = Mem
    End Sub

    Private Sub BtnMPlus_Click(sender As Object, e As EventArgs) Handles BtnMPlus.Click
        Mem = Mem + Val(TextBox1.Text)
    End Sub

    Private Sub BtnMMinus_Click(sender As Object, e As EventArgs) Handles BtnMMinus.Click
        Mem = Mem - Val(TextBox1.Text)
    End Sub

    Private Sub BtnMS_Click(sender As Object, e As EventArgs) Handles BtnMS.Click
        TextBox1.Text = Mem
    End Sub

    Private Sub BtnPi_Click(sender As Object, e As EventArgs) Handles BtnPi.Click
        TextBox1.Text = System.Math.PI
    End Sub

    Private Sub Btn2nd_Click(sender As Object, e As EventArgs) Handles Btn2nd.Click
        If second = True Then
            GroupBox1.Hide()
            GroupBox2.Show()
            second = False
        Else
            GroupBox1.Show()
            GroupBox2.Hide()
            second = True
        End If
    End Sub

    Private Sub BtnOneOver_Click(sender As Object, e As EventArgs) Handles BtnOneOver.Click
        TextBox1.Text = 1 / Val(TextBox1.Text)
    End Sub

    Private Sub BtnXCube_Click(sender As Object, e As EventArgs) Handles BtnXCube.Click
        TextBox1.Text = Val(TextBox1.Text) ^ 3
    End Sub

    Private Sub BtnRoot_Click(sender As Object, e As EventArgs) Handles BtnRoot.Click
        Arithematic2(BtnRoot)
    End Sub

    Private Sub BtnInverseSin_Click(sender As Object, e As EventArgs) Handles BtnInverseSin.Click
        TextBox1.Text = Math.Asin(TextBox1.Text)
    End Sub

    Private Sub BtnInverseCos_Click(sender As Object, e As EventArgs) Handles BtnInverseCos.Click
        TextBox1.Text = Math.Acos(TextBox1.Text)
    End Sub

    Private Sub BtnInverseTan_Click(sender As Object, e As EventArgs) Handles BtnInverseTan.Click
        TextBox1.Text = Math.Atan(TextBox1.Text)
    End Sub

    Private Sub BtnE_Click(sender As Object, e As EventArgs) Handles BtnE.Click
        TextBox1.Text = Math.Exp(TextBox1.Text)
    End Sub

    Private Sub BtnLn_Click(sender As Object, e As EventArgs) Handles BtnLn.Click
        TextBox1.Text = Math.Log(TextBox1.Text)
    End Sub

    Public Degrees As Double
    Public Minutes As Double
    Public Seconds As Double
    Private Sub BtnDMS_Click(sender As Object, e As EventArgs) Handles BtnDMS.Click
        Degrees = Int(TextBox1.Text)
        Minutes = Int((TextBox1.Text - (Int(TextBox1.Text))) * 60)
        Seconds = (((TextBox1.Text - (Int(TextBox1.Text))) * 60) - Minutes) * 60
        Seconds = Replace(Seconds, ".", "")
        If Degrees And Minutes And Seconds > 0 Then
            TextBox1.Text = Degrees & "." & Minutes & Seconds
        ElseIf Degrees And Minutes > 0 Then
            TextBox1.Text = Degrees & "." & Minutes
        ElseIf Degrees > 0 Then
            TextBox1.Text = Degrees
        End If
    End Sub

    Public DegResult As Double
    Private Sub BtnDeg_Click(sender As Object, e As EventArgs) Handles BtnDeg.Click
        Degrees = Int(TextBox1.Text)
        Minutes = Math.Round(((Math.Truncate(TextBox1.Text * 100) / 100) - Degrees) * 100)
        Seconds = (((TextBox1.Text - Degrees) - (Minutes / 100)) * 10000)
        DegResult = (((Seconds / 60) + Minutes) / 60) + Degrees
        TextBox1.Text = DegResult
    End Sub

    Private Sub FunctionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FunctionsToolStripMenuItem.Click
        Functions.Show()
        Me.Hide()
    End Sub

    Private Sub ConverterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConverterToolStripMenuItem.Click
        Converter.Show()
        Me.Hide()
    End Sub


End Class