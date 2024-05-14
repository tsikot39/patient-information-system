Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Form1

    Dim ds As DataSet
    Dim dsyear As DataSet
    Dim dscourse As DataSet
    Dim dsschool As DataSet
    'Dim dsloaddata As DataSet
    Dim dsloadyear As DataSet
    Dim dsloadcourse As DataSet
    Dim dsloadschool As DataSet
    Dim dsdata As DataSet
    Dim dsgender As DataSet

    Dim dv As DataView

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbpatientclassification.Enabled = False
        txthrn.ReadOnly = True
        txtroomno.ReadOnly = True
        dtpadmissiondate.Enabled = False
        dtpadmissiondate.Checked = False
        cbpatienttype.Enabled = False
        txtsourceofreferral.ReadOnly = True
        dtpdateofinterview.Enabled = False
        dtpdateofinterview.Checked = False
        cbphilhealthtype.Enabled = False
        cbclassification.Enabled = False
        txtheight.ReadOnly = True
        txtweight.ReadOnly = True
        txtlname.ReadOnly = True
        txtfname.ReadOnly = True
        txtmname.ReadOnly = True
        txtage.ReadOnly = True
        cbgender.Enabled = False
        txtcityaddress.ReadOnly = True
        txtprovincialaddress.ReadOnly = True
        dtpbday.Enabled = False
        dtpbday.Checked = False
        txtbirthplace.ReadOnly = True
        txtreligion.ReadOnly = True
        cbcivilstatus.Enabled = False
        cbeducation.Enabled = False
        txtoccupation.ReadOnly = True

        btnsave.Enabled = False
        btnedit.Enabled = False
        btncancel.Enabled = False
        btnfamilycomposition.Enabled = False
        btnfamilyexpenses.Enabled = False
        btnpsychosocial.Enabled = False
        btndocumentation.Enabled = False

        Label25.Text = ""
        lbluser.Text = "Welcome, " & user & "!"
    End Sub

    Private Sub main_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If Msearch = 1 Then
            LoadData()
            btnedit.Enabled = True
            btnsave.Enabled = False
            btnadd.Enabled = True
            btncancel.Enabled = False
            btnsearch.Enabled = True
            btnfamilycomposition.Enabled = True
            btnfamilyexpenses.Enabled = True
            btnpsychosocial.Enabled = True
            btndocumentation.Enabled = True
            Msearch = Nothing
        End If
    End Sub

    Private Sub LoadData()
        Dim dsloaddata As DataSet = New DataSet
        Dim daloaddata As SqlDataAdapter = New SqlDataAdapter("Select *, " _
                                                              & "PatientClassification.description As PCdesc, " _
                                                              & "PatientType.description As PTdesc, " _
                                                              & "PhilHealthType.description As PHTdesc, " _
                                                              & "Classification.description As Cdesc, " _
                                                              & "Gender.description As Gdesc, " _
                                                              & "CivilStatus.description As CSdesc, " _
                                                              & "Education.description As Edesc " _
                                                              & "From PatientInfo " _
                                                              & "LEFT JOIN PatientClassification " _
                                                              & "ON PatientInfo.patientclassification=PatientClassification.code " _
                                                              & "LEFT JOIN PatientType " _
                                                              & "ON PatientInfo.patienttype=PatientType.code " _
                                                              & "LEFT JOIN PhilHealthType " _
                                                              & "ON PatientInfo.philhealthtype=PhilHealthType.code " _
                                                              & "LEFT JOIN Classification " _
                                                              & "ON PatientInfo.classification=Classification.code " _
                                                              & "LEFT JOIN Gender " _
                                                              & "ON PatientInfo.gender=Gender.code " _
                                                              & "LEFT JOIN CivilStatus " _
                                                              & "ON PatientInfo.civilstatus=CivilStatus.code " _
                                                              & "LEFT JOIN Education " _
                                                              & "ON PatientInfo.education=Education.code " _
                                                              & "Where docno = '" & aydee & "'", con)

        Dim dspatientclassification As DataSet = New DataSet
        Dim dapatientclassification As New SqlDataAdapter("select * from PatientClassification order by description", con)

        Dim dspatienttype As DataSet = New DataSet
        Dim dapatienttype As New SqlDataAdapter("select * from PatientType order by description", con)

        Dim dsphilhealthtype As DataSet = New DataSet
        Dim daphilhealthtype As New SqlDataAdapter("select * from PhilHealthType order by description", con)

        Dim dsclassification As DataSet = New DataSet
        Dim daclassification As New SqlDataAdapter("select * from Classification order by description", con)

        Dim dsgender As DataSet = New DataSet
        Dim dagender As New SqlDataAdapter("select * from Gender order by description", con)

        Dim dscivilstatus As DataSet = New DataSet
        Dim dacivilstatus As New SqlDataAdapter("select * from CivilStatus order by description", con)

        Dim dseducation As DataSet = New DataSet
        Dim daeducation As New SqlDataAdapter("select * from Education order by description", con)

        con.Close()
        con.Open()

        daloaddata.Fill(dsloaddata, "PatientInfo")
        dv = New DataView(dsloaddata.Tables("PatientInfo"))

        Label25.DataBindings.Clear()
        Label25.DataBindings.Add("Text", dv, "docno")

        dapatientclassification.Fill(dspatientclassification, "PatientClassification")
        With cbpatientclassification
            .DataSource = dspatientclassification.Tables("PatientClassification")
            .DisplayMember = "description"
            .ValueMember = "code"
        End With
        cbpatientclassification.DataBindings.Clear()
        cbpatientclassification.DataBindings.Add("Text", dv, "PCdesc")

        txthrn.DataBindings.Clear()
        txthrn.DataBindings.Add("Text", dv, "hrn")
        txtroomno.DataBindings.Clear()
        txtroomno.DataBindings.Add("Text", dv, "roomno")

        Try
            dtpadmissiondate.DataBindings.Clear()
            dtpadmissiondate.DataBindings.Add("Text", dv, "admissiondate")
        Catch ex As Exception
        End Try

        dapatienttype.Fill(dspatienttype, "PatientType")
        With cbpatienttype
            .DataSource = dspatienttype.Tables("PatientType")
            .DisplayMember = "description"
            .ValueMember = "code"
        End With
        cbpatienttype.DataBindings.Clear()
        cbpatienttype.DataBindings.Add("Text", dv, "PTdesc")

        txtsourceofreferral.DataBindings.Clear()
        txtsourceofreferral.DataBindings.Add("Text", dv, "sourceofreferral")

        Try
            dtpdateofinterview.DataBindings.Clear()
            dtpdateofinterview.DataBindings.Add("Text", dv, "dateofinterview")
        Catch ex As Exception
        End Try

        daphilhealthtype.Fill(dsphilhealthtype, "PhilHealthType")
        With cbphilhealthtype
            .DataSource = dsphilhealthtype.Tables("PhilHealthType")
            .DisplayMember = "description"
            .ValueMember = "code"
        End With
        cbphilhealthtype.DataBindings.Clear()
        cbphilhealthtype.DataBindings.Add("Text", dv, "PHTdesc")

        daclassification.Fill(dsclassification, "Classification")
        With cbclassification
            .DataSource = dsclassification.Tables("Classification")
            .DisplayMember = "description"
            .ValueMember = "code"
        End With
        cbclassification.DataBindings.Clear()
        cbclassification.DataBindings.Add("Text", dv, "Cdesc")

        txtheight.DataBindings.Clear()
        txtheight.DataBindings.Add("Text", dv, "height")
        txtweight.DataBindings.Clear()
        txtweight.DataBindings.Add("Text", dv, "weight")
        txtlname.DataBindings.Clear()
        txtlname.DataBindings.Add("Text", dv, "psurname")
        txtfname.DataBindings.Clear()
        txtfname.DataBindings.Add("Text", dv, "pfname")
        txtmname.DataBindings.Clear()
        txtmname.DataBindings.Add("Text", dv, "pmname")
        txtage.DataBindings.Clear()
        txtage.DataBindings.Add("Text", dv, "age")

        dagender.Fill(dsgender, "Gender")
        With cbgender
            .DataSource = dsgender.Tables("Gender")
            .DisplayMember = "description"
            .ValueMember = "code"
        End With
        cbgender.DataBindings.Clear()
        cbgender.DataBindings.Add("Text", dv, "Gdesc")

        txtcityaddress.DataBindings.Clear()
        txtcityaddress.DataBindings.Add("Text", dv, "cityaddress")
        txtprovincialaddress.DataBindings.Clear()
        txtprovincialaddress.DataBindings.Add("Text", dv, "provincialaddress")

        Try
            dtpbday.DataBindings.Clear()
            dtpbday.DataBindings.Add("Text", dv, "birthday")
        Catch ex As Exception
        End Try

        txtbirthplace.DataBindings.Clear()
        txtbirthplace.DataBindings.Add("Text", dv, "birthplace")
        txtreligion.DataBindings.Clear()
        txtreligion.DataBindings.Add("Text", dv, "religion")

        dacivilstatus.Fill(dscivilstatus, "CivilStatus")
        With cbcivilstatus
            .DataSource = dscivilstatus.Tables("CivilStatus")
            .DisplayMember = "description"
            .ValueMember = "code"
        End With
        cbcivilstatus.DataBindings.Clear()
        cbcivilstatus.DataBindings.Add("Text", dv, "CSdesc")

        daeducation.Fill(dseducation, "Education")
        With cbeducation
            .DataSource = dseducation.Tables("Education")
            .DisplayMember = "description"
            .ValueMember = "code"
        End With
        cbeducation.DataBindings.Clear()
        cbeducation.DataBindings.Add("Text", dv, "Edesc")

        txtoccupation.DataBindings.Clear()
        txtoccupation.DataBindings.Add("Text", dv, "occupation")
        txtage.Text = DateDiff(DateInterval.Year, CDate(dtpbday.Text.Trim), Now.Date)
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim alphabets As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        'Dim small_alphabets As String = "abcdefghijklmnopqrstuvwxyz"
        Dim numbers As String = "1234567890"
        Dim characters As String = numbers
        'characters += Convert.ToString(alphabets & small_alphabets) & numbers
        characters += Convert.ToString(alphabets) & numbers
        Dim length As Integer = Integer.Parse("10")
        Dim id As String = String.Empty
        For i As Integer = 0 To length - 1
            Dim character As String = String.Empty
            Do
                Dim index As Integer = New Random().Next(0, characters.Length)
                character = characters.ToCharArray()(index).ToString()
            Loop While id.IndexOf(character) <> -1
            id += character
        Next
        Label25.Text = id

        Dim dspatientclassification As DataSet = New DataSet
        Dim dapatientclassification As New SqlDataAdapter("select * from PatientClassification order by description", con)

        Dim dspatienttype As DataSet = New DataSet
        Dim dapatienttype As New SqlDataAdapter("select * from PatientType order by description", con)

        Dim dsphilhealthtype As DataSet = New DataSet
        Dim daphilhealthtype As New SqlDataAdapter("select * from PhilHealthType order by description", con)

        dapatientclassification.Fill(dspatientclassification, "PatientClassification")
        With cbpatientclassification
            .DataSource = dspatientclassification.Tables("PatientClassification")
            .DisplayMember = "description"
            .ValueMember = "code"
        End With
        cbpatientclassification.DataBindings.Clear()

        dapatienttype.Fill(dspatienttype, "PatientType")
        With cbpatienttype
            .DataSource = dspatienttype.Tables("PatientType")
            .DisplayMember = "description"
            .ValueMember = "code"
        End With
        cbpatienttype.DataBindings.Clear()

        daphilhealthtype.Fill(dsphilhealthtype, "PhilHealthType")
        With cbphilhealthtype
            .DataSource = dsphilhealthtype.Tables("PhilHealthType")
            .DisplayMember = "description"
            .ValueMember = "code"
        End With
        cbphilhealthtype.DataBindings.Clear()

        cbpatientclassification.Enabled = True
        cbpatientclassification.SelectedIndex = -1
        txthrn.ReadOnly = False
        txthrn.Text = ""
        txtroomno.ReadOnly = False
        txtroomno.Text = ""
        dtpadmissiondate.Checked = False
        dtpadmissiondate.Text = ""
        cbpatienttype.Enabled = True
        cbpatienttype.SelectedIndex = -1
        txtsourceofreferral.ReadOnly = False
        txtsourceofreferral.Text = ""
        dtpdateofinterview.Checked = False
        dtpdateofinterview.Text = ""
        cbphilhealthtype.Enabled = True
        cbphilhealthtype.SelectedIndex = -1
        cbclassification.Enabled = True
        cbclassification.SelectedIndex = -1
        txtheight.ReadOnly = False
        txtheight.Text = ""
        txtweight.ReadOnly = False
        txtweight.Text = ""
        txtlname.ReadOnly = False
        txtlname.Text = ""
        txtfname.ReadOnly = False
        txtfname.Text = ""
        txtmname.ReadOnly = False
        txtmname.Text = ""
        txtage.ReadOnly = True
        txtage.Text = ""
        cbgender.Enabled = True
        cbgender.SelectedIndex = -1
        txtcityaddress.ReadOnly = False
        txtcityaddress.Text = ""
        txtprovincialaddress.ReadOnly = False
        txtprovincialaddress.Text = ""
        dtpbday.Checked = False
        dtpbday.Text = ""
        txtbirthplace.ReadOnly = False
        txtbirthplace.Text = ""
        txtreligion.ReadOnly = False
        txtreligion.Text = ""
        cbcivilstatus.Enabled = True
        cbcivilstatus.SelectedIndex = -1
        cbeducation.Enabled = True
        cbeducation.SelectedIndex = -1
        txtoccupation.ReadOnly = False
        txtoccupation.Text = ""

        btnadd.Enabled = False
        btnsave.Enabled = True
        btnedit.Enabled = False
        btnsearch.Enabled = False
        btncancel.Enabled = True
        btnfamilycomposition.Enabled = False
        btnfamilyexpenses.Enabled = False
        btnpsychosocial.Enabled = False
        btndocumentation.Enabled = False
        'toolsmenu.Enabled = False
        Mquery = 1
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        cbpatientclassification.Enabled = True
        cbpatientclassification.Focus()
        txthrn.ReadOnly = False
        txtroomno.ReadOnly = False
        dtpadmissiondate.Enabled = True
        cbpatienttype.Enabled = True
        txtsourceofreferral.ReadOnly = False
        dtpdateofinterview.Enabled = True
        cbphilhealthtype.Enabled = True
        cbclassification.Enabled = True
        txtheight.ReadOnly = False
        txtweight.ReadOnly = False
        txtlname.ReadOnly = False
        txtfname.ReadOnly = False
        txtmname.ReadOnly = False
        txtage.ReadOnly = True
        cbgender.Enabled = True
        txtcityaddress.ReadOnly = False
        txtprovincialaddress.ReadOnly = False
        dtpbday.Checked = False
        txtbirthplace.ReadOnly = False
        txtreligion.ReadOnly = False
        cbcivilstatus.Enabled = True
        cbeducation.Enabled = True
        txtoccupation.ReadOnly = False

        btnedit.Enabled = False
        btnsave.Enabled = True
        btnsearch.Enabled = False
        btnadd.Enabled = False
        btncancel.Enabled = True

        btnfamilycomposition.Enabled = True
        btnfamilyexpenses.Enabled = True
        btnpsychosocial.Enabled = True
        btndocumentation.Enabled = True

        'toolsmenu.Enabled = False
        Mquery = 2
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        If Mquery = "1" Then
            Label25.Text = ""
            cbpatientclassification.Enabled = False
            cbpatientclassification.SelectedIndex = -1
            cbpatientclassification.Focus()
            txthrn.ReadOnly = True
            txthrn.Text = ""
            txtroomno.ReadOnly = True
            txtroomno.Text = ""
            dtpadmissiondate.Checked = False
            dtpadmissiondate.Text = ""
            cbpatienttype.Enabled = False
            cbpatienttype.SelectedIndex = -1
            txtsourceofreferral.ReadOnly = True
            txtsourceofreferral.Text = ""
            dtpdateofinterview.Checked = False
            dtpdateofinterview.Text = ""
            cbphilhealthtype.Enabled = False
            cbphilhealthtype.SelectedIndex = -1
            cbclassification.Enabled = False
            cbclassification.SelectedIndex = -1
            txtheight.ReadOnly = True
            txtheight.Text = ""
            txtweight.ReadOnly = True
            txtweight.Text = ""
            txtlname.ReadOnly = True
            txtlname.Text = ""
            txtfname.ReadOnly = True
            txtfname.Text = ""
            txtmname.ReadOnly = True
            txtmname.Text = ""
            txtage.ReadOnly = True
            txtage.Text = ""
            cbgender.Enabled = False
            cbgender.SelectedIndex = -1
            txtcityaddress.ReadOnly = True
            txtcityaddress.Text = ""
            txtprovincialaddress.ReadOnly = True
            txtprovincialaddress.Text = ""
            dtpbday.Checked = False
            dtpbday.Text = ""
            txtbirthplace.ReadOnly = True
            txtbirthplace.Text = ""
            txtreligion.ReadOnly = True
            txtreligion.Text = ""
            cbcivilstatus.Enabled = False
            cbcivilstatus.SelectedIndex = -1
            cbeducation.Enabled = False
            cbeducation.SelectedIndex = -1
            txtoccupation.ReadOnly = True
            txtoccupation.Text = ""

            btnsave.Enabled = False
            btnedit.Enabled = True
            btnsearch.Enabled = True
            btnadd.Enabled = True
            btncancel.Enabled = False
        Else
            cbpatientclassification.Enabled = False
            cbpatientclassification.Focus()
            txthrn.ReadOnly = True
            txtroomno.ReadOnly = True
            dtpadmissiondate.Checked = True
            dtpadmissiondate.Enabled = False
            cbpatienttype.Enabled = False
            txtsourceofreferral.ReadOnly = True
            dtpdateofinterview.Checked = False
            cbphilhealthtype.Enabled = False
            cbclassification.Enabled = False
            txtheight.ReadOnly = True
            txtweight.ReadOnly = True
            txtlname.ReadOnly = True
            txtfname.ReadOnly = True
            txtmname.ReadOnly = True
            txtage.ReadOnly = True
            cbgender.Enabled = False
            txtcityaddress.ReadOnly = True
            txtprovincialaddress.ReadOnly = True
            dtpbday.Checked = False
            txtbirthplace.ReadOnly = True
            txtreligion.ReadOnly = True
            cbcivilstatus.Enabled = False
            cbeducation.Enabled = False
            txtoccupation.ReadOnly = True

            btnsave.Enabled = False
            btnedit.Enabled = True
            btnsearch.Enabled = True
            btnadd.Enabled = True
            btncancel.Enabled = False
        End If
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Dim frm As New search
        frm.Show()
    End Sub

    Private Sub dtpbday_TextChanged(sender As Object, e As EventArgs) Handles dtpbday.TextChanged
        txtage.Text = DateDiff(DateInterval.Year, CDate(dtpbday.Text.Trim), Now.Date)
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        Dim frm As New login
        frm.Show()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If Mquery = 1 Then
            If cbpatientclassification.Text = "" Then
                MsgBox("Patient Classification is a required field!")
            ElseIf dtpadmissiondate.Checked = False Then
                MsgBox("Admission Date is a required field!")
            ElseIf cbpatienttype.Text = "" Then
                MsgBox("Patient Type is a required field!")
            ElseIf txtsourceofreferral.Text = "" Then
                MsgBox("Source of Referral is a required field!")
            ElseIf dtpdateofinterview.Text = "" Then
                MsgBox("Date of Interview is a required field!")
            ElseIf cbclassification.Text = "" Then
                MsgBox("Classification is a required field!")
            ElseIf txtlname.Text = "" Then
                MsgBox("Last Name is a required field!")
            ElseIf txtfname.Text = "" Then
                MsgBox("First Name is a required field!")
            ElseIf txtmname.Text = "" Then
                MsgBox("Middle Name is a required field!")
            ElseIf cbgender.Text = "" Then
                MsgBox("Gender is a required field!")
            ElseIf txtcityaddress.Text = "" Then
                MsgBox("City Address is a required field!")
            ElseIf dtpbday.Checked = False Then
                MsgBox("Birthday is a required field!")
            ElseIf cbcivilstatus.Text = "" Then
                MsgBox("Civil Status is a required field!")
            ElseIf cbeducation.Text = "" Then
                MsgBox("Education is a required field!")
            ElseIf txtoccupation.Text = "" Then
                MsgBox("Occupation is a required field!")
            Else
                Dim com As New SqlCommand("Insert Into PatientInfo (docno, patientclassification, hrn, roomno, admissiondate, patienttype, sourceofreferral, dateofinterview, philhealthtype, " _
                                          & "classification, height, weight, psurname, pfname, pmname, age, gender, cityaddress, provincialaddress, birthday, birthplace, religion, civilstatus, education, " _
                                          & "occupation, logdatetime, loguser) " _
                                          & "Values " _
                                          & "(@docno, @patientclassification, @hrn, @roomno, @admissiondate, @patienttype, @sourceofreferral, @dateofinterview, @philhealthtype, @classification, " _
                                          & "@height, @weight, @psurname, @pfname, @pmname, @age, @gender, @cityaddress, @provincialaddress, @birthday, @birthplace, @religion, @civilstatus, @education, " _
                                          & "@occupation, @logdatetime, @loguser) " _
                                          & "insert into OthersFC (idfk) values (@idfk) " _
                                          & "insert into FamilyExpenses (idfk) values (@idfk) " _
                                          & "insert into Psychosocial (idfk) values (@idfk)", con)
                con.Close()
                com.Parameters.AddWithValue("docno", Label25.Text)

                'patient classification
                Dim varpatientclassification As String
                varpatientclassification = ""
                Dim sqlpatientclassification As String = "Select code From PatientClassification where description = '" & cbpatientclassification.Text & "'"
                Dim compatientclassification As New SqlCommand(sqlpatientclassification, con)
                con.Open()
                Dim drpatientclassification As SqlDataReader
                drpatientclassification = compatientclassification.ExecuteReader
                If drpatientclassification.HasRows Then
                    While drpatientclassification.Read
                        varpatientclassification = drpatientclassification.Item("code")
                    End While
                    drpatientclassification.Close()
                End If
                con.Close()
                com.Parameters.AddWithValue("patientclassification", varpatientclassification)

                com.Parameters.AddWithValue("hrn", txthrn.Text.ToUpper)
                com.Parameters.AddWithValue("roomno", txtroomno.Text.ToUpper)

                If dtpadmissiondate.Checked = False Then
                    com.Parameters.AddWithValue("admissiondate", "NULL")
                Else
                    com.Parameters.AddWithValue("admissiondate", dtpadmissiondate.Text)
                End If

                'patient type
                Dim varpatienttype As String
                varpatienttype = ""
                Dim sqlpatienttype As String = "Select code From PatientType where description = '" & cbpatienttype.Text & "'"
                Dim compatienttype As New SqlCommand(sqlpatienttype, con)
                con.Open()
                Dim drpatienttype As SqlDataReader
                drpatienttype = compatienttype.ExecuteReader
                If drpatienttype.HasRows Then
                    While drpatienttype.Read
                        varpatienttype = drpatienttype.Item("code")
                    End While
                    drpatienttype.Close()
                End If
                con.Close()
                com.Parameters.AddWithValue("patienttype", varpatienttype)

                com.Parameters.AddWithValue("sourceofreferral", txtsourceofreferral.Text.ToUpper)

                If dtpdateofinterview.Checked = False Then
                    com.Parameters.AddWithValue("dateofinterview", "NULL")
                Else
                    com.Parameters.AddWithValue("dateofinterview", dtpdateofinterview.Text)
                End If

                'philhealth type
                Dim varphilhealthtype As String
                varphilhealthtype = ""
                Dim sqlphilhealthtype As String = "Select code From PhilHealthType where description = '" & cbphilhealthtype.Text & "'"
                Dim comphilhealthtype As New SqlCommand(sqlphilhealthtype, con)
                con.Open()
                Dim drphilhealthtype As SqlDataReader
                drphilhealthtype = comphilhealthtype.ExecuteReader
                If drphilhealthtype.HasRows Then
                    While drphilhealthtype.Read
                        varphilhealthtype = drphilhealthtype.Item("code")
                    End While
                    drphilhealthtype.Close()
                End If
                con.Close()
                com.Parameters.AddWithValue("philhealthtype", varphilhealthtype)

                'classification
                Dim varclassification As String
                varclassification = ""
                Dim sqlclassification As String = "Select code From Classification where description = '" & cbclassification.Text & "'"
                Dim comclassification As New SqlCommand(sqlclassification, con)
                con.Open()
                Dim drclassification As SqlDataReader
                drclassification = comclassification.ExecuteReader
                If drclassification.HasRows Then
                    While drclassification.Read
                        varclassification = drclassification.Item("code")
                    End While
                    drclassification.Close()
                End If
                con.Close()
                com.Parameters.AddWithValue("classification", varclassification)

                com.Parameters.AddWithValue("height", txtheight.Text)
                com.Parameters.AddWithValue("weight", txtweight.Text)
                com.Parameters.AddWithValue("psurname", txtlname.Text.ToUpper)
                com.Parameters.AddWithValue("pfname", txtfname.Text.ToUpper)
                com.Parameters.AddWithValue("pmname", txtmname.Text.ToUpper)
                com.Parameters.AddWithValue("age", txtage.Text)

                'gender
                Dim vargender As String
                vargender = ""
                Dim sqlgender As String = "Select code From Gender where description = '" & cbgender.Text & "'"
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
                com.Parameters.AddWithValue("gender", vargender)
                com.Parameters.AddWithValue("cityaddress", txtcityaddress.Text.ToUpper)
                com.Parameters.AddWithValue("provincialaddress", txtprovincialaddress.Text.ToUpper)

                If dtpbday.Checked = False Then
                    com.Parameters.AddWithValue("birthday", "NULL")
                Else
                    com.Parameters.AddWithValue("birthday", dtpbday.Text)
                End If

                com.Parameters.AddWithValue("birthplace", txtbirthplace.Text.ToUpper)
                com.Parameters.AddWithValue("religion", txtreligion.Text.ToUpper)

                'civil status
                Dim varcivilstatus As String
                varcivilstatus = ""
                Dim sqlcivilstatus As String = "Select code From CivilStatus where description = '" & cbcivilstatus.Text & "'"
                Dim comcivilstatus As New SqlCommand(sqlcivilstatus, con)
                con.Open()
                Dim drcivilstatus As SqlDataReader
                drcivilstatus = comcivilstatus.ExecuteReader
                If drcivilstatus.HasRows Then
                    While drcivilstatus.Read
                        varcivilstatus = drcivilstatus.Item("code")
                    End While
                    drcivilstatus.Close()
                End If
                con.Close()
                com.Parameters.AddWithValue("civilstatus", varcivilstatus)

                'education
                Dim vareducation As String
                vareducation = ""
                Dim sqleducation As String = "Select code From Education where description = '" & cbeducation.Text & "'"
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
                com.Parameters.AddWithValue("education", vareducation)
                com.Parameters.AddWithValue("occupation", txtoccupation.Text.ToUpper)
                com.Parameters.AddWithValue("logdatetime", DateTime.Now.ToString)
                com.Parameters.AddWithValue("loguser", lbluser.Text)
                'com.Parameters.AddWithValue("lastid", varlastid)
                com.Parameters.AddWithValue("idfk", Label25.Text)

                con.Open()
                com.ExecuteNonQuery()
                con.Close()

                Mquery = Nothing

                cbpatientclassification.Enabled = False
                cbpatientclassification.Focus()
                txthrn.ReadOnly = True
                txtroomno.ReadOnly = True
                dtpadmissiondate.Checked = True
                dtpadmissiondate.Enabled = False
                cbpatienttype.Enabled = False
                txtsourceofreferral.ReadOnly = True
                dtpdateofinterview.Checked = False
                cbphilhealthtype.Enabled = False
                cbclassification.Enabled = False
                txtheight.ReadOnly = True
                txtweight.ReadOnly = True
                txtlname.ReadOnly = True
                txtfname.ReadOnly = True
                txtmname.ReadOnly = True
                txtage.ReadOnly = True
                cbgender.Enabled = False
                txtcityaddress.ReadOnly = True
                txtprovincialaddress.ReadOnly = True
                dtpbday.Checked = False
                txtbirthplace.ReadOnly = True
                txtreligion.ReadOnly = True
                cbcivilstatus.Enabled = False
                cbeducation.Enabled = False
                txtoccupation.ReadOnly = True

                'cbpatientclassification.DataSource = Nothing
                'cbpatientclassification.Items.Clear()
                'cbpatienttype.DataSource = Nothing
                'cbpatienttype.Items.Clear()
                'cbphilhealthtype.DataSource = Nothing
                'cbphilhealthtype.Items.Clear()
                'cbclassification.DataSource = Nothing
                'cbclassification.Items.Clear()
                'cbgender.DataSource = Nothing
                'cbgender.Items.Clear()
                'cbcivilstatus.DataSource = Nothing
                'cbcivilstatus.Items.Clear()
                'cbeducation.DataSource = Nothing
                'cbeducation.Items.Clear()

                btnadd.Enabled = True
                btnsave.Enabled = False
                btnedit.Enabled = False
                btnsearch.Enabled = True
                btncancel.Enabled = False
                'toolsmenu.Enabled = True

                btnfamilycomposition.Enabled = True
                btnfamilyexpenses.Enabled = True
                btnpsychosocial.Enabled = True
                btndocumentation.Enabled = True
                LoadData()
            End If

        ElseIf Mquery = 2 Then

            Dim com As New SqlCommand("Update PatientInfo " _
                                      & "Set " _
                                      & "patientclassification=@patientclassification, " _
                                      & "hrn=@hrn, " _
                                      & "roomno=@roomno, " _
                                      & "admissiondate=@admissiondate, " _
                                      & "patienttype=@patienttype, " _
                                      & "sourceofreferral=@sourceofreferral, " _
                                      & "dateofinterview=@dateofinterview, " _
                                      & "philhealthtype=@philhealthtype, " _
                                      & "classification=@classification, " _
                                      & "psurname=@psurname, " _
                                      & "pfname=@pfname, " _
                                      & "pmname=@pmname, " _
                                      & "age=@age, " _
                                      & "gender=@gender, " _
                                      & "cityaddress=@cityaddress, " _
                                      & "provincialaddress=@provincialaddress, " _
                                      & "birthday=@birthday, " _
                                      & "birthplace=@birthplace, " _
                                      & "religion=@religion, " _
                                      & "civilstatus=@civilstatus, " _
                                      & "education=@education, " _
                                      & "occupation=@occupation, " _
                                      & "logdatetime=@logdatetime, " _
                                      & "loguser=@loguser " _
                                      & "WHERE docno = '" & Label25.Text & "'", con)

            'patient classification
            Dim varpatientclassification As String
            varpatientclassification = ""
            Dim sqlpatientclassification As String = "Select code From PatientClassification where description = '" & cbpatientclassification.Text & "'"
            Dim compatientclassification As New SqlCommand(sqlpatientclassification, con)
            con.Close()
            con.Open()
            Dim drpatientclassification As SqlDataReader
            drpatientclassification = compatientclassification.ExecuteReader
            If drpatientclassification.HasRows Then
                While drpatientclassification.Read
                    varpatientclassification = drpatientclassification.Item("code")
                End While
                drpatientclassification.Close()
            End If
            con.Close()
            com.Parameters.AddWithValue("patientclassification", varpatientclassification)

            com.Parameters.AddWithValue("hrn", txthrn.Text)

            com.Parameters.AddWithValue("roomno", txtroomno.Text)

            If dtpadmissiondate.Checked = False Then
                com.Parameters.AddWithValue("admissiondate", "NULL")
            Else
                com.Parameters.AddWithValue("admissiondate", dtpadmissiondate.Text)
            End If

            'patient type
            Dim varpatienttype As String
            varpatienttype = ""
            Dim sqlpatienttype As String = "Select code From PatientType where description = '" & cbpatienttype.Text & "'"
            Dim compatienttype As New SqlCommand(sqlpatienttype, con)
            con.Open()
            Dim drpatienttype As SqlDataReader
            drpatienttype = compatienttype.ExecuteReader
            If drpatienttype.HasRows Then
                While drpatienttype.Read
                    varpatienttype = drpatienttype.Item("code")
                End While
                drpatienttype.Close()
            End If
            con.Close()
            com.Parameters.AddWithValue("patienttype", varpatienttype)

            com.Parameters.AddWithValue("sourceofreferral", txtsourceofreferral.Text.ToUpper)

            If dtpdateofinterview.Checked = False Then
                com.Parameters.AddWithValue("dateofinterview", "NULL")
            Else
                com.Parameters.AddWithValue("dateofinterview", dtpdateofinterview.Text)
            End If

            'philhealth type
            Dim varphilhealthtype As String
            varphilhealthtype = ""
            Dim sqlphilhealthtype As String = "Select code From PhilHealthType where description = '" & cbphilhealthtype.Text & "'"
            Dim comphilhealthtype As New SqlCommand(sqlphilhealthtype, con)
            con.Open()
            Dim drphilhealthtype As SqlDataReader
            drphilhealthtype = comphilhealthtype.ExecuteReader
            If drphilhealthtype.HasRows Then
                While drphilhealthtype.Read
                    varphilhealthtype = drphilhealthtype.Item("code")
                End While
                drphilhealthtype.Close()
            End If
            con.Close()
            com.Parameters.AddWithValue("philhealthtype", varphilhealthtype)

            'classification
            Dim varclassification As String
            varclassification = ""
            Dim sqlclassification As String = "Select code From Classification where description = '" & cbclassification.Text & "'"
            Dim comclassification As New SqlCommand(sqlclassification, con)
            con.Open()
            Dim drclassification As SqlDataReader
            drclassification = comclassification.ExecuteReader
            If drclassification.HasRows Then
                While drclassification.Read
                    varclassification = drclassification.Item("code")
                End While
                drclassification.Close()
            End If
            con.Close()
            com.Parameters.AddWithValue("classification", varclassification)

            com.Parameters.AddWithValue("height", txtheight.Text)
            com.Parameters.AddWithValue("weight", txtweight.Text)
            com.Parameters.AddWithValue("psurname", txtweight.Text)
            com.Parameters.AddWithValue("psurname", txtlname.Text.ToUpper)
            com.Parameters.AddWithValue("pfname", txtfname.Text.ToUpper)
            com.Parameters.AddWithValue("pmname", txtmname.Text.ToUpper)
            com.Parameters.AddWithValue("age", txtage.Text)

            'gender
            Dim vargender As String
            vargender = ""
            Dim sqlgender As String = "Select code From Gender where description = '" & cbgender.Text & "'"
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
            com.Parameters.AddWithValue("gender", vargender)

            com.Parameters.AddWithValue("cityaddress", txtcityaddress.Text.ToUpper)
            com.Parameters.AddWithValue("provincialaddress", txtprovincialaddress.Text.ToUpper)

            If dtpbday.Checked = False Then
                com.Parameters.AddWithValue("birthday", "NULL")
            Else
                com.Parameters.AddWithValue("birthday", dtpbday.Text)
            End If

            com.Parameters.AddWithValue("birthplace", txtbirthplace.Text.ToUpper)

            com.Parameters.AddWithValue("religion", txtreligion.Text.ToUpper)

            'civil status
            Dim varcivilstatus As String
            varcivilstatus = ""
            Dim sqlcivilstatus As String = "Select code From CivilStatus where description = '" & cbcivilstatus.Text & "'"
            Dim comcivilstatus As New SqlCommand(sqlcivilstatus, con)
            con.Open()
            Dim drcivilstatus As SqlDataReader
            drcivilstatus = comcivilstatus.ExecuteReader
            If drcivilstatus.HasRows Then
                While drcivilstatus.Read
                    varcivilstatus = drcivilstatus.Item("code")
                End While
                drcivilstatus.Close()
            End If
            con.Close()
            com.Parameters.AddWithValue("civilstatus", varcivilstatus)

            'education
            Dim vareducation As String
            vareducation = ""
            Dim sqleducation As String = "Select code From Education where description = '" & cbeducation.Text & "'"
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
            com.Parameters.AddWithValue("education", vareducation)
            com.Parameters.AddWithValue("occupation", txtoccupation.Text.ToUpper)
            com.Parameters.AddWithValue("logdatetime", DateTime.Now.ToString)
            com.Parameters.AddWithValue("loguser", lbluser.Text)

            con.Open()
            com.ExecuteNonQuery()
            con.Close()

            Mquery = Nothing

            cbpatientclassification.Enabled = False
            cbpatientclassification.Focus()
            txthrn.ReadOnly = True
            txtroomno.ReadOnly = True
            dtpadmissiondate.Checked = True
            dtpadmissiondate.Enabled = False
            cbpatienttype.Enabled = False
            txtsourceofreferral.ReadOnly = True
            dtpdateofinterview.Checked = False
            cbphilhealthtype.Enabled = False
            cbclassification.Enabled = False
            txtheight.ReadOnly = True
            txtweight.ReadOnly = True
            txtlname.ReadOnly = True
            txtfname.ReadOnly = True
            txtmname.ReadOnly = True
            txtage.ReadOnly = True
            cbgender.Enabled = False
            txtcityaddress.ReadOnly = True
            txtprovincialaddress.ReadOnly = True
            dtpbday.Checked = False
            txtbirthplace.ReadOnly = True
            txtreligion.ReadOnly = True
            cbcivilstatus.Enabled = False
            cbeducation.Enabled = False
            txtoccupation.ReadOnly = True

            'cbpatientclassification.DataSource = Nothing
            'cbpatientclassification.Items.Clear()

            'cbpatienttype.DataSource = Nothing
            'cbpatienttype.Items.Clear()

            'cbphilhealthtype.DataSource = Nothing
            'cbphilhealthtype.Items.Clear()

            'cbclassification.DataSource = Nothing
            'cbclassification.Items.Clear()

            'cbgender.DataSource = Nothing
            'cbgender.Items.Clear()

            'cbcivilstatus.DataSource = Nothing
            'cbcivilstatus.Items.Clear()

            'cbeducation.DataSource = Nothing
            'cbeducation.Items.Clear()

            btnedit.Enabled = True
            btnadd.Enabled = True
            btnsave.Enabled = False
            btncancel.Enabled = False
            btnsearch.Enabled = True

            btnfamilycomposition.Enabled = True
            btnfamilyexpenses.Enabled = True
            btnpsychosocial.Enabled = True
            btndocumentation.Enabled = True

            'toolsmenu.Enabled = True
            LoadData()
        End If
        Mquery = 1

    End Sub

    Private Sub SearchF5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchF5ToolStripMenuItem.Click
        Dim frm As New search
        frm.Show()
    End Sub

    Private Sub btnfamilycomposition_Click(sender As Object, e As EventArgs) Handles btnfamilycomposition.Click
        aydee = Label25.Text
        Dim frm As New familycomposition
        frm.Show()
    End Sub

    Private Sub btnfamilyexpenses_Click(sender As Object, e As EventArgs) Handles btnfamilyexpenses.Click
        aydee = Label25.Text
        Dim frm As New familyexpenses
        frm.Show()
    End Sub

    Private Sub btnpsychosocial_Click(sender As Object, e As EventArgs) Handles btnpsychosocial.Click
        aydee = Label25.Text
        Dim frm As New psychosocial
        frm.Show()
    End Sub

    Private Sub btndocumentation_Click(sender As Object, e As EventArgs) Handles btndocumentation.Click
        aydee = Label25.Text
        Dim frm As New documentation
        frm.Show()
    End Sub
End Class
