﻿Public Class frmAlert
    Enum alertTypeEnum
        Success
        [Error]
    End Enum

    Dim x, y As Integer
    Public Sub setAlert(msg As String, type As alertTypeEnum)
        Me.Opacity = 0
        Me.StartPosition = FormStartPosition.Manual
        Dim fname As String
        For i As Integer = 1 To 10
            fname = "alert" & i.ToString
            Dim f As frmAlert = Application.OpenForms.Item(fname)
            If f Is Nothing Then
                Me.Name = fname
                x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width + 15
                y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height * i - 5 * i
                Me.Location = New Point(x, y)
                Exit For
            End If
        Next
        x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width - 5
        Select Case type
            Case alertTypeEnum.Error
                Me.GunaPictureBox1.Image = My.Resources.Error_28px
                Me.BackColor = Color.Red
            Case alertTypeEnum.Success
                Me.GunaPictureBox1.Image = My.Resources.Checkmark_28px
                Me.BackColor = Color.Green
        End Select
        Me.GunaLabel1.Text = msg
        '  Me.TopMost = True
        '  Me.ShowIcon = False
        '  Me.ShowInTaskbar = False
        Me.Show()
        Me.Timer1.Interval = 1
        Me.Timer1.Start()
    End Sub

    Enum actionEnum
        wait
        start
        close
    End Enum

    Private action As actionEnum = actionEnum.start

    Private Sub GunaPictureBox2_Click(sender As Object, e As EventArgs) Handles GunaPictureBox2.Click
        Me.Timer1.Interval = 1
        action = actionEnum.close
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select Case action
            Case actionEnum.start
                Me.Timer1.Interval = 1
                Me.Opacity += 0.1
                If x < Me.Location.X Then
                    Me.Left -= 1
                Else
                    If Me.Opacity = 1 Then
                        action = actionEnum.wait
                    End If
                End If
            Case actionEnum.wait
                Timer1.Interval = 1000
                action = actionEnum.close
            Case actionEnum.close
                Timer1.Interval = 1
                Me.Opacity -= 0.1
                Me.Left -= 3
                If Me.Opacity = 0 Then
                    Close()
                End If
        End Select
    End Sub



    Private Sub frmAlert_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class