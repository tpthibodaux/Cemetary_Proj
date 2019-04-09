Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class Puller
    Dim PrimCom As New SqlConnection
    Dim Cmd As New SqlCommand
    Dim Adp As New SqlDataAdapter
    Dim DR As SqlDataReader

    Public Sub New()

        PrimCom.ConnectionString = "Data Source=DESKTOP-A6SIUJP\SQLEXPRESS;Initial Catalog=GraveSample;Integrated Security=True"
        Cmd.Connection = PrimCom
        Cmd.CommandType = CommandType.StoredProcedure
    End Sub

    Public Function GetCem() As _
            DataSet
        Cmd.Parameters.Clear()
        Dim ds As New DataSet
        Cmd.CommandText = "RetCemName"
        PrimCom.Open()
        Adp.SelectCommand = Cmd
        Adp.Fill(ds)
        Adp.Dispose()
        Cmd.Dispose()
        PrimCom.Close()


        Return ds
    End Function

    Public Function RetNameDGVonlyF(Fname As String) As _
            DataTable
        Cmd.Parameters.Clear()
        Dim ds As New DataTable
        Cmd.CommandText = "RetNameDGVonlyF"
        Cmd.Parameters.Add(New SqlParameter("@Fname", Fname))
        Dim Dt As New DataTable
        PrimCom.Open()
        Using Adp As New SqlDataAdapter(Cmd)
            Adp.Fill(Dt)
            Adp.Dispose()
            Cmd.Dispose()
        End Using
        Return Dt
    End Function


    Public Function RetNameDGVonlyLC(Lname As String, Cem_ID As Integer) As _
            DataTable
        Cmd.Parameters.Clear()
        Dim ds As New DataTable
        Cmd.CommandText = "RetNameDGVonlyLC"
        Cmd.Parameters.Add(New SqlParameter("@Lname", Lname))
        Cmd.Parameters.Add(New SqlParameter("@Cem_ID", Cem_ID))
        Dim Dt As New DataTable
        PrimCom.Open()
        Using Adp As New SqlDataAdapter(Cmd)
            Adp.Fill(Dt)
            Adp.Dispose()
            Cmd.Dispose()
        End Using
        Return Dt
    End Function


    Public Function RetNameDGVonlyFC(Fname As String, Cem_ID As Integer) As _
            DataTable
        Cmd.Parameters.Clear()
        Dim ds As New DataTable
        Cmd.CommandText = "RetNameDGVonlyFC"
        Cmd.Parameters.Add(New SqlParameter("@Fname", Fname))
        Cmd.Parameters.Add(New SqlParameter("@Cem_ID", Cem_ID))
        Dim Dt As New DataTable
        PrimCom.Open()
        Using Adp As New SqlDataAdapter(Cmd)
            Adp.Fill(Dt)
            Adp.Dispose()
            Cmd.Dispose()
        End Using
        Return Dt
    End Function

    Public Function RetNameDGVonlyL(Lname As String) As _
            DataTable
        Cmd.Parameters.Clear()
        Cmd.CommandText = "RetNameDGVonlyL"
        Cmd.Parameters.Add(New SqlParameter("@Lname", Lname))
        Dim Dt As New DataTable
        PrimCom.Open()
        Using Adp As New SqlDataAdapter(Cmd)
            Adp.Fill(Dt)
            Adp.Dispose()
            Cmd.Dispose()
        End Using
        Return Dt
    End Function


    Public Function RetNameDGVonlyFL(Fname As String, Lname As String) As _
           DataTable
        Cmd.Parameters.Clear()
        Cmd.CommandText = "RetNameDGVonlyFL"
        Cmd.Parameters.Add(New SqlParameter("@Fname", Fname))
        Cmd.Parameters.Add(New SqlParameter("@Lname", Lname))
        Dim Dt As New DataTable
        PrimCom.Open()
        Using Adp As New SqlDataAdapter(Cmd)
            Adp.Fill(Dt)
            Adp.Dispose()
            Cmd.Dispose()
        End Using
        Return Dt
    End Function

    Public Function RetNameDGV(Fname As String, Lname As String, Cem_ID As Integer) As _
          DataTable
        Cmd.Parameters.Clear()
        Cmd.CommandText = "RetNameDGV"
        Cmd.Parameters.Add(New SqlParameter("@Fname", Fname))
        Cmd.Parameters.Add(New SqlParameter("@Lname", Lname))
        Cmd.Parameters.Add(New SqlParameter("@Cem_ID", Cem_ID))
        Dim Dt As New DataTable
        PrimCom.Open()
        Using Adp As New SqlDataAdapter(Cmd)
            Adp.Fill(Dt)
            Adp.Dispose()
            Cmd.Dispose()
        End Using
        Return Dt
    End Function



    Public Function GetdaPpl(Tit_ID As Integer) As _
         DataTable
        Cmd.Parameters.Clear()
        Cmd.CommandText = "GetDaPpl"
        Cmd.Parameters.Add(New SqlParameter("@Tit_ID", Tit_ID))

        Dim Dt As New DataTable
        PrimCom.Open()
        Using Adp As New SqlDataAdapter(Cmd)
            Adp.Fill(Dt)
            Adp.Dispose()
            Cmd.Dispose()
        End Using
        Return Dt
    End Function


    Public Function GetSpecInfoForTitle(TitleID As Integer) As SpecInfo
        Dim Info As New SpecInfo
        Cmd.Parameters.Clear()
        Cmd.CommandText = "GetSpecInfoForTitle"
        Cmd.Parameters.Add(New SqlParameter("@TitID", TitleID))
        PrimCom.Open()
        DR = Cmd.ExecuteReader
        If DR.Read = True Then
            Info.Owner1FN = DR("Owner1FN")
            Info.Owner1LN = DR("Owner1LN")
            Info.Owner2FN = DR("Owner2FN")
            Info.Owner2LN = DR("Owner2LN")
            Info.Owner3FN = DR("Owner3FN")
            Info.Owner3LN = DR("Owner3LN")
            Info.City = DR("City")
            Info.State = DR("_State")
            Info.Zip = DR("Zip")
            Info.Address = DR("_Address")
            Info.DateIssued = DR("DateIssued")
            Info.Section = DR("Section")
            Info.Section2 = DR("Section2")
            Info.Section3 = DR("Section3")
            Info.Section4 = DR("Section4")
            Info.LotNum = DR("LotNum")
            Info.TypeMem = DR("TypeMem")
            Info.Phase = DR("Phase")
            Info.PlotDesc = DR("PlotDesc")
            Info.Price = DR("Price")
            Info.tier = DR("Tier")
        End If
        PrimCom.Close()

        Return Info
    End Function

    Public Sub InsertRecord(
     TOFName As String,
     TOFName2 As String,
     TOFName3 As String,
     TOFName4 As String,
     TOLName As String,
     TOLName2 As String,
     TOLName3 As String,
     TOLName4 As String,
     TOSuffix As String,
     TOSuffix2 As String,
     TOSuffix3 As String,
     TOSuffix4 As String,
     TOMI As String,
     TOMI2 As String,
     TOMI3 As String,
     TOMI4 As String,
     CemID As Integer
        )

        Cmd.Parameters.Clear()
        Cmd.CommandText = "AddRecord"
        Cmd.Parameters.Add(New SqlParameter("@TOFName", TOFName))
        Cmd.Parameters.Add(New SqlParameter("@TOFName2", TOFName2))
        Cmd.Parameters.Add(New SqlParameter("@TOFName3", TOFName3))
        Cmd.Parameters.Add(New SqlParameter("@TOFName4", TOFName4))
        Cmd.Parameters.Add(New SqlParameter("@TOLName", TOLName))
        Cmd.Parameters.Add(New SqlParameter("@TOLName2", TOLName2))
        Cmd.Parameters.Add(New SqlParameter("@TOLName3", TOLName3))
        Cmd.Parameters.Add(New SqlParameter("@TOLName4", TOLName4))
        Cmd.Parameters.Add(New SqlParameter("@TOSuffix", TOSuffix))
        Cmd.Parameters.Add(New SqlParameter("@TOSuffix2", TOSuffix2))
        Cmd.Parameters.Add(New SqlParameter("@TOSuffix3", TOSuffix3))
        Cmd.Parameters.Add(New SqlParameter("@TOSuffix4", TOSuffix4))
        Cmd.Parameters.Add(New SqlParameter("@TOMI", TOMI))
        Cmd.Parameters.Add(New SqlParameter("@TOMI2", TOMI2))
        Cmd.Parameters.Add(New SqlParameter("@TOMI3", TOMI3))
        Cmd.Parameters.Add(New SqlParameter("@TOMI4", TOMI4))
        Cmd.Parameters.Add(New SqlParameter("@CemID", CemID))
        PrimCom.Open()
        Cmd.ExecuteNonQuery()
        PrimCom.Close()
    End Sub

    Public Sub InsertSpecINfo(
    Owner1FN As String,
    Owner1LN As String,
    City As String,
    State As String,
    Zip As String,
    Address As String,
    DateIssued As String,
        Section As String,
        LotNum As String,
        TypeMem As String,
    Phase As String,
        PlotDesc As String,
        Price As Integer
        )
        Cmd.Parameters.Clear()
        Cmd.CommandText = "AddSpecInfo"
        Cmd.Parameters.Add(New SqlParameter("@Owner1FN", Owner1FN))
        Cmd.Parameters.Add(New SqlParameter("@Owner1LN", Owner1LN))
        Cmd.Parameters.Add(New SqlParameter("@City", City))
        Cmd.Parameters.Add(New SqlParameter("@State", State))
        Cmd.Parameters.Add(New SqlParameter("@Zip", Zip))
        Cmd.Parameters.Add(New SqlParameter("@Address", Address))
        Cmd.Parameters.Add(New SqlParameter("@DateIssued", DateIssued))
        Cmd.Parameters.Add(New SqlParameter("@Section", Section))
        Cmd.Parameters.Add(New SqlParameter("@LotNum", LotNum))
        Cmd.Parameters.Add(New SqlParameter("@TypeMem", TypeMem))
        Cmd.Parameters.Add(New SqlParameter("@Phase", Phase))
        Cmd.Parameters.Add(New SqlParameter("@PlotDesc", PlotDesc))
        Cmd.Parameters.Add(New SqlParameter("@Price", Price))
        PrimCom.Open()
        Cmd.ExecuteNonQuery()
        PrimCom.Close()
    End Sub


End Class
