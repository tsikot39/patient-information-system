Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class familycomposition

    Dim ds As DataSet
    Dim ds1 As DataSet
    Dim dv As DataView
    Dim dv1 As DataView

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub familycomposition_Load(sender As Object, e As EventArgs) Handles Me.Load
        reload()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If mItem = 1 Then
            If txtname.Text <> "" Then
                Dim com As New SqlCommand("Insert Into familycomposition (idfk, name, relationship, age, gender, education, occupation, noe, income) " _
                                          & "values " _
                                          & "(@idfk, @name, @relationship, @age, @gender, @education, @occupation, @noe, @income) " _
                                          & "insert into othersfc (idfk, othersource, totalincome) values (@idfk, @othersource, @totalincome)", con)

                com.Parameters.AddWithValue("@idfk", aydee)
                com.Parameters.AddWithValue("@name", txtname.Text.ToUpper)
                com.Parameters.AddWithValue("@relationship", txtrelation.Text.ToUpper)
                com.Parameters.AddWithValue("@age", txtage.Text)


                Try
                    Dim totalincome As Integer = 0
                    For i As Integer = 0 To dgvfamilycomposition.RowCount - 1
                        totalincome += Convert.ToInt32(dgvfamilycomposition.Rows(i).Cells(9).Value.ToString)
                    Next
                    txttotalincome.Text = totalincome + Val(txtothersource.Text)
                    txtpercapita.Text = Val(txttotalincome.Text) / dgvfamilycomposition.RowCount
                Catch ex As Exception

                End Try

                'gender
                Dim vargender As String
                vargender = ""
                Dim sqlgender As String = "Select code from gender where description ='" & cbgender.Text & "'"
                Dim comgender As New SqlCommand(sqlgender, con)
                con.Open()
                Dim drgender As SqlDataReader
                drgender = comgender.ExecuteReader
                If drgender.HasRows Then
                    While drgender.Read
                        vargender = drgender.Item("code")
                    End While
                    drgender.Close()
                End If
                con.Close()
                com.Parameters.AddWithValue("@gender", vargender)

                'education
                Dim vareducation As String
                vareducation = ""
                Dim sqleducation As String = "Select code from education where description ='" & cbeducation.Text & "'"
                Dim comeducation As New SqlCommand(sqleducation, con)
                con.Open()
                Dim dreducation As SqlDataReader
                dreducation = comeducation.ExecuteReader
                If dreducation.HasRows Then
                    While dreducation.Read
                        vareducation = dreducation.Item("code")
                    End While
                    dreducation.Close()
                End If
                con.Close()
                com.Parameters.AddWithValue("@education", vareducation)

                com.Parameters.AddWithValue("@occupation", txtoccupation.Text.ToUpper)
                com.Parameters.AddWithValue("@noe", txtnature.Text.ToUpper)
                com.Parameters.AddWithValue("@income", txtincome.Text)
                com.Parameters.AddWithValue("@othersource", txtothersource.Text)
                com.Parameters.AddWithValue("@totalincome", txttotalincome.Text)

                con.Open()
                com.ExecuteNonQuery()
                con.Close()

                mItem = Nothing
                reload()

                txtname.ReadOnly = True
                txtname.Text = ""
                txtrelation.ReadOnly = True
                txtrelation.Text = ""
                txtage.ReadOnly = True
                txtage.Text = ""
                cbgender.DataSource = Nothing
                cbgender.Enabled = False
                cbeducation.DataSource = Nothing
                cbeducation.Enabled = False
                txtoccupation.ReadOnly = True
                txtoccupation.Text = ""
                txtnature.ReadOnly = True
                txtnature.Text = ""
                txtincome.ReadOnly = True
                txtincome.Text = ""

                btnadd.Enabled = True
                btnedit.Enabled = True
                btnsave.Enabled = False
                btndelete.Enabled = True
                btncancel.Enabled = False
                btnexit.Enabled = True

                If dgvfamilycomposition.SelectedRows.Count = 0 Then
                    Exit Sub
                Else
                    dgvfamilycomposition.CurrentRow.Selected = False
                End If

            Else
                MsgBox("Please enter a Name!", MsgBoxStyle.Information)
            End If

        ElseIf mItem = 2 Then

            If txtname.Text <> "" Then
                Dim com As New SqlCommand("Update familycomposition " _
                                          & "Set " _
                                          & "name=@name, " _
                                          & "relationship=@relationship, " _
                                          & "age=@age, " _
                                          & "gender=@gender, " _
                                          & "education=@education, " _
                                          & "occupation=@occupation, " _
                                          & "noe=@noe, " _
                                          & "income=@income " _
                                          & "Where id = '" & dgvfamilycomposition.CurrentRow.Cells(0).Value & "' " _
                                          & "update othersfc set othersource=@othersource, totalincome=@totalincome where idfk='" & aydee & "'", con)

                Try
                    Dim totalincome As Integer = 0
                    For i As Integer = 0 To dgvfamilycomposition.RowCount - 1
                        totalincome += Convert.ToInt32(dgvfamilycomposition.Rows(i).Cells(9).Value.ToString)
                    Next
                    txttotalincome.Text = totalincome + Val(txtothersource.Text)
                    txtpercapita.Text = Val(txttotalincome.Text) / dgvfamilycomposition.RowCount
                Catch ex As Exception

                End Try

                com.Parameters.AddWithValue("@idfk", aydee)
                com.Parameters.AddWithValue("@name", txtname.Text.ToUpper)
                com.Parameters.AddWithValue("@relationship", txtrelation.Text.ToUpper)
                com.Parameters.AddWithValue("@age", txtage.Text)

                'gender
                Dim vargender As String
                vargender = ""
                Dim sqlgender As String = "Select code from gender where description ='" & cbgender.Text & "'"
                Dim comgender As New SqlCommand(sqlgender, con)
                con.Open()
                Dim drgender As SqlDataReader
                drgender = comgender.ExecuteReader
                If drgender.HasRows Then
                    While drgender.Read
                        vargender = drgender.Item("code")
                    End While
                    drgender.Close()
                End If
                con.Close()
                com.Parameters.AddWithValue("@gender", vargender)

                'education
                Dim vareducation As String
                vareducation = ""
                Dim sqleducation As String = "Select code from education where description ='" & cbeducation.Text & "'"
                Dim comeducation As New SqlCommand(sqleducation, con)
                con.Open()
                Dim dreducation As SqlDataReader
                dreducation = comeducation.ExecuteReader
                If dreducation.HasRows Then
                    While dreducation.Read
                        vareducation = dreducation.Item("code")
                    End While
                    dreducation.Close()
                End If
                con.Close()
                com.Parameters.AddWithValue("@education", vareducation)
                com.Parameters.AddWithValue("occupation", txtoccupation.Text.ToUpper)
                com.Parameters.AddWithValue("@noe", txtnature.Text.ToUpper)
                com.Parameters.AddWithValue("@income", txtincome.Text)
                com.Parameters.AddWithValue("@othersource", txtothersource.Text)
                com.Parameters.AddWithValue("@totalincome", txttotalincome.Text)

                con.Open()
                com.ExecuteNonQuery()
                con.Close()

                mItem = Nothing
                reload()

                txtname.ReadOnly = True
                txtname.Text = ""
                txtrelation.ReadOnly = True
                txtrelation.Text = ""
                txtage.ReadOnly = True
                txtage.Text = ""
                cbgender.DataSource = Nothing
                cbgender.Enabled = False
                cbeducation.DataSource = Nothing
                cbeducation.Enabled = False
                txtoccupation.ReadOnly = True
                txtoccupation.Text = ""
                txtnature.ReadOnly = True
                txtnature.Text = ""
                txtincome.ReadOnly = True
                txtincome.Text = ""

                btnadd.Enabled = True
                btnedit.Enabled = True
                btnsave.Enabled = False
                btndelete.Enabled = True
                btncancel.Enabled = False
                btnexit.Enabled = True

                If dgvfamilycomposition.SelectedRows.Count = 0 Then
                    Exit Sub
                Else
                    dgvfamilycomposition.CurrentRow.Selected = False
                End If
            Else
                MsgBox("Please enter a Name!", MsgBoxStyle.Information)
            End If
            ElseIf mItem = 3 Then
                If txtname.Text = "" Then
                Dim com As New SqlCommand("update othersfc set othersource=@othersource, totalincome=@totalincome where idfk='" & aydee & "'", con)

                Try
                    Dim totalincome As Integer = 0
                    For i As Integer = 0 To dgvfamilycomposition.RowCount - 1
                        totalincome += Convert.ToInt32(dgvfamilycomposition.Rows(i).Cells(9).Value.ToString)
                    Next
                    txttotalincome.Text = totalincome + Val(txtothersource.Text)
                    txtpercapita.Text = Val(txttotalincome.Text) / dgvfamilycomposition.RowCount
                Catch ex As Exception

                End Try

                com.Parameters.AddWithValue("@othersource", txtothersource.Text)
                com.Parameters.AddWithValue("@totalincome", txttotalincome.Text)

                    con.Open()
                    com.ExecuteNonQuery()
                    con.Close()

                    mItem = Nothing
                    reload()

                txtname.ReadOnly = True
                txtname.Text = ""
                txtrelation.ReadOnly = True
                txtrelation.Text = ""
                txtage.ReadOnly = True
                txtage.Text = ""
                cbgender.DataSource = Nothing
                cbgender.Enabled = False
                cbeducation.DataSource = Nothing
                cbeducation.Enabled = False
                txtoccupation.ReadOnly = True
                txtoccupation.Text = ""
                txtnature.ReadOnly = True
                txtnature.Text = ""
                txtincome.ReadOnly = True
                txtincome.Text = ""
                    txtothersource.ReadOnly = True

                    btnadd.Enabled = True
                    btnedit.Enabled = True
                    btnsave.Enabled = False
                    btndelete.Enabled = True
                    btncancel.Enabled = False
                    btnexit.Enabled = True

                    If dgvfamilycomposition.SelectedRows.Count = 0 Then
                        Exit Sub
                    Else
                        dgvfamilycomposition.CurrentRow.Selected = False
                    End If
                End If
            End If
    End Sub

    Sub reload()
        ds1 = New DataSet
        Dim da1 As New SqlDataAdapter("select * from othersfc where idfk='" & aydee & "'", con)
        con.Close()
        con.Open()
        da1.Fill(ds1, "othersfc")
        dv1 = New DataView(ds1.Tables("othersfc"))
        txtothersource.DataBindings.Clear()
        txtothersource.DataBindings.Add("text", dv1, "othersource")

        con.Close()

        ds = New DataSet
        Dim da As New SqlDataAdapter("select familycomposition.id, idfk, name, relationship, age, gender.description, education.description, occupation, noe, income " _
                                     & "from familycomposition " _
                                     & "left join gender " _
                                     & "on familycomposition.gender=gender.code " _
                                     & "left join education " _
                                     & "on familycomposition.education=education.code " _
                                     & "where idfk = '" & aydee & "' order by familycomposition.id desc", con)
        con.Close()
        con.Open()
        da.Fill(ds, "familycomposition")
        dgvfamilycomposition.DataSource = ds
        dgvfamilycomposition.DataMember = "familycomposition"
        dgvfamilycomposition.Columns(0).HeaderText = "Id"
        dgvfamilycomposition.Columns(0).Visible = False
        dgvfamilycomposition.Columns(1).HeaderText = "Idfk"
        dgvfamilycomposition.Columns(1).Visible = False
        dgvfamilycomposition.Columns(2).HeaderText = "Name"
        dgvfamilycomposition.Columns(3).HeaderText = "Relationship to Patient"
        dgvfamilycomposition.Columns(4).HeaderText = "Age"
        dgvfamilycomposition.Columns(5).HeaderText = "Gender"
        dgvfamilycomposition.Columns(6).HeaderText = "Education"
        dgvfamilycomposition.Columns(7).HeaderText = "Occupation"
        dgvfamilycomposition.Columns(8).HeaderText = "Nature of Employment"
        dgvfamilycomposition.Columns(9).HeaderText = "Income"
        dgvfamilycomposition.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

        Try
            Dim totalincome As Integer = 0
            For i As Integer = 0 To dgvfamilycomposition.RowCount - 1
                totalincome += Convert.ToInt32(dgvfamilycomposition.Rows(i).Cells(9).Value.ToString)
            Next
            txttotalincome.Text = totalincome + Val(txtothersource.Text)
            txtpercapita.Text = Val(txttotalincome.Text) / dgvfamilycomposition.RowCount
        Catch ex As Exception

        End Try

        con.Close()

        txtothersource.ReadOnly = True
        txttotalincome.ReadOnly = True
        txtpercapita.ReadOnly = True
        txtname.ReadOnly = True
        txtrelation.ReadOnly = True
        txtage.ReadOnly = True
        cbgender.Enabled = False
        cbeducation.Enabled = False
        txtoccupation.ReadOnly = True
        txtnature.ReadOnly = True
        txtincome.ReadOnly = True

        btnadd.Enabled = True
        btnedit.Enabled = True
        btnsave.Enabled = False
        btndelete.Enabled = True
        btncancel.Enabled = False
        btnexit.Enabled = True
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        reload()
        txtname.ReadOnly = True
        txtname.Text = ""
        txtrelation.ReadOnly = True
        txtrelation.Text = ""
        txtage.ReadOnly = True
        txtage.Text = ""
        cbgender.DataSource = Nothing
        cbgender.Enabled = False
        cbeducation.DataSource = Nothing
        cbeducation.Enabled = False
        txtnature.ReadOnly = True
        txtnature.Text = ""

        btnadd.Enabled = True
        btnedit.Enabled = True
        btnsave.Enabled = False
        btndelete.Enabled = True
        btncancel.Enabled = False
        btnexit.Enabled = True

        If dgvfamilycomposition.SelectedRows.Count = 0 Then
            Exit Sub
        Else
            dgvfamilycomposition.CurrentRow.Selected = False
        End If
    End Sub

    Private Sub dgvfamilycomposition_SelectionChanged(sender As Object, e As EventArgs) Handles dgvfamilycomposition.SelectionChanged
        Dim x As String
        x = dgvfamilycomposition.CurrentRow.Cells(0).Value

        If dgvfamilycomposition.SelectedRows.Count = 1 Then
            ds = New DataSet
            Dim da As New SqlDataAdapter("select familycomposition.id, " _
                                         & "name, " _
                                         & "relationship, " _
                                         & "age, " _
                                         & "gender.description As Gdesc, " _
                                         & "education.description As Edesc, " _
                                         & "occupation, " _
                                         & "noe, " _
                                         & "income " _
                                         & "from familycomposition " _
                                         & "left join gender " _
                                         & "on familycomposition.gender=gender.code " _
                                         & "left join education " _
                                         & "on familycomposition.education=education.code " _
                                         & "where familycomposition.id = '" & x & "'", con)

            Dim dsgender As New DataSet
            Dim dagender As New SqlDataAdapter("select * from gender order by description", con)

            Dim dseducation As New DataSet
            Dim daeducation As New SqlDataAdapter("select * from education order by description", con)

            da.Fill(ds, "familycomposition")
            dv = New DataView(ds.Tables("familycomposition"))

            txtname.DataBindings.Clear()
            txtname.DataBindings.Add("text", dv, "name")
            txtrelation.DataBindings.Clear()
            txtrelation.DataBindings.Add("text", dv, "relationship")
            txtage.DataBindings.Clear()
            txtage.DataBindings.Add("text", dv, "age")

            dagender.Fill(dsgender, "gender")
            With cbgender
                .DataSource = dsgender.Tables("gender")
                .DisplayMember = "description"
                .ValueMember = "code"
            End With
            cbgender.DataBindings.Clear()
            cbgender.DataBindings.Add("text", dv, "Gdesc")

            daeducation.Fill(dseducation, "education")
            With cbeducation
                .DataSource = dseducation.Tables("education")
                .DisplayMember = "description"
                .ValueMember = "code"
            End With
            cbeducation.DataBindings.Clear()
            cbeducation.DataBindings.Add("text", dv, "Edesc")

            txtoccupation.DataBindings.Clear()
            txtoccupation.DataBindings.Add("text", dv, "occupation")
            txtnature.DataBindings.Clear()
            txtnature.DataBindings.Add("text", dv, "noe")
            txtincome.DataBindings.Clear()
            txtincome.DataBindings.Add("text", dv, "income")
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If txtname.Text <> "" Then
            Dim result As New DialogResult
            result = MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = Windows.Forms.DialogResult.Yes Then
                Dim comskill As New SqlCommand("delete From familycomposition Where id = '" & dgvfamilycomposition.CurrentRow.Cells(0).Value & "' " _
                                                & "delete from othersfc where idfk = '" & dgvfamilycomposition.CurrentRow.Cells(0).Value & "'", con)

                con.Open()
                comskill.ExecuteNonQuery()
                con.Close()
                reload()
                txtname.ReadOnly = True
                txtname.Text = ""
                txtrelation.ReadOnly = True
                txtrelation.Text = ""
                txtage.ReadOnly = True
                txtage.Text = ""
                cbgender.DataSource = Nothing
                cbgender.Enabled = False
                cbeducation.DataSource = Nothing
                cbeducation.Enabled = False
                txtoccupation.ReadOnly = True
                txtoccupation.Text = ""
                txtnature.ReadOnly = True
                txtnature.Text = ""
                txtincome.ReadOnly = True
                txtincome.Text = ""

                btnadd.Enabled = True
                btnedit.Enabled = True
                btnsave.Enabled = False
                btndelete.Enabled = True
                btncancel.Enabled = False
                btnexit.Enabled = True

                If dgvfamilycomposition.SelectedRows.Count = 0 Then
                    Exit Sub
                Else
                    dgvfamilycomposition.CurrentRow.Selected = False
                End If

            End If
        Else
            MsgBox("No record found!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If txtname.Text <> "" Then
            mItem = 2
            txtname.ReadOnly = False
            txtrelation.ReadOnly = False
            txtage.ReadOnly = False
            cbgender.Enabled = True
            cbeducation.Enabled = True
            txtoccupation.ReadOnly = False
            txtnature.ReadOnly = False
            txtincome.ReadOnly = False
            txtothersource.ReadOnly = False
            btnadd.Enabled = False
            btnedit.Enabled = False
            btnsave.Enabled = True
            btndelete.Enabled = False
            btncancel.Enabled = True
            btnexit.Enabled = True
            'ElseIf txtname.Text = "" Then
            '    mItem = 3
            '    txtothersource.ReadOnly = False
            '    btnadd.Enabled = False
            '    btnedit.Enabled = False
            '    btnsave.Enabled = True
            '    btndelete.Enabled = False
            '    btncancel.Enabled = True
            '    btnexit.Enabled = True
        Else
            MsgBox("No record found!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        mItem = 1
        txtname.ReadOnly = False
        txtname.Text = ""
        txtrelation.ReadOnly = False
        txtrelation.Text = ""
        txtage.ReadOnly = False
        txtage.Text = ""
        cbgender.Enabled = True
        cbeducation.Enabled = True
        txtoccupation.ReadOnly = False
        txtoccupation.Text = ""
        txtnature.ReadOnly = False
        txtnature.Text = ""
        txtincome.ReadOnly = False
        txtincome.Text = ""

        Dim dsgender As DataSet
        dsgender = New DataSet
        Dim dagender As New SqlDataAdapter("select * from gender order by description", con)
        dagender.Fill(dsgender, "gender")
        With cbgender
            .DataSource = dsgender.Tables("gender")
            .DisplayMember = "description"
            .ValueMember = "code"
        End With
        cbgender.SelectedIndex = cbgender.FindStringExact("")

        Dim dseducation As DataSet
        dseducation = New DataSet
        Dim daeducation As New SqlDataAdapter("select * from education order by description", con)
        daeducation.Fill(dseducation, "education")
        With cbeducation
            .DataSource = dseducation.Tables("education")
            .DisplayMember = "description"
            .ValueMember = "code"
        End With
        cbeducation.SelectedIndex = cbeducation.FindStringExact("")

        btnadd.Enabled = False
        btnedit.Enabled = False
        btnsave.Enabled = True
        btndelete.Enabled = False
        btncancel.Enabled = True
        btnexit.Enabled = True
    End Sub

    Private Sub txtincome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtincome.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtage.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtothersource_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtothersource.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

End Class