Public Class frmAirbnb
    Const cdecCostPerNight As Decimal = 79D
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblHeading.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNights.Clear()
        lblTotal.Text = ""
        txtNights.Focus()
    End Sub

    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        Dim strNumNights As String
        Dim intNumNights As Integer
        Dim decTotalCost As Decimal

        strNumNights = txtNights.Text
        intNumNights = Convert.ToInt32(strNumNights)
        decTotalCost = intNumNights * cdecCostPerNight
        lblTotal.Text = decTotalCost.ToString("C")
    End Sub

    Private Sub lblTotal_Click(sender As Object, e As EventArgs) Handles lblTotal.Click

    End Sub
End Class
