Imports System.Data.Odbc
Imports MySql.Data

Public Class RUMAH

    Dim operan As Integer

    Sub operasi()
        If operan = "1" Then
            Perush.Close()
            laporan_master.Close()
            Caricoridor.Close()
            CariPerusha.Close()
            help_koridor.Close()
            Form_koridor.Close()
            admin.MdiParent = Me
            admin.Show()
        ElseIf operan = "2" Then
            admin.Close()
            Form_koridor.Close()
            laporan_master.Close()
            Caricoridor.Close()
            CariPerusha.Close()
            help_koridor.Close()
            Perush.MdiParent = Me
            Perush.Show()
        ElseIf operan = "3" Then
            admin.Close()
            Perush.Close()
            laporan_master.Close()
            help_koridor.Close()
            Form_koridor.MdiParent = Me
            Form_koridor.Show()
        ElseIf operan = "4" Then
            admin.Close()
            Perush.Close()
            Caricoridor.Close()
            CariPerusha.Close()
            help_koridor.Close()
            Form_koridor.Close()
            laporan_master.MdiParent = Me
            laporan_master.Show()
        ElseIf operan = "5" Then
            Perush.Close()
            laporan_master.Close()
            Caricoridor.Close()
            CariPerusha.Close()
            help_koridor.Close()
            Form_koridor.Close()
            admin.Close()
            Me.Visible = False
            log_in.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnuser.Click, btnpengguna.Click
        operan = "1"
        operasi()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click, Button6.Click
        operan = "2"
        operasi()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click, Button12.Click
        operan = "3"
        operasi()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlaporanmaster.Click
        operan = "4"
        operasi()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        operan = "5"
        operasi()
    End Sub

    Private Sub RUMAH_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
        conn.Close()
    End Sub

    Private Sub RUMAH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        waktu.Text = TimeOfDay
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        waktu.Text = TimeOfDay
        Timer1.Start()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlaporan.Click
        MsgBox("Anda Bisa Memilih Laporan yang lebih Lengkap pada Menu Bar Laporan di Pojok")
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlaporandata.Click
        Report_bulanan.ShowDialog()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Application.Exit()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        help_koridor.MdiParent = Me
        help_koridor.Show()

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        AboutBox1.MdiParent = Me
        AboutBox1.Show()
    End Sub
End Class
