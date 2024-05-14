Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Xml
Imports System.DBNull
Imports System.Security

Public Class login

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Function DoCheckuser(ByVal username As String, ByVal password As String) As Boolean

        Dim success As Boolean = False

        Dim com As SqlCommand = New SqlCommand("Select id from Users where username=@username And password=@password", con)

        Dim usernameparam As New SqlParameter("@username", username)
        Dim passwordparam As New SqlParameter("@password", password)

        com.Parameters.Add(usernameparam)
        com.Parameters.Add(passwordparam)

        com.Connection.Close()
        com.Connection.Open()

        Dim myreader As SqlDataReader = com.ExecuteReader(CommandBehavior.CloseConnection)

        If myreader.HasRows Then
            success = True
        End If

        com.Connection.Close()

        Return success

    End Function

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        If Me.DoCheckuser(Me.txtusername.Text, Me.txtpassword.Text) = True Then
            Dim str As String = "Select role from Users where username='" & txtusername.Text & "'"
            Dim com As New SqlCommand(str, con)
            Dim varrole As String
            varrole = ""
            con.Open()
            Dim dr As SqlDataReader
            dr = com.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    varrole = dr.Item("role")
                End While
                dr.Close()
            End If
            If varrole = "1" Then
                user = txtusername.Text
                Dim frm As New Form1
                frm.Show()
                Me.Hide()
                con.Close()
            Else
                MessageBox.Show("User is not allowed to login to this system!")
                con.Close()
            End If
        Else
            MessageBox.Show("Username/Password is invalid !")
        End If
        con.Close()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub txtpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnok.PerformClick()
        End If
    End Sub
End Class