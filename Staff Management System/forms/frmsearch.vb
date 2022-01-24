Imports System.Data.OleDb
Imports System.Data
Imports System.Globalization
Public Class frmsearch
    Dim con As New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=" & Application.StartupPath & "\EMP.mdb;user id=admin;jet oledb:database password=343282")

    Private Sub frmsearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EMPDataSet.DBET' table. You can move, or remove it, as needed.
        Me.DBETTableAdapter.Fill(Me.EMPDataSet.DBET)
        Me.TopMost = True
    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        If (String.IsNullOrEmpty(srch.Text)) Then
            MessageBox.Show("يجب ادخال اسم الموظف المراد البحث عنه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If Namesearch.Checked = True Then
            Dim da As New OleDbDataAdapter("select * from DBET WHERE ename LIKE '%" & srch.Text & "%' ", con)
            Dim dt As New DataTable()
            da.Fill(dt)
            DataGridView1.DataSource = dt

        End If

        If (String.IsNullOrEmpty(srch.Text)) Then
            MessageBox.Show("يجب ادخال رقم الموظف المراد البحث عنه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If IDsearch.Checked = True Then
            Dim da As New OleDbDataAdapter("select * from DBET WHERE eid LIKE " & Val(srch.Text) & " ", con)
            Dim dt As New DataTable()
            da.Fill(dt)
            DataGridView1.DataSource = dt
        End If
        DataGridView1.Show()
        DataGridView2.Hide()
        DataGridView3.Hide()
        DataGridView4.Hide()
    End Sub

    Private Sub GunaAdvenceButton6_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton6.Click
        DataGridView1.Show()
        DataGridView2.Hide()
        DataGridView3.Hide()
        DataGridView4.Hide()
        Dim da As New OleDbDataAdapter("select * from DBET", con)
        Dim dt As New DataTable()
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub GunaAdvenceButton7_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton7.Click
        DataGridView1.Hide()
        DataGridView2.Show()
        DataGridView3.Hide()
        DataGridView4.Hide()
        Dim da As New OleDbDataAdapter("select * from DBET", con)
        Dim dt As New DataTable()
        da.Fill(dt)
        DataGridView2.DataSource = dt
    End Sub

    Private Sub GunaAdvenceButton8_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton8.Click
        DataGridView1.Hide()
        DataGridView2.Hide()
        DataGridView3.Show()
        DataGridView4.Hide()
        Dim da As New OleDbDataAdapter("select * from DBET", con)
        Dim dt As New DataTable()
        da.Fill(dt)
        DataGridView3.DataSource = dt
    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        DataGridView1.Hide()
        DataGridView2.Hide()
        DataGridView3.Hide()
        DataGridView4.Show()
        Dim da As New OleDbDataAdapter("select * from DBET", con)
        Dim dt As New DataTable()
        da.Fill(dt)
        DataGridView4.DataSource = dt
    End Sub
End Class