Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Public Class Form_FileUpload
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim PrimCom As New SqlConnection
        Dim Cmd As New SqlCommand
        Dim Adp As New SqlDataAdapter
        Dim DR As SqlDataReader

        PrimCom.ConnectionString = "Data Source=DESKTOP-A6SIUJP\SQLEXPRESS;Initial Catalog=GraveSample;Integrated Security=True"
        Cmd.Connection = PrimCom
        Cmd.CommandType = CommandType.StoredProcedure
        Cmd.CommandText = "UploadImg"

        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        Dim TitleID = Form1.TxtBoxTitleNum.Text
        Dim Filename = txtFileName.Text
        Dim Description = txtDescr.Text

        Cmd.Parameters.Add(New SqlParameter("@TitleId", TitleID))
        Cmd.Parameters.Add(New SqlParameter("@name", Filename))
        Cmd.Parameters.Add(New SqlParameter("@descr", Description))
        Cmd.Parameters.Add(New SqlParameter("@img", ms.ToArray))

        PrimCom.Open()
        If Cmd.ExecuteNonQuery = 1 Then
            MessageBox.Show("Image inserted")
        Else
            MessageBox.Show("Image Not Inserted")
        End If
        PrimCom.Close()
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class