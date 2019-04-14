<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_FileUpload
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
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.txtDescr = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(100, 655)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(132, 23)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "Search for Image"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(250, 655)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(132, 23)
        Me.btnUpload.TabIndex = 1
        Me.btnUpload.Text = "Upload Image"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(100, 603)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(506, 20)
        Me.txtFileName.TabIndex = 3
        '
        'txtDescr
        '
        Me.txtDescr.Location = New System.Drawing.Point(100, 629)
        Me.txtDescr.Name = "txtDescr"
        Me.txtDescr.Size = New System.Drawing.Size(153, 20)
        Me.txtDescr.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(18, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(588, 570)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 606)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "File Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 632)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Description:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(405, 655)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(132, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form_FileUpload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 690)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDescr)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.btnSearch)
        Me.Name = "Form_FileUpload"
        Me.Text = "Form_FileUpload"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSearch As Button
    Friend WithEvents btnUpload As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtFileName As TextBox
    Friend WithEvents txtDescr As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnExit As Button
End Class
