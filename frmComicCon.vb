Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim decGroupSize As Decimal
        Dim decCostPerPerson As Decimal
        Dim decRegCost As Decimal

        Dim decConSpr As Decimal = 380D
        Dim decConAuto As Decimal = 275D
        Dim decCon As Decimal = 209D

        If IsNumeric(txtGrp.Text) Then
            decGroupSize = Convert.ToDecimal(txtGrp.Text)
            If decGroupSize > 0 Then
                If radConSpr.Checked Then
                    decCostPerPerson = decConSpr
                ElseIf radConAuto.Checked Then
                    decCostPerPerson = decConAuto
                ElseIf radCon.Checked Then
                    decCostPerPerson = decCon
                End If

                decRegCost = decCostPerPerson * decGroupSize
                lblCost.Text = decRegCost.ToString("C")

            Else

                MsgBox("You entered " & decGroupSize.ToString() & ". please enter a positive value.")
                txtGrp.Text = ""
                txtGrp.Focus()

            End If
        Else

            MsgBox("Please enter the number of patrons you want to register")
            txtGrp.Text = ""
            txtGrp.Focus()

        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGrp.Clear()
        lblCost.Text = ""
        radConSpr.Checked = True
        radConAuto.Checked = False
        radCon.Checked = False
        txtGrp.Focus()
    End Sub
End Class
