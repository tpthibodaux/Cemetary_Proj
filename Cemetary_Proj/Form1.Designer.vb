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
        Me.lblTimeStamp = New System.Windows.Forms.Label()
        Me.lblAdmin = New System.Windows.Forms.Label()
        Me.txtFN = New System.Windows.Forms.TextBox()
        Me.txtLN = New System.Windows.Forms.TextBox()
        Me.cbCemetery = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnNewCard = New System.Windows.Forms.Button()
        Me.gbSearch = New System.Windows.Forms.GroupBox()
        Me.gbHistory = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.gbDeceased = New System.Windows.Forms.GroupBox()
        Me.btnEditDec = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblLastUpdate = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSearch.SuspendLayout()
        Me.gbHistory.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbLocation.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRemarks.SuspendLayout()
        Me.gbDeceased.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblAdmin.Location = New System.Drawing.Point(12, 9)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(53, 16)
        Me.lblAdmin.TabIndex = 1
        Me.lblAdmin.Text = "Admin?"
        '
        'txtFN
        '
        Me.txtFN.Location = New System.Drawing.Point(224, 19)
        Me.txtFN.Name = "txtFN"
        Me.txtFN.Size = New System.Drawing.Size(100, 20)
        Me.txtFN.TabIndex = 2
        Me.txtFN.Text = "First Name"
        Me.txtFN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLN
        '
        Me.txtLN.Location = New System.Drawing.Point(347, 19)
        Me.txtLN.Name = "txtLN"
        Me.txtLN.Size = New System.Drawing.Size(100, 20)
        Me.txtLN.TabIndex = 3
        Me.txtLN.Text = "Last Name"
        Me.txtLN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbCemetery
        '
        Me.cbCemetery.FormattingEnabled = True
        Me.cbCemetery.Location = New System.Drawing.Point(465, 18)
        Me.cbCemetery.Name = "cbCemetery"
        Me.cbCemetery.Size = New System.Drawing.Size(121, 21)
        Me.cbCemetery.TabIndex = 4
        Me.cbCemetery.Text = "Select Cemetery"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 48)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(784, 124)
        Me.DataGridView1.TabIndex = 5
        '
        'btnNewCard
        '
        Me.btnNewCard.Location = New System.Drawing.Point(6, 178)
        Me.btnNewCard.Name = "btnNewCard"
        Me.btnNewCard.Size = New System.Drawing.Size(100, 23)
        Me.btnNewCard.TabIndex = 6
        Me.btnNewCard.Text = "Add New Card"
        Me.btnNewCard.UseVisualStyleBackColor = True
        '
        'gbSearch
        '
        Me.gbSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gbSearch.Controls.Add(Me.btnNewCard)
        Me.gbSearch.Controls.Add(Me.DataGridView1)
        Me.gbSearch.Controls.Add(Me.cbCemetery)
        Me.gbSearch.Controls.Add(Me.txtLN)
        Me.gbSearch.Controls.Add(Me.txtFN)
        Me.gbSearch.Location = New System.Drawing.Point(373, 28)
        Me.gbSearch.Name = "gbSearch"
        Me.gbSearch.Size = New System.Drawing.Size(796, 207)
        Me.gbSearch.TabIndex = 7
        Me.gbSearch.TabStop = False
        '
        'gbHistory
        '
        Me.gbHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gbHistory.Controls.Add(Me.PictureBox1)
        Me.gbHistory.Controls.Add(Me.TextBox5)
        Me.gbHistory.Controls.Add(Me.TextBox4)
        Me.gbHistory.Controls.Add(Me.TextBox3)
        Me.gbHistory.Controls.Add(Me.TextBox2)
        Me.gbHistory.Controls.Add(Me.TextBox1)
        Me.gbHistory.Controls.Add(Me.Label6)
        Me.gbHistory.Controls.Add(Me.Label5)
        Me.gbHistory.Controls.Add(Me.Label4)
        Me.gbHistory.Controls.Add(Me.Label3)
        Me.gbHistory.Controls.Add(Me.Label2)
        Me.gbHistory.Controls.Add(Me.Label1)
        Me.gbHistory.Location = New System.Drawing.Point(2, 241)
        Me.gbHistory.Name = "gbHistory"
        Me.gbHistory.Size = New System.Drawing.Size(796, 333)
        Me.gbHistory.TabIndex = 8
        Me.gbHistory.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(285, 134)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(222, 166)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(660, 103)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 19
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(660, 133)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 18
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(99, 161)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 17
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(99, 133)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 16
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(99, 103)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(566, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Title Number:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(592, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Address:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Title Owners:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Date Issued:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Title Holder:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(267, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 31)
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
        Me.gbLocation.Location = New System.Drawing.Point(812, 241)
        Me.gbLocation.Name = "gbLocation"
        Me.gbLocation.Size = New System.Drawing.Size(776, 333)
        Me.gbLocation.TabIndex = 20
        Me.gbLocation.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(338, 306)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(114, 21)
        Me.ComboBox1.TabIndex = 23
        Me.ComboBox1.Text = "Select Phase"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(282, 307)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 16)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Phase:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(285, 134)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(222, 166)
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(371, 100)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 19
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(634, 100)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 18
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(137, 100)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(100, 20)
        Me.TextBox8.TabIndex = 17
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(137, 71)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(100, 20)
        Me.TextBox9.TabIndex = 16
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(137, 44)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(100, 20)
        Me.TextBox10.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(282, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Lot Number:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(512, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 16)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Type of Memorial:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(62, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 16)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Cemetery:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(75, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 16)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Section:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(125, 16)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Name on Memorial:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(267, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(264, 31)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Location of Memorial"
        '
        'gbRemarks
        '
        Me.gbRemarks.Controls.Add(Me.Button1)
        Me.gbRemarks.Controls.Add(Me.TextBox12)
        Me.gbRemarks.Controls.Add(Me.Label16)
        Me.gbRemarks.Controls.Add(Me.TextBox11)
        Me.gbRemarks.Controls.Add(Me.Label15)
        Me.gbRemarks.Controls.Add(Me.Label14)
        Me.gbRemarks.Location = New System.Drawing.Point(408, 580)
        Me.gbRemarks.Name = "gbRemarks"
        Me.gbRemarks.Size = New System.Drawing.Size(787, 96)
        Me.gbRemarks.TabIndex = 21
        Me.gbRemarks.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(8, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Upload Document"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(430, 60)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(85, 20)
        Me.TextBox12.TabIndex = 26
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(382, 61)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 16)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "Price:"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(93, 57)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(237, 20)
        Me.TextBox11.TabIndex = 24
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 57)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 16)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Description:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(330, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(123, 31)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Remarks"
        '
        'gbDeceased
        '
        Me.gbDeceased.Controls.Add(Me.btnEditDec)
        Me.gbDeceased.Controls.Add(Me.DataGridView2)
        Me.gbDeceased.Controls.Add(Me.Label17)
        Me.gbDeceased.Location = New System.Drawing.Point(408, 682)
        Me.gbDeceased.Name = "gbDeceased"
        Me.gbDeceased.Size = New System.Drawing.Size(787, 317)
        Me.gbDeceased.TabIndex = 28
        Me.gbDeceased.TabStop = False
        '
        'btnEditDec
        '
        Me.btnEditDec.Location = New System.Drawing.Point(6, 16)
        Me.btnEditDec.Name = "btnEditDec"
        Me.btnEditDec.Size = New System.Drawing.Size(75, 23)
        Me.btnEditDec.TabIndex = 29
        Me.btnEditDec.Text = "Edit Fields"
        Me.btnEditDec.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(6, 50)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(775, 261)
        Me.DataGridView2.TabIndex = 29
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(271, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(260, 31)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Names of Deceased"
        '
        'lblLastUpdate
        '
        Me.lblLastUpdate.AutoSize = True
        Me.lblLastUpdate.Location = New System.Drawing.Point(12, 1004)
        Me.lblLastUpdate.Name = "lblLastUpdate"
        Me.lblLastUpdate.Size = New System.Drawing.Size(166, 13)
        Me.lblLastUpdate.TabIndex = 30
        Me.lblLastUpdate.Text = "Last Updated 2/23/2019 7:26PM"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1600, 1026)
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTimeStamp As Label
    Friend WithEvents lblAdmin As Label
    Friend WithEvents txtFN As TextBox
    Friend WithEvents txtLN As TextBox
    Friend WithEvents cbCemetery As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
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
    Friend WithEvents TextBox3 As TextBox
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
    Friend WithEvents btnEditDec As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label17 As Label
    Friend WithEvents lblLastUpdate As Label
End Class
