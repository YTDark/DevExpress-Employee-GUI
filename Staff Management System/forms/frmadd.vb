Imports System.Data.OleDb
Imports System.Data
Imports System.Globalization
Imports System.IO
Imports System.Drawing.Image
Public Class frmadd
    Dim con As New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=" & Application.StartupPath & "\EMP.mdb;user id=admin;jet oledb:database password=343282")

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        ofd.Filter = "Image Formats (*.PNG; *.JPG; *.BMP) | *.PNG; *.JPG; *.BMP | All Files (*.*) | *.*"
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

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        If name1.Text = "" Or id.Text = "" Then
            MsgBox("يجب ادخال الاسم والرقم الوظيفي NOT NULL", MsgBoxStyle.Critical, "ERROR")
            name1.Focus()
            Exit Sub
        End If
        If salary.Text = "" Then Exit Sub
        If id.Text = "" Then Exit Sub
        If name1.Text = "" Then Exit Sub
        If nat.Text = "" Then Exit Sub
        If qua.Text = "" Then Exit Sub
        If age.Text = "" Then Exit Sub
        If addrs.Text = "" Then Exit Sub
        If Gender.Text = "" Then Exit Sub
        If toe.Text = "" Then Exit Sub
        If phon.Text = "" Then Exit Sub
        If dept.Text = "" Then Exit Sub
        If tcn.Text = "" Then Exit Sub


        '==============================================================================================================

        Dim ret As Integer = (New OleDb.OleDbDataAdapter("SELECT eid FROM DBET WHERE eid=" & Val(id.Text), con).Fill(New DataTable))
        If ret > 0 Then
            MsgBox("الرقم الوظيفي موجود مسبقا", MsgBoxStyle.Critical, "Error")
            Return
        End If


        Try


            Dim cmd As New OleDbCommand("insert into DBET ([ename],[eid],[eage],[DateBirth],[Gender],[Nationality],[Qualification],[Address],[Phone],[nCompany],[Department],[TypeEmp],[Salary],[Dateemp],[Notes],[Photo]) values(@ename,@eid,@eage,@DateBirth,@Gender,@Nationality,@Qualification,@Address,@Phone,@nCompany,@Department,@TypeEmp,@Salary,@Dateemp,@Notes,@Photo)", con)
            cmd.Parameters.AddWithValue("@ename", name1.Text)
            cmd.Parameters.AddWithValue("@eid", id.Text)
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




            'فتح الاتصال وتاكيد الاضافه وبعد ذلك اغلاق الاتصال
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            'اظهار رساله للمستخدم تبين له نجاح اضافته واغلاق الاتصال واغلاق الفورم بتاع الاضافه والذهاب الى الفورم الرئيسى
            MsgBox("تمت عملية الاضافة والحفظ في قاعدة البيانات بنجاح", 64, "حفظ الاضافة")
            'Home.Equals.Call Retrieve_Employe_Recensement()
            name1.Text = ""
            id.Text = ""
            age.Text = ""
            Gender.SelectedIndex = -1
            nat.Text = ""
            qua.Text = ""
            addrs.Text = ""
            phon.Text = ""
            toe.Text = ""
            dept.Text = ""
            tcn.Text = ""
            salary.Text = ""
            TextBox1.Text = ""

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmadd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True

    End Sub

    Private Sub id_KeyPress(sender As Object, e As KeyPressEventArgs) Handles id.KeyPress
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

    Private Sub phon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles phon.KeyPress
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