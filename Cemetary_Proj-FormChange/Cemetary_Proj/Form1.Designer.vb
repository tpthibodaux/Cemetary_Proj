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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblTimeStamp = New System.Windows.Forms.Label()
        Me.lblAdmin = New System.Windows.Forms.Label()
        Me.txtFN = New System.Windows.Forms.TextBox()
        Me.txtLN = New System.Windows.Forms.TextBox()
        Me.cbCemetery = New System.Windows.Forms.ComboBox()
        Me.SearchDGV = New System.Windows.Forms.DataGridView()
        Me.First_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Last_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cemetery = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNewCard = New System.Windows.Forms.Button()
        Me.gbSearch = New System.Windows.Forms.GroupBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.gbHistory = New System.Windows.Forms.GroupBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbLocation = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.gbRemarks = New System.Windows.Forms.GroupBox()
        Me.lblDocuments = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.gbDeceased = New System.Windows.Forms.GroupBox()
        Me.DeceasedDGV = New System.Windows.Forms.DataGridView()
        Me.Column_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameOfDeceased = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Age = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Position = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Casket = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblLastUpdate = New System.Windows.Forms.Label()
        CType(Me.SearchDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSearch.SuspendLayout()
        Me.gbHistory.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbLocation.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRemarks.SuspendLayout()
        Me.gbDeceased.SuspendLayout()
        CType(Me.DeceasedDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTimeStamp
        '
        Me.lblTimeStamp.AutoSize = True
        Me.lblTimeStamp.Location = New System.Drawing.Point(12, 744)
        Me.lblTimeStamp.Name = "lblTimeStamp"
        Me.lblTimeStamp.Size = New System.Drawing.Size(0, 13)
        Me.lblTimeStamp.TabIndex = 0
        '
        'lblAdmin
        '
        Me.lblAdmin.AutoSize = True
        Me.lblAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdmin.Location = New System.Drawing.Point(12, 5)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(53, 16)
        Me.lblAdmin.TabIndex = 1
        Me.lblAdmin.Text = "Admin?"
        '
        'txtFN
        '
        Me.txtFN.Location = New System.Drawing.Point(210, 44)
        Me.txtFN.Name = "txtFN"
        Me.txtFN.Size = New System.Drawing.Size(111, 20)
        Me.txtFN.TabIndex = 2
        Me.txtFN.Text = "First Name"
        Me.txtFN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLN
        '
        Me.txtLN.Location = New System.Drawing.Point(327, 44)
        Me.txtLN.Name = "txtLN"
        Me.txtLN.Size = New System.Drawing.Size(111, 20)
        Me.txtLN.TabIndex = 3
        Me.txtLN.Text = "Last Name"
        Me.txtLN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbCemetery
        '
        Me.cbCemetery.FormattingEnabled = True
        Me.cbCemetery.Items.AddRange(New Object() {"St. Francis de Sales Cemetery # 1", "St. Francis de Sales Cemetery #2", "St. Joseph"})
        Me.cbCemetery.Location = New System.Drawing.Point(440, 44)
        Me.cbCemetery.Name = "cbCemetery"
        Me.cbCemetery.Size = New System.Drawing.Size(212, 21)
        Me.cbCemetery.TabIndex = 4
        Me.cbCemetery.Text = "Select Cemetery"
        '
        'SearchDGV
        '
        Me.SearchDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SearchDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.SearchDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SearchDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.First_Name, Me.Last_Name, Me.Cemetery})
        Me.SearchDGV.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SearchDGV.Location = New System.Drawing.Point(6, 69)
        Me.SearchDGV.Name = "SearchDGV"
        Me.SearchDGV.Size = New System.Drawing.Size(855, 124)
        Me.SearchDGV.TabIndex = 5
        '
        'First_Name
        '
        Me.First_Name.HeaderText = "First Name"
        Me.First_Name.Name = "First_Name"
        '
        'Last_Name
        '
        Me.Last_Name.HeaderText = "Last Name"
        Me.Last_Name.Name = "Last_Name"
        '
        'Cemetery
        '
        Me.Cemetery.HeaderText = "Cemetery"
        Me.Cemetery.Name = "Cemetery"
        '
        'btnNewCard
        '
        Me.btnNewCard.Location = New System.Drawing.Point(338, 199)
        Me.btnNewCard.Name = "btnNewCard"
        Me.btnNewCard.Size = New System.Drawing.Size(100, 23)
        Me.btnNewCard.TabIndex = 6
        Me.btnNewCard.Text = "Add New Card"
        Me.btnNewCard.UseVisualStyleBackColor = True
        '
        'gbSearch
        '
        Me.gbSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gbSearch.Controls.Add(Me.lblSearch)
        Me.gbSearch.Controls.Add(Me.btnNewCard)
        Me.gbSearch.Controls.Add(Me.SearchDGV)
        Me.gbSearch.Controls.Add(Me.cbCemetery)
        Me.gbSearch.Controls.Add(Me.txtLN)
        Me.gbSearch.Controls.Add(Me.txtFN)
        Me.gbSearch.Location = New System.Drawing.Point(1, 20)
        Me.gbSearch.Name = "gbSearch"
        Me.gbSearch.Size = New System.Drawing.Size(867, 228)
        Me.gbSearch.TabIndex = 7
        Me.gbSearch.TabStop = False
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.Location = New System.Drawing.Point(344, 16)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(80, 25)
        Me.lblSearch.TabIndex = 10
        Me.lblSearch.Text = "Search"
        '
        'gbHistory
        '
        Me.gbHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gbHistory.Controls.Add(Me.MaskedTextBox1)
        Me.gbHistory.Controls.Add(Me.PictureBox1)
        Me.gbHistory.Controls.Add(Me.TextBox5)
        Me.gbHistory.Controls.Add(Me.TextBox4)
        Me.gbHistory.Controls.Add(Me.TextBox2)
        Me.gbHistory.Controls.Add(Me.TextBox1)
        Me.gbHistory.Controls.Add(Me.Label6)
        Me.gbHistory.Controls.Add(Me.Label5)
        Me.gbHistory.Controls.Add(Me.Label4)
        Me.gbHistory.Controls.Add(Me.Label3)
        Me.gbHistory.Controls.Add(Me.Label2)
        Me.gbHistory.Controls.Add(Me.Label1)
        Me.gbHistory.Location = New System.Drawing.Point(1, 249)
        Me.gbHistory.Name = "gbHistory"
        Me.gbHistory.Size = New System.Drawing.Size(867, 216)
        Me.gbHistory.TabIndex = 8
        Me.gbHistory.TabStop = False
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(770, 50)
        Me.MaskedTextBox1.Mask = "00/00/0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(71, 20)
        Me.MaskedTextBox1.TabIndex = 23
        Me.MaskedTextBox1.ValidatingType = GetType(Date)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(222, 155)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(367, 138)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox5.Size = New System.Drawing.Size(240, 40)
        Me.TextBox5.TabIndex = 19
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(770, 94)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(71, 20)
        Me.TextBox4.TabIndex = 18
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(367, 94)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(240, 40)
        Me.TextBox2.TabIndex = 16
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(367, 49)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(240, 40)
        Me.TextBox1.TabIndex = 15
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
        Me.Label5.Location = New System.Drawing.Point(299, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Address:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(278, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Title Owners:"
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
        Me.Label1.Location = New System.Drawing.Point(267, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "History of Ownership"
        '
        'gbLocation
        '
        Me.gbLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gbLocation.Controls.Add(Me.ComboBox1)
        Me.gbLocation.Controls.Add(Me.Label13)
        Me.gbLocation.Controls.Add(Me.PictureBox2)
        Me.gbLocation.Controls.Add(Me.TextBox6)
        Me.gbLocation.Controls.Add(Me.TextBox7)
        Me.gbLocation.Controls.Add(Me.TextBox8)
        Me.gbLocation.Controls.Add(Me.TextBox9)
        Me.gbLocation.Controls.Add(Me.TextBox10)
        Me.gbLocation.Controls.Add(Me.Label7)
        Me.gbLocation.Controls.Add(Me.Label8)
        Me.gbLocation.Controls.Add(Me.Label9)
        Me.gbLocation.Controls.Add(Me.Label10)
        Me.gbLocation.Controls.Add(Me.Label11)
        Me.gbLocation.Controls.Add(Me.Label12)
        Me.gbLocation.Location = New System.Drawing.Point(1, 466)
        Me.gbLocation.Name = "gbLocation"
        Me.gbLocation.Size = New System.Drawing.Size(867, 239)
        Me.gbLocation.TabIndex = 20
        Me.gbLocation.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(209, 189)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.TabIndex = 23
        Me.ComboBox1.Text = "Select Phase"
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
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Cemetary_Proj.My.Resources.Resources.GenericMap
        Me.PictureBox2.Location = New System.Drawing.Point(479, 46)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(222, 166)
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(209, 131)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 19
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(209, 159)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 18
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(209, 101)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(100, 20)
        Me.TextBox8.TabIndex = 17
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(209, 72)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(100, 20)
        Me.TextBox9.TabIndex = 16
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(209, 45)
        Me.TextBox10.Multiline = True
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(246, 20)
        Me.TextBox10.TabIndex = 15
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
        Me.Label12.Location = New System.Drawing.Point(276, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(212, 25)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Location of Memorial"
        '
        'gbRemarks
        '
        Me.gbRemarks.Controls.Add(Me.lblDocuments)
        Me.gbRemarks.Controls.Add(Me.Button1)
        Me.gbRemarks.Controls.Add(Me.TextBox12)
        Me.gbRemarks.Controls.Add(Me.Label16)
        Me.gbRemarks.Controls.Add(Me.TextBox11)
        Me.gbRemarks.Controls.Add(Me.Label15)
        Me.gbRemarks.Controls.Add(Me.Label14)
        Me.gbRemarks.Location = New System.Drawing.Point(1, 706)
        Me.gbRemarks.Name = "gbRemarks"
        Me.gbRemarks.Size = New System.Drawing.Size(867, 96)
        Me.gbRemarks.TabIndex = 21
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(709, 60)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Upload Document"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(424, 62)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(85, 20)
        Me.TextBox12.TabIndex = 26
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
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(121, 50)
        Me.TextBox11.Multiline = True
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(240, 40)
        Me.TextBox11.TabIndex = 24
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
        Me.Label14.Location = New System.Drawing.Point(362, 21)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 25)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Remarks"
        '
        'gbDeceased
        '
        Me.gbDeceased.Controls.Add(Me.DeceasedDGV)
        Me.gbDeceased.Controls.Add(Me.Label17)
        Me.gbDeceased.Location = New System.Drawing.Point(1, 803)
        Me.gbDeceased.Name = "gbDeceased"
        Me.gbDeceased.Size = New System.Drawing.Size(867, 227)
        Me.gbDeceased.TabIndex = 28
        Me.gbDeceased.TabStop = False
        '
        'DeceasedDGV
        '
        Me.DeceasedDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DeceasedDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column_Date, Me.NameOfDeceased, Me.Sex, Me.Age, Me.Position, Me.Casket})
        Me.DeceasedDGV.Location = New System.Drawing.Point(6, 50)
        Me.DeceasedDGV.Name = "DeceasedDGV"
        Me.DeceasedDGV.Size = New System.Drawing.Size(855, 171)
        Me.DeceasedDGV.TabIndex = 29
        '
        'Column_Date
        '
        Me.Column_Date.HeaderText = "Date"
        Me.Column_Date.Name = "Column_Date"
        Me.Column_Date.Width = 75
        '
        'NameOfDeceased
        '
        Me.NameOfDeceased.HeaderText = "Name of Deceased"
        Me.NameOfDeceased.Name = "NameOfDeceased"
        Me.NameOfDeceased.Width = 467
        '
        'Sex
        '
        Me.Sex.HeaderText = "Sex"
        Me.Sex.Name = "Sex"
        Me.Sex.Width = 35
        '
        'Age
        '
        Me.Age.HeaderText = "Age"
        Me.Age.Name = "Age"
        Me.Age.Width = 35
        '
        'Position
        '
        Me.Position.HeaderText = "Position"
        Me.Position.Name = "Position"
        '
        'Casket
        '
        Me.Casket.HeaderText = "Casket"
        Me.Casket.Name = "Casket"
        Me.Casket.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(346, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(109, 25)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Deceased"
        '
        'lblLastUpdate
        '
        Me.lblLastUpdate.AutoSize = True
        Me.lblLastUpdate.Location = New System.Drawing.Point(7, 1038)
        Me.lblLastUpdate.Name = "lblLastUpdate"
        Me.lblLastUpdate.Size = New System.Drawing.Size(166, 13)
        Me.lblLastUpdate.TabIndex = 30
        Me.lblLastUpdate.Text = "Last Updated 2/23/2019 7:26PM"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(869, 1062)
        Me.Controls.Add(Me.lblLastUpdate)
        Me.Controls.Add(Me.gbDeceased)
        Me.Controls.Add(Me.gbRemarks)
        Me.Controls.Add(Me.gbLocation)
        Me.Controls.Add(Me.gbHistory)
        Me.Controls.Add(Me.gbSearch)
        Me.Controls.Add(Me.lblAdmin)
        Me.Controls.Add(Me.lblTimeStamp)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.SearchDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSearch.ResumeLayout(False)
        Me.gbSearch.PerformLayout()
        Me.gbHistory.ResumeLayout(False)
        Me.gbHistory.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbLocation.ResumeLayout(False)
        Me.gbLocation.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRemarks.ResumeLayout(False)
        Me.gbRemarks.PerformLayout()
        Me.gbDeceased.ResumeLayout(False)
        Me.gbDeceased.PerformLayout()
        CType(Me.DeceasedDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTimeStamp As Label
    Friend WithEvents lblAdmin As Label
    Friend WithEvents txtFN As TextBox
    Friend WithEvents txtLN As TextBox
    Friend WithEvents cbCemetery As ComboBox
    Friend WithEvents SearchDGV As DataGridView
    Friend WithEvents btnNewCard As Button
    Friend WithEvents gbSearch As GroupBox
    Friend WithEvents gbHistory As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents gbLocation As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents gbRemarks As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents gbDeceased As GroupBox
    Friend WithEvents DeceasedDGV As DataGridView
    Friend WithEvents Label17 As Label
    Friend WithEvents lblLastUpdate As Label
    Friend WithEvents First_Name As DataGridViewTextBoxColumn
    Friend WithEvents Last_Name As DataGridViewTextBoxColumn
    Friend WithEvents Cemetery As DataGridViewTextBoxColumn
    Friend WithEvents Column_Date As DataGridViewTextBoxColumn
    Friend WithEvents NameOfDeceased As DataGridViewTextBoxColumn
    Friend WithEvents Sex As DataGridViewTextBoxColumn
    Friend WithEvents Age As DataGridViewTextBoxColumn
    Friend WithEvents Position As DataGridViewTextBoxColumn
    Friend WithEvents Casket As DataGridViewTextBoxColumn
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents lblDocuments As Label
End Class
