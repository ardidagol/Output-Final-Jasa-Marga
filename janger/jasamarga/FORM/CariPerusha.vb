Imports System.Data.Odbc

Public Class CariPerusha

    Sub cari()
        Try
            da = New OdbcDataAdapter("SELECT * FROM perusahaan WHERE nama_perush LIKE  '%" + TextBox1.Text + "%' ", conn)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "coridor")
            DataGridView1.DataSource = ds.Tables("coridor")
        Catch ex As Exception
            MsgBox("Kesalahan koneksi harap periksa dan ulangi kembali.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        cari()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click, DataGridView1.CellDoubleClick
        Perush.butedit()
        Try
            Dim i As Integer
            i = DataGridView1.CurrentRow.Index
            With DataGridView1.Rows.Item(i)
                Perush.TextBox1.Text = .Cells(0).Value
                Perush.TextBox2.Text = .Cells(1).Value
                Perush.TextBox3.Text = .Cells(2).Value
                Perush.TextBox4.Text = .Cells(3).Value
                Perush.TextBox5.Text = .Cells(4).Value
                Perush.TextBox6.Text = .Cells(5).Value
                Perush.PictureBox1.ImageLocation = .Cells(5).Value
                Close()
            End With
        Catch ex As Exception
            MsgBox("Kesalahan koneksi harap periksa dan ulangi kembali.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub CariPerusha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim dt As DataTable
            da = New OdbcDataAdapter("select * from perusahaan", conn)
            dt = New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
            DataGridView1.Columns(0).HeaderText = "Kode Perusahaan"
            DataGridView1.Columns(1).HeaderText = "Nama Perusahaan"
            DataGridView1.Columns(2).HeaderText = "Alamat"
            DataGridView1.Columns(3).HeaderText = "No. Telepon"
            DataGridView1.Columns(4).HeaderText = "E-mail"
            DataGridView1.Columns(5).HeaderText = "Gambar"
        Catch ex As Exception
            MsgBox("Kesalahan koneksi harap periksa dan ulangi kembali.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class