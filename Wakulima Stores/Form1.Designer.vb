<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TotalButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.ItemsTextBox = New System.Windows.Forms.TextBox()
        Me.CostTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.BalanceTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Amount = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TotalsTextBox = New System.Windows.Forms.TextBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TotalButton
        '
        Me.TotalButton.Location = New System.Drawing.Point(82, 337)
        Me.TotalButton.Name = "TotalButton"
        Me.TotalButton.Size = New System.Drawing.Size(75, 23)
        Me.TotalButton.TabIndex = 0
        Me.TotalButton.Text = "&Totals"
        Me.TotalButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(220, 337)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(75, 23)
        Me.ResetButton.TabIndex = 1
        Me.ResetButton.Text = "&Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'ItemsTextBox
        '
        Me.ItemsTextBox.Location = New System.Drawing.Point(105, 102)
        Me.ItemsTextBox.Name = "ItemsTextBox"
        Me.ItemsTextBox.Size = New System.Drawing.Size(265, 20)
        Me.ItemsTextBox.TabIndex = 2
        '
        'CostTextBox
        '
        Me.CostTextBox.Location = New System.Drawing.Point(105, 128)
        Me.CostTextBox.Name = "CostTextBox"
        Me.CostTextBox.Size = New System.Drawing.Size(265, 20)
        Me.CostTextBox.TabIndex = 3
        '
        'AmountTextBox
        '
        Me.AmountTextBox.Location = New System.Drawing.Point(143, 227)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(152, 20)
        Me.AmountTextBox.TabIndex = 4
        '
        'BalanceTextBox
        '
        Me.BalanceTextBox.Location = New System.Drawing.Point(143, 277)
        Me.BalanceTextBox.Name = "BalanceTextBox"
        Me.BalanceTextBox.ReadOnly = True
        Me.BalanceTextBox.Size = New System.Drawing.Size(152, 20)
        Me.BalanceTextBox.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Item Bought: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Cost :"
        '
        'Amount
        '
        Me.Amount.AutoSize = True
        Me.Amount.Location = New System.Drawing.Point(57, 230)
        Me.Amount.Name = "Amount"
        Me.Amount.Size = New System.Drawing.Size(80, 13)
        Me.Amount.TabIndex = 8
        Me.Amount.Text = "Amount Given :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Balance (Change):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Total Purchased :"
        '
        'TotalsTextBox
        '
        Me.TotalsTextBox.Location = New System.Drawing.Point(143, 191)
        Me.TotalsTextBox.Name = "TotalsTextBox"
        Me.TotalsTextBox.ReadOnly = True
        Me.TotalsTextBox.Size = New System.Drawing.Size(152, 20)
        Me.TotalsTextBox.TabIndex = 11
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(444, 337)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 12
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(32, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(122, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Showcard Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(160, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(320, 40)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "WAKULIMA  STORES"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(582, 372)
        Me.ShapeContainer1.TabIndex = 15
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 56
        Me.LineShape1.X2 = 406
        Me.LineShape1.Y1 = 173
        Me.LineShape1.Y2 = 174
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 372)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.TotalsTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Amount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BalanceTextBox)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(Me.CostTextBox)
        Me.Controls.Add(Me.ItemsTextBox)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.TotalButton)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Form1"
        Me.Text = "Cash Out"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TotalButton As System.Windows.Forms.Button
    Friend WithEvents ResetButton As System.Windows.Forms.Button
    Friend WithEvents ItemsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BalanceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Amount As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TotalsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape

End Class
