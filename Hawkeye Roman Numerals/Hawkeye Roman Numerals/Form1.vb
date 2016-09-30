Public Class Form1

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim decInt As Integer

        ' Convert variables
        decInt = CInt(txtInput.Text)

        ' Convert and display result
        If decInt = 1 Then
            lblResult.Text = "I"

        ElseIf decInt = 2 Then
            lblResult.Text = "II"

        ElseIf decInt = 3 Then
            lblResult.Text = "III"

        ElseIf decInt = 4 Then
            lblResult.Text = "IIII"

        ElseIf decInt = 5 Then
            lblResult.Text = "V"

        ElseIf decInt = 6 Then
            lblResult.Text = "VI"

        ElseIf decInt = 7 Then
            lblResult.Text = "VII"

        ElseIf decInt = 8 Then
            lblResult.Text = "VIII"

        ElseIf decInt = 9 Then
            lblResult.Text = "VIIII"

        ElseIf decInt = 10 Then
            lblResult.Text = "X"

        ElseIf decInt = 11 Then
            lblResult.Text = "XI"

        ElseIf decInt = 12 Then
            lblResult.Text = "XII"

        ElseIf decInt = 13 Then
            lblResult.Text = "XIII"

        ElseIf decInt = 14 Then
            lblResult.Text = "XIIII"

        ElseIf decInt = 15 Then
            lblResult.Text = "XV"

        ElseIf decInt = 16 Then
            lblResult.Text = "XVI"

        ElseIf decInt = 17 Then
            lblResult.Text = "XVII"

        ElseIf decInt = 18 Then
            lblResult.Text = "XVIII"

        ElseIf decInt = 19 Then
            lblResult.Text = "XVIIII"

        ElseIf decInt = 20 Then
            lblResult.Text = "XX"

        ElseIf decInt = 21 Then
            lblResult.Text = "XXI"

        ElseIf decInt = 22 Then
            lblResult.Text = "XXII"

        ElseIf decInt = 23 Then
            lblResult.Text = "XXIII"

        ElseIf decInt = 24 Then
            lblResult.Text = "XXIIII"

        ElseIf decInt = 25 Then
            lblResult.Text = "XXV"

        ElseIf decInt = 26 Then
            lblResult.Text = "XXVI"

        ElseIf decInt = 27 Then
            lblResult.Text = "XXVII"

        ElseIf decInt = 28 Then
            lblResult.Text = "XXVIII"

        ElseIf decInt = 29 Then
            lblResult.Text = "XXVIIII"

        ElseIf decInt = 30 Then
            lblResult.Text = "XXX"

        ElseIf decInt = 31 Then
            lblResult.Text = "XXXI"

        ElseIf decInt = 32 Then
            lblResult.Text = "XXXII"

        ElseIf decInt = 33 Then
            lblResult.Text = "XXXIII"

        ElseIf decInt = 34 Then
            lblResult.Text = "XXXIIII"

        ElseIf decInt = 35 Then
            lblResult.Text = "XXXV"

        ElseIf decInt = 36 Then
            lblResult.Text = "XXXVI"

        ElseIf decInt = 37 Then
            lblResult.Text = "XXXVII"

        ElseIf decInt = 38 Then
            lblResult.Text = "XXXVIII"

        ElseIf decInt = 39 Then
            lblResult.Text = "XXXVIIII"

        ElseIf decInt = 40 Then
            lblResult.Text = "XXXX"

        ElseIf decInt = 41 Then
            lblResult.Text = "XXXXI"

        ElseIf decInt = 42 Then
            lblResult.Text = "XXXXII"

        ElseIf decInt = 43 Then
            lblResult.Text = "XXXXIII"

        ElseIf decInt = 44 Then
            lblResult.Text = "XXXXIIII"

        ElseIf decInt = 45 Then
            lblResult.Text = "XXXXV"

        ElseIf decInt = 46 Then
            lblResult.Text = "XXXXVI"

        ElseIf decInt = 47 Then
            lblResult.Text = "XXXXVII"

        ElseIf decInt = 48 Then
            lblResult.Text = "XXXXVIII"

        ElseIf decInt = 49 Then
            lblResult.Text = "XXXXVIIII"

        ElseIf decInt = 50 Then
            lblResult.Text = "L"

        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtInput.Clear()
        lblResult.Text = ("")
    End Sub
End Class
