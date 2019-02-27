Public Class Form1
    Private Sub lblAdmin_Click(sender As Object, e As EventArgs) Handles lblAdmin.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CemeteryColumn = SearchDGV.Columns("Cemetery")
        CemeteryColumn.MinimumWidth = (SearchDGV.Width * 0.4)
    End Sub


End Class
