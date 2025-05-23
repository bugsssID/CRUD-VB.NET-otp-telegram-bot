Imports System.Data.Odbc
Imports System.Reflection

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ipcek()
        tmpservice()
        tmpP3AT()
        Me.Text = "Application Support DC PWK | Versi : " + Application.ProductVersion + " | Company : " + Application.CompanyName
    End Sub

    Private Sub MasterDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterDataToolStripMenuItem.Click
        FrmMasterdc.Show()
    End Sub

    Private Sub TransaksiServiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiServiceToolStripMenuItem.Click
        FrmTService.ShowDialog()
    End Sub

    Private Sub ReprintSJServiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReprintSJServiceToolStripMenuItem.Click
        FrmRepsjservice.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        tmpservice()
    End Sub

    Private Sub TransaksiP3ATToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiP3ATToolStripMenuItem.Click
        Frmp3atbarang.ShowDialog()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        If MetroComboBox1.Text = "Monitoring Service" Then
            Try
                konek()
                Dim query As String = "Select kategori, noseri, keter, tanggaljam, pick, kondisi, lokasi, status, penjelasan, nosj, tglselesai, pick_ga 
                               From tbl_service
                               Where noseri Like '%" & MetroTextBox1.Text & "%' 
                               Or kategori Like '%" & MetroTextBox1.Text & "%' 
                               Or keter Like '%" & MetroTextBox1.Text & "%' 
                               Or lokasi Like '%" & MetroTextBox1.Text & "%' 
                               Or status Like '%" & MetroTextBox1.Text & "%' 
                               ORDER BY noseri DESC;"

                cmd = New OdbcCommand(query, conn)
                da = New OdbcDataAdapter(cmd)
                dt = New DataTable
                da.Fill(dt)

                DataGridView1.Rows.Clear()
                For i = 0 To dt.Rows.Count - 1
                    DataGridView1.Rows.Add(dt.Rows(i)("kategori"), dt.Rows(i)("noseri"), dt.Rows(i)("keter"), dt.Rows(i)("tanggaljam"), dt.Rows(i)("pick"), dt.Rows(i)("kondisi"), dt.Rows(i)("lokasi"), dt.Rows(i)("status"), dt.Rows(i)("penjelasan"), dt.Rows(i)("nosj"), dt.Rows(i)("tglselesai"), dt.Rows(i)("pick_ga"))
                Next
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf MetroComboBox1.Text = "Monitoring P3AT" Then
            Try
                konek()
                Dim query As String = "Select kategori, noseri, keter, tanggaljam, pick, kondisi, lokasi, status, penjelasan, nop3at, tglselesai, pick_ga
                               From tbl_p3at
                               Where noseri Like '%" & MetroTextBox1.Text & "%' 
                               Or kategori Like '%" & MetroTextBox1.Text & "%' 
                               Or keter Like '%" & MetroTextBox1.Text & "%' 
                               Or lokasi Like '%" & MetroTextBox1.Text & "%' 
                               Or status Like '%" & MetroTextBox1.Text & "%' 
                               ORDER BY noseri DESC;"

                cmd = New OdbcCommand(query, conn)
                da = New OdbcDataAdapter(cmd)
                dt = New DataTable
                da.Fill(dt)

                DataGridView2.Rows.Clear()
                For i = 0 To dt.Rows.Count - 1
                    DataGridView2.Rows.Add(dt.Rows(i)("kategori"), dt.Rows(i)("noseri"), dt.Rows(i)("keter"), dt.Rows(i)("tanggaljam"), dt.Rows(i)("pick"), dt.Rows(i)("kondisi"), dt.Rows(i)("lokasi"), dt.Rows(i)("status"), dt.Rows(i)("penjelasan"), dt.Rows(i)("nop3at"), dt.Rows(i)("tglselesai"), dt.Rows(i)("pick_ga"))
                Next
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf MetroComboBox1.Text = "Monitoring PP" Then


        End If
    End Sub
    Private Sub MetroTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles MetroTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If MetroComboBox1.Text = "Monitoring Service" Then
                Try
                    konek()
                    Dim query As String = "Select kategori, noseri, keter, tanggaljam, pick, kondisi, lokasi, status, penjelasan, nosj, tglselesai, pick_ga
                               From tbl_service
                               Where noseri Like '%" & MetroTextBox1.Text & "%' 
                               Or kategori Like '%" & MetroTextBox1.Text & "%' 
                               Or keter Like '%" & MetroTextBox1.Text & "%' 
                               Or lokasi Like '%" & MetroTextBox1.Text & "%' 
                               Or status Like '%" & MetroTextBox1.Text & "%' 
                               ORDER BY noseri DESC;"

                    cmd = New OdbcCommand(query, conn)
                    da = New OdbcDataAdapter(cmd)
                    dt = New DataTable
                    da.Fill(dt)

                    DataGridView1.Rows.Clear()
                    For i = 0 To dt.Rows.Count - 1
                        DataGridView1.Rows.Add(dt.Rows(i)("kategori"), dt.Rows(i)("noseri"), dt.Rows(i)("keter"), dt.Rows(i)("tanggaljam"), dt.Rows(i)("pick"), dt.Rows(i)("kondisi"), dt.Rows(i)("lokasi"), dt.Rows(i)("status"), dt.Rows(i)("penjelasan"), dt.Rows(i)("nosj"), dt.Rows(i)("tglselesai"), dt.Rows(i)("pick_ga"))
                    Next
                    conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            ElseIf MetroComboBox1.Text = "Monitoring P3AT" Then
                Try
                    konek()
                    Dim query As String = "Select kategori, noseri, keter, tanggaljam, pick, kondisi, lokasi, status, penjelasan, nop3at, tglselesai, pick_ga
                               From tbl_p3at
                               Where noseri Like '%" & MetroTextBox1.Text & "%' 
                               Or kategori Like '%" & MetroTextBox1.Text & "%' 
                               Or keter Like '%" & MetroTextBox1.Text & "%' 
                               Or lokasi Like '%" & MetroTextBox1.Text & "%' 
                               Or status Like '%" & MetroTextBox1.Text & "%' 
                               ORDER BY noseri DESC;"

                    cmd = New OdbcCommand(query, conn)
                    da = New OdbcDataAdapter(cmd)
                    dt = New DataTable
                    da.Fill(dt)

                    DataGridView2.Rows.Clear()
                    For i = 0 To dt.Rows.Count - 1
                        DataGridView2.Rows.Add(dt.Rows(i)("kategori"), dt.Rows(i)("noseri"), dt.Rows(i)("keter"), dt.Rows(i)("tanggaljam"), dt.Rows(i)("pick"), dt.Rows(i)("kondisi"), dt.Rows(i)("lokasi"), dt.Rows(i)("status"), dt.Rows(i)("penjelasan"), dt.Rows(i)("nop3at"), dt.Rows(i)("tglselesai"), dt.Rows(i)("pick_ga"))
                    Next
                    conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            ElseIf MetroComboBox1.Text = "Monitoring PP" Then


            End If
        End If
    End Sub
    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Try
            Dim noSeri As String = DataGridView1.Rows(e.RowIndex).Cells("noseri").Value.ToString()
            Dim kondisi As String = DataGridView1.Rows(e.RowIndex).Cells("kondisi").Value.ToString()
            Dim status As String = DataGridView1.Rows(e.RowIndex).Cells("status").Value.ToString()
            Dim lokasi As String = DataGridView1.Rows(e.RowIndex).Cells("lokasi").Value.ToString()
            Dim keter As String = DataGridView1.Rows(e.RowIndex).Cells("keter").Value.ToString()
            Dim pick_ga As String = DataGridView1.Rows(e.RowIndex).Cells("pick_ga").Value.ToString()

            konek()
            str = "update tbl_service Set kondisi='" & kondisi & "',status='" & status & "',penjelasan='" & keter & "',pick_ga='" & pick_ga & "' where noseri='" & noSeri & "'"
            cmd = New Odbc.OdbcCommand(str, conn)
        cmd.ExecuteNonQuery()

        Dim u1 As String
        Dim u2 As String
        u1 = "UPDATE tbl_dat_dc SET status = '" & status & "',lokasi = '" & lokasi & "',alasan = '" & keter & "' WHERE noseri = '" & noseri & "'"
        cmd = New OdbcCommand(u1, conn)
        cmd.ExecuteNonQuery()

        u2 = "UPDATE tbl_dat_aup SET status = '" & status & "',lokasi = '" & lokasi & "',alasan = '" & keter & "' WHERE noseri = '" & noseri & "'"

        cmd = New OdbcCommand(u2, conn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
        MessageBox.Show("Gagal memperbarui data: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
