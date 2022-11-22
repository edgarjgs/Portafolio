<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View
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
        Me.components = New System.ComponentModel.Container()
        Dim CANTIDADLabel As System.Windows.Forms.Label
        Dim DESCRIPCIONLabel As System.Windows.Forms.Label
        Dim ISBNLabel As System.Windows.Forms.Label
        Dim AUTORLabel As System.Windows.Forms.Label
        Dim TITULOLabel As System.Windows.Forms.Label
        Dim NUM_LIBROLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(View))
        Me.BIBLIOTECADataSet = New Database.BIBLIOTECADataSet()
        Me.LIBROSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LIBROSTableAdapter = New Database.BIBLIOTECADataSetTableAdapters.LIBROSTableAdapter()
        Me.TableAdapterManager = New Database.BIBLIOTECADataSetTableAdapters.TableAdapterManager()
        Me.LIBROSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.LIBROSBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.HomeLabel = New System.Windows.Forms.ToolStripLabel()
        Me.TableLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ExitLabel = New System.Windows.Forms.ToolStripLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CANTIDADTextBox = New System.Windows.Forms.TextBox()
        Me.DESCRIPCIONTextBox = New System.Windows.Forms.TextBox()
        Me.ISBNTextBox = New System.Windows.Forms.TextBox()
        Me.AUTORTextBox = New System.Windows.Forms.TextBox()
        Me.TITULOTextBox = New System.Windows.Forms.TextBox()
        Me.NUM_LIBROTextBox = New System.Windows.Forms.TextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        CANTIDADLabel = New System.Windows.Forms.Label()
        DESCRIPCIONLabel = New System.Windows.Forms.Label()
        ISBNLabel = New System.Windows.Forms.Label()
        AUTORLabel = New System.Windows.Forms.Label()
        TITULOLabel = New System.Windows.Forms.Label()
        NUM_LIBROLabel = New System.Windows.Forms.Label()
        CType(Me.BIBLIOTECADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIBROSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIBROSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LIBROSBindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CANTIDADLabel
        '
        CANTIDADLabel.AutoSize = True
        CANTIDADLabel.Location = New System.Drawing.Point(6, 159)
        CANTIDADLabel.Name = "CANTIDADLabel"
        CANTIDADLabel.Size = New System.Drawing.Size(80, 16)
        CANTIDADLabel.TabIndex = 10
        CANTIDADLabel.Text = "CANTIDAD:"
        '
        'DESCRIPCIONLabel
        '
        DESCRIPCIONLabel.AutoSize = True
        DESCRIPCIONLabel.Location = New System.Drawing.Point(6, 133)
        DESCRIPCIONLabel.Name = "DESCRIPCIONLabel"
        DESCRIPCIONLabel.Size = New System.Drawing.Size(102, 16)
        DESCRIPCIONLabel.TabIndex = 8
        DESCRIPCIONLabel.Text = "DESCRIPCION:"
        '
        'ISBNLabel
        '
        ISBNLabel.AutoSize = True
        ISBNLabel.Location = New System.Drawing.Point(6, 107)
        ISBNLabel.Name = "ISBNLabel"
        ISBNLabel.Size = New System.Drawing.Size(42, 16)
        ISBNLabel.TabIndex = 6
        ISBNLabel.Text = "ISBN:"
        '
        'AUTORLabel
        '
        AUTORLabel.AutoSize = True
        AUTORLabel.Location = New System.Drawing.Point(6, 81)
        AUTORLabel.Name = "AUTORLabel"
        AUTORLabel.Size = New System.Drawing.Size(59, 16)
        AUTORLabel.TabIndex = 4
        AUTORLabel.Text = "AUTOR:"
        '
        'TITULOLabel
        '
        TITULOLabel.AutoSize = True
        TITULOLabel.Location = New System.Drawing.Point(6, 54)
        TITULOLabel.Name = "TITULOLabel"
        TITULOLabel.Size = New System.Drawing.Size(59, 16)
        TITULOLabel.TabIndex = 2
        TITULOLabel.Text = "TITULO:"
        '
        'NUM_LIBROLabel
        '
        NUM_LIBROLabel.AutoSize = True
        NUM_LIBROLabel.Location = New System.Drawing.Point(6, 28)
        NUM_LIBROLabel.Name = "NUM_LIBROLabel"
        NUM_LIBROLabel.Size = New System.Drawing.Size(84, 16)
        NUM_LIBROLabel.TabIndex = 0
        NUM_LIBROLabel.Text = "NUM LIBRO:"
        '
        'BIBLIOTECADataSet
        '
        Me.BIBLIOTECADataSet.DataSetName = "BIBLIOTECADataSet"
        Me.BIBLIOTECADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LIBROSBindingSource
        '
        Me.LIBROSBindingSource.DataMember = "LIBROS"
        Me.LIBROSBindingSource.DataSource = Me.BIBLIOTECADataSet
        '
        'LIBROSTableAdapter
        '
        Me.LIBROSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.LIBROSTableAdapter = Me.LIBROSTableAdapter
        Me.TableAdapterManager.UpdateOrder = Database.BIBLIOTECADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LIBROSBindingNavigator
        '
        Me.LIBROSBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.LIBROSBindingNavigator.BindingSource = Me.LIBROSBindingSource
        Me.LIBROSBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.LIBROSBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.LIBROSBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.LIBROSBindingNavigatorSaveItem, Me.ToolStripSeparator1, Me.HomeLabel, Me.ToolStripSeparator2, Me.TableLabel, Me.ToolStripSeparator3, Me.ExitLabel})
        Me.LIBROSBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.LIBROSBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.LIBROSBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.LIBROSBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.LIBROSBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.LIBROSBindingNavigator.Name = "LIBROSBindingNavigator"
        Me.LIBROSBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.LIBROSBindingNavigator.Size = New System.Drawing.Size(402, 25)
        Me.LIBROSBindingNavigator.TabIndex = 0
        Me.LIBROSBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'LIBROSBindingNavigatorSaveItem
        '
        Me.LIBROSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LIBROSBindingNavigatorSaveItem.Image = CType(resources.GetObject("LIBROSBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.LIBROSBindingNavigatorSaveItem.Name = "LIBROSBindingNavigatorSaveItem"
        Me.LIBROSBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.LIBROSBindingNavigatorSaveItem.Text = "Save Data"
        '
        'HomeLabel
        '
        Me.HomeLabel.Name = "HomeLabel"
        Me.HomeLabel.Size = New System.Drawing.Size(40, 22)
        Me.HomeLabel.Text = "Home"
        '
        'TableLabel
        '
        Me.TableLabel.Name = "TableLabel"
        Me.TableLabel.Size = New System.Drawing.Size(34, 22)
        Me.TableLabel.Text = "Table"
        '
        'ExitLabel
        '
        Me.ExitLabel.Name = "ExitLabel"
        Me.ExitLabel.Size = New System.Drawing.Size(26, 22)
        Me.ExitLabel.Text = "Exit"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(CANTIDADLabel)
        Me.GroupBox1.Controls.Add(Me.CANTIDADTextBox)
        Me.GroupBox1.Controls.Add(DESCRIPCIONLabel)
        Me.GroupBox1.Controls.Add(Me.DESCRIPCIONTextBox)
        Me.GroupBox1.Controls.Add(ISBNLabel)
        Me.GroupBox1.Controls.Add(Me.ISBNTextBox)
        Me.GroupBox1.Controls.Add(AUTORLabel)
        Me.GroupBox1.Controls.Add(Me.AUTORTextBox)
        Me.GroupBox1.Controls.Add(TITULOLabel)
        Me.GroupBox1.Controls.Add(Me.TITULOTextBox)
        Me.GroupBox1.Controls.Add(NUM_LIBROLabel)
        Me.GroupBox1.Controls.Add(Me.NUM_LIBROTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 192)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información del Libro"
        '
        'CANTIDADTextBox
        '
        Me.CANTIDADTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LIBROSBindingSource, "CANTIDAD", True))
        Me.CANTIDADTextBox.Location = New System.Drawing.Point(114, 156)
        Me.CANTIDADTextBox.Name = "CANTIDADTextBox"
        Me.CANTIDADTextBox.Size = New System.Drawing.Size(249, 22)
        Me.CANTIDADTextBox.TabIndex = 11
        '
        'DESCRIPCIONTextBox
        '
        Me.DESCRIPCIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LIBROSBindingSource, "DESCRIPCION", True))
        Me.DESCRIPCIONTextBox.Location = New System.Drawing.Point(114, 130)
        Me.DESCRIPCIONTextBox.Name = "DESCRIPCIONTextBox"
        Me.DESCRIPCIONTextBox.Size = New System.Drawing.Size(249, 22)
        Me.DESCRIPCIONTextBox.TabIndex = 9
        '
        'ISBNTextBox
        '
        Me.ISBNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LIBROSBindingSource, "ISBN", True))
        Me.ISBNTextBox.Location = New System.Drawing.Point(114, 104)
        Me.ISBNTextBox.Name = "ISBNTextBox"
        Me.ISBNTextBox.Size = New System.Drawing.Size(249, 22)
        Me.ISBNTextBox.TabIndex = 7
        '
        'AUTORTextBox
        '
        Me.AUTORTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LIBROSBindingSource, "AUTOR", True))
        Me.AUTORTextBox.Location = New System.Drawing.Point(114, 78)
        Me.AUTORTextBox.Name = "AUTORTextBox"
        Me.AUTORTextBox.Size = New System.Drawing.Size(249, 22)
        Me.AUTORTextBox.TabIndex = 5
        '
        'TITULOTextBox
        '
        Me.TITULOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LIBROSBindingSource, "TITULO", True))
        Me.TITULOTextBox.Location = New System.Drawing.Point(114, 51)
        Me.TITULOTextBox.Name = "TITULOTextBox"
        Me.TITULOTextBox.Size = New System.Drawing.Size(249, 22)
        Me.TITULOTextBox.TabIndex = 3
        '
        'NUM_LIBROTextBox
        '
        Me.NUM_LIBROTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LIBROSBindingSource, "NUM_LIBRO", True))
        Me.NUM_LIBROTextBox.Location = New System.Drawing.Point(114, 25)
        Me.NUM_LIBROTextBox.Name = "NUM_LIBROTextBox"
        Me.NUM_LIBROTextBox.ReadOnly = True
        Me.NUM_LIBROTextBox.Size = New System.Drawing.Size(249, 22)
        Me.NUM_LIBROTextBox.TabIndex = 1
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 229)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LIBROSBindingNavigator)
        Me.Name = "View"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View"
        CType(Me.BIBLIOTECADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIBROSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIBROSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LIBROSBindingNavigator.ResumeLayout(False)
        Me.LIBROSBindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BIBLIOTECADataSet As BIBLIOTECADataSet
    Friend WithEvents LIBROSBindingSource As BindingSource
    Friend WithEvents LIBROSTableAdapter As BIBLIOTECADataSetTableAdapters.LIBROSTableAdapter
    Friend WithEvents TableAdapterManager As BIBLIOTECADataSetTableAdapters.TableAdapterManager
    Friend WithEvents LIBROSBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents LIBROSBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CANTIDADTextBox As TextBox
    Friend WithEvents DESCRIPCIONTextBox As TextBox
    Friend WithEvents ISBNTextBox As TextBox
    Friend WithEvents AUTORTextBox As TextBox
    Friend WithEvents TITULOTextBox As TextBox
    Friend WithEvents NUM_LIBROTextBox As TextBox
    Friend WithEvents HomeLabel As ToolStripLabel
    Friend WithEvents ExitLabel As ToolStripLabel
    Friend WithEvents TableLabel As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
End Class
