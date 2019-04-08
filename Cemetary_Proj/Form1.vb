Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms

Public Class Form1

    Dim PrimConn As New SqlConnection
    Dim Cmd As New SqlCommand




    Private Sub lblAdmin_Click(sender As Object, e As EventArgs) Handles lblAdmin.Click

    End Sub




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim DS As New DataSet
        Dim Returner As New Puller
        DS = Returner.GetCem
        ''This populates the combobox cbcemetery with all the cemetery names
        cbCemetery.DataSource = DS.Tables(0)
        cbCemetery.ValueMember = "Cem_ID"
        cbCemetery.DisplayMember = "Cem_Desc"

        ''this sets a default vaule for the combobox
        cbCemetery.SelectedValue = 0
        cbCemetery.Text = "Please Select a Cemetery"



    End Sub

    Private Sub Button_Delete_Click(sender As Object, e As EventArgs) Handles Button_Delete.Click





    End Sub

    Private Sub btnNewCard_Click(sender As Object, e As EventArgs) Handles btnNewCard.Click





    End Sub

    Private Sub Button_Search_Click(sender As Object, e As EventArgs) Handles Button_Search.Click

        ''this sub handles the search bar functionaltiy with interchangeable stored procedures. They all produce the same dataset specified in the Data Grid View 'dgvsearch'

        Dim FName As String = txtFN.Text
        Dim LName As String = txtLN.Text
        Dim Dt As New DataTable
        Dim Returner As New Puller
        If cbCemetery.SelectedValue = 0 And txtLN.Text = "Last Name" Then ''no cem just fname entered
            Dt = Returner.RetNameDGVonlyF(FName)
            SearchDGV.DataSource = Dt
        ElseIf txtFN.Text = "First Name" And cbCemetery.SelectedValue = 0 Then ''no cem just last name
            Dt = Returner.RetNameDGVonlyL(LName)
            SearchDGV.DataSource = Dt
        ElseIf cbCemetery.SelectedValue = 0 Then ''fname and lname entered no cem
            Dt = Returner.RetNameDGVonlyFL(FName, LName)
            SearchDGV.DataSource = Dt
        ElseIf txtFN.Text = "First Name" Then  ''cem selected  and last name entered
            Dim Cem_ID As Integer = cbCemetery.SelectedItem(0)
            Dt = Returner.RetNameDGVonlyLC(LName, Cem_ID)
            SearchDGV.DataSource = Dt
        ElseIf txtLN.Text = "Last Name" Then ''cem selected and first name entered
            Dim Cem_ID As Integer = cbCemetery.SelectedItem(0)
            Dt = Returner.RetNameDGVonlyFC(FName, Cem_ID)
            SearchDGV.DataSource = Dt
        Else
            Dim Cem_ID As Integer = cbCemetery.SelectedItem(0) ''cem entered, fname entered, lname entered
            Dt = Returner.RetNameDGV(FName, LName, Cem_ID)
            SearchDGV.DataSource = Dt
            PrimConn.Close()
        End If
        Dt.Dispose()
    End Sub



    Private Sub SearchDGV_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles SearchDGV.CellDoubleClick
        '' this grabs the all of values in the datagrid view and assigns them to appropriate textboxes 
        Dim i As Integer
        i = SearchDGV.CurrentRow.Index
        TxtBoxTitleNum.Text = SearchDGV.Item(0, i).Value
        TextBox_TitleHolder.Text = SearchDGV.Item(1, i).Value & " " & SearchDGV.Item(2, i).Value & " " & SearchDGV.Item(3, i).Value
        TextBox_Cemetery.Text = SearchDGV.Item(4, i).Value

        ''This grabs the ID of the title from the data grid view and saves it as integer 'TID' to be used for stored procedures etc
        Dim TID As Integer = SearchDGV.Item(0, i).Value

        '' This will unleash a stored procedure that will fill most information boxes based off of the Title integer 'TID'
        Dim info As New Puller
        TextBox_Section.Text = info.GetSpecInfoForTitle(TID).Section & " " & info.GetSpecInfoForTitle(TID).Section2 & " " & info.GetSpecInfoForTitle(TID).Section3 & " " & info.GetSpecInfoForTitle(TID).Section4
        TextBox_NameOnMemor.Text = info.GetSpecInfoForTitle(TID).Owner1FN & " " & info.GetSpecInfoForTitle(TID).Owner1LN & " " & "&" & " " & info.GetSpecInfoForTitle(TID).Owner2FN & " " & info.GetSpecInfoForTitle(TID).Owner2LN & " " & info.GetSpecInfoForTitle(TID).Owner3FN & " " & info.GetSpecInfoForTitle(TID).Owner3LN
        TextBox_LotNum.Text = info.GetSpecInfoForTitle(TID).LotNum
        TextBox_TypeMemorial.Text = info.GetSpecInfoForTitle(TID).TypeMem
        ComboBox_Phase.Text = info.GetSpecInfoForTitle(TID).Phase
        TextBox_Desc.Text = info.GetSpecInfoForTitle(TID).PlotDesc
        TextBox_Price.Text = info.GetSpecInfoForTitle(TID).Price
        TextBox_Address.Text = info.GetSpecInfoForTitle(TID).Address & " " & info.GetSpecInfoForTitle(TID).City & " " & info.GetSpecInfoForTitle(TID).Zip & " " & info.GetSpecInfoForTitle(TID).State
        MaskedTextBox_DateIssued.Text = info.GetSpecInfoForTitle(TID).DateIssued
        TextBox_Tier.Text = info.GetSpecInfoForTitle(TID).tier

        ''This will trigger a stored procedure that populates the bottom dgv with the names of the deceased
        Dim dattab As New DataTable
        Dim FillObj As New Puller
        dattab = FillObj.GetdaPpl(TID)
        DeceasedDGV.DataSource = dattab
    End Sub
End Class
