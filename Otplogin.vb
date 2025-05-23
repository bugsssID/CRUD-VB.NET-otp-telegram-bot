Public Class Otplogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OtpTextbox.Text = Frmlogin.otp Then
            'MsgBox("Login Berhasil, Selamat Datang " & LoginForm.UsernameTextBox.Text & " ! ", MsgBoxStyle.Information, "Successfull Login")
            Form1.Show()
            Form1.ToolStripLabel4.Text = Frmlogin.MetroTextBox1.Text
            Me.Close()
        Else
            MessageBox.Show("OTP salah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            OtpTextbox.Text = ""
            OtpTextbox.Focus()
        End If
        conn.Close()
    End Sub

    Private Sub Otplogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OtpTextbox.Focus()
    End Sub
End Class