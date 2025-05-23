Imports System.Data.Odbc
Public Class FrmTService
    Private Sub FrmTService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kodeotomatis()
        tmpservicelist()
    End Sub

    Private Sub MetroComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        MetroTextBox1.Clear()
        ComboBox2.Text = Nothing

        If ComboBox1.Text = "ANDALAN UTAMA PRIMA (AUP)" Then
            ComboBox2.Items.Clear()
            konek()
            Dim str As String = "select noseri from tbl_dat_aup;"
            cmd = New OdbcCommand(str, conn)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                Do While dr.Read
                    ComboBox2.Items.Add(dr("noseri"))
                Loop
            End If
            dr.Close()
        ElseIf ComboBox1.Text = "DISTRIBUSION CENTER (DC)" Then
            MetroTextBox1.Clear()
            ComboBox2.Text = Nothing
            konek()
            Dim str As String = "select noseri from tbl_dat_dc;"
            cmd = New OdbcCommand(str, conn)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                Do While dr.Read
                    ComboBox2.Items.Add(dr("noseri"))
                Loop
            End If
            dr.Close()
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox1.Text = "ANDALAN UTAMA PRIMA (AUP)" Then
            konek()
            str = "SELECT noseri FROM tbl_dat_aup WHERE noseri='" & ComboBox2.Text & "' AND status IN ('SERVICE', 'P3AT')"
            cmd = New OdbcCommand(str, conn)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                MsgBox("Nomor Aktiva : " + ComboBox2.Text + " Status Sudah Rusak-Service-P3AT tidak bisa di service...", MsgBoxStyle.Critical)
                ComboBox2.Text = Nothing
                MetroTextBox1.Clear()
                ComboBox2.Focus()
                conn.Close()
                dr.Close()
            Else
                Try
                    konek()
                    Dim str As String
                    str = "select * from tbl_dat_aup where noseri = '" & ComboBox2.Text & "'"
                    cmd = New OdbcCommand(str, conn)
                    dr = cmd.ExecuteReader
                    dr.Read()
                    If dr.HasRows Then
                        MetroTextBox1.Text = dr.Item("Keter")
                    End If
                Catch ex As Exception
                    ShowError("error", ex)
                End Try
            End If
        ElseIf ComboBox1.Text = "DISTRIBUSION CENTER (DC)" Then
            konek()
            str = "SELECT noseri FROM tbl_dat_dc WHERE noseri='" & ComboBox2.Text & "' AND status IN ('SERVICE', 'P3AT')"
            cmd = New OdbcCommand(str, conn)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                MsgBox("Nomor Aktiva : " + ComboBox2.Text + " Status Sudah Rusak-Service-P3AT tidak bisa di service...", MsgBoxStyle.Critical)
                ComboBox2.Text = Nothing
                MetroTextBox1.Clear()
                ComboBox2.Focus()
                conn.Close()
                dr.Close()
            Else
                Try
                    konek()
                    Dim str As String
                    str = "select * from tbl_dat_dc where noseri = '" & ComboBox2.Text & "'"
                    cmd = New OdbcCommand(str, conn)
                    dr = cmd.ExecuteReader
                    dr.Read()
                    If dr.HasRows Then
                        MetroTextBox1.Text = dr.Item("Keter")
                    End If
                Catch ex As Exception
                    ShowError("error", ex)
                End Try
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        addlistservice()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        If DataGridView1.Rows.Count = 0 Then
            MessageBox.Show("Data Tidak ada!!!")
            Exit Sub
        End If
        SimpanDataKeDatabase()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 9 Then
            Dim result As DialogResult = MessageBox.Show("Yakin Hapus Data ini!!!", "Perhatian", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
                'MessageBox.Show("Cancel pressed")
            ElseIf result = DialogResult.No Then
                MessageBox.Show("Hapus Data Batal")
            ElseIf result = DialogResult.Yes Then
                Try
                    konek()
                    str = "delete from tmp_service where noseri='" & DataGridView1.Rows(e.RowIndex).Cells(1).Value & "'"
                    cmd = New OdbcCommand(str, conn)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Hapus Data Sukses")
                    conn.Close()
                    tmpservicelist()
                Catch ex As Exception
                    ShowError("error", ex)
                End Try
            End If
        End If
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Me.Close()
    End Sub
    Private Sub FrmTService_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Close()
        conn.Close()
        dr.Close()
    End Sub

End Class