Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Public Class Form_ViewFiles
    Private Sub btnTxt_Click(sender As Object, e As EventArgs) Handles btnTxt.Click
        Me.Close()
    End Sub

    Private Sub Form_ViewFiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim PrimCom As New SqlConnection
        Dim Cmd As New SqlCommand
        Dim TitleID = Form1.TxtBoxTitleNum.Text
        Dim Dt As New DataTable

        PrimCom.ConnectionString = "Data Source=DESKTOP-A6SIUJP\SQLEXPRESS;Initial Catalog=GraveSample;Integrated Security=True"
        Cmd.Connection = PrimCom
        Cmd.CommandType = CommandType.StoredProcedure
        Cmd.CommandText = "GrabImages"

        Cmd.Parameters.Add(New SqlParameter("@TitleId", TitleID))
        Dim Adp As New SqlDataAdapter(Cmd)
        Adp.Fill(Dt)
        dgvFiles.AllowUserToDeleteRows = False
        dgvFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvFiles.RowTemplate.Height = 100
        Dim imgc As New DataGridViewImageColumn()
        dgvFiles.DataSource = Dt
        imgc = dgvFiles.Columns(2)
        imgc.ImageLayout = DataGridViewImageCellLayout.Stretch



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class