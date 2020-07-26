'wakulima stores 
'felix vaati 
'26/7/2020
Public Class Form1

    Private Sub Splitter1_SplitterMoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.SplitterEventArgs)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()

    End Sub

    Private Sub ResetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetButton.Click
        ItemsTextBox.Clear()
        CostTextBox.Clear()
        TotalsTextBox.Clear()
        AmountTextBox.Clear()
        BalanceTextBox.Clear()
        QuantityTextBox.Clear()


    End Sub

    Private Sub ComputeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComputeButton.Click
        Dim CostDecimal As Decimal
        CostDecimal = Decimal.Parse(CostTextBox.Text, Globalization.NumberStyles.Currency)
        Dim QuantityInteger As Integer
        QuantityInteger = Integer.Parse(QuantityTextBox.Text, Globalization.NumberStyles.Number)
        Dim TotalsDecimal As Decimal
        TotalsDecimal = CostDecimal * QuantityInteger
        TotalsTextBox.Text = TotalsDecimal.ToString("C")



    End Sub

    Private Sub TotalButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalButton.Click
        Dim TotalsDecimal As Decimal
        TotalsDecimal = Decimal.Parse(TotalsTextBox.Text, Globalization.NumberStyles.Currency)
        Dim BalanceDecimal As Decimal
        Dim AmountDecimal As Decimal
        AmountDecimal = Decimal.Parse(AmountTextBox.Text, Globalization.NumberStyles.Currency)
        BalanceDecimal = (AmountDecimal - TotalsDecimal)
        BalanceTextBox.Text = BalanceDecimal.ToString("C")

    End Sub

    Private Sub QuantityTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuantityTextBox.TextChanged
        Const QualityTextBox As Integer = 5
    End Sub
End Class
