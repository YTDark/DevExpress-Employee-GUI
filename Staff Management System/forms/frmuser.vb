Imports System.Data.OleDb
Imports System.Data
Imports System.Globalization
Public Class frmuser
    Dim str As String = ("provider=microsoft.jet.oledb.4.0;data source=" & Application.StartupPath & "\EMP.mdb;user id=admin;jet oledb:database password=343282")
    'تحديد الصلاحيات
    Public con As New OleDbConnection(Str)
    Public Powers1 As Boolean = False
    Public Powers2 As Boolean = False
    Public Powers3 As Boolean = False
    Public Powers4 As Boolean = False

    Sub LoadDataToDGV()
        Dim da As New OleDbDataAdapter("select * from users", con)
        Dim dt As New DataTable()
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
    Private Sub frmuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EMPDataSet.users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.EMPDataSet.users)
        Me.TopMost = True
       
    End Sub

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn1.Click
        Dim str As String = ("provider=microsoft.jet.oledb.4.0;data source=" & Application.StartupPath & "\EMP.mdb;user id=admin;jet oledb:database password=343282")
        Dim con As New OleDbConnection(str)
        Dim issql As String = "select * from users where us='" & Me.user1.Text & "'"
        Dim isds As New DataSet
        Dim isda As New OleDb.OleDbDataAdapter(issql, con)
        isda.Fill(isds, "us")
        If user1.Text = "" Or pass1.Text = "" Then
            MsgBox("يجب تعبئة الحقول المهمه ", MsgBoxStyle.Critical, "خطا")

            Exit Sub
        End If
        If Me.BindingContext(isds, "us").Count > 0 Then
            MsgBox("اسم المستخدم موجود مسبقا ", MsgBoxStyle.Critical, "خطا")
            Exit Sub
        End If
        '==============================================================================================================
        Try
            Dim cmd As New OleDbCommand("insert into users ([us],[ps],[Powers1],[Powers2],[Powers3],[Powers4]) values(@us,@ps,@Powers1,@Powers2,@Powers3,@Powers4)", con)
            cmd.Parameters.AddWithValue("@us", user1.Text)
            cmd.Parameters.AddWithValue("@ps", pass1.Text)
            cmd.Parameters.AddWithValue("@Powers1", CheckBox1.Checked)
            cmd.Parameters.AddWithValue("@Powers2", CheckBox2.Checked)
            cmd.Parameters.AddWithValue("@Powers3", CheckBox3.Checked)
            cmd.Parameters.AddWithValue("@Powers4", CheckBox4.Checked)
            'cmd.Parameters.AddWithValue("@us", OleDbType.VarChar).Value = Trim(user1.Text)
            'cmd.Parameters.AddWithValue("@ps", OleDbType.VarChar).Value = Trim(pass1.Text)
            'cmd.Parameters.AddWithValue("@Powers1", OleDbType.Boolean).Value = CheckBox1.Checked
            'cmd.Parameters.AddWithValue("@Powers2", OleDbType.Boolean).Value = CheckBox2.Checked
            'cmd.Parameters.AddWithValue("@Powers3", OleDbType.Boolean).Value = CheckBox3.Checked
            'cmd.Parameters.AddWithValue("@Powers4", OleDbType.Boolean).Value = CheckBox4.Checked
           
            'فتح الاتصال وتاكيد الاضافه وبعد ذلك اغلاق الاتصال 
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        user1.Text = ""
        pass1.Text = ""
        MsgBox("تم حفظ المستخدم الجديد بنجاح", MsgBoxStyle.Information)
        LoadDataToDGV()
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub GunaButton10_Click(sender As Object, e As EventArgs) Handles GunaButton10.Click
        If (DataGridView1.SelectedRows.Count = 0) Then
            MessageBox.Show("يجب تحديد البيانات المراد تعديلها اولا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'كود جلب البيانات
        Dim indx As Integer = DataGridView1.SelectedRows(0).Index
        user.Text = DataGridView1(1, indx).Value.ToString()
        pass.Text = DataGridView1(2, indx).Value.ToString()
        CheckBox11.Checked = DataGridView1(3, indx).Value.ToString()
        CheckBox22.Checked = DataGridView1(4, indx).Value.ToString()
        CheckBox33.Checked = DataGridView1(5, indx).Value.ToString()
        CheckBox44.Checked = DataGridView1(6, indx).Value.ToString()

    End Sub

    Private Sub GunaButton8_Click(sender As Object, e As EventArgs) Handles GunaButton8.Click
        If (String.IsNullOrEmpty(user.Text)) Then
            MessageBox.Show("يجب ادخال الاسم اولا قبل الحفظ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If



        Dim id As Integer = CInt(DataGridView1(0, DataGridView1.SelectedRows(0).Index).Value.ToString())
        Dim cmd As New OleDbCommand("update users set us=@us, ps=@ps, Powers1=@Powers1, Powers2=@Powers2, Powers3=@Powers3, Powers4=@Powers4  where ID =@ID", con)
        cmd.Parameters.AddWithValue("@us", user.Text)
        cmd.Parameters.AddWithValue("@ps", pass.Text)
        cmd.Parameters.AddWithValue("@Powers1", CheckBox11.Checked)
        cmd.Parameters.AddWithValue("@Powers2", CheckBox22.Checked)
        cmd.Parameters.AddWithValue("@Powers3", CheckBox33.Checked)
        cmd.Parameters.AddWithValue("@Powers4", CheckBox44.Checked)
        'cmd.Parameters.AddWithValue("@us", OleDbType.VarChar).Value = Trim(user.Text)
        'cmd.Parameters.AddWithValue("@ps", OleDbType.VarChar).Value = Trim(pass.Text)
        'cmd.Parameters.AddWithValue("@Powers1", OleDbType.Boolean).Value = CheckBox11.Checked
        'cmd.Parameters.AddWithValue("@Powers2", OleDbType.Boolean).Value = CheckBox22.Checked
        'cmd.Parameters.AddWithValue("@Powers3", OleDbType.Boolean).Value = CheckBox33.Checked
        'cmd.Parameters.AddWithValue("@Powers4", OleDbType.Boolean).Value = CheckBox44.Checked

        cmd.Parameters.AddWithValue("@ID", id)

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("تمت عملية الاضافة والحفظ في قاعدة البيانات بنجاح", 64, "حفظ الاضافة")
        LoadDataToDGV()



        user.Text = ""
        pass.Text = ""
    End Sub

    Private Sub GunaButton9_Click(sender As Object, e As EventArgs) Handles GunaButton9.Click
        If (DataGridView1.SelectedRows.Count = 0) Then
            MessageBox.Show("يجب تحديد الموظف المراد حذفه اولا", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If (MessageBox.Show("هل انت متاكد من عملية الحذف", "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) <> DialogResult.Yes) Then Return
        Dim str As String = String.Format("Delete From [users] where ID={0}", DataGridView1(0, DataGridView1.SelectedRows(0).Index).Value.ToString())
        Dim cmd As New OleDbCommand(str, con)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        LoadDataToDGV()
        MessageBox.Show("تم الحذف بنجاح", "Deleted")
    End Sub
End Class