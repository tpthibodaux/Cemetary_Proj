<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddRecord
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
        Me.Button_Add = New System.Windows.Forms.Button()
        Me.Button_Can = New System.Windows.Forms.Button()
        Me.TextBox_Tier_AddRec = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_NameOnMemor_AddRec = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbCemetery_AddRec = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox_AddRec = New System.Windows.Forms.GroupBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.txtPhase = New System.Windows.Forms.TextBox()
        Me.txtMem = New System.Windows.Forms.TextBox()
        Me.txtLotNum = New System.Windows.Forms.TextBox()
        Me.txtSection = New System.Windows.Forms.TextBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txt_City = New System.Windows.Forms.TextBox()
        Me.txtSuf4 = New System.Windows.Forms.TextBox()
        Me.txtSuf3 = New System.Windows.Forms.TextBox()
        Me.txtSuf2 = New System.Windows.Forms.TextBox()
        Me.txtSuf1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_MI_AddRec4 = New System.Windows.Forms.TextBox()
        Me.txtLN_AddRec4 = New System.Windows.Forms.TextBox()
        Me.txtFN_AddRec4 = New System.Windows.Forms.TextBox()
        Me.txt_MI_AddRec3 = New System.Windows.Forms.TextBox()
        Me.txtLN_AddRec3 = New System.Windows.Forms.TextBox()
        Me.txtFN_AddRec3 = New System.Windows.Forms.TextBox()
        Me.txt_MI_AddRec2 = New System.Windows.Forms.TextBox()
        Me.txtLN_AddRec2 = New System.Windows.Forms.TextBox()
        Me.txtFN_AddRec2 = New System.Windows.Forms.TextBox()
        Me.txt_MI_AddRec1 = New System.Windows.Forms.TextBox()
        Me.txtLN_AddRec1 = New System.Windows.Forms.TextBox()
        Me.txtFN_AddRec1 = New System.Windows.Forms.TextBox()
        Me.GraveSampleDataSet1 = New Cemetary_Proj.GraveSampleDataSet()
        Me.GroupBox_AddRec.SuspendLayout()
        CType(Me.GraveSampleDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_Add
        '
        Me.Button_Add.Location = New System.Drawing.Point(232, 376)
        Me.Button_Add.Name = "Button_Add"
        Me.Button_Add.Size = New System.Drawing.Size(107, 28)
        Me.Button_Add.TabIndex = 0
        Me.Button_Add.Text = "Add Record"
        Me.Button_Add.UseVisualStyleBackColor = True
        '
        'Button_Can
        '
        Me.Button_Can.Location = New System.Drawing.Point(452, 376)
        Me.Button_Can.Name = "Button_Can"
        Me.Button_Can.Size = New System.Drawing.Size(107, 28)
        Me.Button_Can.TabIndex = 1
        Me.Button_Can.Text = "Cancel"
        Me.Button_Can.UseVisualStyleBackColor = True
        '
        'TextBox_Tier_AddRec
        '
        Me.TextBox_Tier_AddRec.Location = New System.Drawing.Point(457, 279)
        Me.TextBox_Tier_AddRec.Name = "TextBox_Tier_AddRec"
        Me.TextBox_Tier_AddRec.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Tier_AddRec.TabIndex = 39
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(85, 284)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 16)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Phase:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(416, 282)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 16)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Tier:"
        '
        'TextBox_NameOnMemor_AddRec
        '
        Me.TextBox_NameOnMemor_AddRec.Location = New System.Drawing.Point(141, 166)
        Me.TextBox_NameOnMemor_AddRec.Multiline = True
        Me.TextBox_NameOnMemor_AddRec.Name = "TextBox_NameOnMemor_AddRec"
        Me.TextBox_NameOnMemor_AddRec.Size = New System.Drawing.Size(246, 20)
        Me.TextBox_NameOnMemor_AddRec.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(55, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Lot Number:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(19, 258)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 16)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Type of Memorial:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(79, 195)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 16)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Section:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(10, 167)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(125, 16)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Name on Memorial:"
        '
        'cbCemetery_AddRec
        '
        Me.cbCemetery_AddRec.FormattingEnabled = True
        Me.cbCemetery_AddRec.Items.AddRange(New Object() {"St. Francis de Sales Cemetery # 1", "St. Francis de Sales Cemetery #2", "St. Joseph"})
        Me.cbCemetery_AddRec.Location = New System.Drawing.Point(141, 134)
        Me.cbCemetery_AddRec.Name = "cbCemetery_AddRec"
        Me.cbCemetery_AddRec.Size = New System.Drawing.Size(212, 21)
        Me.cbCemetery_AddRec.TabIndex = 40
        Me.cbCemetery_AddRec.Text = "- -"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(25, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 16)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Select Cemetery:"
        '
        'GroupBox_AddRec
        '
        Me.GroupBox_AddRec.Controls.Add(Me.txtPrice)
        Me.GroupBox_AddRec.Controls.Add(Me.Label23)
        Me.GroupBox_AddRec.Controls.Add(Me.Label22)
        Me.GroupBox_AddRec.Controls.Add(Me.txtDesc)
        Me.GroupBox_AddRec.Controls.Add(Me.txtPhase)
        Me.GroupBox_AddRec.Controls.Add(Me.txtMem)
        Me.GroupBox_AddRec.Controls.Add(Me.txtLotNum)
        Me.GroupBox_AddRec.Controls.Add(Me.txtSection)
        Me.GroupBox_AddRec.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox_AddRec.Controls.Add(Me.Label17)
        Me.GroupBox_AddRec.Controls.Add(Me.Label16)
        Me.GroupBox_AddRec.Controls.Add(Me.txtAddress)
        Me.GroupBox_AddRec.Controls.Add(Me.Label15)
        Me.GroupBox_AddRec.Controls.Add(Me.txtZip)
        Me.GroupBox_AddRec.Controls.Add(Me.Label14)
        Me.GroupBox_AddRec.Controls.Add(Me.Label12)
        Me.GroupBox_AddRec.Controls.Add(Me.txtState)
        Me.GroupBox_AddRec.Controls.Add(Me.txt_City)
        Me.GroupBox_AddRec.Controls.Add(Me.txtSuf4)
        Me.GroupBox_AddRec.Controls.Add(Me.txtSuf3)
        Me.GroupBox_AddRec.Controls.Add(Me.txtSuf2)
        Me.GroupBox_AddRec.Controls.Add(Me.txtSuf1)
        Me.GroupBox_AddRec.Controls.Add(Me.Label6)
        Me.GroupBox_AddRec.Controls.Add(Me.Label5)
        Me.GroupBox_AddRec.Controls.Add(Me.Label3)
        Me.GroupBox_AddRec.Controls.Add(Me.Label2)
        Me.GroupBox_AddRec.Controls.Add(Me.txt_MI_AddRec4)
        Me.GroupBox_AddRec.Controls.Add(Me.txtLN_AddRec4)
        Me.GroupBox_AddRec.Controls.Add(Me.txtFN_AddRec4)
        Me.GroupBox_AddRec.Controls.Add(Me.txt_MI_AddRec3)
        Me.GroupBox_AddRec.Controls.Add(Me.txtLN_AddRec3)
        Me.GroupBox_AddRec.Controls.Add(Me.txtFN_AddRec3)
        Me.GroupBox_AddRec.Controls.Add(Me.txt_MI_AddRec2)
        Me.GroupBox_AddRec.Controls.Add(Me.txtLN_AddRec2)
        Me.GroupBox_AddRec.Controls.Add(Me.txtFN_AddRec2)
        Me.GroupBox_AddRec.Controls.Add(Me.txt_MI_AddRec1)
        Me.GroupBox_AddRec.Controls.Add(Me.txtLN_AddRec1)
        Me.GroupBox_AddRec.Controls.Add(Me.txtFN_AddRec1)
        Me.GroupBox_AddRec.Controls.Add(Me.Label1)
        Me.GroupBox_AddRec.Controls.Add(Me.cbCemetery_AddRec)
        Me.GroupBox_AddRec.Controls.Add(Me.TextBox_Tier_AddRec)
        Me.GroupBox_AddRec.Controls.Add(Me.Label13)
        Me.GroupBox_AddRec.Controls.Add(Me.Label4)
        Me.GroupBox_AddRec.Controls.Add(Me.TextBox_NameOnMemor_AddRec)
        Me.GroupBox_AddRec.Controls.Add(Me.Label7)
        Me.GroupBox_AddRec.Controls.Add(Me.Label8)
        Me.GroupBox_AddRec.Controls.Add(Me.Label10)
        Me.GroupBox_AddRec.Controls.Add(Me.Label11)
        Me.GroupBox_AddRec.Controls.Add(Me.Button_Can)
        Me.GroupBox_AddRec.Controls.Add(Me.Button_Add)
        Me.GroupBox_AddRec.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox_AddRec.Name = "GroupBox_AddRec"
        Me.GroupBox_AddRec.Size = New System.Drawing.Size(749, 404)
        Me.GroupBox_AddRec.TabIndex = 42
        Me.GroupBox_AddRec.TabStop = False
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(457, 250)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(60, 20)
        Me.txtPrice.TabIndex = 85
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(409, 250)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(42, 16)
        Me.Label23.TabIndex = 84
        Me.Label23.Text = "Price:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(55, 351)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(79, 16)
        Me.Label22.TabIndex = 83
        Me.Label22.Text = "Description:"
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(141, 350)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(511, 20)
        Me.txtDesc.TabIndex = 82
        '
        'txtPhase
        '
        Me.txtPhase.Location = New System.Drawing.Point(141, 280)
        Me.txtPhase.Name = "txtPhase"
        Me.txtPhase.Size = New System.Drawing.Size(60, 20)
        Me.txtPhase.TabIndex = 80
        '
        'txtMem
        '
        Me.txtMem.Location = New System.Drawing.Point(141, 254)
        Me.txtMem.Name = "txtMem"
        Me.txtMem.Size = New System.Drawing.Size(246, 20)
        Me.txtMem.TabIndex = 77
        '
        'txtLotNum
        '
        Me.txtLotNum.Location = New System.Drawing.Point(141, 228)
        Me.txtLotNum.Name = "txtLotNum"
        Me.txtLotNum.Size = New System.Drawing.Size(60, 20)
        Me.txtLotNum.TabIndex = 76
        '
        'txtSection
        '
        Me.txtSection.Location = New System.Drawing.Point(141, 194)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.Size = New System.Drawing.Size(60, 20)
        Me.txtSection.TabIndex = 74
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(452, 135)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 73
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(368, 139)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(83, 16)
        Me.Label17.TabIndex = 71
        Me.Label17.Text = "Date Issued:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(73, 316)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 16)
        Me.Label16.TabIndex = 69
        Me.Label16.Text = "Address:"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(141, 316)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(179, 20)
        Me.txtAddress.TabIndex = 68
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(421, 223)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(30, 16)
        Me.Label15.TabIndex = 67
        Me.Label15.Text = "Zip:"
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(457, 219)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(100, 20)
        Me.txtZip.TabIndex = 66
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(409, 197)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 16)
        Me.Label14.TabIndex = 65
        Me.Label14.Text = "State:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(418, 170)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 16)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "City:"
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(457, 193)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(100, 20)
        Me.txtState.TabIndex = 63
        '
        'txt_City
        '
        Me.txt_City.Location = New System.Drawing.Point(457, 166)
        Me.txt_City.Name = "txt_City"
        Me.txt_City.Size = New System.Drawing.Size(100, 20)
        Me.txt_City.TabIndex = 62
        '
        'txtSuf4
        '
        Me.txtSuf4.Location = New System.Drawing.Point(412, 108)
        Me.txtSuf4.Name = "txtSuf4"
        Me.txtSuf4.Size = New System.Drawing.Size(29, 20)
        Me.txtSuf4.TabIndex = 61
        Me.txtSuf4.Text = "Suf"
        '
        'txtSuf3
        '
        Me.txtSuf3.Location = New System.Drawing.Point(412, 82)
        Me.txtSuf3.Name = "txtSuf3"
        Me.txtSuf3.Size = New System.Drawing.Size(29, 20)
        Me.txtSuf3.TabIndex = 60
        Me.txtSuf3.Text = "Suf"
        '
        'txtSuf2
        '
        Me.txtSuf2.Location = New System.Drawing.Point(412, 56)
        Me.txtSuf2.Name = "txtSuf2"
        Me.txtSuf2.Size = New System.Drawing.Size(29, 20)
        Me.txtSuf2.TabIndex = 59
        Me.txtSuf2.Text = "Suf"
        '
        'txtSuf1
        '
        Me.txtSuf1.Location = New System.Drawing.Point(412, 30)
        Me.txtSuf1.Name = "txtSuf1"
        Me.txtSuf1.Size = New System.Drawing.Size(29, 20)
        Me.txtSuf1.TabIndex = 58
        Me.txtSuf1.Text = "Suf"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(25, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 16)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Title Holder 1:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(25, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 16)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Title Holder 2:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(25, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 16)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Title Holder 3:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(25, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Title Holder 4:"
        '
        'txt_MI_AddRec4
        '
        Me.txt_MI_AddRec4.Location = New System.Drawing.Point(260, 108)
        Me.txt_MI_AddRec4.Name = "txt_MI_AddRec4"
        Me.txt_MI_AddRec4.Size = New System.Drawing.Size(29, 20)
        Me.txt_MI_AddRec4.TabIndex = 53
        Me.txt_MI_AddRec4.Text = "M/I"
        '
        'txtLN_AddRec4
        '
        Me.txtLN_AddRec4.Location = New System.Drawing.Point(295, 108)
        Me.txtLN_AddRec4.Name = "txtLN_AddRec4"
        Me.txtLN_AddRec4.Size = New System.Drawing.Size(111, 20)
        Me.txtLN_AddRec4.TabIndex = 52
        Me.txtLN_AddRec4.Text = "Last Name"
        Me.txtLN_AddRec4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFN_AddRec4
        '
        Me.txtFN_AddRec4.Location = New System.Drawing.Point(141, 108)
        Me.txtFN_AddRec4.Name = "txtFN_AddRec4"
        Me.txtFN_AddRec4.Size = New System.Drawing.Size(111, 20)
        Me.txtFN_AddRec4.TabIndex = 51
        Me.txtFN_AddRec4.Text = "First Name"
        Me.txtFN_AddRec4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_MI_AddRec3
        '
        Me.txt_MI_AddRec3.Location = New System.Drawing.Point(260, 82)
        Me.txt_MI_AddRec3.Name = "txt_MI_AddRec3"
        Me.txt_MI_AddRec3.Size = New System.Drawing.Size(29, 20)
        Me.txt_MI_AddRec3.TabIndex = 50
        Me.txt_MI_AddRec3.Text = "M/I"
        '
        'txtLN_AddRec3
        '
        Me.txtLN_AddRec3.Location = New System.Drawing.Point(295, 82)
        Me.txtLN_AddRec3.Name = "txtLN_AddRec3"
        Me.txtLN_AddRec3.Size = New System.Drawing.Size(111, 20)
        Me.txtLN_AddRec3.TabIndex = 49
        Me.txtLN_AddRec3.Text = "Last Name"
        Me.txtLN_AddRec3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFN_AddRec3
        '
        Me.txtFN_AddRec3.Location = New System.Drawing.Point(141, 82)
        Me.txtFN_AddRec3.Name = "txtFN_AddRec3"
        Me.txtFN_AddRec3.Size = New System.Drawing.Size(111, 20)
        Me.txtFN_AddRec3.TabIndex = 48
        Me.txtFN_AddRec3.Text = "First Name"
        Me.txtFN_AddRec3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_MI_AddRec2
        '
        Me.txt_MI_AddRec2.Location = New System.Drawing.Point(260, 56)
        Me.txt_MI_AddRec2.Name = "txt_MI_AddRec2"
        Me.txt_MI_AddRec2.Size = New System.Drawing.Size(29, 20)
        Me.txt_MI_AddRec2.TabIndex = 47
        Me.txt_MI_AddRec2.Text = "M/I"
        '
        'txtLN_AddRec2
        '
        Me.txtLN_AddRec2.Location = New System.Drawing.Point(295, 56)
        Me.txtLN_AddRec2.Name = "txtLN_AddRec2"
        Me.txtLN_AddRec2.Size = New System.Drawing.Size(111, 20)
        Me.txtLN_AddRec2.TabIndex = 46
        Me.txtLN_AddRec2.Text = "Last Name"
        Me.txtLN_AddRec2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFN_AddRec2
        '
        Me.txtFN_AddRec2.Location = New System.Drawing.Point(141, 56)
        Me.txtFN_AddRec2.Name = "txtFN_AddRec2"
        Me.txtFN_AddRec2.Size = New System.Drawing.Size(111, 20)
        Me.txtFN_AddRec2.TabIndex = 45
        Me.txtFN_AddRec2.Text = "First Name"
        Me.txtFN_AddRec2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_MI_AddRec1
        '
        Me.txt_MI_AddRec1.Location = New System.Drawing.Point(260, 30)
        Me.txt_MI_AddRec1.Name = "txt_MI_AddRec1"
        Me.txt_MI_AddRec1.Size = New System.Drawing.Size(29, 20)
        Me.txt_MI_AddRec1.TabIndex = 44
        Me.txt_MI_AddRec1.Text = "M/I"
        '
        'txtLN_AddRec1
        '
        Me.txtLN_AddRec1.Location = New System.Drawing.Point(295, 30)
        Me.txtLN_AddRec1.Name = "txtLN_AddRec1"
        Me.txtLN_AddRec1.Size = New System.Drawing.Size(111, 20)
        Me.txtLN_AddRec1.TabIndex = 43
        Me.txtLN_AddRec1.Text = "Last Name"
        Me.txtLN_AddRec1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFN_AddRec1
        '
        Me.txtFN_AddRec1.Location = New System.Drawing.Point(141, 30)
        Me.txtFN_AddRec1.Name = "txtFN_AddRec1"
        Me.txtFN_AddRec1.Size = New System.Drawing.Size(111, 20)
        Me.txtFN_AddRec1.TabIndex = 42
        Me.txtFN_AddRec1.Text = "First Name"
        Me.txtFN_AddRec1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GraveSampleDataSet1
        '
        Me.GraveSampleDataSet1.DataSetName = "GraveSampleDataSet"
        Me.GraveSampleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AddRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 437)
        Me.Controls.Add(Me.GroupBox_AddRec)
        Me.Name = "AddRecord"
        Me.Text = "AddRecord"
        Me.GroupBox_AddRec.ResumeLayout(False)
        Me.GroupBox_AddRec.PerformLayout()
        CType(Me.GraveSampleDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button_Add As Button
    Friend WithEvents Button_Can As Button
    Friend WithEvents TextBox_Tier_AddRec As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_NameOnMemor_AddRec As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cbCemetery_AddRec As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox_AddRec As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_MI_AddRec4 As TextBox
    Friend WithEvents txtLN_AddRec4 As TextBox
    Friend WithEvents txtFN_AddRec4 As TextBox
    Friend WithEvents txt_MI_AddRec3 As TextBox
    Friend WithEvents txtLN_AddRec3 As TextBox
    Friend WithEvents txtFN_AddRec3 As TextBox
    Friend WithEvents txt_MI_AddRec2 As TextBox
    Friend WithEvents txtLN_AddRec2 As TextBox
    Friend WithEvents txtFN_AddRec2 As TextBox
    Friend WithEvents txt_MI_AddRec1 As TextBox
    Friend WithEvents txtLN_AddRec1 As TextBox
    Friend WithEvents txtFN_AddRec1 As TextBox
    Friend WithEvents txtSuf4 As TextBox
    Friend WithEvents txtSuf3 As TextBox
    Friend WithEvents txtSuf2 As TextBox
    Friend WithEvents txtSuf1 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtState As TextBox
    Friend WithEvents txt_City As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtZip As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label17 As Label
    Friend WithEvents txtSection As TextBox
    Friend WithEvents txtMem As TextBox
    Friend WithEvents txtLotNum As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents txtPhase As TextBox
    Friend WithEvents GraveSampleDataSet1 As GraveSampleDataSet
End Class
