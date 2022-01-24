Imports System.ComponentModel
Imports System.Text
Imports System.Data.OleDb
Imports System.Data
Imports System.Globalization


Partial Public Class frmMenu
    Dim con As New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=" & Application.StartupPath & "\EMP.mdb;user id=admin;jet oledb:database password=343282")
    Private ReadOnly DesignSize As Size = New Size(1024, 768)

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_DBLCLKS As Int32 = &H8
            Const CS_NOCLOSE As Int32 = &H200
            cp.ClassStyle = CS_DBLCLKS Or CS_NOCLOSE
            Return cp
        End Get
    End Property
    Public Sub New()
        InitializeComponent()
    End Sub
    Sub LoadData()
        If con.State = ConnectionState.Closed Then con.Open()
        Using Cmd As New OleDbCommand(Nothing, con)
            Cmd.CommandText = "SELECT COUNT(*) From DBET Where Gender='MALE'"
            Me.GunaLabel4.Text = Cmd.ExecuteScalar
            Cmd.CommandText = "SELECT COUNT(*) From DBET Where Gender='FEMALE'"
            Me.GunaLabel7.Text = Cmd.ExecuteScalar
            Cmd.CommandText = "SELECT COUNT(*) From DBET"
            Me.GunaLabel3.Text = Cmd.ExecuteScalar
        End Using
        If con.State = ConnectionState.Open Then con.Close()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'BarButtonItem2.Enabled = Powers1
        'BarButtonItem14.Enabled = Powers2
        'BarButtonItem10.Enabled = Powers3
        'BarButtonItem15.Enabled = Powers4
        'TileItem6.Enabled = Powers1
        'TileItem1.Enabled = Powers2
        'TileItem4.Enabled = Powers3
        'TileItem7.Enabled = Powers4
        '===============================================================================================

        If con.State = ConnectionState.Closed Then con.Open()
        Using Cmd As New OleDbCommand(Nothing, con)
            Cmd.CommandText = "SELECT COUNT(*) From DBET Where Gender='MALE'"
            Me.GunaLabel4.Text = Cmd.ExecuteScalar
            Cmd.CommandText = "SELECT COUNT(*) From DBET Where Gender='FEMALE'"
            Me.GunaLabel7.Text = Cmd.ExecuteScalar
            Cmd.CommandText = "SELECT COUNT(*) From DBET"
            Me.GunaLabel3.Text = Cmd.ExecuteScalar
        End Using
        If con.State = ConnectionState.Open Then con.Close()
        '===============================================================================================
        Dim wgrowth As Single = CSng(Screen.PrimaryScreen.Bounds.Width) / DesignSize.Width
        Dim hgrowth As Single = CSng(Screen.PrimaryScreen.Bounds.Height) / DesignSize.Height
        If wgrowth < hgrowth Then hgrowth = wgrowth
        If hgrowth > 1 Then
            Me.Font = New Font(Me.Font.FontFamily, hgrowth * Me.Font.Size)
            Me.StartPosition = FormStartPosition.Manual
            Dim x As Integer = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
            Dim y As Integer = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
            Me.Location = New Point(x, y)
        End If
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        frmadd.Show()
        LoadData()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        frmedit.Show()
        LoadData()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.BarStaticItem8.Caption = "       مرحبا بك :  " + frmlogin.user.Text
        Me.BarStaticItem10.Caption = "     تاريخ اليوم :  " + Date.Today
        Me.BarStaticItem9.Caption = "      الوقت الان:  " + TimeOfDay
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        frmsearch.Show()
        LoadData()
    End Sub

    Private Sub BarButtonItem14_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        frmprint1.Show()
        LoadData()
    End Sub

 

    Private Sub BarButtonItem15_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem15.ItemClick
        frmsalary.Show()

    End Sub

    Private Sub BarButtonItem10_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        frmuser.Show()

    End Sub

    Private Sub BarButtonItem16_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem16.ItemClick
       
    End Sub

  

    Private Sub TileItem4_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem4.ItemClick
        frmprint1.Show()
    End Sub

    Private Sub TileItem5_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem5.ItemClick
        frmadd.Show()
    End Sub

    Private Sub TileItem6_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem6.ItemClick
        frmedit.Show()
        LoadData()
    End Sub

    Private Sub TileItem7_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs)
        frmuser.Show()
        LoadData()
    End Sub

    Private Sub TileItem2_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem2.ItemClick
        frmsearch.Show()
        LoadData()
    End Sub

    Private Sub TileItem1_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem1.ItemClick
        frmsalary.Show()
        LoadData()
    End Sub

    Private Sub TileItem7_ItemClick_1(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem7.ItemClick
        frmuser.Show()
    End Sub

    Private Sub BarButtonItem17_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem17.ItemClick
        Me.Hide()
        frmlogin.Show()
        frmlogin.loginbtn.Visible = True
        LoadData()
    End Sub

    Private Sub BarButtonItem11_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        frmbackup.Show()
    End Sub

    Private Sub TileControl1_Click(sender As Object, e As EventArgs) Handles TileControl1.Click

    End Sub

    Private Sub BarButtonItem21_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem21.ItemClick
        About.Show()
    End Sub
End Class
