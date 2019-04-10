Public Class AddRecord
    Private Sub Button_Can_Click(sender As Object, e As EventArgs) Handles Button_Can.Click
        Me.Close()
    End Sub


    Private Sub AddRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim DS As New DataSet
        Dim Returner As New Puller
        DS = Returner.GetCem
        ''This populates the combobox cbCemetery_AddRec with all the cemetery names
        cbCemetery_AddRec.DataSource = DS.Tables(0)
        cbCemetery_AddRec.ValueMember = "Cem_ID"
        cbCemetery_AddRec.DisplayMember = "Cem_Desc"

        ''this sets a default vaule for the combobox
        cbCemetery_AddRec.SelectedValue = 0
        cbCemetery_AddRec.Text = "- -"


        ''Sets the format for the date
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "dd/MM/yyyy"


    End Sub

    Private Sub Button_Add_Click(sender As Object, e As EventArgs) Handles Button_Add.Click
        Dim Info As New Puller
        Dim TOFName = txtFN_AddRec1.Text
        Dim TOFName2 = txtFN_AddRec2.Text
        Dim TOFName3 = txtFN_AddRec3.Text
        Dim TOFName4 = txtFN_AddRec4.Text
        Dim TOLName = txtLN_AddRec1.Text
        Dim TOLName2 = txtLN_AddRec2.Text
        Dim TOLName3 = txtLN_AddRec3.Text
        Dim TOLName4 = txtLN_AddRec4.Text
        Dim TOSuffix = txtSuf1.Text
        Dim TOSuffix2 = txtSuf2.Text
        Dim TOSuffix3 = txtSuf3.Text
        Dim TOSuffix4 = txtSuf4.Text
        Dim TOMI = txt_MI_AddRec1.Text
        Dim TOMI2 = txt_MI_AddRec2.Text
        Dim TOMI3 = txt_MI_AddRec3.Text
        Dim TOMI4 = txt_MI_AddRec4.Text
        Dim CemID = cbCemetery_AddRec.SelectedValue
        Dim Owner1FN = txtFN_AddRec1.Text
        Dim Owner1LN = txtFN_AddRec2.Text
        Dim City = txt_City.Text
        Dim State = txtState.Text
        Dim Zip = txtZip.Text
        Dim Address = txtAddress.Text
        Dim DateIssued = DateTimePicker2.Value
        Dim Section = txtSection.Text
        Dim LotNum = txtLotNum.Text
        Dim TypeMem = txtMem.Text
        Dim Phase = txtPhase.Text
        Dim PlotDesc = txtDesc.Text
        Dim Price = txtPrice.Text

        Info.InsertRecord(
        TOFName,
        TOFName2,
        TOFName3,
        TOFName4,
        TOLName,
        TOLName2,
        TOLName3,
        TOLName4,
        TOSuffix,
        TOSuffix2,
        TOSuffix3,
        TOSuffix4,
        TOMI,
        TOMI2,
        TOMI3,
        TOMI4,
        CemID
        )



        Info.InsertSpecINfo(
          Owner1FN,
          Owner1LN,
          City,
          State,
        Zip,
        Address,
          DateIssued,
        Section,
          LotNum,
        TypeMem,
          Phase,
        PlotDesc,
          Price)


        MessageBox.Show("This record has been added.")
        Me.Close()
    End Sub


End Class