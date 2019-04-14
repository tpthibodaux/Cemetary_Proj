<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_ViewFiles
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
        Me.dgvFiles = New System.Windows.Forms.DataGridView()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImgDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GrabImagesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GraveSampleDataSet3 = New Cemetary_Proj.GraveSampleDataSet3()
        Me.GrabImagesTableAdapter = New Cemetary_Proj.GraveSampleDataSet3TableAdapters.GrabImagesTableAdapter()
        Me.btnTxt = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.dgvFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrabImagesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GraveSampleDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvFiles
        '
        Me.dgvFiles.AutoGenerateColumns = False
        Me.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFiles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.DescrDataGridViewTextBoxColumn, Me.ImgDataGridViewImageColumn})
        Me.dgvFiles.DataSource = Me.GrabImagesBindingSource
        Me.dgvFiles.Location = New System.Drawing.Point(2, 3)
        Me.dgvFiles.Name = "dgvFiles"
        Me.dgvFiles.Size = New System.Drawing.Size(1045, 315)
        Me.dgvFiles.TabIndex = 0
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "File Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.Width = 200
        '
        'DescrDataGridViewTextBoxColumn
        '
        Me.DescrDataGridViewTextBoxColumn.DataPropertyName = "descr"
        Me.DescrDataGridViewTextBoxColumn.HeaderText = "File Description"
        Me.DescrDataGridViewTextBoxColumn.Name = "DescrDataGridViewTextBoxColumn"
        Me.DescrDataGridViewTextBoxColumn.Width = 200
        '
        'ImgDataGridViewImageColumn
        '
        Me.ImgDataGridViewImageColumn.DataPropertyName = "img"
        Me.ImgDataGridViewImageColumn.HeaderText = "Image"
        Me.ImgDataGridViewImageColumn.Name = "ImgDataGridViewImageColumn"
        Me.ImgDataGridViewImageColumn.Width = 600
        '
        'GrabImagesBindingSource
        '
        Me.GrabImagesBindingSource.DataMember = "GrabImages"
        Me.GrabImagesBindingSource.DataSource = Me.GraveSampleDataSet3
        '
        'GraveSampleDataSet3
        '
        Me.GraveSampleDataSet3.DataSetName = "GraveSampleDataSet3"
        Me.GraveSampleDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GrabImagesTableAdapter
        '
        Me.GrabImagesTableAdapter.ClearBeforeFill = True
        '
        'btnTxt
        '
        Me.btnTxt.Location = New System.Drawing.Point(150, 359)
        Me.btnTxt.Name = "btnTxt"
        Me.btnTxt.Size = New System.Drawing.Size(136, 26)
        Me.btnTxt.TabIndex = 1
        Me.btnTxt.Text = "Exit"
        Me.btnTxt.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(691, 359)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 26)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Delete File"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form_ViewFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 554)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnTxt)
        Me.Controls.Add(Me.dgvFiles)
        Me.Name = "Form_ViewFiles"
        Me.Text = "Form_ViewFiles"
        CType(Me.dgvFiles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrabImagesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GraveSampleDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvFiles As DataGridView
    Friend WithEvents GrabImagesBindingSource As BindingSource
    Friend WithEvents GraveSampleDataSet3 As GraveSampleDataSet3
    Friend WithEvents GrabImagesTableAdapter As GraveSampleDataSet3TableAdapters.GrabImagesTableAdapter
    Friend WithEvents btnTxt As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImgDataGridViewImageColumn As DataGridViewImageColumn
End Class
