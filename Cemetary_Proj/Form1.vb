Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms



Public Class Form1
    Private Sub lblAdmin_Click(sender As Object, e As EventArgs) Handles lblAdmin.Click

    End Sub




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ''
        '' populates the combobox 'cbCemetery' with Cemetery names. Important to replace with official/relevant DB info 
        Dim PrimCom As New SqlConnection
        Dim Cmd As New SqlCommand
        Dim Adp As New SqlDataAdapter
        Dim Ds As New DataSet

        ''Change to official DB info. Sets up connection/command 
        PrimCom.ConnectionString = "Data Source=DESKTOP-A6SIUJP\SQLEXPRESS;Initial Catalog=GraveSample;Integrated Security=True"
        Cmd.Connection = PrimCom
        Cmd.CommandType = CommandType.StoredProcedure

        ''Change to official DB info. Calls a stored procedure "RetCemName" that selects the cemetery name and associated cemetery id (to be used by other stored procedures).
        Cmd.CommandText = "RetCemName"
        PrimCom.Open()
        Adp.SelectCommand = Cmd
        Adp.Fill(Ds)
        Adp.Dispose()
        Cmd.Dispose()
        PrimCom.Close()

        ''Change to official DB info. This populates the info from "RetCemName" into the dropdown. 
        cbCemetery.DataSource = Ds.Tables(0)
        cbCemetery.ValueMember = "Cem_ID"
        cbCemetery.DisplayMember = "Cem_Desc"

        ''This will allow for searching with just first and last name
        cbCemetery.SelectedValue = 0
        cbCemetery.Text = "Please Select a Cemetery"



    End Sub

    Private Sub Button_Delete_Click(sender As Object, e As EventArgs) Handles Button_Delete.Click





    End Sub

    Private Sub btnNewCard_Click(sender As Object, e As EventArgs) Handles btnNewCard.Click





    End Sub

    Private Sub Button_Search_Click(sender As Object, e As EventArgs) Handles Button_Search.Click


        ''this sub handles the search bar functionaltiy with interchangeable stored procedures. They all produce the same dataset specified in the Data Grid View 'dgvsearch'

        ''This section populates a seach bar click for when *Only* First name. It will pull all people from all cemeteries with a specified firstname ()
        Dim Cmd As New SqlCommand
        Dim FName As String = txtFN.Text
        Dim LName As String = txtLN.Text
        If cbCemetery.SelectedValue = 0 And txtLN.Text = "Last Name" Then
            Dim PrimConn As New SqlConnection
            PrimConn.ConnectionString = "Data Source=DESKTOP-A6SIUJP\SQLEXPRESS;Initial Catalog=GraveSample;Integrated Security=True"
            Cmd.Connection = PrimConn
            Cmd.CommandType = CommandType.StoredProcedure
            ''Calls  a stored procedure "RetNameDGVOnluF" that returns first and last name of person = to the first name in the text box

            Cmd.CommandText = "RetNameDGVonlyF"
            Cmd.Parameters.Add(New SqlParameter("@Fname", FName))
            PrimConn.Open()
            Using Adp As New SqlDataAdapter(Cmd)
                Dim Dt As New DataTable
                Adp.Fill(Dt)
                SearchDGV.DataSource = Dt
            End Using
            PrimConn.Close()




            ''This section populates a seach bar click for when *Only* Lasr name and cemetery. It will pull all people from all cemeteries with a specified lastname and cemetery ()


        ElseIf txtFN.Text = "First Name" Then
            Dim Cem_ID As Integer = cbCemetery.SelectedItem(0)
            Dim PrimConn As New SqlConnection
            PrimConn.ConnectionString = "Data Source=DESKTOP-A6SIUJP\SQLEXPRESS;Initial Catalog=GraveSample;Integrated Security=True"
            Cmd.Connection = PrimConn
            Cmd.CommandType = CommandType.StoredProcedure

            ''Calls  a stored procedure "" that returns first and last name of person = to the first name in the text box
            Cmd.CommandText = "RetNameDGVonlyLC"
            Cmd.Parameters.Add(New SqlParameter("@Lname", LName))
            Cmd.Parameters.Add(New SqlParameter("@Cem_ID", Cem_ID))
            PrimConn.Open()
            Using Adp As New SqlDataAdapter(Cmd)
                Dim Dt As New DataTable
                Adp.Fill(Dt)
                SearchDGV.DataSource = Dt
            End Using
            PrimConn.Close()



            ''This section populates a seach bar click for when *Only* First name and cemetery. It will pull all people from all cemeteries with a specified firstname and cemetery ()
        ElseIf txtLN.Text = "Last Name" Then
                Dim Cem_ID As Integer = cbCemetery.SelectedItem(0)
                Dim PrimConn As New SqlConnection
                PrimConn.ConnectionString = "Data Source=DESKTOP-A6SIUJP\SQLEXPRESS;Initial Catalog=GraveSample;Integrated Security=True"
                Cmd.Connection = PrimConn
                Cmd.CommandType = CommandType.StoredProcedure

                ''Calls  a stored procedure "" that returns first and last name of person = to the first name in the text box
                Cmd.CommandText = "RetNameDGVonlyFC"
                Cmd.Parameters.Add(New SqlParameter("@Fname", FName))
                Cmd.Parameters.Add(New SqlParameter("@Cem_ID", Cem_ID))
                PrimConn.Open()
                Using Adp As New SqlDataAdapter(Cmd)
                    Dim Dt As New DataTable
                    Adp.Fill(Dt)
                    SearchDGV.DataSource = Dt
                End Using
                PrimConn.Close()






                ''This section populates a seach bar click for when *Only* Last name is chosen. It will pull all people from all cemeteries with a specified last name ()

            ElseIf txtFN.Text = "First Name" And cbCemetery.SelectedValue = 0 Then
                Dim PrimConn As New SqlConnection
                PrimConn.ConnectionString = "Data Source=DESKTOP-A6SIUJP\SQLEXPRESS;Initial Catalog=GraveSample;Integrated Security=True"
                Cmd.Connection = PrimConn
                Cmd.CommandType = CommandType.StoredProcedure
                ''Calls  a stored procedure "" that returns first and last name of person = to the last name in the text box
                Cmd.CommandText = "RetNameDGVonlyL"
                Cmd.Parameters.Add(New SqlParameter("@Lname", LName))
                PrimConn.Open()
                Using Adp As New SqlDataAdapter(Cmd)
                    Dim Dt As New DataTable
                    Adp.Fill(Dt)
                    SearchDGV.DataSource = Dt
                End Using
                PrimConn.Close()







                ''This section populates a seach bar click for when *Only* First name, last name. It will pull all people from all cemeteries with a specified first and last name ()
            ElseIf cbCemetery.SelectedValue = 0 Then
                Dim PrimConn As New SqlConnection
                PrimConn.ConnectionString = "Data Source=DESKTOP-A6SIUJP\SQLEXPRESS;Initial Catalog=GraveSample;Integrated Security=True"
                Cmd.Connection = PrimConn
                Cmd.CommandType = CommandType.StoredProcedure
                ''Calls  a stored procedure "RetNameDGVOnluF" that returns first and last name of person = to the first and last name in the text boxes

                Cmd.CommandText = "RetNameDGVonlyFL"
                Cmd.Parameters.Add(New SqlParameter("@Fname", FName))
                Cmd.Parameters.Add(New SqlParameter("@Lname", LName))
                PrimConn.Open()
                Using Adp As New SqlDataAdapter(Cmd)
                    Dim Dt As New DataTable
                    Adp.Fill(Dt)
                    SearchDGV.DataSource = Dt
                End Using
                PrimConn.Close()

            Else

                ''This section populates the datagrid for a seach bar click for when First name, last name and cemetery info are entered. (More specific results)
                Dim Cem_ID As Integer = cbCemetery.SelectedItem(0)
            Dim PrimConn As New SqlConnection
            PrimConn.ConnectionString = "Data Source=DESKTOP-A6SIUJP\SQLEXPRESS;Initial Catalog=GraveSample;Integrated Security=True"
            Cmd.Connection = PrimConn
            Cmd.CommandType = CommandType.StoredProcedure
            ''Change to official DB info 
            ''Calls  a stored procedure "RetNameDGV" that returns first and last name of person = to the text boxes and in specified cemetery (from combobox)
            Cmd.CommandText = "RetNameDGV"
            Cmd.Parameters.Add(New SqlParameter("@Fname", FName))
            Cmd.Parameters.Add(New SqlParameter("@Lname", LName))
            Cmd.Parameters.Add(New SqlParameter("@Cem_ID", Cem_ID))
            ''Populates the data grid view 'SearchDGV' with the infomation returned from the stored procedure.
            PrimConn.Open()
            Using Adp As New SqlDataAdapter(Cmd)
                Dim Dt As New DataTable
                Adp.Fill(Dt)
                SearchDGV.DataSource = Dt
            End Using



            PrimConn.Close()

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

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
        Dim PrimCom As New SqlConnection
        Dim Cmd As New SqlCommand
        Dim Dr As SqlDataReader
        PrimCom.ConnectionString = "Data Source=DESKTOP-A6SIUJP\SQLEXPRESS;Initial Catalog=GraveSample;Integrated Security=True"
        Cmd.Connection = PrimCom
        Cmd.CommandType = CommandType.StoredProcedure
        Cmd.CommandText = "GetSpecInfoForTitle"
        Cmd.Parameters.Add(New SqlParameter("@TitleID", TID))

        ''This is infomratoion from a fake table i have created. I am sure this code can be optimized
        Dim Owner1FN As String
        Dim Owner1LN As String
        Dim Owner2FN As String
        Dim Owner2LN As String
        Dim Owner3FN As String
        Dim Owner3LN As String
        Dim City As String
        Dim State As String
        Dim Zip As String 
        Dim Address As String
        Dim DateIssued As String
        Dim Section As String
        Dim Section2 As String
        Dim Section3 As String
        Dim Section4 As String
        Dim LotNum As String
        Dim TypeMem As String 
        Dim Phase As String
        Dim PlotDesc As String
        Dim Price As String

        ''Reads the fake date 

        PrimCom.Open()
        Dr = Cmd.ExecuteReader
        If Dr.Read = True Then
            Owner1FN = Dr("Owner1FN")
            Owner1LN = Dr("Owner1LN")
            Owner2FN = Dr("Owner2FN")
            Owner2LN = Dr("Owner2LN")
            Owner3FN = Dr("Owner3FN")
            Owner3LN = Dr("Owner3LN")
            City = Dr("City")
            State = Dr("State")
            Zip = Dr("Zip")
            Address = Dr("Address")
            DateIssued = Dr("DateIssued")
            Section = Dr("Section")
            Section2 = Dr("Section2")
            Section3 = Dr("Section3")
            Section4 = Dr("Section4")
            LotNum = Dr("LotNum")
            TypeMem = Dr("TypeMem")
            Phase = Dr("Phase")
            PlotDesc = Dr("PlotDesc")
            Price = Dr("Price")
        End If
        TextBox_Section.Text = Section & " " & Section2 & " " & Section3 & " " & Section4
#Disable Warning BC42104 ' Variable is used before it has been assigned a value
        TextBox_NameOnMemor.Text = Owner1FN & " " & Owner1LN & " " & "&" & " " & Owner2FN & " " & Owner2LN & " " & Owner3FN & " " & Owner3LN
#Enable Warning BC42104 ' Variable is used before it has been assigned a value
        TextBox_LotNum.Text = LotNum
        TextBox_TypeMemorial.Text = TypeMem
        ComboBox_Phase.Text = Phase
        TextBox_Desc.Text = PlotDesc
        TextBox_Price.Text = Price
        TextBox_Address.Text = Address & " " & City & " " & Zip & " " & State
        MaskedTextBox_DateIssued.Text = DateIssued
    End Sub

End Class
