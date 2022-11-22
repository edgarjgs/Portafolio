<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AlaskaButton = New System.Windows.Forms.RadioButton()
        Me.MainlandUSButton = New System.Windows.Forms.RadioButton()
        Me.HawaiiButton = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PoundsBox = New System.Windows.Forms.TextBox()
        Me.Bclear = New System.Windows.Forms.Button()
        Me.Calculate = New System.Windows.Forms.Button()
        Me.Cost = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(38, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Shipping Cost Calculator:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AlaskaButton)
        Me.GroupBox1.Controls.Add(Me.MainlandUSButton)
        Me.GroupBox1.Controls.Add(Me.HawaiiButton)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(60, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(176, 113)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Location:"
        '
        'AlaskaButton
        '
        Me.AlaskaButton.AutoSize = True
        Me.AlaskaButton.Location = New System.Drawing.Point(6, 83)
        Me.AlaskaButton.Name = "AlaskaButton"
        Me.AlaskaButton.Size = New System.Drawing.Size(83, 28)
        Me.AlaskaButton.TabIndex = 1
        Me.AlaskaButton.Text = "Alaska"
        Me.AlaskaButton.UseVisualStyleBackColor = True
        '
        'MainlandUSButton
        '
        Me.MainlandUSButton.AutoSize = True
        Me.MainlandUSButton.Checked = True
        Me.MainlandUSButton.Location = New System.Drawing.Point(6, 27)
        Me.MainlandUSButton.Name = "MainlandUSButton"
        Me.MainlandUSButton.Size = New System.Drawing.Size(152, 28)
        Me.MainlandUSButton.TabIndex = 0
        Me.MainlandUSButton.TabStop = True
        Me.MainlandUSButton.Text = "Continental US"
        Me.MainlandUSButton.UseVisualStyleBackColor = True
        '
        'HawaiiButton
        '
        Me.HawaiiButton.AutoSize = True
        Me.HawaiiButton.Location = New System.Drawing.Point(6, 55)
        Me.HawaiiButton.Name = "HawaiiButton"
        Me.HawaiiButton.Size = New System.Drawing.Size(84, 28)
        Me.HawaiiButton.TabIndex = 2
        Me.HawaiiButton.Text = "Hawaii"
        Me.HawaiiButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(20, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Weight (Pounds):"
        '
        'PoundsBox
        '
        Me.PoundsBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.PoundsBox.Location = New System.Drawing.Point(177, 155)
        Me.PoundsBox.Name = "PoundsBox"
        Me.PoundsBox.Size = New System.Drawing.Size(100, 29)
        Me.PoundsBox.TabIndex = 3
        '
        'Bclear
        '
        Me.Bclear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Bclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Bclear.Location = New System.Drawing.Point(159, 243)
        Me.Bclear.Name = "Bclear"
        Me.Bclear.Size = New System.Drawing.Size(101, 33)
        Me.Bclear.TabIndex = 9
        Me.Bclear.Text = "Clear"
        Me.Bclear.UseVisualStyleBackColor = True
        '
        'Calculate
        '
        Me.Calculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Calculate.Location = New System.Drawing.Point(37, 243)
        Me.Calculate.Name = "Calculate"
        Me.Calculate.Size = New System.Drawing.Size(101, 33)
        Me.Calculate.TabIndex = 8
        Me.Calculate.Text = "Calculate"
        Me.Calculate.UseVisualStyleBackColor = True
        '
        'Cost
        '
        Me.Cost.AutoSize = True
        Me.Cost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Cost.Location = New System.Drawing.Point(185, 200)
        Me.Cost.Name = "Cost"
        Me.Cost.Size = New System.Drawing.Size(65, 24)
        Me.Cost.TabIndex = 11
        Me.Cost.Text = "$00.00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(47, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 24)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Shipping Cost:"
        '
        'Form1
        '
        Me.AcceptButton = Me.Calculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Bclear
        Me.ClientSize = New System.Drawing.Size(297, 287)
        Me.Controls.Add(Me.Cost)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Bclear)
        Me.Controls.Add(Me.Calculate)
        Me.Controls.Add(Me.PoundsBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Two-Day Package Shipping"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents HawaiiButton As RadioButton
    Friend WithEvents AlaskaButton As RadioButton
    Friend WithEvents MainlandUSButton As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents PoundsBox As TextBox
    Friend WithEvents Bclear As Button
    Friend WithEvents Calculate As Button
    Friend WithEvents Cost As Label
    Friend WithEvents Label3 As Label
End Class
