Public Class Form1

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim rate As Double
        Dim months As Double
        Dim amount As Double
        Dim payment As Double

        rate = AnnualRate.Text / 12
        months = NumberofYears.Text * 12
        amount = LoanAmount.Text
        payment = -Pmt(rate, months, amount)
        MonthlyPayment.Text = Format(payment, "currency")
    End Sub

    Private Sub NumberofYears_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumberofYears.TextChanged

    End Sub

    Private Sub LoanAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoanAmount.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class
