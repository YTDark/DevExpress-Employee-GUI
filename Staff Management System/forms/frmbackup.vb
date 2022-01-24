Imports System.Data.OleDb
Imports System.Data
Imports System.Globalization
Imports System.IO
Public Class frmbackup
    Dim con As New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=" & Application.StartupPath & "\EMP.mdb;user id=admin;jet oledb:database password=343282")
    Public con2 As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\EMP.mdb;Jet OLEDB:Database Password=343282")
    Dim op As New OpenFileDialog
    Dim opf As New FolderBrowserDialog
    Dim sql As String
    Dim da As New OleDbDataAdapter
    Dim cmd As OleDbCommand
    Dim re As OleDbDataReader
    Dim data As String = "EMP.mdb"
    Dim BJAC As String = "backup"
    Private Sub frmbackup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True

    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        Try

            If (String.IsNullOrEmpty(T2.Text)) Then
                MessageBox.Show("يجب اختيار مسار قاعدة البيانات اولا قبل الاستعادة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If File.Exists(data) Then
                File.Delete(data)
            End If
            File.Copy(T2.Text, data)
            MessageBox.Show("تم إستعادة النسخة الاحتياطية  بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information)
            T2.Text = ""
            Application.Restart()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Try
            If (String.IsNullOrEmpty(txtdbpath.Text)) Then
                MessageBox.Show("يجب اختيار مكان حفظ قاعدة البيانات اولا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            txtdbpath.Text = opf.SelectedPath
            File.Copy("EMP.mdb", txtdbpath.Text & "\EMP.mdb")
            MessageBox.Show("تم حفظ النسخة الاحتياطية  بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GunaButton10_Click(sender As Object, e As EventArgs) Handles GunaButton10.Click
        If opf.ShowDialog = DialogResult.OK Then
            txtdbpath.Text = opf.SelectedPath
        End If
    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        If op.ShowDialog = DialogResult.OK Then
            T2.Text = op.FileName
        End If
    End Sub
End Class