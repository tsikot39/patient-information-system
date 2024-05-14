Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class documentation

    Dim ds As DataSet
    Dim ds1 As DataSet
    Dim dv As DataView
    Dim dv1 As DataView

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        mItem = 1
        cbactivities.Enabled = True
        dtpdatedone.Enabled = True
        dtpdatedone.Text = ""
        txtissues.ReadOnly = False
        txtissues.Text = ""
        txtaction.ReadOnly = False
        txtaction.Text = ""
        txtremarks.ReadOnly = False
        txtremarks.Text = ""
        dtpdategranted.Enabled = True
        dtpdategranted.Text = ""
        txtfunder.ReadOnly = False
        txtfunder.Text = ""
        txtamount.ReadOnly = False
        txtamount.Text = ""
        Dim dsactivities As DataSet
        dsactivities = New DataSet
        Dim daactivities As New SqlDataAdapter("select * from tbl_activities order by description", con)
        daactivities.Fill(dsactivities, "tbl_activities")
        With cbactivities
            .DataSource = dsactivities.Tables("tbl_activities")
            .DisplayMember = "description"
            .ValueMember = "code"
        End With
        cbactivities.SelectedIndex = cbactivities.FindStringExact("")
        btnadd.Enabled = False
        btnedit.Enabled = False
        btnsave.Enabled = True
        btndelete.Enabled = False
        btncancel.Enabled = True
        btnexit.Enabled = True
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If cbactivities.SelectedValue <> "" Then
            mItem = 2
            cbactivities.Enabled = True
            dtpdatedone.Enabled = True
            txtissues.ReadOnly = False
            txtaction.ReadOnly = False
            txtremarks.ReadOnly = False
            dtpdategranted.Enabled = True
            txtfunder.ReadOnly = False
            txtamount.ReadOnly = False
            btnadd.Enabled = False
            btnedit.Enabled = False
            btnsave.Enabled = True
            btndelete.Enabled = False
            btncancel.Enabled = True
            btnexit.Enabled = True
        Else
            MsgBox("No record found!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If cbactivities.Text <> "" Then
            Dim result As New DialogResult
            result = MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = Windows.Forms.DialogResult.Yes Then
                Dim comskill As New SqlCommand("delete from documentation where id = '" & dgvdocumentation.CurrentRow.Cells(0).Value & "'", con)
                con.Open()
                comskill.ExecuteNonQuery()
                con.Close()
                reload()
                cbactivities.DataSource = Nothing
                cbactivities.Enabled = False
                dtpdatedone.Enabled = False
                dtpdatedone.Text = ""
                txtissues.ReadOnly = True
                txtissues.Text = ""
                txtaction.ReadOnly = True
                txtaction.Text = ""
                txtremarks.ReadOnly = True
                txtremarks.Text = ""
                dtpdategranted.Enabled = False
                dtpdategranted.Text = ""
                txtfunder.ReadOnly = False
                txtfunder.Text = ""
                txtamount.ReadOnly = False
                txtamount.Text = ""
                btnadd.Enabled = True
                btnedit.Enabled = True
                btnsave.Enabled = False
                btndelete.Enabled = True
                btncancel.Enabled = False
                btnexit.Enabled = True
                If dgvdocumentation.SelectedRows.Count = 0 Then
                    Exit Sub
                Else
                    dgvdocumentation.CurrentRow.Selected = False
                End If
            End If
        Else
            MsgBox("No record found!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If mItem = 1 Then
            If cbactivities.Text <> "" Then
                Dim com As New SqlCommand("Insert Into documentation (idfk, activities, datedone, issues, actiontaken, remarks, dategranted, funder, amount, logdatetime, loguser) " _
                                          & "values " _
                                          & "(@idfk, @activities, @datedone, @issues, @actiontaken, @remarks, @dategranted, @funder, @amount, @logdatetime, @loguser)", con)

                com.Parameters.AddWithValue("@idfk", aydee)
                com.Parameters.AddWithValue("@datedone", dtpdatedone.Text)
                com.Parameters.AddWithValue("@issues", txtissues.Text)
                com.Parameters.AddWithValue("@actiontaken", txtaction.Text)
                com.Parameters.AddWithValue("@remarks", txtremarks.Text)
                com.Parameters.AddWithValue("@dategranted", dtpdategranted.Text)
                com.Parameters.AddWithValue("@funder", txtfunder.Text)
                com.Parameters.AddWithValue("@amount", txtamount.Text)
                com.Parameters.AddWithValue("@logdatetime", DateTime.Now.ToString)
                com.Parameters.AddWithValue("@loguser", user)
                Dim varactivities As String
                varactivities = ""
                Dim sqlactivities As String = "Select code from tbl_activities where description ='" & cbactivities.Text & "'"
                Dim comactivities As New SqlCommand(sqlactivities, con)
                con.Open()
                Dim dractivities As SqlDataReader
                dractivities = comactivities.ExecuteReader
                If dractivities.HasRows Then
                    While dractivities.Read
                        varactivities = dractivities.Item("code")
                    End While
                    dractivities.Close()
                End If
                con.Close()
                com.Parameters.AddWithValue("@activities", varactivities)
                con.Open()
                com.ExecuteNonQuery()
                con.Close()
                mItem = Nothing
                reload()
                cbactivities.DataSource = Nothing
                cbactivities.Enabled = False
                dtpdatedone.Enabled = False
                dtpdatedone.Text = ""
                txtissues.ReadOnly = True
                txtissues.Text = ""
                txtaction.ReadOnly = True
                txtaction.Text = ""
                txtremarks.ReadOnly = True
                txtremarks.Text = ""
                dtpdategranted.Enabled = False
                dtpdategranted.Text = ""
                txtfunder.ReadOnly = True
                txtfunder.Text = ""
                txtamount.ReadOnly = True
                txtamount.Text = ""
                btnadd.Enabled = True
                btnedit.Enabled = True
                btnsave.Enabled = False
                btndelete.Enabled = True
                btncancel.Enabled = False
                btnexit.Enabled = True
                If dgvdocumentation.SelectedRows.Count = 0 Then
                    Exit Sub
                Else
                    dgvdocumentation.CurrentRow.Selected = False
                End If
            Else
                MsgBox("Please choose an activity!", MsgBoxStyle.Information)
            End If
        ElseIf mItem = 2 Then
            If cbactivities.Text <> "" Then
                Dim com As New SqlCommand("Update documentation " _
                                          & "Set " _
                                          & "activities=@activities, " _
                                          & "datedone=@datedone, " _
                                          & "issues=@issues, " _
                                          & "actiontaken=@actiontaken, " _
                                          & "remarks=@remarks, " _
                                          & "dategranted=@dategranted, " _
                                          & "funder=@funder, " _
                                          & "amount=@amount, " _
                                          & "logdatetime=@logdatetime, " _
                                          & "loguser=@loguser " _
                                          & "Where id = '" & dgvdocumentation.CurrentRow.Cells(0).Value & "'", con)
                Dim varactivities As String
                varactivities = ""
                Dim sqlactivities As String = "Select code from tbl_activities where description ='" & cbactivities.Text & "'"
                Dim comactivities As New SqlCommand(sqlactivities, con)
                con.Open()
                Dim dractivities As SqlDataReader
                dractivities = comactivities.ExecuteReader
                If dractivities.HasRows Then
                    While dractivities.Read
                        varactivities = dractivities.Item("code")
                    End While
                    dractivities.Close()
                End If
                con.Close()
                com.Parameters.AddWithValue("@activities", varactivities)
                If dtpdatedone.Checked = False Then
                    com.Parameters.AddWithValue("datedone", "NULL")
                Else
                    com.Parameters.AddWithValue("datedone", dtpdatedone.Text)
                End If
                com.Parameters.AddWithValue("@issues", txtissues.Text)
                com.Parameters.AddWithValue("@actiontaken", txtaction.Text)
                com.Parameters.AddWithValue("@remarks", txtremarks.Text)
                com.Parameters.AddWithValue("@dategranted", dtpdategranted.Text)
                com.Parameters.AddWithValue("@funder", txtfunder.Text)
                com.Parameters.AddWithValue("@amount", txtamount.Text)
                com.Parameters.AddWithValue("@logdatetime", DateTime.Now.ToString)
                com.Parameters.AddWithValue("@loguser", user)
                con.Open()
                com.ExecuteNonQuery()
                con.Close()
                mItem = Nothing
                reload()
                cbactivities.DataSource = Nothing
                cbactivities.Enabled = False
                dtpdatedone.Enabled = False
                dtpdatedone.Text = ""
                txtissues.ReadOnly = True
                txtissues.Text = ""
                txtaction.ReadOnly = True
                txtaction.Text = ""
                txtremarks.ReadOnly = True
                txtremarks.Text = ""
                dtpdategranted.Enabled = False
                dtpdategranted.Text = ""
                txtfunder.ReadOnly = True
                txtfunder.Text = ""
                txtamount.ReadOnly = True
                txtamount.Text = ""
                btnadd.Enabled = True
                btnedit.Enabled = True
                btnsave.Enabled = False
                btndelete.Enabled = True
                btncancel.Enabled = False
                btnexit.Enabled = True
                If dgvdocumentation.SelectedRows.Count = 0 Then
                    Exit Sub
                Else
                    dgvdocumentation.CurrentRow.Selected = False
                End If
            Else
                MsgBox("Please choose an activity!", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Sub reload()
        ds = New DataSet
        Dim da As New SqlDataAdapter("select documentation.id, idfk, tbl_activities.description, datedone, issues, actiontaken, remarks, dategranted, funder, amount, logdatetime, loguser " _
                                     & "from documentation " _
                                     & "left join tbl_activities " _
                                     & "on documentation.activities=tbl_activities.code " _
                                     & "where idfk = '" & aydee & "' order by documentation.id desc", con)
        con.Close()
        con.Open()
        da.Fill(ds, "documentation")
        dgvdocumentation.DataSource = ds
        dgvdocumentation.DataMember = "documentation"
        dgvdocumentation.Columns(0).HeaderText = "ID"
        dgvdocumentation.Columns(0).Visible = False
        dgvdocumentation.Columns(1).HeaderText = "Idfk"
        dgvdocumentation.Columns(1).Visible = False
        dgvdocumentation.Columns(2).HeaderText = "Activity"
        dgvdocumentation.Columns(3).HeaderText = "Date Done"
        dgvdocumentation.Columns(4).HeaderText = "Issues"
        dgvdocumentation.Columns(5).HeaderText = "Action Taken"
        dgvdocumentation.Columns(6).HeaderText = "Remarks"
        dgvdocumentation.Columns(7).HeaderText = "Date Granted"
        dgvdocumentation.Columns(8).HeaderText = "Funder"
        dgvdocumentation.Columns(9).HeaderText = "Amount"
        dgvdocumentation.Columns(10).HeaderText = "LogDateTime"
        dgvdocumentation.Columns(11).HeaderText = "LogUser"
        'dgvdocumentation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        con.Close()
        cbactivities.Enabled = False
        dtpdatedone.Enabled = False
        txtissues.ReadOnly = True
        txtaction.ReadOnly = True
        txtremarks.ReadOnly = True
        dtpdategranted.Enabled = False
        txtfunder.ReadOnly = True
        txtamount.ReadOnly = True
        btnadd.Enabled = True
        btnedit.Enabled = True
        btnsave.Enabled = False
        btndelete.Enabled = True
        btncancel.Enabled = False
        btnexit.Enabled = True
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        reload()
        cbactivities.DataSource = Nothing
        cbactivities.Enabled = False
        dtpdatedone.Enabled = False
        txtissues.ReadOnly = True
        txtissues.Text = ""
        txtaction.ReadOnly = True
        txtaction.Text = ""
        txtremarks.ReadOnly = True
        txtremarks.Text = ""
        dtpdategranted.Enabled = False
        txtfunder.ReadOnly = True
        txtfunder.Text = ""
        txtamount.ReadOnly = True
        txtamount.Text = ""
        btnadd.Enabled = True
        btnedit.Enabled = True
        btnsave.Enabled = False
        btndelete.Enabled = True
        btncancel.Enabled = False
        btnexit.Enabled = True
        If dgvdocumentation.SelectedRows.Count = 0 Then
            Exit Sub
        Else
            dgvdocumentation.CurrentRow.Selected = False
        End If
    End Sub

    Private Sub documentation_Load(sender As Object, e As EventArgs) Handles Me.Load
        reload()
        'dtpdatedone.Checked = False
    End Sub

    Private Sub dgvdocumentation_SelectionChanged(sender As Object, e As EventArgs) Handles dgvdocumentation.SelectionChanged
        Dim x As String
        x = dgvdocumentation.CurrentRow.Cells(0).Value
        If dgvdocumentation.SelectedRows.Count = 1 Then
            ds = New DataSet
            Dim da As New SqlDataAdapter("select documentation.id, " _
                                         & "tbl_activities.description As actdesc, " _
                                         & "datedone, " _
                                         & "issues, " _
                                         & "actiontaken, " _
                                         & "remarks, " _
                                         & "dategranted, " _
                                         & "funder, " _
                                         & "amount, " _
                                         & "logdatetime, " _
                                         & "loguser " _
                                         & "from documentation " _
                                         & "left join tbl_activities " _
                                         & "on documentation.activities=tbl_activities.code " _
                                         & "where documentation.id = '" & x & "'", con)

            Dim dsactivity As New DataSet
            Dim daactivity As New SqlDataAdapter("select * from tbl_activities order by description", con)

            da.Fill(ds, "documentation")
            dv = New DataView(ds.Tables("documentation"))

            daactivity.Fill(dsactivity, "tbl_activities")
            With cbactivities
                .DataSource = dsactivity.Tables("tbl_activities")
                .DisplayMember = "description"
                .ValueMember = "code"
            End With
            cbactivities.DataBindings.Clear()
            cbactivities.DataBindings.Add("text", dv, "actdesc")

            Try
                dtpdatedone.DataBindings.Clear()
                dtpdatedone.DataBindings.Add("text", dv, "datedone")
            Catch ex As Exception
            End Try
            txtissues.DataBindings.Clear()
            txtissues.DataBindings.Add("text", dv, "issues")
            txtaction.DataBindings.Clear()
            txtaction.DataBindings.Add("text", dv, "actiontaken")
            txtremarks.DataBindings.Clear()
            txtremarks.DataBindings.Add("text", dv, "remarks")
            Try
                dtpdategranted.DataBindings.Clear()
                dtpdategranted.DataBindings.Add("text", dv, "dategranted")
            Catch ex As Exception
            End Try
            txtfunder.DataBindings.Clear()
            txtfunder.DataBindings.Add("text", dv, "funder")
            txtamount.DataBindings.Clear()
            txtamount.DataBindings.Add("text", dv, "amount")
        End If
    End Sub

    Private Sub txtamount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtamount.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class