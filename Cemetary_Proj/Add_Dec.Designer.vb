<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Dec
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
        Me.txtDecFN = New System.Windows.Forms.TextBox()
        Me.txtDecLN = New System.Windows.Forms.TextBox()
        Me.txtDecAge = New System.Windows.Forms.TextBox()
        Me.txtDecPos = New System.Windows.Forms.TextBox()
        Me.txtDecCas = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAddDec = New System.Windows.Forms.Button()
        Me.btnCanDec = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDecSex = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDecFN
        '
        Me.txtDecFN.Location = New System.Drawing.Point(84, 19)
        Me.txtDecFN.Name = "txtDecFN"
        Me.txtDecFN.Size = New System.Drawing.Size(200, 20)
        Me.txtDecFN.TabIndex = 0
        '
        'txtDecLN
        '
        Me.txtDecLN.Location = New System.Drawing.Point(84, 70)
        Me.txtDecLN.Name = "txtDecLN"
        Me.txtDecLN.Size = New System.Drawing.Size(200, 20)
        Me.txtDecLN.TabIndex = 1
        '
        'txtDecAge
        '
        Me.txtDecAge.Location = New System.Drawing.Point(224, 163)
        Me.txtDecAge.Name = "txtDecAge"
        Me.txtDecAge.Size = New System.Drawing.Size(60, 20)
        Me.txtDecAge.TabIndex = 4
        '
        'txtDecPos
        '
        Me.txtDecPos.Location = New System.Drawing.Point(84, 210)
        Me.txtDecPos.Name = "txtDecPos"
        Me.txtDecPos.Size = New System.Drawing.Size(200, 20)
        Me.txtDecPos.TabIndex = 5
        '
        'txtDecCas
        '
        Me.txtDecCas.Location = New System.Drawing.Point(84, 248)
        Me.txtDecCas.Name = "txtDecCas"
        Me.txtDecCas.Size = New System.Drawing.Size(200, 20)
        Me.txtDecCas.TabIndex = 6
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "DateTime.Now.ToString(""d"")"
        Me.DateTimePicker1.Location = New System.Drawing.Point(84, 113)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtDecSex)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDecCas)
        Me.GroupBox1.Controls.Add(Me.txtDecPos)
        Me.GroupBox1.Controls.Add(Me.txtDecAge)
        Me.GroupBox1.Controls.Add(Me.txtDecLN)
        Me.GroupBox1.Controls.Add(Me.txtDecFN)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(290, 283)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(189, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Age:"
        '
        'btnAddDec
        '
        Me.btnAddDec.Location = New System.Drawing.Point(10, 301)
        Me.btnAddDec.Name = "btnAddDec"
        Me.btnAddDec.Size = New System.Drawing.Size(130, 23)
        Me.btnAddDec.TabIndex = 8
        Me.btnAddDec.Text = "Add"
        Me.btnAddDec.UseVisualStyleBackColor = True
        '
        'btnCanDec
        '
        Me.btnCanDec.Location = New System.Drawing.Point(170, 301)
        Me.btnCanDec.Name = "btnCanDec"
        Me.btnCanDec.Size = New System.Drawing.Size(130, 23)
        Me.btnCanDec.TabIndex = 9
        Me.btnCanDec.Text = "Cancel"
        Me.btnCanDec.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "First Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Last Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Sex:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Position:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 251)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Casket:"
        '
        'txtDecSex
        '
        Me.txtDecSex.FormattingEnabled = True
        Me.txtDecSex.Items.AddRange(New Object() {"M", "F"})
        Me.txtDecSex.Location = New System.Drawing.Point(84, 162)
        Me.txtDecSex.Name = "txtDecSex"
        Me.txtDecSex.Size = New System.Drawing.Size(86, 21)
        Me.txtDecSex.TabIndex = 3
        '
        'Add_Dec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 332)
        Me.Controls.Add(Me.btnCanDec)
        Me.Controls.Add(Me.btnAddDec)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Add_Dec"
        Me.Text = "Deceased Entry"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtDecFN As TextBox
    Friend WithEvents txtDecLN As TextBox
    Friend WithEvents txtDecAge As TextBox
    Friend WithEvents txtDecPos As TextBox
    Friend WithEvents txtDecCas As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAddDec As Button
    Friend WithEvents btnCanDec As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDecSex As ComboBox
End Class
