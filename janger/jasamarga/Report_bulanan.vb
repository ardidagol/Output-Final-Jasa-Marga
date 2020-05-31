Imports System.Data.Odbc

Public Class Report_bulanan
    Sub tampil_km()
        cmbkm.Items.Clear()
        cmbkm2.Items.Clear()
        cmd = New OdbcCommand("select distinct km from coridor order by km asc", conn)
        dr = cmd.ExecuteReader
        While dr.Read
            cmbkm.Items.Add(dr.GetString(0))
            cmbkm2.Items.Add(dr.GetString(0))
        End While
    End Sub
    Private Sub Mounthly_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tanggal()
        Call tampil_km()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CRV.SelectionFormula = "month ({coridor1.start_kontrak}) = (" & Month(DateTimePicker1.Text) & ") and year ({coridor1.start_kontrak}) = ( " & Year(DateTimePicker1.Text) & ") "
        CRV.ReportSource = "Laporan_bulananED.rpt"
        CRV.RefreshReport()

    End Sub
    Sub tanggal()
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        cmd = New OdbcCommand("select distinct tanggal from coridor", conn)
        dr = cmd.ExecuteReader
        While dr.Read
            ComboBox1.Items.Add(dr.GetString(0))
            ComboBox2.Items.Add(dr.GetString(0))
            ComboBox3.Items.Add(dr.GetString(0))

        End While
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        CRV.SelectionFormula = " ({coridor1.tanggal}) in date('" & ComboBox1.Text & "') to date ('" & ComboBox1.Text & "')"
        CRV.ReportSource = "CR_Harian.rpt"
        CRV.RefreshReport()



        ' If ComboBox1.Text = "" Then
        'MsgBox(" Please Fill The Combobox First !! ")
        'Else
        'laporan_harian.CRCoba1.SetParameterValue("MyPara", ComboBox1.Text)
        'CRV.ReportSource = "CRCoba.rpt"
        'CRV.RefreshReport()
        'laporan_harian.Show()
        'laporan_harian.CRCoba1.SetParameterValue("MyPara", ComboBox1.Text)
        'laporan_harian.Show()

        'End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CRV.SelectionFormula = " ({coridor1.tanggal}) in date ('" & ComboBox2.Text & "') to date ('" & ComboBox3.Text & "')"
        CRV.ReportSource = "CR_bulanan.rpt"
        CRV.RefreshReport()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        CRV.SelectionFormula = "({coridor1.km}) in ('" & cmbkm.Text & "') to ('" & cmbkm2.Text & "')"
        CRV.ReportSource = "CR.rpt"
        CRV.RefreshReport()
    End Sub
End Class