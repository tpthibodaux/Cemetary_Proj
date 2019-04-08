Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class Puller
    Dim PrimCom As New SqlConnection
    Dim Cmd As New SqlCommand
    Dim Adp As New SqlDataAdapter

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


End Class
