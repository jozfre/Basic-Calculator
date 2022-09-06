Public Class basicCalculator
    Dim operand1, operand2, total As Decimal
    Dim operations As Char
    Dim operation_select = False

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If calcDisplay.Text <> "0" Then
            calcDisplay.Text += "0"
        End If
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If calcDisplay.Text <> "0" Then
            calcDisplay.Text += "1"
        Else
            calcDisplay.Text = "1"
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If calcDisplay.Text <> "0" Then
            calcDisplay.Text += "2"
        Else
            calcDisplay.Text = "2"
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If calcDisplay.Text <> "0" Then
            calcDisplay.Text += "3"
        Else
            calcDisplay.Text = "3"
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If calcDisplay.Text <> "0" Then
            calcDisplay.Text += "4"
        Else
            calcDisplay.Text = "4"
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If calcDisplay.Text <> "0" Then
            calcDisplay.Text += "5"
        Else
            calcDisplay.Text = "5"
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If calcDisplay.Text <> "0" Then
            calcDisplay.Text += "6"
        Else
            calcDisplay.Text = "6"
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If calcDisplay.Text <> "0" Then
            calcDisplay.Text += "7"
        Else
            calcDisplay.Text = "7"
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If calcDisplay.Text <> "0" Then
            calcDisplay.Text += "8"
        Else
            calcDisplay.Text = "8"
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If calcDisplay.Text <> "0" Then
            calcDisplay.Text += "9"
        Else
            calcDisplay.Text = "9"
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        calcDisplay.Text = "0"
    End Sub

    Private Sub btnAddition_Click(sender As Object, e As EventArgs) Handles btnAddition.Click
        operand1 = calcDisplay.Text
        calcDisplay.Text = "0"
        operation_select = True
        operations = "+"
    End Sub

    Private Sub btnSubstraction_Click(sender As Object, e As EventArgs) Handles btnSubstraction.Click
        operand1 = calcDisplay.Text
        calcDisplay.Text = "0"
        operation_select = True
        operations = "-"
    End Sub

    Private Sub btnMultiplication_Click(sender As Object, e As EventArgs) Handles btnMultiplication.Click
        operand1 = calcDisplay.Text
        calcDisplay.Text = "0"
        operation_select = True
        operations = "*"
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        operand1 = calcDisplay.Text
        calcDisplay.Text = "0"
        operation_select = True
        operations = "/"
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click

        If operation_select = True Then
            operand2 = calcDisplay.Text
            If operations = "+" Then
                calcDisplay.Text = operand1 + operand2
            ElseIf operations = "-" Then
                calcDisplay.Text = operand1 - operand2
            ElseIf operations = "*" Then
                calcDisplay.Text = operand1 * operand2
            Else
                If operand2 = 0 Then
                    calcDisplay.Text = "Error!"
                Else
                    calcDisplay.Text = operand1 / operand2
                End If
            End If
        Else
            operand1 = calcDisplay.Text
        End If

        operation_select = False

    End Sub
End Class


