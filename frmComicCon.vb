Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim decGroupSize As Decimal
        Dim decCostPerPerson As Decimal
        Dim decRegCost As Decimal

        Dim decConSpr As Decimal = 380D
        Dim decConAuto As Decimal = 275D
        Dim decCon As Decimal = 209D

        If IsNumeric(txtGrp.Text) Then
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



            End If
        End If

    End Sub
End Class
