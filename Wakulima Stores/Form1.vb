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

    End Sub
End Class
