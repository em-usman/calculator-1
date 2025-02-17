Public Class Form1
    Dim operand1, operand2 As Double
    Dim operator1 As String

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        TextBox_result.Text = ""

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If (TextBox_result.Text.Length > 0) Then
            TextBox_result.Text = TextBox_result.Text.Remove(TextBox_result.Text.Length - 1, 1)
        End If

    End Sub

    Private Sub btn_1_Click(sender As Object, e As EventArgs) Handles btn_1.Click
        TextBox_result.Text += "1"

    End Sub

    Private Sub btn_2_Click(sender As Object, e As EventArgs) Handles btn_2.Click
        TextBox_result.Text += "2"

    End Sub

    Private Sub btn_3_Click(sender As Object, e As EventArgs) Handles btn_3.Click
        TextBox_result.Text += "3"

    End Sub

    Private Sub btn_4_Click(sender As Object, e As EventArgs) Handles btn_4.Click
        TextBox_result.Text += "4"

    End Sub

    Private Sub btn_5_Click(sender As Object, e As EventArgs) Handles btn_5.Click
        TextBox_result.Text += "5"

    End Sub

    Private Sub btn_6_Click(sender As Object, e As EventArgs) Handles btn_6.Click
        TextBox_result.Text += "6"

    End Sub

    Private Sub btn_7_Click(sender As Object, e As EventArgs) Handles btn_7.Click
        TextBox_result.Text += "7"

    End Sub

    Private Sub btn_8_Click(sender As Object, e As EventArgs) Handles btn_8.Click
        TextBox_result.Text += "8"

    End Sub

    Private Sub btn_9_Click(sender As Object, e As EventArgs) Handles btn_9.Click
        TextBox_result.Text += "9"

    End Sub

    Private Sub btn_00_Click(sender As Object, e As EventArgs) Handles btn_00.Click
        TextBox_result.Text += "00"

    End Sub

    Private Sub btn_0_Click(sender As Object, e As EventArgs) Handles btn_0.Click
        TextBox_result.Text += "0"

    End Sub


    Private Sub btn_division_Click(sender As Object, e As EventArgs) Handles btn_division.Click
        operand1 = TextBox_result.Text
        TextBox_result.Clear()
        TextBox_result.Focus()
        operator1 = "/"

    End Sub

    Private Sub btn_multilply_Click(sender As Object, e As EventArgs) Handles btn_multiply.Click
        operand1 = TextBox_result.Text
        TextBox_result.Clear()
        TextBox_result.Focus()
        operator1 = "*"

    End Sub

    Private Sub btn_subtract_Click(sender As Object, e As EventArgs) Handles btn_subtract.Click
        operand1 = TextBox_result.Text
        TextBox_result.Clear()
        TextBox_result.Focus()
        operator1 = "-"



    End Sub

    Private Sub btn_plus_Click(sender As Object, e As EventArgs) Handles btn_plus.Click
        operand1 = TextBox_result.Text
        TextBox_result.Clear()
        TextBox_result.Focus()
        operator1 = "+"

        Label1.Text = operand1
        Label2.Text = operator1


    End Sub

    Private Sub btn_dot_Click(sender As Object, e As EventArgs) Handles btn_dot.Click
        TextBox_result.Text = TextBox_result.Text + "."

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox_result.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btn_equal_Click(sender As Object, e As EventArgs) Handles btn_equal.Click
        operand2 = TextBox_result.Text

        If operator1 = "+" Then
            TextBox_result.Text = operand1 + operand2
        ElseIf operator1 = "-" Then
            TextBox_result.Text = operand1 - operand2
        ElseIf operator1 = "/" Then
            TextBox_result.Text = operand1 / operand2
        ElseIf operator1 = "*" Then
            TextBox_result.Text = operand1 * operand2
        End If

    End Sub

End Class
