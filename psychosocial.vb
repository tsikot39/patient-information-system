Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class psychosocial
    Dim ds As DataSet
    Dim dv As DataView


    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub psychosocial_Load(sender As Object, e As EventArgs) Handles Me.Load
        reload()
    End Sub

    Sub reload()
        ds = New DataSet
        Dim da As New SqlDataAdapter("select " _
                                     & "idfk, " _
                                     & "modifiers, " _
                                     & "strengths " _
                                     & "from psychosocial " _
                                     & "where idfk='" & aydee & "'", con)
        con.Close()
        con.Open()
        da.Fill(ds, "psychosocial")
        dv = New DataView(ds.Tables("psychosocial"))
        txtmodifiers.DataBindings.Clear()
        txtmodifiers.DataBindings.Add("text", dv, "modifiers")
        txtstrengths.DataBindings.Clear()
        txtstrengths.DataBindings.Add("text", dv, "strengths")
        con.Close()
        txtmodifiers.ReadOnly = True
        txtstrengths.ReadOnly = True
        btnedit.Enabled = True
        btnsave.Enabled = False
        btncancel.Enabled = False
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        reload()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        txtmodifiers.ReadOnly = False
        txtstrengths.ReadOnly = False
        btnedit.Enabled = False
        btnsave.Enabled = True
        btncancel.Enabled = True
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim com As New SqlCommand("update psychosocial set modifiers=@modifiers, strengths=@strengths where idfk = '" & aydee & "'", con)
        com.Parameters.AddWithValue("modifiers", txtmodifiers.Text)
        com.Parameters.AddWithValue("strengths", txtstrengths.Text)
        con.Open()
        com.ExecuteNonQuery()
        con.Close()
        txtmodifiers.ReadOnly = True
        txtstrengths.ReadOnly = True
        btnedit.Enabled = True
        btnsave.Enabled = False
        btncancel.Enabled = False
        reload()
    End Sub

End Class