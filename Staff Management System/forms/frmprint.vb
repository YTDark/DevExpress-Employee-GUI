Imports System.Data.OleDb
Imports DevExpress.XtraReports.UI
Public Class frmprint1

    Private Sub frmprint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EMPDataSet.DBET' table. You can move, or remove it, as needed.
        Me.DBETTableAdapter.Fill(Me.EMPDataSet.DBET)
        'Me.TopMost = True

    End Sub


    Private Sub GunaAdvenceButton7_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton7.Click
        Dim dt As New DataTable("DBTE")
        With dt
            .Columns.Add("ename")
            .Columns.Add("eid")
            .Columns.Add("eage")
            .Columns.Add("DateBirth")
            .Columns.Add("Gender")
            .Columns.Add("Nationality")
            .Columns.Add("Qualification")
            .Columns.Add("Address")
            .Columns.Add("Phone")
            '.Columns.Add("nCompany")
            '.Columns.Add("Department")
            '.Columns.Add("TypeEmp")
            '.Columns.Add("Salary")
            '.Columns.Add("Dateemp")
            '.Columns.Add("Notes")

        End With
        dt.Rows.Clear()
        With DataGridView1
            For i = 0 To .Rows.Count - 1
                dt.Rows.Add(.Rows(i).Cells(1).Value, .Rows(i).Cells(2).Value, .Rows(i).Cells(3).Value, .Rows(i).Cells(4).Value, .Rows(i).Cells(5).Value, .Rows(i).Cells(6).Value, .Rows(i).Cells(7).Value, .Rows(i).Cells(8).Value, .Rows(i).Cells(9).Value)
            Next
        End With
        Dim adapter As New OleDbDataAdapter
        Dim report As New Report1
        report.DataSource = dt
        report.DataAdapter = adapter
        report.DataMember = "DBTE"
        Dim tool As ReportPrintTool = New ReportPrintTool(report)
        report.CreateDocument()
        report.ShowPreview()
    End Sub

    Private Sub GunaAdvenceButton8_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton8.Click
        Dim dt As New DataTable("DBTE")
        With dt
            .Columns.Add("ename")
            .Columns.Add("eid")
            .Columns.Add("nCompany")
            .Columns.Add("Department")
            .Columns.Add("TypeEmp")
            .Columns.Add("Salary")
            .Columns.Add("Dateemp")
            .Columns.Add("Notes")

        End With
        dt.Rows.Clear()
        With DataGridView1
            For i = 0 To .Rows.Count - 1
                dt.Rows.Add(.Rows(i).Cells(1).Value, .Rows(i).Cells(2).Value, .Rows(i).Cells(10).Value, .Rows(i).Cells(11).Value, .Rows(i).Cells(12).Value, .Rows(i).Cells(13).Value, .Rows(i).Cells(14).Value, .Rows(i).Cells(15).Value)
            Next
        End With
        Dim adapter As New OleDbDataAdapter
        Dim report As New Report2
        report.DataSource = dt
        report.DataAdapter = adapter
        report.DataMember = "DBTE"
        Dim tool As ReportPrintTool = New ReportPrintTool(report)
        report.CreateDocument()
        report.ShowPreview()
    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        Dim dt As New DataTable("DBTE")
        With dt
            .Columns.Add("ename")
            .Columns.Add("eid")
            .Columns.Add("Department")
            .Columns.Add("TypeEmp")
            .Columns.Add("Salary")


        End With
        dt.Rows.Clear()
        With DataGridView1
            For i = 0 To .Rows.Count - 1
                dt.Rows.Add(.Rows(i).Cells(1).Value, .Rows(i).Cells(2).Value, .Rows(i).Cells(11).Value, .Rows(i).Cells(12).Value, .Rows(i).Cells(13).Value)
            Next
        End With
        Dim adapter As New OleDbDataAdapter
        Dim report As New Report3
        report.DataSource = dt
        report.DataAdapter = adapter
        report.DataMember = "DBTE"
        Dim tool As ReportPrintTool = New ReportPrintTool(report)
        report.CreateDocument()
        report.ShowPreview()
    End Sub
End Class