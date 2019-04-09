Public Class Add_Dec
    Private Sub AddDec_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ''Sets the format for the date
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"

    End Sub

    Private Sub btnCanDec_Click(sender As Object, e As EventArgs) Handles btnCanDec.Click
        Me.Close()
    End Sub

    Private Sub btnAddDec_Click(sender As Object, e As EventArgs) Handles btnAddDec.Click

        Dim TitleID As Integer = Form1.TxtBoxTitleNum.Text
        Dim Fname = txtDecFN.Text
        Dim Lname = txtDecLN.Text
        Dim _Date = DateTimePicker1.Value
        Dim Sex = txtDecSex.Text
        Dim Age = txtDecAge.Text
        Dim Position = txtDecPos.Text
        Dim Casket = txtDecCas.Text
        Dim obj As New Puller
        obj.AddDec(
            TitleID,
            Fname,
            Lname,
            _Date,
            Sex,
            Age,
            Position,
            Casket)
        MessageBox.Show("Record Added")
        Form1.DeceasedDGV.Refresh()
        Me.Close()

        Dim dattab As New DataTable
        Dim FillObj As New Puller
        dattab = FillObj.GetdaPpl(TitleID)
        Form1.DeceasedDGV.DataSource = dattab
    End Sub


End Class