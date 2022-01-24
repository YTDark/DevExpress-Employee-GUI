Imports System.Data.OleDb
Imports System.Data
Imports System.Globalization
Public Class frmlogin
    Dim File = Application.StartupPath + "\config.ini"
    Dim Settings = "Settings"
    Dim Check2 = "Check2"
    Dim MPass2 = "MPass2"
    Dim NEM = "NEM"
    Dim con As New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=" & Application.StartupPath & "\EMP.mdb;user id=admin;jet oledb:database password=343282")
    Public Sub Alert(msg As String, type As frmAlert.alertTypeEnum)
        Dim f As frmAlert = New frmAlert
        f.setAlert(msg, type)
    End Sub

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        'كود خاص بقراءة اخر عملية تسجيل وحفظها Remember Me
        If Remember.Checked = True Then
            writeIni(File, Settings, Check2, "True")
            writeIni(File, Settings, NEM, user.Text)
            writeIni(File, Settings, MPass2, pass.Text)
        Else
            writeIni(File, Settings, Check2, "False")
            writeIni(File, Settings, NEM, "")
            writeIni(File, Settings, MPass2, "")

        End If
        ''''''''''''''''''''''''''''''''''''''''''''''

        Try
            If user.Text = "" Or pass.Text = "" Then
                MsgBox("من فضلك قم بكتابة اسم المستخدم وكلمة المرور")
                user.Text = Nothing
                pass.Text = Nothing
                ErrorProvider2.Clear()

                ErrorProvider1.SetError(user, "NOT NULL")
                ErrorProvider1.SetError(pass, "NOT NULL")

                Exit Sub
            End If

            Dim ds As New DataSet
            ds.Clear()
            Dim data As New OleDbDataAdapter("select us,ps from users where us='" & Trim(user.Text) & "' and ps='" & Trim(pass.Text) & "'", con)
            con.Open()
            data.Fill(ds, "users")
            con.Close()
            If ds.Tables("users").Rows.Count = 0 Then
                MsgBox("خطا في اسم المستخدم او كلمة المرور")
                user.BorderColor = Color.Red
                pass.BorderColor = Color.Red
                user.Text = ""
                pass.Text = ""
                ErrorProvider1.SetError(user, "NOT NULL")
                ErrorProvider1.SetError(pass, "NOT NULL")
                user.Focus()
                Alert("خطأ في التسجيل", frmAlert.alertTypeEnum.Error)


            Else
                ErrorProvider1.Clear()
                ErrorProvider2.SetError(user, "Valid Data")
                ErrorProvider2.SetError(pass, "Valid Data")
                user.BorderColor = Color.FromArgb(35, 50, 101)
                pass.BorderColor = Color.FromArgb(35, 50, 101)



                Timer1.Start()

                Alert("تم تسجيل الدخول بنجاح", frmAlert.alertTypeEnum.Success)

            End If
        Catch ex As Exception

            'MessageBox.Show("يبدو ان البرنامج قد فقد قاعدة البيانات يرجي استعادة قاعدة البيانات الخاصة بالبرنامج", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ''backup1.ShowDialog()
            Exit Sub
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        loginbtn.Hide()
        GunaProgressBar1.Increment(1.5)
        If GunaProgressBar1.Value = 100 Then
            Timer1.Stop()
            Me.Hide()
            frmMenu.Show()
        End If
    End Sub


    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        End
    End Sub

    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Remember.Checked = ReadIni(File, Settings, Check2, "")

            user.Text = ReadIni(File, Settings, NEM, "")
            pass.Text = ReadIni(File, Settings, MPass2, "")
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Class