Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Module Module1
    Public loginid As String
    Public aydee As String
    Public user As String
    Public mAccession As String
    Public mItem As String
    Public con As New SqlConnection("Data Source=10.0.0.10;Initial Catalog=mssdb;User ID=sa;Password=q1w2e3X")
    Public Mschool As Integer
    Public Mcourse As Integer
    Public Myear As Integer
    Public Msearch As Integer
    Public Mquery As String

    Public varselect As String
    Public varCourse As String
    Public varYear As String

    Public showmain As Boolean
    Public showsub As Boolean

    Public showbutton As Boolean

End Module
