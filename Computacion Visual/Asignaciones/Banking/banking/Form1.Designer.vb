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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.week = New System.Windows.Forms.Label()
        Me.viewhour = New System.Windows.Forms.Button()
        Me.hour = New System.Windows.Forms.Label()
        Me.leave = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.banking.My.Resources.Resources._1stNat_1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(177, 188)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(205, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 78)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "First Corner National Bank"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(257, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "FDIC Insured"
        '
        'week
        '
        Me.week.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.week.Location = New System.Drawing.Point(56, 220)
        Me.week.Name = "week"
        Me.week.Size = New System.Drawing.Size(141, 63)
        Me.week.TabIndex = 3
        Me.week.Text = "Monday–Thursday" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Friday " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Saturday"
        Me.week.Visible = False
        '
        'viewhour
        '
        Me.viewhour.BackColor = System.Drawing.Color.NavajoWhite
        Me.viewhour.Location = New System.Drawing.Point(249, 144)
        Me.viewhour.Name = "viewhour"
        Me.viewhour.Size = New System.Drawing.Size(120, 24)
        Me.viewhour.TabIndex = 4
        Me.viewhour.Text = "View Banking Hours"
        Me.viewhour.UseVisualStyleBackColor = False
        '
        'hour
        '
        Me.hour.AutoSize = True
        Me.hour.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hour.Location = New System.Drawing.Point(246, 223)
        Me.hour.Name = "hour"
        Me.hour.Size = New System.Drawing.Size(124, 60)
        Me.hour.TabIndex = 5
        Me.hour.Text = "9:00am-5:00pm" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "9:00am-8:00pm" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "9:00am-1:00 pm" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.hour.Visible = False
        '
        'leave
        '
        Me.leave.BackColor = System.Drawing.Color.NavajoWhite
        Me.leave.Location = New System.Drawing.Point(176, 297)
        Me.leave.Name = "leave"
        Me.leave.Size = New System.Drawing.Size(75, 23)
        Me.leave.TabIndex = 7
        Me.leave.Text = "Exit Window"
        Me.leave.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.ClientSize = New System.Drawing.Size(426, 334)
        Me.Controls.Add(Me.leave)
        Me.Controls.Add(Me.hour)
        Me.Controls.Add(Me.viewhour)
        Me.Controls.Add(Me.week)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Bank Welcome Screen with Banking Hours"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents week As Label
    Friend WithEvents viewhour As Button
    Friend WithEvents hour As Label
    Friend WithEvents leave As Button
End Class
