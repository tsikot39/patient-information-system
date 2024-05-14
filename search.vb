Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class search

    Dim ds As DataSet

    Private Sub search_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        ds = New DataSet
        Dim da As New SqlDataAdapter("select docno, psurname, pfname, pmname from PatientInfo where psurname like  '%" & txtsearch.Text & "%' or pfname like '%" & txtsearch.Text & "%' order by psurname+pfname", con)
        con.Close()
        con.Open()
        da.Fill(ds, "PatientInfo")
        dgvsearch.DataSource = ds
        dgvsearch.DataMember = "PatientInfo"

        dgvsearch.Columns(0).HeaderText = "Record Number"
        dgvsearch.Columns(1).HeaderText = "Last Name"
        dgvsearch.Columns(2).HeaderText = "First Name"
        dgvsearch.Columns(3).HeaderText = "Middle Name"
        dgvsearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub dgvsearch_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsearch.CellClick
        aydee = dgvsearch.CurrentRow.Cells(0).Value
        Msearch = 1
        Me.Close()
    End Sub
End Class