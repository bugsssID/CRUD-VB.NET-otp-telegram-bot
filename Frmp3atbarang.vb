Imports System.Data.Odbc
Imports Telegram.Bot
Imports Telegram.Bot.Types
Imports Telegram.Bot.Types.ReplyMarkups

Public Class Frmp3atbarang
    Dim bot As New TelegramBotClient("987124141:AAGPl6_WDnM-6pumltQib0gelAUb_6wVoDI")
    Dim chatId As Long = 750065190
    Private Sub Frmp3atbarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tmpp3atlist()
        kodeotomatisp3at()
        ComboBox1.Items.Clear()
        konek()
        Dim str As String = "select noseri from tbl_service;"
        cmd = New OdbcCommand(str, conn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Do While dr.Read
                ComboBox1.Items.Add(dr("noseri"))
            Loop
        End If
        dr.Close()
    End Sub
    Sub Tmpp3atlist()
        Try
            konek()
            Dim data As String = " SELECT kategori, noseri, keter, kondisi,status,tanggal, penjelasan FROM tmp_p3at ORDER BY noseri DESC;"
            cmd = New OdbcCommand
            da = New OdbcDataAdapter
            dt = New DataTable
            With cmd
                .CommandText = data
                .Connection = conn
            End With
            With da
                .SelectCommand = cmd
                .Fill(dt)
            End With
            DataGridView1.Rows.Clear()
            For i = 0 To dt.Rows.Count - 1
                With DataGridView1
                    .Rows.Add(dt.Rows(i)("kategori"), dt.Rows(i)("noseri"), dt.Rows(i)("keter"), dt.Rows(i)("kondisi"), dt.Rows(i)("status"), dt.Rows(i)("tanggal"), dt.Rows(i)("penjelasan"))
                End With
            Next
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub MetroLink1_Click(sender As Object, e As EventArgs) Handles MetroLink1.Click
        Frmstatusbarang.ShowDialog()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            konek()
            Dim str As String
            str = "select * from tbl_service where noseri = '" & ComboBox1.Text & "'"
            cmd = New OdbcCommand(str, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                TextBox1.Text = dr.Item("Keter")
                TextBox2.Text = dr.Item("kategori")
                TextBox3.Text = dr.Item("kondisi")
                TextBox6.Text = dr.Item("status")
                TextBox4.Text = dr.Item("penjelasan")
            End If
        Catch ex As Exception
            ShowError("error", ex)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If ComboBox1.Text = Nothing Then
                MsgBox("Pilih dulu datanya brow")
                Exit Sub
            End If
            konek()
            Dim query As String = "INSERT INTO tmp_p3at (kategori,noseri, keter, kondisi, status, tanggal, penjelasan) VALUES ('" & TextBox2.Text & "','" & ComboBox1.Text & "','" & TextBox1.Text & "','" & TextBox3.Text & "','" & TextBox6.Text & "','" & DateTime.Now.ToString("yyyy-MM-dd") & "','" & TextBox4.Text & "')"
            cmd = New OdbcCommand(query, conn)
            cmd.ExecuteNonQuery()
            Tmpp3atlist()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        conn.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Tmpp3atlist()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            For Each row As DataGridViewRow In DataGridView1.Rows
                If Not row.IsNewRow Then ' Abaikan baris baru atau kosong
                    Dim kategori As String = row.Cells(0).Value?.ToString()
                    Dim noseri As String = row.Cells(1).Value?.ToString()
                    Dim nama As String = row.Cells(2).Value?.ToString()
                    Dim tglOriginal As String = row.Cells(5).Value?.ToString()
                    Dim tglFormatted As String = ""
                    ' Cek apakah nilai tanggal valid
                    If Not String.IsNullOrEmpty(tglOriginal) Then
                        Dim parsedDate As DateTime
                        If DateTime.TryParse(tglOriginal, parsedDate) Then
                            tglFormatted = parsedDate.ToString("yyyy-MM-dd") ' Format tanggal
                        Else
                            tglFormatted = "Invalid Date" ' Penanganan jika tanggal tidak valid
                        End If
                    End If
                    Dim kondisi As String = row.Cells(3).Value?.ToString()
                    Dim sts As String = row.Cells(4).Value?.ToString()
                    Dim keter As String = row.Cells(6).Value?.ToString()
                    Dim nop3at As String = TextBox5.Text
                    'MsgBox(kategori)

                    konek()
                    Dim str As String = "insert into tbl_p3at(kategori, noseri, keter, tanggaljam, pick, kondisi, status, penjelasan, nop3at,lokasi)values('" & kategori & "','" & noseri &
                                "','" & nama & "','" & tglFormatted & "','" & Form1.ToolStripLabel4.Text & "','" & kondisi & "','" & sts & "','" & keter & "','" & nop3at & "','" & "DC" & "')"
                    cmd = New OdbcCommand(str, conn)
                    cmd.ExecuteNonQuery()
                    Dim pesan As String = "Laporan Data p3at Barang | Tanggal :" & tglFormatted & vbCrLf &
                                          "-------------------------------" & vbCrLf &
                                          "No. Seri: " & noseri & vbCrLf &
                                          "Nama: " & nama & vbCrLf &
                                          "Kondisi: " & kondisi & vbCrLf &
                                          "Status: " & sts & vbCrLf &
                                          "Keterangan: " & keter & vbCrLf &
                                          "-------------------------------" & vbCrLf
                    bot.SendTextMessageAsync(chatId, pesan).Wait()
                    conn.Close()
                    '        'update ke database tbl_dat_dc dan AUP
                    Try
                        konek()
                        Dim u1 As String
                        Dim u2 As String
                        u1 = "UPDATE tbl_dat_dc SET status = '" & sts & "',lokasi = '" & "DC" & "',alasan = '" & keter & "' WHERE noseri = '" & noseri & "'"
                        cmd = New OdbcCommand(u1, conn)
                        cmd.ExecuteNonQuery()

                        u2 = "UPDATE tbl_dat_aup SET status = '" & sts & "',lokasi = '" & "DC" & "',alasan = '" & keter & "' WHERE noseri = '" & noseri & "'"

                        cmd = New OdbcCommand(u2, conn)
                        cmd.ExecuteNonQuery()
                        conn.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        FrmTService.Close()
                    End Try
                End If
            Next
            MsgBox("Berhasil simpan service data", MsgBoxStyle.Information)
            CETAKSJ()
            kodeotomatisp3at()
            conn.Close()
            Try
                konek()
                Dim deltmp As String = "delete from tmp_p3at"
                cmd = New OdbcCommand(deltmp, conn)
                cmd.ExecuteNonQuery()

                Dim delsvc As String = "delete from tbl_service"
                cmd = New OdbcCommand(delsvc, conn)
                cmd.ExecuteNonQuery()

                Tmpp3atlist()
                tmpP3AT()
            Catch ex As Exception
                ShowError("error", ex)
            End Try
            conn.Close()
        Catch ex As Exception
            ShowError("error", ex)
        End Try
    End Sub
    Sub CETAKSJ()
        konek()
        str = " select * from tbl_p3at where nop3at='" & TextBox5.Text & "';"
        Try
            cmd = New OdbcCommand(str, conn)
            da.SelectCommand = cmd
            da.Fill(FrmCetaksjp3at.DataSet1.tbl_p3at)
            FrmCetaksjp3at.Show()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
End Class