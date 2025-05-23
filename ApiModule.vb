Imports System.Data.Odbc
Imports System.IO
Imports System.Net
Imports Telegram
Imports Telegram.Bot
Imports Telegram.Bot.Types

Module ApiModule
    Dim bot As New TelegramBotClient("987124141:AAGPl6_WDnM-6pumltQib0gelAUb_6wVoDI")
    Dim chatId As Long = 750065190
    Public conn As OdbcConnection
    Public cmd As OdbcCommand
    Public da As OdbcDataAdapter
    Public dr As OdbcDataReader
    Public ds As DataSet
    Public dt As DataTable
    Public str As String
    Public dtsource As New BindingSource

    Public Sub konek()
        Try
            Dim koneksi As String = "DRIVER={PostgreSQL Unicode};database=postgres;server=192.168.63.117;port=5432;uid=postgres;password=262627;"
            conn = New OdbcConnection(koneksi)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Application.Exit()
        End Try
    End Sub
    Public Sub ipcek()
        Dim strIPAddress As String
        Dim strHostName As String
        strHostName = System.Net.Dns.GetHostName()
        strIPAddress = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.ToolStripLabel2.Text = strIPAddress
        Try
            konek()
            cmd = New OdbcCommand("SELECT datname FROM pg_database WHERE datname Not IN ('template0', 'template1') ORDER BY datname", conn)
            da = New OdbcDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "database")
            Dim dbList As String = String.Join(vbCrLf, ds.Tables("database").Rows.Cast(Of DataRow)().Select(Function(dr) dr("datname").ToString()))
            Form1.ToolStripLabel6.Text = String.Join(vbCrLf, dbList)
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Sub tmpservice()
        Try
            konek()
            Dim data As String = " SELECT kategori, noseri, keter, tanggaljam, pick, kondisi,lokasi, status, penjelasan,nosj,tglselesai,pick_ga FROM tbl_service ORDER BY noseri DESC;"
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
            Form1.DataGridView1.Rows.Clear()
            For i = 0 To dt.Rows.Count - 1
                With Form1.DataGridView1
                    .Rows.Add(dt.Rows(i)("kategori"), dt.Rows(i)("noseri"), dt.Rows(i)("keter"), dt.Rows(i)("tanggaljam"), dt.Rows(i)("pick"), dt.Rows(i)("kondisi"), dt.Rows(i)("lokasi"), dt.Rows(i)("status"), dt.Rows(i)("penjelasan"), dt.Rows(i)("nosj"), dt.Rows(i)("tglselesai"), dt.Rows(i)("pick_ga"))
                End With
            Next
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub tmpP3AT()
        Try
            konek()
            Dim data As String = " SELECT kategori, noseri, keter, tanggaljam, pick, kondisi,lokasi, status, penjelasan,nop3at,tglselesai,pick_ga FROM tbl_p3at ORDER BY noseri DESC;"
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
            Form1.DataGridView2.Rows.Clear()
            For i = 0 To dt.Rows.Count - 1
                With Form1.DataGridView2
                    .Rows.Add(dt.Rows(i)("kategori"), dt.Rows(i)("noseri"), dt.Rows(i)("keter"), dt.Rows(i)("tanggaljam"), dt.Rows(i)("pick"), dt.Rows(i)("kondisi"), dt.Rows(i)("lokasi"), dt.Rows(i)("status"), dt.Rows(i)("penjelasan"), dt.Rows(i)("nop3at"), dt.Rows(i)("tglselesai"), dt.Rows(i)("pick_ga"))
                End With
            Next
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub masterdatadc()
        Try
            konek()
            Dim data As String = "SELECT * FROM tbl_dat_dc ORDER BY noseri DESC;"

            Using cmd As New OdbcCommand(data, conn)
                Using da As New OdbcDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)

                    FrmMasterdc.DataGridView1.Rows.Clear()
                    FrmMasterdc.DataGridView1.DataSource = dt
                End Using
            End Using
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub masterdataaup()
        Try
            konek()
            Dim data As String = "SELECT * FROM tbl_dat_aup ORDER BY noseri DESC;"

            Using cmd As New OdbcCommand(data, conn)
                Using da As New OdbcDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)

                    FrmMasterdc.DataGridView2.Rows.Clear()
                    FrmMasterdc.DataGridView2.DataSource = dt
                End Using
            End Using
            conn.Close()
        Catch ex As Exception
            ShowError("Error Menampilkan data", ex)
        End Try
    End Sub
    Public Sub kodeotomatis()
        konek()
        cmd = New OdbcCommand("select * from tbl_service order by nosj desc", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            FrmTService.TextBox3.Text = "SJ" + "0001"
        Else
            FrmTService.TextBox3.Text = Val(Microsoft.VisualBasic.Mid(dr.Item("nosj").ToString, 4, 3)) + 1
            If Len(FrmTService.TextBox3.Text) = 1 Then
                FrmTService.TextBox3.Text = "SJ000" & FrmTService.TextBox3.Text & ""
            ElseIf Len(FrmTService.TextBox3.Text) = 2 Then
                FrmTService.TextBox3.Text = "SJ00" & FrmTService.TextBox3.Text & ""
            ElseIf Len(FrmTService.TextBox3.Text) = 3 Then
                FrmTService.TextBox3.Text = "SJ0" & FrmTService.TextBox3.Text & ""
            End If
        End If
        dr.Close()
        conn.Close()
    End Sub
    Public Sub kodeotomatisp3at()
        konek()
        cmd = New OdbcCommand("select * from tbl_p3at order by nop3at desc", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            Frmp3atbarang.TextBox5.Text = "SJ" + "0001"
        Else
            Frmp3atbarang.TextBox5.Text = Val(Microsoft.VisualBasic.Mid(dr.Item("nop3at").ToString, 4, 3)) + 1
            If Len(Frmp3atbarang.TextBox5.Text) = 1 Then
                Frmp3atbarang.TextBox5.Text = "SJ000" & Frmp3atbarang.TextBox5.Text & ""
            ElseIf Len(Frmp3atbarang.TextBox5.Text) = 2 Then
                Frmp3atbarang.TextBox5.Text = "SJ00" & Frmp3atbarang.TextBox5.Text & ""
            ElseIf Len(Frmp3atbarang.TextBox5.Text) = 3 Then
                Frmp3atbarang.TextBox5.Text = "SJ0" & Frmp3atbarang.TextBox5.Text & ""
            End If
        End If
    End Sub
    Public Sub addlistservice()
        If FrmTService.ComboBox1.Text = "" Or FrmTService.ComboBox2.Text = "" Or FrmTService.MetroTextBox1.Text = "" Or FrmTService.ComboBox3.Text = "" Or FrmTService.TextBox2.Text = "" Or FrmTService.ComboBox5.Text = "" Then
            MessageBox.Show("Silahkan isi data dengan benar !!!")
            Exit Sub
        End If
        Dim tgljam As String = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")
        Try
            konek()
            Dim str = "Insert into tmp_service (kategori, noseri, keter, tanggaljam, pick, kondisi,lokasi, status, penjelasan) values('" & FrmTService.ComboBox1.Text & "','" & FrmTService.ComboBox2.Text & "','" & FrmTService.MetroTextBox1.Text & "','" & tgljam & "','" & Form1.ToolStripLabel4.Text & "','" & FrmTService.ComboBox3.Text & "','" & FrmTService.ComboBox4.Text & "','" & FrmTService.ComboBox5.Text & "','" & FrmTService.TextBox2.Text & "');"
            cmd = New OdbcCommand(str, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Add Suksesss", MsgBoxStyle.Information)
            tmpservicelist()
            FrmTService.ComboBox1.Text = Nothing
            FrmTService.ComboBox2.Text = Nothing
            FrmTService.ComboBox3.Text = Nothing
            FrmTService.ComboBox4.Text = Nothing
            FrmTService.ComboBox5.Text = Nothing
            FrmTService.MetroTextBox1.Clear()
            FrmTService.TextBox2.Clear()
            FrmTService.ComboBox1.Focus()
        Catch ex As Exception
            ShowError("Error", ex)
        End Try
    End Sub
    Sub tmpservicelist()
        Try
            konek()
            Dim data As String = " SELECT kategori, noseri, keter, tanggaljam, pick, kondisi,lokasi, status, penjelasan FROM tmp_service ORDER BY noseri DESC;"
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
            FrmTService.DataGridView1.Rows.Clear()
            For i = 0 To dt.Rows.Count - 1
                With FrmTService.DataGridView1
                    .Rows.Add(dt.Rows(i)("kategori"), dt.Rows(i)("noseri"), dt.Rows(i)("keter"), dt.Rows(i)("tanggaljam"), dt.Rows(i)("pick"), dt.Rows(i)("kondisi"), dt.Rows(i)("lokasi"), dt.Rows(i)("status"), dt.Rows(i)("penjelasan"))
                End With
            Next
            conn.Close()
        Catch ex As Exception
            ShowError("Error Menampilkan data", ex)
        End Try
    End Sub
    Public Sub SimpanDataKeDatabase()
        For Each row As DataGridViewRow In FrmTService.DataGridView1.Rows
            If Not row.IsNewRow Then ' Abaikan baris baru atau kosong
                Dim kategori As String = row.Cells(0).Value?.ToString()
                Dim noseri As String = row.Cells(1).Value?.ToString()
                Dim nama As String = row.Cells(2).Value?.ToString()
                Dim tglOriginal As String = row.Cells(3).Value?.ToString()
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
                Dim pick As String = row.Cells(4).Value?.ToString()
                Dim kondisi As String = row.Cells(5).Value?.ToString()
                Dim lokasi As String = row.Cells(6).Value?.ToString()
                Dim sts As String = row.Cells(7).Value?.ToString()
                Dim keter As String = row.Cells(8).Value?.ToString()
                Dim nosj As String = FrmTService.TextBox3.Text
                'MsgBox(kategori)
                Try
                    konek()
                    Dim str As String = "insert into tbl_service(kategori, noseri, keter, tanggaljam, pick, kondisi,lokasi, status, penjelasan, nosj)values('" & kategori & "','" & noseri &
                        "','" & nama & "','" & tglFormatted & "','" & pick & "','" & kondisi & "','" & lokasi & "','" & sts & "','" & keter & "','" & nosj & "')"
                    cmd = New OdbcCommand(str, conn)
                    cmd.ExecuteNonQuery()
                    Try
                        Dim pesan As String = "Laporan Data Service Barang | Tanggal :" & tglFormatted & vbCrLf &
                                              "-------------------------------" & vbCrLf &
                                              "No. Seri: " & noseri & vbCrLf &
                                              "Nama: " & nama & vbCrLf &
                                              "Pick: " & pick & vbCrLf &
                                              "Kondisi: " & kondisi & vbCrLf &
                                              "Status: " & sts & vbCrLf &
                                              "Keterangan: " & keter & vbCrLf &
                                              "No. SJ: " & nosj & vbCrLf &
                                              "-------------------------------" & vbCrLf
                        bot.SendTextMessageAsync(chatId, pesan).Wait()
                        conn.Close()
                    Catch ex As Exception
                        ShowError("error", ex)
                    End Try
                    'update ke database tbl_dat_dc dan AUP
                    Try
                        konek()
                        Dim u1 As String
                        Dim u2 As String
                        u1 = "UPDATE tbl_dat_dc SET status = '" & sts & "',lokasi = '" & lokasi & "',alasan = '" & keter & "' WHERE noseri = '" & noseri & "'"
                        cmd = New OdbcCommand(u1, conn)
                        cmd.ExecuteNonQuery()

                        u2 = "UPDATE tbl_dat_aup SET status = '" & sts & "',lokasi = '" & lokasi & "',alasan = '" & keter & "' WHERE noseri = '" & noseri & "'"

                        cmd = New OdbcCommand(u2, conn)
                        cmd.ExecuteNonQuery()
                        conn.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        FrmTService.Close()
                    End Try
                Catch ex As Exception
                    ShowError("error", ex)
                End Try
            End If

        Next
        MsgBox("Berhasil simpan service data", MsgBoxStyle.Information)
        CETAKSJ()
        kodeotomatis()
        conn.Close()
        Try
            konek()
            Dim deltmp As String = "delete from tmp_service"
            cmd = New OdbcCommand(deltmp, conn)
            cmd.ExecuteNonQuery()
            tmpservice()
            tmpservicelist()
        Catch ex As Exception
            ShowError("error", ex)
        End Try
        conn.Close()
    End Sub

    Sub CETAKSJ()
        konek()
        str = " select * from tbl_service where nosj='" & FrmTService.TextBox3.Text & "';"
        Try
            cmd = New OdbcCommand(str, conn)
            da.SelectCommand = cmd
            da.Fill(FrmcetakSJservice.DataSet1.tbl_service)
            FrmcetakSJservice.Show()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Sub repCETAKSJ()
        konek()
        str = " select * from tbl_service where nosj='" & FrmRepsjservice.MetroComboBox1.Text & "';"
        Try
            cmd = New OdbcCommand(str, conn)
            da.SelectCommand = cmd
            da.Fill(FrmcetakSJservice.DataSet1.tbl_service)
            FrmcetakSJservice.Show()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        conn.Close()
    End Sub
    Sub repcetaksjp3at()
        konek()
        str = " select * from tbl_p3at where nop3at='" & FrmRepsjservice.MetroComboBox2.Text & "';"
        Try
            cmd = New OdbcCommand(str, conn)
            da.SelectCommand = cmd
            da.Fill(FrmCetaksjp3at.DataSet1.tbl_p3at)
            FrmCetaksjp3at.Show()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        conn.Close()
    End Sub
    Public Sub ShowError(ByVal str As String, ByVal err As Exception)
        MessageBox.Show(String.Concat(New String() {str, ChrW(13) & ChrW(10) & ChrW(13) & ChrW(10) & "Error Prog :", err.Message, ChrW(13) & ChrW(10) & "From : ", err.Source, ChrW(13) & ChrW(10) & "Trace : ", err.StackTrace}), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Dim writer As New StreamWriter((Application.StartupPath & "\ErrorLog.TXT"), True)
        writer.WriteLine(("#Error Tgl: " & Strings.Format(DateAndTime.Now, "dd-MM-yyyy HH:mm:ss")))
        writer.WriteLine(("   Error Prog  : " & err.Message))
        writer.WriteLine(("   Error From  : " & err.Source))
        writer.WriteLine(("   Error Trace : " & err.StackTrace))
        writer.Close()
    End Sub
End Module
