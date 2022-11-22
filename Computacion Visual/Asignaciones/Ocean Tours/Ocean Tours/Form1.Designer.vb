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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblTourType = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnFindCost = New System.Windows.Forms.Button()
        Me.lstTours = New System.Windows.Forms.ListBox()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.txtNumberInParty = New System.Windows.Forms.TextBox()
        Me.lblParty = New System.Windows.Forms.Label()
        Me.cboIsland = New System.Windows.Forms.ComboBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblLength)
        Me.Panel1.Controls.Add(Me.lblCost)
        Me.Panel1.Controls.Add(Me.lblTourType)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnFindCost)
        Me.Panel1.Controls.Add(Me.lstTours)
        Me.Panel1.Controls.Add(Me.lblSelect)
        Me.Panel1.Controls.Add(Me.txtNumberInParty)
        Me.Panel1.Controls.Add(Me.lblParty)
        Me.Panel1.Controls.Add(Me.cboIsland)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(204, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(311, 316)
        Me.Panel1.TabIndex = 2
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLength.Location = New System.Drawing.Point(84, 295)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(49, 16)
        Me.lblLength.TabIndex = 10
        Me.lblLength.Text = "Label6"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(84, 269)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(49, 16)
        Me.lblCost.TabIndex = 9
        Me.lblCost.Text = "Label5"
        '
        'lblTourType
        '
        Me.lblTourType.AutoSize = True
        Me.lblTourType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTourType.Location = New System.Drawing.Point(84, 243)
        Me.lblTourType.Name = "lblTourType"
        Me.lblTourType.Size = New System.Drawing.Size(49, 16)
        Me.lblTourType.TabIndex = 8
        Me.lblTourType.Text = "Label4"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(203, 217)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnFindCost
        '
        Me.btnFindCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindCost.Location = New System.Drawing.Point(33, 217)
        Me.btnFindCost.Name = "btnFindCost"
        Me.btnFindCost.Size = New System.Drawing.Size(75, 23)
        Me.btnFindCost.TabIndex = 6
        Me.btnFindCost.Text = "Find Cost"
        Me.btnFindCost.UseVisualStyleBackColor = True
        '
        'lstTours
        '
        Me.lstTours.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTours.FormattingEnabled = True
        Me.lstTours.ItemHeight = 16
        Me.lstTours.Location = New System.Drawing.Point(87, 127)
        Me.lstTours.Name = "lstTours"
        Me.lstTours.Size = New System.Drawing.Size(136, 84)
        Me.lstTours.TabIndex = 5
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelect.Location = New System.Drawing.Point(94, 102)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(123, 16)
        Me.lblSelect.TabIndex = 4
        Me.lblSelect.Text = "Select Ocean Tour:"
        '
        'txtNumberInParty
        '
        Me.txtNumberInParty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberInParty.Location = New System.Drawing.Point(203, 70)
        Me.txtNumberInParty.Name = "txtNumberInParty"
        Me.txtNumberInParty.Size = New System.Drawing.Size(37, 22)
        Me.txtNumberInParty.TabIndex = 3
        '
        'lblParty
        '
        Me.lblParty.AutoSize = True
        Me.lblParty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParty.Location = New System.Drawing.Point(68, 73)
        Me.lblParty.Name = "lblParty"
        Me.lblParty.Size = New System.Drawing.Size(109, 16)
        Me.lblParty.TabIndex = 2
        Me.lblParty.Text = "Number in Party: "
        '
        'cboIsland
        '
        Me.cboIsland.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIsland.FormattingEnabled = True
        Me.cboIsland.Items.AddRange(New Object() {" Aruba", "Jamaica", "Key West "})
        Me.cboIsland.Location = New System.Drawing.Point(71, 38)
        Me.cboIsland.Name = "cboIsland"
        Me.cboIsland.Size = New System.Drawing.Size(169, 24)
        Me.cboIsland.TabIndex = 1
        Me.cboIsland.Text = "Select Island Location"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.DarkOrange
        Me.lblTitle.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(3, 8)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(305, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Ocean Tours Information"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Ocean_Tours.My.Resources.Resources.sunset_view_13
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(197, 316)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(518, 318)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ocean Tours"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblLength As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents lblTourType As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnFindCost As Button
    Friend WithEvents lstTours As ListBox
    Friend WithEvents lblSelect As Label
    Friend WithEvents txtNumberInParty As TextBox
    Friend WithEvents lblParty As Label
    Friend WithEvents cboIsland As ComboBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
