Imports System.Data
Imports MySql.Data
Imports System.Data.Odbc
Imports CrystalDecisions.Shared.CrystalReportsException
Public Class laporan_master

    Sub tampil_jalur()
        Cmb_sortJalur.Items.Clear()
        cmd = New OdbcCommand("select distinct jalur from coridor order by jalur asc", conn)
        dr = cmd.ExecuteReader
        While dr.Read
            Cmb_sortJalur.Items.Add(dr.GetString(0))
        End While
    End Sub
  
    Sub tampil_perusahaan()
        CmbPerusahaan.Items.Clear()
        cmd = New OdbcCommand("Select distinct nama_perush from coridor group by nama_perush asc", conn)
        dr = cmd.ExecuteReader
        While dr.Read
            CmbPerusahaan.Items.Add(dr.GetString(0))
        End While
    End Sub

    Sub bersih()
        Cmb_sortJalur.Text = ""
    End Sub

    Sub tampilrepotlokasi()
        If cmb_sortLokasi.Text = "" Then
            MsgBox(" Please Fill The Combobox First !! ")
        ElseIf cmb_sortLokasi.Text = "RMJ" Then
            Report_Lokasi.Cr_LokasiSORT1.SetParameterValue("LokasiA", cmb_sortLokasi.Text)
            Report_Lokasi.Show()
        ElseIf cmb_sortLokasi.Text = "RWJ" Then
            Report_Lokasi.Cr_LokasiSORT1.SetParameterValue("LokasiA", cmb_sortLokasi.Text)
            Report_Lokasi.Show()
        ElseIf cmb_sortLokasi.Text = "OB" Then
            Report_Lokasi.Cr_LokasiSORT1.SetParameterValue("LokasiA", cmb_sortLokasi.Text)
            Report_Lokasi.Show()
        ElseIf cmb_sortLokasi.Text = "JPO" Then
            Report_Lokasi.Cr_LokasiSORT1.SetParameterValue("LokasiA", cmb_sortLokasi.Text)
            Report_Lokasi.Show()
            Call bersih()
            Call tampil_lokasi()
        End If
    End Sub

    Sub tampil_lokasi()
        cmb_sortLokasi.Items.Clear()
        cmd = New OdbcCommand("select distinct lokasi from coridor order by lokasi asc", conn)
        dr = cmd.ExecuteReader
        While dr.Read
            cmb_sortLokasi.Items.Add(dr.GetString(0))
        End While
    End Sub

    Sub tampilrepotjalur()
        If Cmb_sortJalur.Text = "" Then
            MsgBox(" Please Fill The Combobox First !! ")
        ElseIf Cmb_sortJalur.Text = "A" Then
            Laporan_Sort_Jalur.CR_SortJalur1.SetParameterValue("JalurA", Cmb_sortJalur.Text)
            Laporan_Sort_Jalur.Show()
        ElseIf Cmb_sortJalur.Text = "A1" Then
            Laporan_Sort_Jalur.CR_SortJalur1.SetParameterValue("JalurA", Cmb_sortJalur.Text)
            Laporan_Sort_Jalur.Show()
        ElseIf Cmb_sortJalur.Text = "A2" Then
            Laporan_Sort_Jalur.CR_SortJalur1.SetParameterValue("JalurA", Cmb_sortJalur.Text)
            Laporan_Sort_Jalur.Show()
        ElseIf Cmb_sortJalur.Text = "AB" Then
            Laporan_Sort_Jalur.CR_SortJalur1.SetParameterValue("JalurA", Cmb_sortJalur.Text)
            Laporan_Sort_Jalur.Show()
        ElseIf Cmb_sortJalur.Text = "B" Then
            Laporan_Sort_Jalur.CR_SortJalur1.SetParameterValue("JalurA", Cmb_sortJalur.Text)
            Laporan_Sort_Jalur.Show()
        ElseIf Cmb_sortJalur.Text = "MH T" Then
            Laporan_Sort_Jalur.CR_SortJalur1.SetParameterValue("JalurA", Cmb_sortJalur.Text)
            Laporan_Sort_Jalur.Show()
            Call bersih()
            Call tampil_jalur()
        End If
    End Sub

    Sub cleardat()
        Cmb_sortJalur.Text = ""
        cmb_sortLokasi.Text = ""
        CmbPerusahaan.Text = ""
    End Sub

    Private Sub btn_master_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_master.Click
        master_laporan.Show()
        cleardat()
    End Sub

    Private Sub btn_periodik_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_periodik.Click
        Report_bulanan.Show()
        cleardat()
    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        RUMAH.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Cmb_sortJalur.Text = "" Then
            MsgBox(" Please Fill The Combobox First !! ")
        ElseIf Cmb_sortJalur.Text = Cmb_sortJalur.Text Then
            Laporan_Sort_Jalur.CR_SortJalur1.SetParameterValue("JalurA", Cmb_sortJalur.Text)
            Laporan_Sort_Jalur.Show()
        End If
        cleardat()
    End Sub

    Private Sub laporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        Call tampil_jalur()
        Call tampil_lokasi()
        Call tampil_perusahaan()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If cmb_sortLokasi.Text = "" Then
            MsgBox(" Please Fill The Combobox First !! ")
        ElseIf cmb_sortLokasi.Text = cmb_sortLokasi.Text Then
            Report_Lokasi.Cr_LokasiSORT1.SetParameterValue("LokasiA", cmb_sortLokasi.Text)
            Report_Lokasi.Show()
        End If
        cleardat()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Laporan_nama.CrNamaPerushan1.SetParameterValue("para_nama", CmbPerusahaan.Text)
        Laporan_nama.Show()
        cleardat()
    End Sub

    Private Sub CmbPerusahaan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbPerusahaan.KeyPress
        If e.KeyChar = Chr(13) Then
            cmd = New OdbcCommand("select nama_perush from coridor where nama_perush like '%" & CmbPerusahaan.Text & "%' ", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                CmbPerusahaan.Text = dr.Item("nama_perush")
            End If
        End If
    End Sub

    Private Sub Cmb_sortJalur_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_sortJalur.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class