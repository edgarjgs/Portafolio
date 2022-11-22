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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Calculate = New System.Windows.Forms.Button()
        Me.itembox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.costbox = New System.Windows.Forms.TextBox()
        Me.itemname = New System.Windows.Forms.Label()
        Me.cost = New System.Windows.Forms.Label()
        Me.Bexit = New System.Windows.Forms.Button()
        Me.BClear = New System.Windows.Forms.Button()
        Me.total = New System.Windows.Forms.Label()
        Me.tax = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Walmart"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Cash_Register.My.Resources.Resources.download
        Me.PictureBox1.Location = New System.Drawing.Point(203, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(205, 134)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Calculate
        '
        Me.Calculate.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calculate.Location = New System.Drawing.Point(28, 50)
        Me.Calculate.Name = "Calculate"
        Me.Calculate.Size = New System.Drawing.Size(140, 30)
        Me.Calculate.TabIndex = 3
        Me.Calculate.Text = "Display Cost"
        Me.Calculate.UseVisualStyleBackColor = True
        '
        'itembox
        '
        Me.itembox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.itembox.Location = New System.Drawing.Point(67, 167)
        Me.itembox.Name = "itembox"
        Me.itembox.Size = New System.Drawing.Size(153, 29)
        Me.itembox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 24)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Item:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(220, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 24)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Cost:"
        '
        'costbox
        '
        Me.costbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.costbox.Location = New System.Drawing.Point(277, 167)
        Me.costbox.Name = "costbox"
        Me.costbox.Size = New System.Drawing.Size(83, 29)
        Me.costbox.TabIndex = 2
        '
        'itemname
        '
        Me.itemname.AutoSize = True
        Me.itemname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemname.Location = New System.Drawing.Point(11, 224)
        Me.itemname.Name = "itemname"
        Me.itemname.Size = New System.Drawing.Size(77, 25)
        Me.itemname.TabIndex = 12
        Me.itemname.Text = "Label4"
        '
        'cost
        '
        Me.cost.AutoSize = True
        Me.cost.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.cost.Location = New System.Drawing.Point(219, 224)
        Me.cost.Name = "cost"
        Me.cost.Size = New System.Drawing.Size(77, 25)
        Me.cost.TabIndex = 13
        Me.cost.Text = "Label5"
        '
        'Bexit
        '
        Me.Bexit.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!)
        Me.Bexit.Location = New System.Drawing.Point(28, 112)
        Me.Bexit.Name = "Bexit"
        Me.Bexit.Size = New System.Drawing.Size(140, 30)
        Me.Bexit.TabIndex = 5
        Me.Bexit.Text = "Exit"
        Me.Bexit.UseVisualStyleBackColor = True
        '
        'BClear
        '
        Me.BClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BClear.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!)
        Me.BClear.Location = New System.Drawing.Point(28, 81)
        Me.BClear.Name = "BClear"
        Me.BClear.Size = New System.Drawing.Size(140, 30)
        Me.BClear.TabIndex = 4
        Me.BClear.Text = "Clear"
        Me.BClear.UseVisualStyleBackColor = True
        '
        'total
        '
        Me.total.AutoSize = True
        Me.total.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.total.Location = New System.Drawing.Point(219, 271)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(77, 25)
        Me.total.TabIndex = 17
        Me.total.Text = "Label6"
        '
        'tax
        '
        Me.tax.AutoSize = True
        Me.tax.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.tax.Location = New System.Drawing.Point(11, 271)
        Me.tax.Name = "tax"
        Me.tax.Size = New System.Drawing.Size(77, 25)
        Me.tax.TabIndex = 16
        Me.tax.Text = "Label7"
        '
        'Form1
        '
        Me.AcceptButton = Me.Calculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BClear
        Me.ClientSize = New System.Drawing.Size(420, 313)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.tax)
        Me.Controls.Add(Me.Bexit)
        Me.Controls.Add(Me.BClear)
        Me.Controls.Add(Me.cost)
        Me.Controls.Add(Me.itemname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.costbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.itembox)
        Me.Controls.Add(Me.Calculate)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Register"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Calculate As Button
    Friend WithEvents itembox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents costbox As TextBox
    Friend WithEvents itemname As Label
    Friend WithEvents cost As Label
    Friend WithEvents Bexit As Button
    Friend WithEvents BClear As Button
    Friend WithEvents total As Label
    Friend WithEvents tax As Label
End Class
