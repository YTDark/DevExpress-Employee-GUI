Imports System.Data.OleDb
Imports System.IO

Module Module1
    Dim str As String = ("provider=microsoft.jet.oledb.4.0;data source=" & Application.StartupPath & "\EMP.mdb;user id=admin;jet oledb:database password=343282")
    'تحديد الصلاحيات
    Public con As New OleDbConnection(str)
    Public Powers1 As Boolean = False
    Public Powers2 As Boolean = False
    Public Powers3 As Boolean = False
    Public Powers4 As Boolean = False

End Module