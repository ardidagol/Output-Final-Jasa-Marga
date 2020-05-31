Imports System.Data.Odbc
Public Class log_in

    Sub masuk()
        Try
            koneksi()
            Dim sql, pass, user As String
            user = T_user.Text
            pass = T_pass.Text
            sql = "SELECT * FROM user WHERE username='" + user + "' AND password='" + pass + "'"
            cmd = New Odbc.OdbcCommand(sql, conn)
            dr = cmd.ExecuteReader()
            dr.Read()
            If dr.HasRows = True Then
                RUMAH.Show()
                Me.Hide()
            Else
                MessageBox.Show("Kombinasi Username dan Password Salah", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                T_user.Focus()
            End If
            T_user.Text = ""
            T_pass.Text = ""
        Catch ex As Exception
            MsgBox("Kesalahan koneksi harap periksa dan ulangi kembali.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        koneksi()
        cmd = New OdbcCommand("select * from user where username='" & T_user.Text & "' and password='" & T_pass.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Me.Visible = False
            RUMAH.Show()
            RUMAH.id.Text = dr.GetString(1) 'Muncul di menu utama adalah id pegawai
            RUMAH.nama.Text = dr.GetString(2) 'Muncul di menu utama adalah nama pegawai
            RUMAH.status.Text = dr.GetString(4) 'Muncul di menu utama adalah status pegawai
            If RUMAH.status.Text <> "Administrator" Then 'panel3 adalah status pegawai, jika yang me-login bukan BERSTATUS ADMIN maka akan ada fitur yang tertutup/dibatasi.
                RUMAH.btnpengguna.Enabled = False
                RUMAH.btnuser.Enabled = False
                RUMAH.btnlaporanmaster.Enabled = False
                RUMAH.btnlaporandata.Enabled = False
            Else
                RUMAH.btnpengguna.Enabled = True
                RUMAH.btnuser.Enabled = True
                '   RUMAH.pegawaiToolStripMenuItem.Enabled = True
            End If
        Else
            MsgBox("login salah, periksan kembali user name dan password")
            T_user.Focus()
        End If
    End Sub

    Private Sub log_in_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        T_user.Focus()
    End Sub

    Private Sub T_pass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles T_pass.KeyPress
        If Not T_pass.Text = "" Then
            If e.KeyChar = Chr(13) Then
                Me.Button1.Focus()
                Me.Button1.BackColor = Color.Blue
            End If
        End If
    End Sub

    Private Sub T_user_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles T_user.KeyPress
        If Not T_user.Text = "" Then
            If e.KeyChar = Chr(13) Then
                Me.T_pass.Focus()
            End If
        End If
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        help.Show()
    End Sub
End Class