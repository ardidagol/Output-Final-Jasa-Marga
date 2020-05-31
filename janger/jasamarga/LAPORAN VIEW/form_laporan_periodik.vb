Imports System.Data.Odbc
Imports MySql.Data
Imports CrystalDecisions.Shared.DocumentViewType
Imports CrystalDecisions.CrystalReports.Engine

Public Class form_laporan_periodik
    Sub tanggal()
        ComboBox1.Items.Clear()
        cmd = New OdbcCommand("select distinct tanggal from coridor", conn)
        dr = cmd.ExecuteReader
        While dr.Read
            ComboBox1.Items.Add(dr.GetString(0))

        End While
    End Sub

    Sub bulan1()
        cmb_range1.Items.Clear()
        cmd = New OdbcCommand("select distinct tanggal from coridor", conn)
        dr = cmd.ExecuteReader
        While dr.Read
            cmb_range1.Items.Add(dr.GetString(0))

        End While
    End Sub
    Sub bulan2()
        cmb_range2.Items.Clear()
        cmd = New OdbcCommand("select distinct tanggal from coridor", conn)
        dr = cmd.ExecuteReader
        While dr.Read
            cmb_range2.Items.Add(dr.GetString(0))

        End While
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        laporan_master.Show()
        Me.Hide()
    End Sub
    Sub ref()
        laporan_harian.Refresh()
    End Sub
    Sub bersih_report()
        Dim coba As New CRCoba
        Dim value As New Date

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ComboBox1.Text = "" Then
            MsgBox(" Please Fill The Combobox First !! ")
        Else
            laporan_harian.CRCoba1.SetParameterValue("MyPara", ComboBox1.Text)
            laporan_harian.Show()
            Call ref()
        End If

    End Sub

    Private Sub form_laporan_periodik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tanggal()
        'Call tampilbulan()
        'Call tampiltahun()
        Call bulan1()
        Call bulan2()


    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If cmb_range1.Text = "" Or cmb_range2.Text = "" Then
            MsgBox("Pilih Range Tanggal !!")
        Else
            laporan_periodik.Cr_bulanan1.SetParameterValue("awal", cmb_range1.Text)
            laporan_periodik.Cr_bulanan1.SetParameterValue("akhir", cmb_range2.Text)
            laporan_periodik.Show()
        End If




    End Sub

    Private Sub AxCrystalReport1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class