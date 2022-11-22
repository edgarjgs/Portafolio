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
        Me.txtlinearfeet = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblEstimate = New System.Windows.Forms.Label()
        Me.calculate = New System.Windows.Forms.Button()
        Me.bclear = New System.Windows.Forms.Button()
        Me.pine = New System.Windows.Forms.RadioButton()
        Me.oak = New System.Windows.Forms.RadioButton()
        Me.cherry = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Linear Feet?"
        '
        'txtlinearfeet
        '
        Me.txtlinearfeet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txtlinearfeet.Location = New System.Drawing.Point(153, 16)
        Me.txtlinearfeet.Name = "txtlinearfeet"
        Me.txtlinearfeet.Size = New System.Drawing.Size(100, 29)
        Me.txtlinearfeet.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(85, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Wood Type:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(38, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cost Estimate:"
        '
        'lblEstimate
        '
        Me.lblEstimate.AutoSize = True
        Me.lblEstimate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lblEstimate.Location = New System.Drawing.Point(161, 175)
        Me.lblEstimate.Name = "lblEstimate"
        Me.lblEstimate.Size = New System.Drawing.Size(75, 24)
        Me.lblEstimate.TabIndex = 5
        Me.lblEstimate.Text = "0000.00"
        '
        'calculate
        '
        Me.calculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.calculate.Location = New System.Drawing.Point(29, 208)
        Me.calculate.Name = "calculate"
        Me.calculate.Size = New System.Drawing.Size(101, 33)
        Me.calculate.TabIndex = 6
        Me.calculate.Text = "Calculate"
        Me.calculate.UseVisualStyleBackColor = True
        '
        'bclear
        '
        Me.bclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.bclear.Location = New System.Drawing.Point(155, 208)
        Me.bclear.Name = "bclear"
        Me.bclear.Size = New System.Drawing.Size(101, 33)
        Me.bclear.TabIndex = 7
        Me.bclear.Text = "Clear"
        Me.bclear.UseVisualStyleBackColor = True
        '
        'pine
        '
        Me.pine.AutoSize = True
        Me.pine.Checked = True
        Me.pine.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.pine.Location = New System.Drawing.Point(4, 3)
        Me.pine.Name = "pine"
        Me.pine.Size = New System.Drawing.Size(66, 28)
        Me.pine.TabIndex = 0
        Me.pine.TabStop = True
        Me.pine.Text = "Pine"
        Me.pine.UseVisualStyleBackColor = True
        '
        'oak
        '
        Me.oak.AutoSize = True
        Me.oak.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.oak.Location = New System.Drawing.Point(4, 28)
        Me.oak.Name = "oak"
        Me.oak.Size = New System.Drawing.Size(62, 28)
        Me.oak.TabIndex = 1
        Me.oak.Text = "Oak"
        Me.oak.UseVisualStyleBackColor = True
        '
        'cherry
        '
        Me.cherry.AutoSize = True
        Me.cherry.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cherry.Location = New System.Drawing.Point(4, 52)
        Me.cherry.Name = "cherry"
        Me.cherry.Size = New System.Drawing.Size(84, 28)
        Me.cherry.TabIndex = 2
        Me.cherry.Text = "Cherry"
        Me.cherry.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cherry)
        Me.Panel1.Controls.Add(Me.oak)
        Me.Panel1.Controls.Add(Me.pine)
        Me.Panel1.Location = New System.Drawing.Point(85, 86)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(114, 81)
        Me.Panel1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 253)
        Me.Controls.Add(Me.bclear)
        Me.Controls.Add(Me.calculate)
        Me.Controls.Add(Me.lblEstimate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtlinearfeet)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Extimate"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txtlinearfeet As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblEstimate As Label
    Friend WithEvents calculate As Button
    Friend WithEvents bclear As Button
    Friend WithEvents pine As RadioButton
    Friend WithEvents oak As RadioButton
    Friend WithEvents cherry As RadioButton
    Friend WithEvents Panel1 As Panel
End Class
