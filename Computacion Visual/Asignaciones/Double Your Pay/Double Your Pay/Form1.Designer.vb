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
        Me.Days = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.newEmployeeButton = New System.Windows.Forms.RadioButton()
        Me.expEmployeeButton = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.calculate = New System.Windows.Forms.Button()
        Me.display = New System.Windows.Forms.Label()
        Me.display2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Days
        '
        Me.Days.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Days.Location = New System.Drawing.Point(109, 39)
        Me.Days.Name = "Days"
        Me.Days.Size = New System.Drawing.Size(38, 26)
        Me.Days.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 43)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter the amount of days worked " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(16-22 days):"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 51)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Select if it's a New or Experienced Employee:"
        '
        'newEmployeeButton
        '
        Me.newEmployeeButton.AutoSize = True
        Me.newEmployeeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newEmployeeButton.Location = New System.Drawing.Point(3, 3)
        Me.newEmployeeButton.Name = "newEmployeeButton"
        Me.newEmployeeButton.Size = New System.Drawing.Size(108, 19)
        Me.newEmployeeButton.TabIndex = 3
        Me.newEmployeeButton.TabStop = True
        Me.newEmployeeButton.Text = "New Employee"
        Me.newEmployeeButton.UseVisualStyleBackColor = True
        '
        'expEmployeeButton
        '
        Me.expEmployeeButton.AutoSize = True
        Me.expEmployeeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expEmployeeButton.Location = New System.Drawing.Point(3, 28)
        Me.expEmployeeButton.Name = "expEmployeeButton"
        Me.expEmployeeButton.Size = New System.Drawing.Size(152, 19)
        Me.expEmployeeButton.TabIndex = 4
        Me.expEmployeeButton.TabStop = True
        Me.expEmployeeButton.Text = "Experienced Employee"
        Me.expEmployeeButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.newEmployeeButton)
        Me.Panel1.Controls.Add(Me.expEmployeeButton)
        Me.Panel1.Location = New System.Drawing.Point(64, 115)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(163, 54)
        Me.Panel1.TabIndex = 5
        '
        'calculate
        '
        Me.calculate.AutoSize = True
        Me.calculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.calculate.Location = New System.Drawing.Point(88, 174)
        Me.calculate.Name = "calculate"
        Me.calculate.Size = New System.Drawing.Size(115, 30)
        Me.calculate.TabIndex = 6
        Me.calculate.Text = "Calculate Pay"
        Me.calculate.UseVisualStyleBackColor = True
        '
        'display
        '
        Me.display.AutoSize = True
        Me.display.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.display.Location = New System.Drawing.Point(6, 207)
        Me.display.Name = "display"
        Me.display.Size = New System.Drawing.Size(57, 20)
        Me.display.TabIndex = 7
        Me.display.Text = "Label3"
        '
        'display2
        '
        Me.display2.AutoSize = True
        Me.display2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.display2.Location = New System.Drawing.Point(6, 227)
        Me.display2.Name = "display2"
        Me.display2.Size = New System.Drawing.Size(57, 20)
        Me.display2.TabIndex = 8
        Me.display2.Text = "Label3"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(290, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Form1
        '
        Me.AcceptButton = Me.calculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 251)
        Me.Controls.Add(Me.display2)
        Me.Controls.Add(Me.display)
        Me.Controls.Add(Me.calculate)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Days)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Double Your Pay"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Days As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents newEmployeeButton As RadioButton
    Friend WithEvents expEmployeeButton As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents calculate As Button
    Friend WithEvents display As Label
    Friend WithEvents display2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
