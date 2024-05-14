Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class familyexpenses

    Dim ds As DataSet

    Dim dstotalincome As DataSet
    Dim dv As DataView
    Dim dvtotalincome As DataView

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub familyexpenses_Load(sender As Object, e As EventArgs) Handles Me.Load
        reload()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        txtfood.ReadOnly = False
        txtshelter.ReadOnly = False
        txtclothings.ReadOnly = False
        txteducation.ReadOnly = False
        txtelectricity.ReadOnly = False
        txtwater.ReadOnly = False
        txtothers.ReadOnly = False
        txttotalfamilyexpenses.ReadOnly = True
        txtnetfamilyincome.ReadOnly = True

        btnedit.Enabled = False
        btnsave.Enabled = True
        btncancel.Enabled = True
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        Try
            Dim varfood, varshelter, varclothings, vareducation, varelectricity, varwater, varothers, vartotalfamilyexpenses As Integer
            varfood = 0
            varshelter = 0
            varclothings = 0
            vareducation = 0
            varelectricity = 0
            varwater = 0
            varothers = 0
            vartotalfamilyexpenses = 0

            varfood = txtfood.Text
            varshelter = txtshelter.Text
            varclothings = txtclothings.Text
            vareducation = txteducation.Text
            varelectricity = txtelectricity.Text
            varwater = txtwater.Text
            varothers = txtothers.Text
            vartotalfamilyexpenses = varfood + varshelter + varclothings + vareducation + varelectricity + varwater + varothers

            con.Close()
            Dim com As New SqlCommand("Update familyexpenses " _
                          & "Set " _
                          & "food=@food, " _
                          & "shelter=@shelter, " _
                          & "clothings=@clothings, " _
                          & "education=@education, " _
                          & "electricity=@electricity, " _
                          & "water=@water, " _
                          & "others=@others, " _
                          & "totalfamilyexpenses=@totalfamilyexpenses " _
                          & "where idfk = '" & aydee & "'", con)
            com.Parameters.AddWithValue("food", varfood)
            com.Parameters.AddWithValue("shelter", varshelter)
            com.Parameters.AddWithValue("clothings", varclothings)
            com.Parameters.AddWithValue("education", vareducation)
            com.Parameters.AddWithValue("electricity", varelectricity)
            com.Parameters.AddWithValue("water", varwater)
            com.Parameters.AddWithValue("others", varothers)
            com.Parameters.AddWithValue("totalfamilyexpenses", vartotalfamilyexpenses)
            con.Open()
            com.ExecuteNonQuery()
            con.Close()

            txtfood.ReadOnly = True
            txtshelter.ReadOnly = True
            txtclothings.ReadOnly = True
            txteducation.ReadOnly = True
            txtelectricity.ReadOnly = True
            txtwater.ReadOnly = True
            txtothers.ReadOnly = True
            btnedit.Enabled = True
            btnsave.Enabled = False
            btncancel.Enabled = False
            reload()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        txtfood.ReadOnly = True
        txtshelter.ReadOnly = True
        txtclothings.ReadOnly = True
        txteducation.ReadOnly = True
        txtelectricity.ReadOnly = True
        txtwater.ReadOnly = True
        txtothers.ReadOnly = True

        btnedit.Enabled = True
        btnsave.Enabled = False
        btncancel.Enabled = False

        txttotalfamilyexpenses.Text = ""

        ds = New DataSet
        Dim da As New SqlDataAdapter("select " _
                                     & "id, " _
                                     & "idfk, " _
                                     & "food, " _
                                     & "shelter, " _
                                     & "clothings, " _
                                     & "education, " _
                                     & "electricity, " _
                                     & "water, " _
                                     & "others " _
                                     & "from familyexpenses " _
                                     & "where idfk='" & aydee & "'", con)

        con.Open()
        da.Fill(ds, "familyexpenses")
        dv = New DataView(ds.Tables("familyexpenses"))
        txtfood.DataBindings.Clear()
        txtfood.DataBindings.Add("text", dv, "food")
        txtshelter.DataBindings.Clear()
        txtshelter.DataBindings.Add("text", dv, "shelter")
        txtclothings.DataBindings.Clear()
        txtclothings.DataBindings.Add("text", dv, "clothings")
        txteducation.DataBindings.Clear()
        txteducation.DataBindings.Add("text", dv, "education")
        txtelectricity.DataBindings.Clear()
        txtelectricity.DataBindings.Add("text", dv, "electricity")
        txtwater.DataBindings.Clear()
        txtwater.DataBindings.Add("text", dv, "water")
        txtothers.DataBindings.Clear()
        txtothers.DataBindings.Add("text", dv, "others")
        con.Close()
        txtfood.ReadOnly = True
        txtshelter.ReadOnly = True
        txtclothings.ReadOnly = True
        txteducation.ReadOnly = True
        txtelectricity.ReadOnly = True
        txtwater.ReadOnly = True
        txtothers.ReadOnly = True

        btnedit.Enabled = True
        btnsave.Enabled = False
        btncancel.Enabled = False
    End Sub

    Sub reload()
        txttotalincome.ReadOnly = True
        txttotalincome.Text = ""
        txttotalfamilyexpenses.ReadOnly = True
        txttotalfamilyexpenses.Text = ""
        txtnetfamilyincome.ReadOnly = True
        txtnetfamilyincome.Text = ""

        ds = New DataSet
        Dim da As New SqlDataAdapter("select " _
                                     & "idfk, " _
                                     & "food, " _
                                     & "shelter, " _
                                     & "clothings, " _
                                     & "education, " _
                                     & "electricity, " _
                                     & "water, " _
                                     & "others, " _
                                     & "totalfamilyexpenses " _
                                     & "from familyExpenses " _
                                     & "where idfk='" & aydee & "'", con)

        con.Close()
        con.Open()
        da.Fill(ds, "familyexpenses")
        dv = New DataView(ds.Tables("familyexpenses"))

        txtfood.DataBindings.Clear()
        txtfood.DataBindings.Add("text", dv, "food")
        txtshelter.DataBindings.Clear()
        txtshelter.DataBindings.Add("text", dv, "shelter")
        txtclothings.DataBindings.Clear()
        txtclothings.DataBindings.Add("text", dv, "clothings")
        txteducation.DataBindings.Clear()
        txteducation.DataBindings.Add("text", dv, "education")
        txtelectricity.DataBindings.Clear()
        txtelectricity.DataBindings.Add("text", dv, "electricity")
        txtwater.DataBindings.Clear()
        txtwater.DataBindings.Add("text", dv, "water")
        txtothers.DataBindings.Clear()
        txtothers.DataBindings.Add("text", dv, "others")
        txttotalfamilyexpenses.DataBindings.Clear()
        txttotalfamilyexpenses.DataBindings.Add("text", dv, "totalfamilyexpenses")

        con.Close()
        txtfood.ReadOnly = True
        txtshelter.ReadOnly = True
        txtclothings.ReadOnly = True
        txteducation.ReadOnly = True
        txtelectricity.ReadOnly = True
        txtwater.ReadOnly = True
        txtothers.ReadOnly = True

        dstotalincome = New DataSet
        Dim datotalincome As New SqlDataAdapter("select totalincome from othersfc where idfk='" & aydee & "'", con)
        con.Close()
        con.Open()
        datotalincome.Fill(dstotalincome, "othersfc")
        dvtotalincome = New DataView(dstotalincome.Tables("othersfc"))
        txttotalincome.DataBindings.Clear()
        txttotalincome.DataBindings.Add("text", dvtotalincome, "totalincome")
        con.Close()

        Try
            txtnetfamilyincome.Text = Val(txttotalincome.Text) - Val(txttotalfamilyexpenses.Text)
            'txtpercapita.Text = Val(txttotalincome.Text) / dgvfamilycomposition.RowCount
        Catch ex As Exception

        End Try

        btnedit.Enabled = True
        btnsave.Enabled = False
        btncancel.Enabled = False
    End Sub

    Private Sub txtfood_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtfood.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtshelter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtshelter.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtclothings_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtclothings.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txteducation_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txteducation.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtelectricity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtelectricity.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtwater_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtwater.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtothers_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtothers.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class