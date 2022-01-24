Imports System.Data.OleDb
Imports System.Data
Imports System.Globalization
Public Class frmsalary
    Dim con As New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=" & Application.StartupPath & "\EMP.mdb;user id=admin;jet oledb:database password=343282")
    Dim DataSetMaterials As New DataSet
    Dim SQLMaterials As String = "Select * from DBET"
    Dim DataSNF As New DataSet
    Dim DataSet1 As New DataSet
    Dim SQLstr As String
    Sub LoadDataToDGV()
        Dim da As New OleDbDataAdapter("select * from DBET", con)
        Dim dt As New DataTable()
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
    Private Sub frmsalary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EMPDataSet.DBET' table. You can move, or remove it, as needed.
        Me.DBETTableAdapter.Fill(Me.EMPDataSet.DBET)
        Me.TopMost = True
    End Sub

    Private Sub GunaButton10_Click(sender As Object, e As EventArgs) Handles GunaButton10.Click
        If (DataGridView1.SelectedRows.Count = 0) Then
            MessageBox.Show("يجب تحديد البيانات المراد تعديلها اولا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'كود جلب البيانات
        Dim indx As Integer = DataGridView1.SelectedRows(0).Index
        salary.Text = DataGridView1(13, indx).Value.ToString()
    End Sub

    Private Sub GunaButton8_Click(sender As Object, e As EventArgs) Handles GunaButton8.Click
      
        Dim id As Integer = CInt(DataGridView1(0, DataGridView1.SelectedRows(0).Index).Value.ToString())
        Dim cmd As New OleDbCommand("update DBET set  Salary=@Salary  where ID =@ID", con)
        cmd.Parameters.AddWithValue("@Salary", salary.Text)
        cmd.Parameters.AddWithValue("@ID", id)

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("تمت عملية الاضافة والحفظ في قاعدة البيانات بنجاح", 64, "حفظ الاضافة")

        LoadDataToDGV()

        salary.Text = ""
        
    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        If (String.IsNullOrEmpty(Search.Text)) Then
            MessageBox.Show("يجب ادخال اسم الموظف المراد البحث عنه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim da As New OleDbDataAdapter("select * from DBET WHERE ename LIKE '%" & Search.Text & "%' ", con)
            Dim dt As New DataTable()
            da.Fill(dt)
            DataGridView1.DataSource = dt
        End If
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        If (String.IsNullOrEmpty(Search.Text)) Then
            MessageBox.Show("يجب ادخال رقم الموظف المراد البحث عنه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim da As New OleDbDataAdapter("select * from DBET WHERE eid LIKE " & Val(Search.Text) & " ", con)
            Dim dt As New DataTable()
            da.Fill(dt)
            DataGridView1.DataSource = dt
        End If
    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        LoadDataToDGV()
    End Sub
End Class