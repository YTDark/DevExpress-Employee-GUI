Imports System.Data.OleDb
Imports System.Data
Imports System.Globalization
Imports System.IO
Imports System.Drawing.Image
Public Class frmedit
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
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub frmedit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EMPDataSet.DBET' table. You can move, or remove it, as needed.
        Me.DBETTableAdapter.Fill(Me.EMPDataSet.DBET)
        'TODO: This line of code loads data into the 'EMPDataSet.DBET' table. You can move, or remove it, as needed.
        Me.DBETTableAdapter.Fill(Me.EMPDataSet.DBET)
        Me.TopMost = True

    End Sub

    Private Sub GunaButton7_Click(sender As Object, e As EventArgs) Handles GunaButton7.Click
        If MsgBox("هل انت متاكد من حذف جميع الموظفين?", 48 + MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
            Exit Sub
        End If
        Try
            Dim Savecommand As New OleDb.OleDbCommand
            Dim dt As New DataSet
            Dim DataAdapter1 As New OleDbDataAdapter(SQLMaterials, con)
            Savecommand.Connection = con
            Savecommand.CommandType = CommandType.Text
            Savecommand.CommandText = "DELETE  * FROM DBET "
            con.Open()
            Savecommand.ExecuteNonQuery()
            con.Close()
            dt.Clear()
            DataAdapter1.Fill(dt, "DBET")
            MsgBox("تم حذف جميع الموظفين بنجاح", 64, "All Deleted")
            LoadDataToDGV()
            Me.DataGridView1.DataSource = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        ofd.Filter = "Image Files (*.bmp) | *.bmp|JPEG Files (*.jpg)|*.jpg|AllFiles (*.*)|*.*"
        ofd.FilterIndex = 1
        ofd.Title = "استعراض عن صوره للموظف"
        ofd.CheckFileExists = True
        ofd.CheckPathExists = True
        ofd.ValidateNames = True
        ofd.DereferenceLinks = True
        'ofd.InitialDirectory = "C:\"
        ofd.RestoreDirectory = True
        ofd.ShowDialog()
        photoadd.ImageLocation = ofd.FileName
    End Sub

    Private Sub GunaButton10_Click(sender As Object, e As EventArgs) Handles GunaButton10.Click
        If (DataGridView1.SelectedRows.Count = 0) Then
            MessageBox.Show("يجب تحديد البيانات المراد تعديلها اولا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'كود جلب البيانات
        Dim indx As Integer = DataGridView1.SelectedRows(0).Index
        name1.Text = DataGridView1(1, indx).Value.ToString()
        id2.Text = DataGridView1(2, indx).Value.ToString()
        age.Text = DataGridView1(3, indx).Value.ToString()
        BunifuDate.Text = DataGridView1(4, indx).Value.ToString()
        Gender.Text = DataGridView1(5, indx).Value.ToString()
        nat.Text = DataGridView1(6, indx).Value.ToString()
        qua.Text = DataGridView1(7, indx).Value.ToString()
        addrs.Text = DataGridView1(8, indx).Value.ToString()
        phon.Text = DataGridView1(9, indx).Value.ToString()
        tcn.Text = DataGridView1(10, indx).Value.ToString()
        dept.Text = DataGridView1(11, indx).Value.ToString()
        toe.Text = DataGridView1(12, indx).Value.ToString()
        salary.Text = DataGridView1(13, indx).Value.ToString()
        Dateemp.Text = DataGridView1(14, indx).Value.ToString()
        TextBox1.Text = DataGridView1(15, indx).Value.ToString()

        Dim ms As New IO.MemoryStream(CType(DataGridView1(16, indx).Value, Byte()))
        Dim returnImage As Image = Image.FromStream(ms)
        photoadd.Image = returnImage
    End Sub

    Private Sub GunaButton8_Click(sender As Object, e As EventArgs) Handles GunaButton8.Click
        If (String.IsNullOrEmpty(name1.Text)) Then
            MessageBox.Show("يجب ادخال الاسم اولا قبل الحفظ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If



        Dim id As Integer = CInt(DataGridView1(0, DataGridView1.SelectedRows(0).Index).Value.ToString())
        Dim cmd As New OleDbCommand("update DBET set  ename=@ename, eid=@eid, eage=@eage, DateBirth=@DateBirth, Gender=@Gender, Nationality=@Nationality, Qualification=@Qualification, Address=@Address, Phone=@Phone, nCompany=@nCompany, Department=@Department, TypeEmp=@TypeEmp, Salary=@Salary, Dateemp=@Dateemp, Notes=@Notes, Photo=@Photo  where ID =@ID", con)
        cmd.Parameters.AddWithValue("@ename", name1.Text)
        cmd.Parameters.AddWithValue("@eid", id2.Text)
        cmd.Parameters.AddWithValue("@eage", age.Text)
        cmd.Parameters.AddWithValue("@DateBirth", BunifuDate.Value.ToShortDateString)
        cmd.Parameters.AddWithValue("@Gender", Gender.Text)
        cmd.Parameters.AddWithValue("@Nationality", nat.Text)
        cmd.Parameters.AddWithValue("@Qualification", qua.Text)
        cmd.Parameters.AddWithValue("@Address", addrs.Text)
        cmd.Parameters.AddWithValue("@Phone", phon.Text)
        cmd.Parameters.AddWithValue("@nCompany", tcn.Text)
        cmd.Parameters.AddWithValue("@Department", dept.Text)
        cmd.Parameters.AddWithValue("@TypeEmp", toe.Text)
        cmd.Parameters.AddWithValue("@Salary", salary.Text)
        cmd.Parameters.AddWithValue("@Dateemp", Dateemp.Value.ToShortDateString)
        cmd.Parameters.AddWithValue("@Notes", TextBox1.Text)

        Dim ms = New IO.MemoryStream()
        photoadd.Image.Save(ms, photoadd.Image.RawFormat)
        Dim bytes = ms.ToArray()
        cmd.Parameters.AddWithValue("@Photo", bytes)

        cmd.Parameters.AddWithValue("@ID", id)

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("تمت عملية الاضافة والحفظ في قاعدة البيانات بنجاح", 64, "حفظ الاضافة")
        LoadDataToDGV()



        name1.Text = ""
        id2.Text = ""
        age.Text = ""
        Gender.SelectedIndex = -1
        nat.Text = ""
        qua.Text = ""
        addrs.Text = ""
        phon.Text = ""
        toe.Text = ""
        dept.Text = ""
        toe.Text = ""
        salary.Text = ""
        TextBox1.Text = ""
        photoadd.Image = Nothing
    End Sub

    Private Sub GunaButton9_Click(sender As Object, e As EventArgs) Handles GunaButton9.Click
        If (DataGridView1.SelectedRows.Count = 0) Then
            MessageBox.Show("يجب تحديد الموظف المراد حذفه اولا", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If (MessageBox.Show("هل انت متاكد من عملية الحذف", "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) <> DialogResult.Yes) Then Return
        Dim str As String = String.Format("Delete From [DBET] where ID={0}", DataGridView1(0, DataGridView1.SelectedRows(0).Index).Value.ToString())
        Dim cmd As New OleDbCommand(str, con)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        LoadDataToDGV()
        MessageBox.Show("تم الحذف بنجاح", "Deleted")
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

    Private Sub id2_TextChange(sender As Object, e As EventArgs) Handles id2.TextChange

    End Sub

    Private Sub id2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles id2.KeyPress
        If Not Char.IsControl(e.KeyChar) Then
            If Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub age_KeyPress(sender As Object, e As KeyPressEventArgs) Handles age.KeyPress
        If Not Char.IsControl(e.KeyChar) Then
            If Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub salary_KeyPress(sender As Object, e As KeyPressEventArgs) Handles salary.KeyPress
        If Not Char.IsControl(e.KeyChar) Then
            If Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub
End Class