Imports System
Imports System.Data.Odbc
Imports Telegram
Imports Telegram.Bot
Imports Telegram.Bot.Types
Imports System.Security.Cryptography
Imports System.Threading

Public Class Frmlogin
    Dim botToken As String = "987124141:AAGPl6_WDnM-6pumltQib0gelAUb_6wVoDI"
    Dim bot As New TelegramBotClient(botToken)
    Public otp As String
    Function GenerateOTP() As String
        Dim rng As New RNGCryptoServiceProvider()
        Dim buf(4) As Byte
        rng.GetBytes(buf)
        Return BitConverter.ToInt32(buf, 0).ToString().Substring(1, 4)
    End Function
    Private Async Sub MetroTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles MetroTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                konek()
                Dim str As String = "SELECT * FROM user_dc WHERE username = '" & MetroTextBox1.Text & "'"
                cmd = New OdbcCommand(str, conn)
                dr = cmd.ExecuteReader()

                If dr.HasRows = 0 Then
                    dr.Close()
                    MessageBox.Show("Login gagal, username atau Password salah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    MetroTextBox1.Text = ""
                    MetroTextBox1.Focus()
                Else

                    otp = GenerateOTP()
                    Dim telegramId As Long = CLng(dr("telegram_id")) 'Ambil telegram_id dari basis data
                    Dim tanggalJam As String = DateTime.Now.ToString("dd MMM yyyy HH:mm")
                    Dim tanggalJam2 As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm")
                    Dim pesan As String = $"OTP Password Anda untuk akun {MetroTextBox1.Text} adalah: {otp}
                Tanggal/Jam: {tanggalJam}
                *Note: Created by bugsss*"
                    Await bot.SendTextMessageAsync(chatId:=telegramId, text:=pesan, cancellationToken:=CancellationToken.None)
                    Otplogin.ShowDialog() 'Tampilkan form OTP
                    Me.Hide()
                    'simpan waktu login ke database mysql 
                    konek()
                    Dim logsimpan As String
                    logsimpan = "Insert into user_dclog (username,logtime,logid) values ('" & MetroTextBox1.Text & "','" & tanggalJam2 & "','" & DateTime.Now.ToString("HHmmss") & "')"
                    cmd = New OdbcCommand(logsimpan, conn)
                    cmd.ExecuteNonQuery()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub Frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MetroTextBox1.Focus()
    End Sub
End Class