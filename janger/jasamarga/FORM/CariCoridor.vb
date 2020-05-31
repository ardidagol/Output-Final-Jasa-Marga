Imports System.Data.Odbc

Public Class Caricoridor
    Sub cari()
        Try
            da = New OdbcDataAdapter("SELECT no, nama_perush, km, jalur, lokasi, jenis, ukuran, mk, start_kontrak, " _
                                     + " end_kontrak, ket, gambar, tanggal FROM coridor WHERE  nama_perush LIKE  '%" + TextBox1.Text + "%' ", conn)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "coridor")
            dg.DataSource = ds.Tables("coridor")
        Catch ex As Exception
            MsgBox("Kesalahan koneksi harap periksa dan ulangi kembali.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Sub cari1()
        Try
            da = New OdbcDataAdapter("SELECT no, nama_perush, km, jalur, lokasi, jenis, ukuran, mk, start_kontrak, " _
                                     + " end_kontrak, ket, gambar, tanggal FROM coridor WHERE  no LIKE  '%" + TextBox3.Text + "%' ", conn)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "coridor")
            dg.DataSource = ds.Tables("coridor")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub cari2()
        Try
            da = New OdbcDataAdapter("SELECT no, nama_perush, km, jalur, lokasi, jenis, ukuran, mk, start_kontrak, " _
                                     + " end_kontrak, ket, gambar, tanggal FROM coridor WHERE  km  LIKE  '%" + TextBox2.Text + "%' ", conn)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "coridor")
            dg.DataSource = ds.Tables("coridor")
        Catch ex As Exception
            MsgBox("Kesalahan koneksi harap periksa dan ulangi kembali.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        cari()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        cari2()
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        cari1()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click, dg.CellDoubleClick
        Form_koridor.butedit()
        Try
            Dim i As Integer
            i = dg.CurrentRow.Index
            With dg.Rows.Item(i)
                Form_koridor.txt_no.Text = .Cells(0).Value
                Form_koridor.TNama.Text = .Cells(1).Value
                Form_koridor.TextBox2.Text = .Cells(2).Value
                Form_koridor.CmbJalur.Text = .Cells(3).Value
                Form_koridor.CmbLokasi.Text = .Cells(4).Value
                Form_koridor.CmbJenis.Text = .Cells(5).Value
                Form_koridor.TextBox3.Text = .Cells(6).Value
                Form_koridor.TMk.Text = .Cells(7).Value
                Form_koridor.DateTimePicker1.Text = .Cells(8).Value
                Form_koridor.DateTimePicker2.Text = .Cells(9).Value
                Form_koridor.TKet.Text = .Cells(10).Value
                Form_koridor.PictureBox1.ImageLocation = .Cells(11).Value
                'koridor.TextBox8.Text = .Cells(13).Value
                Close()
            End With
        Catch ex As Exception
            MsgBox("Kesalahan koneksi harap periksa dan ulangi kembali.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class