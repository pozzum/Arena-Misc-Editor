<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ObjectArrayEditor
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToCSVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ChairNum = New Arena_Misc_Editor.NumericUpDownColumn()
        Me.Enabled = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ChairName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.X = New Arena_Misc_Editor.NumericUpDownColumn()
        Me.Y = New Arena_Misc_Editor.NumericUpDownColumn()
        Me.Z = New Arena_Misc_Editor.NumericUpDownColumn()
        Me.RX = New Arena_Misc_Editor.NumericUpDownColumn()
        Me.RY = New Arena_Misc_Editor.NumericUpDownColumn()
        Me.RZ = New Arena_Misc_Editor.NumericUpDownColumn()
        Me.Dec1 = New Arena_Misc_Editor.NumericUpDownColumn()
        Me.Dec2 = New Arena_Misc_Editor.NumericUpDownColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.NumericUpDownColumn1 = New Arena_Misc_Editor.NumericUpDownColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumericUpDownColumn2 = New Arena_Misc_Editor.NumericUpDownColumn()
        Me.NumericUpDownColumn3 = New Arena_Misc_Editor.NumericUpDownColumn()
        Me.NumericUpDownColumn4 = New Arena_Misc_Editor.NumericUpDownColumn()
        Me.NumericUpDownColumn5 = New Arena_Misc_Editor.NumericUpDownColumn()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(684, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ExportToCSVToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ExportToCSVToolStripMenuItem
        '
        Me.ExportToCSVToolStripMenuItem.Name = "ExportToCSVToolStripMenuItem"
        Me.ExportToCSVToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExportToCSVToolStripMenuItem.Text = "Export to CSV"
        Me.ExportToCSVToolStripMenuItem.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(684, 387)
        Me.Panel1.TabIndex = 2
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(684, 387)
        Me.SplitContainer1.SplitterDistance = 499
        Me.SplitContainer1.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ChairNum, Me.Enabled, Me.ChairName, Me.X, Me.Y, Me.Z, Me.RX, Me.RY, Me.RZ, Me.Dec1, Me.Dec2})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(499, 387)
        Me.DataGridView1.TabIndex = 0
        '
        'ChairNum
        '
        Me.ChairNum.Frozen = True
        Me.ChairNum.HeaderText = "Number"
        Me.ChairNum.Name = "ChairNum"
        Me.ChairNum.ReadOnly = True
        Me.ChairNum.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ChairNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ChairNum.Width = 69
        '
        'Enabled
        '
        Me.Enabled.HeaderText = "Enabled"
        Me.Enabled.Name = "Enabled"
        Me.Enabled.Width = 52
        '
        'ChairName
        '
        Me.ChairName.HeaderText = "Name"
        Me.ChairName.Name = "ChairName"
        Me.ChairName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ChairName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ChairName.Width = 41
        '
        'X
        '
        Me.X.HeaderText = "X"
        Me.X.Name = "X"
        Me.X.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.X.Width = 20
        '
        'Y
        '
        Me.Y.HeaderText = "Y"
        Me.Y.Name = "Y"
        Me.Y.Width = 20
        '
        'Z
        '
        Me.Z.HeaderText = "Z"
        Me.Z.Name = "Z"
        Me.Z.Width = 20
        '
        'RX
        '
        Me.RX.HeaderText = "RX"
        Me.RX.Name = "RX"
        Me.RX.Width = 28
        '
        'RY
        '
        Me.RY.HeaderText = "RY"
        Me.RY.Name = "RY"
        Me.RY.Width = 28
        '
        'RZ
        '
        Me.RZ.HeaderText = "RZ"
        Me.RZ.Name = "RZ"
        Me.RZ.Width = 28
        '
        'Dec1
        '
        Me.Dec1.HeaderText = "D1"
        Me.Dec1.Name = "Dec1"
        Me.Dec1.Width = 27
        '
        'Dec2
        '
        Me.Dec2.HeaderText = "D2"
        Me.Dec2.Name = "Dec2"
        Me.Dec2.Width = 27
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "00.dat"
        '
        'NumericUpDownColumn1
        '
        Me.NumericUpDownColumn1.Frozen = True
        Me.NumericUpDownColumn1.HeaderText = "Number"
        Me.NumericUpDownColumn1.Name = "NumericUpDownColumn1"
        Me.NumericUpDownColumn1.ReadOnly = True
        Me.NumericUpDownColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NumericUpDownColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.NumericUpDownColumn1.Width = 69
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 41
        '
        'NumericUpDownColumn2
        '
        Me.NumericUpDownColumn2.HeaderText = "X"
        Me.NumericUpDownColumn2.Name = "NumericUpDownColumn2"
        Me.NumericUpDownColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NumericUpDownColumn2.Width = 20
        '
        'NumericUpDownColumn3
        '
        Me.NumericUpDownColumn3.HeaderText = "Y"
        Me.NumericUpDownColumn3.Name = "NumericUpDownColumn3"
        Me.NumericUpDownColumn3.Width = 20
        '
        'NumericUpDownColumn4
        '
        Me.NumericUpDownColumn4.HeaderText = "Z"
        Me.NumericUpDownColumn4.Name = "NumericUpDownColumn4"
        Me.NumericUpDownColumn4.Width = 20
        '
        'NumericUpDownColumn5
        '
        Me.NumericUpDownColumn5.HeaderText = "R"
        Me.NumericUpDownColumn5.Name = "NumericUpDownColumn5"
        Me.NumericUpDownColumn5.Width = 21
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "00.csv"
        Me.SaveFileDialog1.Filter = "Comma Seperated Value File|*.csv|All files (*.*)|*.*"
        '
        'ObjectArrayEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 411)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ObjectArrayEditor"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Object Array Editor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ExportToCSVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NumericUpDownColumn1 As NumericUpDownColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NumericUpDownColumn2 As NumericUpDownColumn
    Friend WithEvents NumericUpDownColumn3 As NumericUpDownColumn
    Friend WithEvents NumericUpDownColumn4 As NumericUpDownColumn
    Friend WithEvents NumericUpDownColumn5 As NumericUpDownColumn
    Friend WithEvents ChairNum As NumericUpDownColumn
    Friend WithEvents Enabled As DataGridViewCheckBoxColumn
    Friend WithEvents ChairName As DataGridViewTextBoxColumn
    Friend WithEvents X As NumericUpDownColumn
    Friend WithEvents Y As NumericUpDownColumn
    Friend WithEvents Z As NumericUpDownColumn
    Friend WithEvents RX As NumericUpDownColumn
    Friend WithEvents RY As NumericUpDownColumn
    Friend WithEvents RZ As NumericUpDownColumn
    Friend WithEvents Dec1 As NumericUpDownColumn
    Friend WithEvents Dec2 As NumericUpDownColumn
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
