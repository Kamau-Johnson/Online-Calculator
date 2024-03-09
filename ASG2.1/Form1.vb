Imports System.Runtime.InteropServices.ComTypes

Public Class Form1

    Private Sub lblTt_Click(sender As Object, e As EventArgs) Handles lblTt.Click
        Dim chem As Single, phy As Single, oop As Single, total As Single
        chem = txtChem.Text
        phy = txtPhy.Text
        oop = txtOop.Text
        total = Val(chem + phy + oop)
        MessageBox.Show(total)


    End Sub

    Private Sub lblAverage_Click(sender As Object, e As EventArgs) Handles lblAverage.Click
        Dim chem As Single, phy As Single, oop As Single, total As Single, average As Single
        chem = txtChem.Text
        phy = txtPhy.Text
        oop = txtOop.Text
        average = Val(total / 3)
        MessageBox.Show(average)
    End Sub

    Private Sub lblGrade_Click(sender As Object, e As EventArgs) Handles lblGrade.Click
        Dim average As Single, grade As String
        If average >= 0 And average <= 29 Then
            grade = MessageBox.Show("D")
        ElseIf average >= 30 And average <= 59 Then
            grade = MessageBox.Show("C")
        ElseIf average >= 60 And average <= 79 Then
            grade = MessageBox.Show("B")
        ElseIf average >= 80 And average <= 100 Then
            grade = MessageBox.Show("A")
        Else
            grade = MessageBox.Show("ERROR")
        End If


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtChem.Clear()
        txtPhy.Clear()
        txtOop.Clear()
        txtChem.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim chem As Single, phy As Single, oop As Single, total As Single, average As Single, grade As String
        chem = txtChem.Text
        phy = txtPhy.Text
        oop = txtOop.Text
        total = Val(chem + phy + oop)
        average = Val(total / 3)
        If average >= 0 And average <= 29 Then
            grade = MessageBox.Show("You have a D")
        ElseIf average >= 30 And average <= 59 Then
            grade = MessageBox.Show("You have a C")
        ElseIf average >= 60 And average <= 79 Then
            grade = MessageBox.Show("You have a B")
        ElseIf average >= 80 And average <= 100 Then
            grade = MessageBox.Show("You have an A")
        Else
            grade = MessageBox.Show("ERROR")
        End If

        lblTt.Text = total.ToString()
        lblAverage.Text = average.ToString("N2")
        lblGrade.Text = grade



    End Sub
End Class
