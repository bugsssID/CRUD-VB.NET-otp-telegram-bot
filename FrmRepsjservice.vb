Imports System.Data.Odbc
Public Class FrmRepsjservice
    Private Sub FrmRepsjservice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetroComboBox1.Items.Clear()
        konek()
        Dim str As String = "select nosj from tbl_service group by nosj order by nosj desc;"
        cmd = New OdbcCommand(str, conn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Do While dr.Read
                MetroComboBox1.Items.Add(dr("nosj"))
            Loop
        End If
        dr.Close()
        viewnop3at()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        repCETAKSJ()
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        repcetaksjp3at()
    End Sub
    Sub viewnop3at()
        MetroComboBox2.Items.Clear()
        konek()
        Dim str As String = "select nop3at from tbl_p3at group by nop3at order by nop3at desc;"
        cmd = New OdbcCommand(str, conn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Do While dr.Read
                MetroComboBox2.Items.Add(dr("nop3at"))
            Loop
        End If
        conn.Close()
        dr.Close()
    End Sub

End Class