﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.components = New System.ComponentModel.Container()
        Me.lblAdmin = New System.Windows.Forms.Label()
        Me.gbSearch = New System.Windows.Forms.GroupBox()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.Button_Delete = New System.Windows.Forms.Button()
        Me.Button_Search = New System.Windows.Forms.Button()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.btnNewCard = New System.Windows.Forms.Button()
        Me.SearchDGV = New System.Windows.Forms.DataGridView()
        Me.UserID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Suffix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CemeteryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetNameDGVBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GraveSampleDataSet1 = New Cemetary_Proj.GraveSampleDataSet1()
        Me.cbCemetery = New System.Windows.Forms.ComboBox()
        Me.txtLN = New System.Windows.Forms.TextBox()
        Me.txtFN = New System.Windows.Forms.TextBox()
        Me.gbHistory = New System.Windows.Forms.GroupBox()
        Me.MaskedTextBox_DateIssued = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox_Address = New System.Windows.Forms.TextBox()
        Me.TxtBoxTitleNum = New System.Windows.Forms.TextBox()
        Me.TextBox_TitleHolder = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gbLocation = New System.Windows.Forms.GroupBox()
        Me.TextBox_Tier = New System.Windows.Forms.TextBox()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.ComboBox_Phase = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox_LotNum = New System.Windows.Forms.TextBox()
        Me.TextBox_TypeMemorial = New System.Windows.Forms.TextBox()
        Me.TextBox_Section = New System.Windows.Forms.TextBox()
        Me.TextBox_Cemetery = New System.Windows.Forms.TextBox()
        Me.TextBox_NameOnMemor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.gbRemarks = New System.Windows.Forms.GroupBox()
        Me.lblDocuments = New System.Windows.Forms.Label()
        Me.btn_UploadFile = New System.Windows.Forms.Button()
        Me.TextBox_Price = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox_Desc = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.gbDeceased = New System.Windows.Forms.GroupBox()
        Me.btn_AddDec = New System.Windows.Forms.Button()
        Me.DeceasedDGV = New System.Windows.Forms.DataGridView()
        Me.FNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CasketDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GetDaPplBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GraveSampleDataSet2 = New Cemetary_Proj.GraveSampleDataSet2()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GraveSampleDataSet = New Cemetary_Proj.GraveSampleDataSet()
        Me.RetNameDGVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RetNameDGVTableAdapter = New Cemetary_Proj.GraveSampleDataSetTableAdapters.RetNameDGVTableAdapter()
        Me.RetNameDGVTableAdapter1 = New Cemetary_Proj.GraveSampleDataSet1TableAdapters.RetNameDGVTableAdapter()
        Me.GetDaPplTableAdapter = New Cemetary_Proj.GraveSampleDataSet2TableAdapters.GetDaPplTableAdapter()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnViewDocs = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Form1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gbSearch.SuspendLayout()
        CType(Me.SearchDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RetNameDGVBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GraveSampleDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbHistory.SuspendLayout()
        Me.gbLocation.SuspendLayout()
        Me.gbRemarks.SuspendLayout()
        Me.gbDeceased.SuspendLayout()
        CType(Me.DeceasedDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetDaPplBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GraveSampleDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GraveSampleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RetNameDGVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Form1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAdmin
        '
        Me.lblAdmin.AutoSize = True
        Me.lblAdmin.CausesValidation = False
        Me.lblAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdmin.Location = New System.Drawing.Point(23, 16)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(53, 16)
        Me.lblAdmin.TabIndex = 0
        Me.lblAdmin.Text = "Admin?"
        '
        'gbSearch
        '
        Me.gbSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gbSearch.Controls.Add(Me.Button_Save)
        Me.gbSearch.Controls.Add(Me.Button_Delete)
        Me.gbSearch.Controls.Add(Me.Button_Search)
        Me.gbSearch.Controls.Add(Me.lblSearch)
        Me.gbSearch.Controls.Add(Me.btnNewCard)
        Me.gbSearch.Controls.Add(Me.lblAdmin)
        Me.gbSearch.Controls.Add(Me.SearchDGV)
        Me.gbSearch.Controls.Add(Me.cbCemetery)
        Me.gbSearch.Controls.Add(Me.txtLN)
        Me.gbSearch.Controls.Add(Me.txtFN)

        Me.gbSearch.Location = New System.Drawing.Point(31, 12)

        Me.gbSearch.Name = "gbSearch"
        Me.gbSearch.Size = New System.Drawing.Size(867, 228)
        Me.gbSearch.TabIndex = 31
        Me.gbSearch.TabStop = False
        '
        'Button_Save
        '
        Me.Button_Save.Location = New System.Drawing.Point(225, 199)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(130, 23)
        Me.Button_Save.TabIndex = 6
        Me.Button_Save.Text = "Edit Record"
        Me.Button_Save.UseVisualStyleBackColor = True
        '
        'Button_Delete
        '
        Me.Button_Delete.Location = New System.Drawing.Point(555, 199)
        Me.Button_Delete.Name = "Button_Delete"
        Me.Button_Delete.Size = New System.Drawing.Size(130, 23)
        Me.Button_Delete.TabIndex = 8
        Me.Button_Delete.Text = "Delete Record"
        Me.Button_Delete.UseVisualStyleBackColor = True
        '
        'Button_Search
        '
        Me.Button_Search.BackColor = System.Drawing.SystemColors.Control
        Me.Button_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_Search.Location = New System.Drawing.Point(786, 42)
        Me.Button_Search.Name = "Button_Search"
        Me.Button_Search.Size = New System.Drawing.Size(75, 23)
        Me.Button_Search.TabIndex = 4
        Me.Button_Search.Text = "Search"
        Me.Button_Search.UseVisualStyleBackColor = False
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.Location = New System.Drawing.Point(413, 9)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(80, 25)
        Me.lblSearch.TabIndex = 10
        Me.lblSearch.Text = "Search"
        Me.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNewCard
        '
        Me.btnNewCard.Location = New System.Drawing.Point(390, 200)
        Me.btnNewCard.Name = "btnNewCard"
        Me.btnNewCard.Size = New System.Drawing.Size(130, 23)
        Me.btnNewCard.TabIndex = 7
        Me.btnNewCard.Text = "Add New Card"
        Me.btnNewCard.UseVisualStyleBackColor = True
        '
        'SearchDGV
        '
        Me.SearchDGV.AllowUserToAddRows = False
        Me.SearchDGV.AllowUserToDeleteRows = False
        Me.SearchDGV.AutoGenerateColumns = False
        Me.SearchDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SearchDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.SearchDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SearchDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserID, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.Suffix, Me.CemeteryDataGridViewTextBoxColumn})
        Me.SearchDGV.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SearchDGV.DataSource = Me.RetNameDGVBindingSource1
        Me.SearchDGV.Location = New System.Drawing.Point(6, 69)
        Me.SearchDGV.Name = "SearchDGV"
        Me.SearchDGV.Size = New System.Drawing.Size(855, 124)
        Me.SearchDGV.TabIndex = 5
        '
        'UserID
        '
        Me.UserID.DataPropertyName = "UserID"
        Me.UserID.HeaderText = "Title ID"
        Me.UserID.Name = "UserID"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'Suffix
        '
        Me.Suffix.DataPropertyName = "Suffix"
        Me.Suffix.HeaderText = "Suffix"
        Me.Suffix.Name = "Suffix"
        '
        'CemeteryDataGridViewTextBoxColumn
        '
        Me.CemeteryDataGridViewTextBoxColumn.DataPropertyName = "Cemetery"
        Me.CemeteryDataGridViewTextBoxColumn.HeaderText = "Cemetery"
        Me.CemeteryDataGridViewTextBoxColumn.Name = "CemeteryDataGridViewTextBoxColumn"
        '
        'RetNameDGVBindingSource1
        '
        Me.RetNameDGVBindingSource1.DataMember = "RetNameDGV"
        Me.RetNameDGVBindingSource1.DataSource = Me.GraveSampleDataSet1
        '
        'GraveSampleDataSet1
        '
        Me.GraveSampleDataSet1.DataSetName = "GraveSampleDataSet1"
        Me.GraveSampleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbCemetery
        '
        Me.cbCemetery.FormattingEnabled = True
        Me.cbCemetery.Items.AddRange(New Object() {"St. Francis de Sales Cemetery # 1", "St. Francis de Sales Cemetery #2", "St. Joseph"})
        Me.cbCemetery.Location = New System.Drawing.Point(546, 43)
        Me.cbCemetery.Name = "cbCemetery"
        Me.cbCemetery.Size = New System.Drawing.Size(212, 21)
        Me.cbCemetery.TabIndex = 3
        Me.cbCemetery.Text = "Select Cemetery"
        '
        'txtLN
        '
        Me.txtLN.Location = New System.Drawing.Point(379, 44)
        Me.txtLN.Name = "txtLN"
        Me.txtLN.Size = New System.Drawing.Size(150, 20)
        Me.txtLN.TabIndex = 2
        Me.txtLN.Text = "Last Name"
        Me.txtLN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFN
        '
        Me.txtFN.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.txtFN.Location = New System.Drawing.Point(212, 44)
        Me.txtFN.Name = "txtFN"
        Me.txtFN.Size = New System.Drawing.Size(150, 20)
        Me.txtFN.TabIndex = 1
        Me.txtFN.Text = "First Name"
        Me.txtFN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbHistory
        '
        Me.gbHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gbHistory.Controls.Add(Me.MaskedTextBox_DateIssued)
        Me.gbHistory.Controls.Add(Me.PictureBox1)
        Me.gbHistory.Controls.Add(Me.TextBox_Address)
        Me.gbHistory.Controls.Add(Me.TxtBoxTitleNum)
        Me.gbHistory.Controls.Add(Me.TextBox_TitleHolder)
        Me.gbHistory.Controls.Add(Me.Label6)
        Me.gbHistory.Controls.Add(Me.Label5)
        Me.gbHistory.Controls.Add(Me.Label3)
        Me.gbHistory.Controls.Add(Me.Label2)
        Me.gbHistory.Controls.Add(Me.Label1)

        Me.gbHistory.Location = New System.Drawing.Point(31, 265)

        Me.gbHistory.Name = "gbHistory"
        Me.gbHistory.Size = New System.Drawing.Size(867, 216)
        Me.gbHistory.TabIndex = 32
        Me.gbHistory.TabStop = False
        '
        'MaskedTextBox_DateIssued
        '
        Me.MaskedTextBox_DateIssued.Location = New System.Drawing.Point(770, 50)
        Me.MaskedTextBox_DateIssued.Mask = "00/00/0000"
        Me.MaskedTextBox_DateIssued.Name = "MaskedTextBox_DateIssued"
        Me.MaskedTextBox_DateIssued.ReadOnly = True
        Me.MaskedTextBox_DateIssued.Size = New System.Drawing.Size(71, 20)
        Me.MaskedTextBox_DateIssued.TabIndex = 10
        Me.MaskedTextBox_DateIssued.ValidatingType = GetType(Date)
        '
        'TextBox_Address
        '
        Me.TextBox_Address.Location = New System.Drawing.Point(367, 95)
        Me.TextBox_Address.Multiline = True
        Me.TextBox_Address.Name = "TextBox_Address"
        Me.TextBox_Address.ReadOnly = True
        Me.TextBox_Address.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox_Address.Size = New System.Drawing.Size(240, 40)
        Me.TextBox_Address.TabIndex = 11
        '
        'TxtBoxTitleNum
        '
        Me.TxtBoxTitleNum.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.TxtBoxTitleNum.Location = New System.Drawing.Point(770, 94)
        Me.TxtBoxTitleNum.Name = "TxtBoxTitleNum"
        Me.TxtBoxTitleNum.ReadOnly = True
        Me.TxtBoxTitleNum.Size = New System.Drawing.Size(71, 20)
        Me.TxtBoxTitleNum.TabIndex = 12
        '
        'TextBox_TitleHolder
        '
        Me.TextBox_TitleHolder.Location = New System.Drawing.Point(367, 49)
        Me.TextBox_TitleHolder.Multiline = True
        Me.TextBox_TitleHolder.Name = "TextBox_TitleHolder"
        Me.TextBox_TitleHolder.ReadOnly = True
        Me.TextBox_TitleHolder.Size = New System.Drawing.Size(240, 40)
        Me.TextBox_TitleHolder.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(681, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Title Number:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(299, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Address:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(681, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Date Issued:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(282, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Title Holder:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(350, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "History of Ownership"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(315, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Tier:"
        '
        'gbLocation
        '
        Me.gbLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gbLocation.Controls.Add(Me.TextBox_Tier)
        Me.gbLocation.Controls.Add(Me.VScrollBar1)
        Me.gbLocation.Controls.Add(Me.ComboBox_Phase)
        Me.gbLocation.Controls.Add(Me.Label13)
        Me.gbLocation.Controls.Add(Me.PictureBox2)
        Me.gbLocation.Controls.Add(Me.TextBox_LotNum)
        Me.gbLocation.Controls.Add(Me.TextBox_TypeMemorial)
        Me.gbLocation.Controls.Add(Me.TextBox_Section)
        Me.gbLocation.Controls.Add(Me.Label4)
        Me.gbLocation.Controls.Add(Me.TextBox_Cemetery)
        Me.gbLocation.Controls.Add(Me.TextBox_NameOnMemor)
        Me.gbLocation.Controls.Add(Me.Label7)
        Me.gbLocation.Controls.Add(Me.Label8)
        Me.gbLocation.Controls.Add(Me.Label9)
        Me.gbLocation.Controls.Add(Me.Label10)
        Me.gbLocation.Controls.Add(Me.Label11)
        Me.gbLocation.Controls.Add(Me.Label12)

        Me.gbLocation.Location = New System.Drawing.Point(31, 498)

        Me.gbLocation.Name = "gbLocation"
        Me.gbLocation.Size = New System.Drawing.Size(867, 239)
        Me.gbLocation.TabIndex = 33
        Me.gbLocation.TabStop = False
        '
        'TextBox_Tier
        '
        Me.TextBox_Tier.Location = New System.Drawing.Point(355, 71)
        Me.TextBox_Tier.Name = "TextBox_Tier"
        Me.TextBox_Tier.ReadOnly = True
        Me.TextBox_Tier.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Tier.TabIndex = 15
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(850, -216)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(17, 492)
        Me.VScrollBar1.TabIndex = 24
        '
        'ComboBox_Phase
        '
        Me.ComboBox_Phase.BackColor = System.Drawing.SystemColors.Menu
        Me.ComboBox_Phase.FormattingEnabled = True
        Me.ComboBox_Phase.Location = New System.Drawing.Point(209, 189)
        Me.ComboBox_Phase.Name = "ComboBox_Phase"
        Me.ComboBox_Phase.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox_Phase.TabIndex = 19
        Me.ComboBox_Phase.Text = "Select Phase"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(153, 190)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 16)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Phase:"
        '
        'TextBox_LotNum
        '
        Me.TextBox_LotNum.Location = New System.Drawing.Point(209, 131)
        Me.TextBox_LotNum.Name = "TextBox_LotNum"
        Me.TextBox_LotNum.ReadOnly = True
        Me.TextBox_LotNum.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_LotNum.TabIndex = 17
        '
        'TextBox_TypeMemorial
        '
        Me.TextBox_TypeMemorial.Location = New System.Drawing.Point(209, 159)
        Me.TextBox_TypeMemorial.Name = "TextBox_TypeMemorial"
        Me.TextBox_TypeMemorial.ReadOnly = True
        Me.TextBox_TypeMemorial.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_TypeMemorial.TabIndex = 18
        '
        'TextBox_Section
        '
        Me.TextBox_Section.Location = New System.Drawing.Point(209, 101)
        Me.TextBox_Section.Name = "TextBox_Section"
        Me.TextBox_Section.ReadOnly = True
        Me.TextBox_Section.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Section.TabIndex = 16
        '
        'TextBox_Cemetery
        '
        Me.TextBox_Cemetery.Location = New System.Drawing.Point(209, 72)
        Me.TextBox_Cemetery.Name = "TextBox_Cemetery"
        Me.TextBox_Cemetery.ReadOnly = True
        Me.TextBox_Cemetery.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Cemetery.TabIndex = 14
        '
        'TextBox_NameOnMemor
        '
        Me.TextBox_NameOnMemor.Location = New System.Drawing.Point(209, 45)
        Me.TextBox_NameOnMemor.Multiline = True
        Me.TextBox_NameOnMemor.Name = "TextBox_NameOnMemor"
        Me.TextBox_NameOnMemor.ReadOnly = True
        Me.TextBox_NameOnMemor.Size = New System.Drawing.Size(246, 20)
        Me.TextBox_NameOnMemor.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(123, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Lot Number:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(87, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 16)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Type of Memorial:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(134, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 16)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Cemetery:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(147, 101)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 16)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Section:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(78, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(125, 16)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Name on Memorial:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(349, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(212, 25)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Location of Memorial"
        '
        'gbRemarks
        '
        Me.gbRemarks.Controls.Add(Me.btnViewDocs)
        Me.gbRemarks.Controls.Add(Me.lblDocuments)
        Me.gbRemarks.Controls.Add(Me.btn_UploadFile)
        Me.gbRemarks.Controls.Add(Me.TextBox_Price)
        Me.gbRemarks.Controls.Add(Me.Label16)
        Me.gbRemarks.Controls.Add(Me.TextBox_Desc)
        Me.gbRemarks.Controls.Add(Me.Label15)
        Me.gbRemarks.Controls.Add(Me.Label14)

        Me.gbRemarks.Location = New System.Drawing.Point(31, 743)

        Me.gbRemarks.Name = "gbRemarks"
        Me.gbRemarks.Size = New System.Drawing.Size(867, 96)
        Me.gbRemarks.TabIndex = 34
        Me.gbRemarks.TabStop = False
        '
        'lblDocuments
        '
        Me.lblDocuments.AutoSize = True
        Me.lblDocuments.Location = New System.Drawing.Point(586, 65)
        Me.lblDocuments.Name = "lblDocuments"
        Me.lblDocuments.Size = New System.Drawing.Size(61, 13)
        Me.lblDocuments.TabIndex = 28
        Me.lblDocuments.Text = "Documents"
        '
        'btn_UploadFile
        '

        Me.btn_UploadFile.Location = New System.Drawing.Point(709, 60)
        Me.btn_UploadFile.Name = "btn_UploadFile"
        Me.btn_UploadFile.Size = New System.Drawing.Size(130, 23)
        Me.btn_UploadFile.TabIndex = 27
        Me.btn_UploadFile.Text = "Upload Document"
        Me.btn_UploadFile.UseVisualStyleBackColor = True

        '
        'TextBox_Price
        '
        Me.TextBox_Price.Location = New System.Drawing.Point(424, 62)
        Me.TextBox_Price.Name = "TextBox_Price"
        Me.TextBox_Price.ReadOnly = True
        Me.TextBox_Price.Size = New System.Drawing.Size(85, 20)
        Me.TextBox_Price.TabIndex = 21
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(379, 63)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 16)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "Price:"
        '
        'TextBox_Desc
        '
        Me.TextBox_Desc.Location = New System.Drawing.Point(121, 50)
        Me.TextBox_Desc.Multiline = True
        Me.TextBox_Desc.Name = "TextBox_Desc"
        Me.TextBox_Desc.ReadOnly = True
        Me.TextBox_Desc.Size = New System.Drawing.Size(240, 40)
        Me.TextBox_Desc.TabIndex = 20
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(36, 63)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 16)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Description:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(408, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 25)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Remarks"
        '
        'gbDeceased
        '
        Me.gbDeceased.Controls.Add(Me.btn_AddDec)
        Me.gbDeceased.Controls.Add(Me.DeceasedDGV)
        Me.gbDeceased.Controls.Add(Me.Label17)

        Me.gbDeceased.Location = New System.Drawing.Point(31, 845)

        Me.gbDeceased.Name = "gbDeceased"
        Me.gbDeceased.Size = New System.Drawing.Size(867, 227)
        Me.gbDeceased.TabIndex = 35
        Me.gbDeceased.TabStop = False
        '
        'btn_AddDec
        '
        Me.btn_AddDec.Location = New System.Drawing.Point(717, 19)
        Me.btn_AddDec.Name = "btn_AddDec"
        Me.btn_AddDec.Size = New System.Drawing.Size(130, 23)
        Me.btn_AddDec.TabIndex = 23
        Me.btn_AddDec.Text = "Add Deceased"
        Me.btn_AddDec.UseVisualStyleBackColor = True
        '
        'DeceasedDGV
        '
        Me.DeceasedDGV.AllowUserToAddRows = False
        Me.DeceasedDGV.AllowUserToDeleteRows = False
        Me.DeceasedDGV.AutoGenerateColumns = False
        Me.DeceasedDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DeceasedDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FNameDataGridViewTextBoxColumn, Me.LNameDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.SexDataGridViewTextBoxColumn, Me.PositionDataGridViewTextBoxColumn, Me.CasketDataGridViewTextBoxColumn})
        Me.DeceasedDGV.DataSource = Me.GetDaPplBindingSource
        Me.DeceasedDGV.Location = New System.Drawing.Point(20, 50)
        Me.DeceasedDGV.Name = "DeceasedDGV"
        Me.DeceasedDGV.Size = New System.Drawing.Size(841, 171)
        Me.DeceasedDGV.TabIndex = 24
        '
        'FNameDataGridViewTextBoxColumn
        '
        Me.FNameDataGridViewTextBoxColumn.DataPropertyName = "FName"
        Me.FNameDataGridViewTextBoxColumn.HeaderText = "FName"
        Me.FNameDataGridViewTextBoxColumn.Name = "FNameDataGridViewTextBoxColumn"
        Me.FNameDataGridViewTextBoxColumn.Width = 150
        '
        'LNameDataGridViewTextBoxColumn
        '
        Me.LNameDataGridViewTextBoxColumn.DataPropertyName = "LName"
        Me.LNameDataGridViewTextBoxColumn.HeaderText = "LName"
        Me.LNameDataGridViewTextBoxColumn.Name = "LNameDataGridViewTextBoxColumn"
        Me.LNameDataGridViewTextBoxColumn.Width = 150
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.Width = 200
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        Me.AgeDataGridViewTextBoxColumn.Width = 50
        '
        'SexDataGridViewTextBoxColumn
        '
        Me.SexDataGridViewTextBoxColumn.DataPropertyName = "Sex"
        Me.SexDataGridViewTextBoxColumn.HeaderText = "Sex"
        Me.SexDataGridViewTextBoxColumn.Name = "SexDataGridViewTextBoxColumn"
        Me.SexDataGridViewTextBoxColumn.Width = 50
        '
        'PositionDataGridViewTextBoxColumn
        '
        Me.PositionDataGridViewTextBoxColumn.DataPropertyName = "Position"
        Me.PositionDataGridViewTextBoxColumn.HeaderText = "Position"
        Me.PositionDataGridViewTextBoxColumn.Name = "PositionDataGridViewTextBoxColumn"
        '
        'CasketDataGridViewTextBoxColumn
        '
        Me.CasketDataGridViewTextBoxColumn.DataPropertyName = "Casket"
        Me.CasketDataGridViewTextBoxColumn.HeaderText = "Casket"
        Me.CasketDataGridViewTextBoxColumn.Name = "CasketDataGridViewTextBoxColumn"
        '
        'GetDaPplBindingSource
        '
        Me.GetDaPplBindingSource.DataMember = "GetDaPpl"
        Me.GetDaPplBindingSource.DataSource = Me.GraveSampleDataSet2
        '
        'GraveSampleDataSet2
        '
        Me.GraveSampleDataSet2.DataSetName = "GraveSampleDataSet2"
        Me.GraveSampleDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(400, 15)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(109, 25)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Deceased"
        '
        'GraveSampleDataSet
        '
        Me.GraveSampleDataSet.DataSetName = "GraveSampleDataSet"
        Me.GraveSampleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RetNameDGVBindingSource
        '
        Me.RetNameDGVBindingSource.DataMember = "RetNameDGV"
        Me.RetNameDGVBindingSource.DataSource = Me.GraveSampleDataSet
        '
        'RetNameDGVTableAdapter
        '
        Me.RetNameDGVTableAdapter.ClearBeforeFill = True
        '
        'RetNameDGVTableAdapter1
        '
        Me.RetNameDGVTableAdapter1.ClearBeforeFill = True
        '
        'GetDaPplTableAdapter
        '
        Me.GetDaPplTableAdapter.ClearBeforeFill = True
        '

        'BackgroundWorker1
        '
        '
        'btnViewDocs
        '
        Me.btnViewDocs.Location = New System.Drawing.Point(709, 19)
        Me.btnViewDocs.Name = "btnViewDocs"
        Me.btnViewDocs.Size = New System.Drawing.Size(130, 23)
        Me.btnViewDocs.TabIndex = 29
        Me.btnViewDocs.Text = "View Documents"
        Me.btnViewDocs.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Cemetary_Proj.My.Resources.Resources.GenericMap
        Me.PictureBox2.Location = New System.Drawing.Point(479, 46)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(222, 166)
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Cemetary_Proj.My.Resources.Resources.CemeteryRegisterPicture
        Me.PictureBox1.Location = New System.Drawing.Point(9, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(222, 155)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'Form1BindingSource
        '
        Me.Form1BindingSource.DataSource = GetType(Cemetary_Proj.Form1)
        '

        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(0, 85)
        Me.AutoScrollMinSize = New System.Drawing.Size(0, 85)

        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1136, 698)

        Me.Controls.Add(Me.gbDeceased)
        Me.Controls.Add(Me.gbRemarks)
        Me.Controls.Add(Me.gbLocation)
        Me.Controls.Add(Me.gbHistory)
        Me.Controls.Add(Me.gbSearch)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.gbSearch.ResumeLayout(False)
        Me.gbSearch.PerformLayout()
        CType(Me.SearchDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RetNameDGVBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GraveSampleDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbHistory.ResumeLayout(False)
        Me.gbHistory.PerformLayout()
        Me.gbLocation.ResumeLayout(False)
        Me.gbLocation.PerformLayout()
        Me.gbRemarks.ResumeLayout(False)
        Me.gbRemarks.PerformLayout()
        Me.gbDeceased.ResumeLayout(False)
        Me.gbDeceased.PerformLayout()
        CType(Me.DeceasedDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetDaPplBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GraveSampleDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GraveSampleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RetNameDGVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Form1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblAdmin As Label
    Friend WithEvents gbSearch As GroupBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents btnNewCard As Button
    Friend WithEvents SearchDGV As DataGridView
    Friend WithEvents cbCemetery As ComboBox
    Friend WithEvents txtLN As TextBox
    Friend WithEvents txtFN As TextBox
    Friend WithEvents gbHistory As GroupBox
    Friend WithEvents MaskedTextBox_DateIssued As MaskedTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox_Address As TextBox
    Friend WithEvents TxtBoxTitleNum As TextBox
    Friend WithEvents TextBox_TitleHolder As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents gbLocation As GroupBox
    Friend WithEvents ComboBox_Phase As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox_LotNum As TextBox
    Friend WithEvents TextBox_TypeMemorial As TextBox
    Friend WithEvents TextBox_Section As TextBox
    Friend WithEvents TextBox_Cemetery As TextBox
    Friend WithEvents TextBox_NameOnMemor As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents gbRemarks As GroupBox
    Friend WithEvents lblDocuments As Label
    Friend WithEvents btn_UploadFile As Button
    Friend WithEvents TextBox_Price As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox_Desc As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents gbDeceased As GroupBox
    Friend WithEvents DeceasedDGV As DataGridView
    Friend WithEvents Label17 As Label
    Friend WithEvents Button_Delete As Button
    Friend WithEvents Button_Search As Button
    Friend WithEvents Button_Save As Button
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents RetNameDGVBindingSource As BindingSource
    Friend WithEvents GraveSampleDataSet As GraveSampleDataSet
    Friend WithEvents Form1BindingSource As BindingSource
    Friend WithEvents RetNameDGVTableAdapter As GraveSampleDataSetTableAdapters.RetNameDGVTableAdapter
    Friend WithEvents RetNameDGVBindingSource1 As BindingSource
    Friend WithEvents GraveSampleDataSet1 As GraveSampleDataSet1
    Friend WithEvents RetNameDGVTableAdapter1 As GraveSampleDataSet1TableAdapters.RetNameDGVTableAdapter
    Friend WithEvents UserID As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Suffix As DataGridViewTextBoxColumn
    Friend WithEvents CemeteryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GetDaPplBindingSource As BindingSource
    Friend WithEvents GraveSampleDataSet2 As GraveSampleDataSet2
    Friend WithEvents GetDaPplTableAdapter As GraveSampleDataSet2TableAdapters.GetDaPplTableAdapter
    Friend WithEvents TextBox_Tier As TextBox
    Friend WithEvents FNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PositionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CasketDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btn_AddDec As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnViewDocs As Button
End Class
