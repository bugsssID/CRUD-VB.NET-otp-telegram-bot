Imports System.Data.Odbc
Public Class Frmstatusbarang
    Private Sub Frmstatusbarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            konek()
            Dim data As String = " SELECT kategori, noseri, keter, tanggaljam, pick, kondisi,lokasi, status, penjelasan,nosj,tglselesai,pick_ga FROM tbl_service where status='P3AT' ORDER BY noseri DESC;"
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
                    .Rows.Add(dt.Rows(i)("kategori"), dt.Rows(i)("noseri"), dt.Rows(i)("keter"), dt.Rows(i)("tanggaljam"), dt.Rows(i)("pick"), dt.Rows(i)("kondisi"), dt.Rows(i)("lokasi"), dt.Rows(i)("status"), dt.Rows(i)("penjelasan"), dt.Rows(i)("nosj"), dt.Rows(i)("tglselesai"), dt.Rows(i)("pick_ga"))
                End With
            Next
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class