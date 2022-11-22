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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Calculate = New System.Windows.Forms.Button()
        Me.BClear = New System.Windows.Forms.Button()
        Me.Bexit = New System.Windows.Forms.Button()
        Me.SongcountBox = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 24.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Digital Downloads"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.Label2.Location = New System.Drawing.Point(40, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(14, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Number of Song Downloads:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(14, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total Cost of Download:"
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Total.Location = New System.Drawing.Point(198, 192)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(57, 20)
        Me.Total.TabIndex = 4
        Me.Total.Text = "Label5"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.download_music.My.Resources.Resources.singer_clipart_png_images_singer_png_263_350
        Me.PictureBox1.Location = New System.Drawing.Point(288, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 134)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Calculate
        '
        Me.Calculate.Location = New System.Drawing.Point(41, 236)
        Me.Calculate.Name = "Calculate"
        Me.Calculate.Size = New System.Drawing.Size(95, 23)
        Me.Calculate.TabIndex = 6
        Me.Calculate.Text = "Calculate Cost"
        Me.Calculate.UseVisualStyleBackColor = True
        '
        'BClear
        '
        Me.BClear.Location = New System.Drawing.Point(157, 236)
        Me.BClear.Name = "BClear"
        Me.BClear.Size = New System.Drawing.Size(95, 23)
        Me.BClear.TabIndex = 7
        Me.BClear.Text = "Clear"
        Me.BClear.UseVisualStyleBackColor = True
        '
        'Bexit
        '
        Me.Bexit.Location = New System.Drawing.Point(273, 236)
        Me.Bexit.Name = "Bexit"
        Me.Bexit.Size = New System.Drawing.Size(95, 23)
        Me.Bexit.TabIndex = 8
        Me.Bexit.Text = "Exit"
        Me.Bexit.UseVisualStyleBackColor = True
        '
        'SongcountBox
        '
        Me.SongcountBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.SongcountBox.Location = New System.Drawing.Point(232, 148)
        Me.SongcountBox.Name = "SongcountBox"
        Me.SongcountBox.Size = New System.Drawing.Size(49, 26)
        Me.SongcountBox.TabIndex = 9
        '
        'Form1
        '
        Me.AcceptButton = Me.Calculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(407, 284)
        Me.Controls.Add(Me.SongcountBox)
        Me.Controls.Add(Me.Bexit)
        Me.Controls.Add(Me.BClear)
        Me.Controls.Add(Me.Calculate)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Download Music"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Total As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Calculate As Button
    Friend WithEvents BClear As Button
    Friend WithEvents Bexit As Button
    Friend WithEvents SongcountBox As TextBox
End Class
