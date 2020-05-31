Imports System.Data.Odbc
Imports System.IO
Imports System.Drawing.Image

Public Class Perush

    Private pathFile As String = Nothing
    Dim ms As MemoryStream = New MemoryStream

    Sub browsee()
        On Error Resume Next
        OpenFileDialog1.Filter = "JPG Files(*.jpg)|*.jpg|JPEG Files(*.jpeg)|*.jpeg|GIF Files(*.gif)|*.gif|PNG Files(*.png)|*.png|BMP Files(*.bmp)|*.bmp|TIFF Files(*.tiff)|*.tiff|All Files(*.*)|*.*"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox1.Image = New Bitmap(OpenFileDialog1.FileName)
            btn_upload.Enabled = True
            pathFile = OpenFileDialog1.FileName
            'Label15.Text = pathFile.Substring(pathFile.LastIndexOf("\") + 1)
            TextBox6.Text = OpenFileDialog1.FileName
            PictureBox1.Image = Image.FromFile(TextBox6.Text)
        End If
    End Sub

    Sub bersih()
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        PictureBox1.Image = Nothing
        TextBox2.Focus()
    End Sub

    Sub butsimpan()
        Btn_update.Enabled = False
        Button2.Enabled = True
    End Sub

    Sub butedit()
        Button2.Enabled = False
        Btn_update.Enabled = True
    End Sub

    Sub nomorOtomatis()
        Try
            cmd = New OdbcCommand("Select * from perusahaan where kode_perush in (select max(kode_perush) from perusahaan) order by kode_perush desc", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                TextBox1.Text = Format(Now, "yyMMdd") + "0001"
            Else
                If Microsoft.VisualBasic.Left(dr.GetString(0), 6) <> Format(Now, "yyMMdd") Then
                    TextBox1.Text = Format(Now, "yyMMdd") + "0001"
                Else
                    TextBox1.Text = dr.GetString(0) + 1
                End If
            End If
        Catch ex As Exception
            MsgBox("Kesalahan koneksi harap periksa dan ulangi kembali.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Sub hapus()
        Try
            If TextBox1.Text = "" Then
                MsgBox("Kode perusahaan harap di isi.!", MsgBoxStyle.Critical, "Hapus")
                TextBox1.Focus()
                Exit Sub
            Else
                cmd = New OdbcCommand("select * from perusahaan where kode_perush ='" & TextBox1.Text & "'", conn)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    If MessageBox.Show("Yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                        cmd = New OdbcCommand("Delete from perusahaan where kode_perush='" & TextBox1.Text & "'", conn)
                        cmd.ExecuteNonQuery()
                        Call bersih()
                        '  Call tampil()
                        Call nomorOtomatis()
                        TextBox1.Focus()
                    Else
                        Call bersih()
                        TextBox1.Focus()
                    End If
                Else
                    MsgBox("Kode perusahaan tidak terdaftar, harap pilih data yang akan dihapus.!", MsgBoxStyle.Critical, "Hapus")
                End If
            End If
        Catch ex As Exception
            MsgBox("Kesalahan koneksi harap periksa dan ulangi kembali.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Sub simdit()
        Try
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                MsgBox("Lengkapi Data")
                Exit Sub
            Else
                Dim Simpan As String = ("insert into perusahaan (kode_perush,nama_perush,alamat,telp,email,gambar) " _
                                      + " VALUES (?,?,?,?,?,?)")
                cmd = New OdbcCommand(Simpan, conn)
                With cmd.Parameters
                    .Add("?", OdbcType.VarChar).Value = TextBox1.Text.Trim
                    .Add("?", OdbcType.VarChar).Value = TextBox2.Text.Trim
                    .Add("?", OdbcType.VarChar).Value = TextBox3.Text.Trim
                    .Add("?", OdbcType.VarChar).Value = TextBox4.Text.Trim
                    .Add("?", OdbcType.VarChar).Value = TextBox5.Text.Trim
                    .Add("?", OdbcType.VarChar).Value = TextBox6.Text.Trim
                End With
                cmd.ExecuteNonQuery()
                cmd = Nothing
                Cursor = Cursors.WaitCursor
                MsgBox("Data Telah Disimpan")
                Call bersih()
                Call nomorOtomatis()
                Cursor = Cursors.Default
            End If
        Catch ex As Exception
            MsgBox("Kesalahan koneksi harap periksa dan ulangi kembali.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Sub edit()
        Try
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                MsgBox("Lengkapi Data")
                Exit Sub
            Else
                Dim i As Short
                Using cmd As New OdbcCommand("Update perusahaan set nama_perush ='" & TextBox2.Text & "', " & _
                                        "alamat ='" & TextBox3.Text & "', telp = '" & TextBox4.Text & "'," & _
                                        "email = '" & TextBox5.Text & "', gambar = ? where kode_perush = '" & TextBox1.Text & "'", conn)

                    cmd.Parameters.Add("?", OdbcType.VarChar).Value = TextBox6.Text.Trim
                    i = cmd.ExecuteNonQuery()
                    If (i > 0) Then
                        MsgBox("Data telah terupdate !!", MsgBoxStyle.Information, "Update")
                    End If
                    Call bersih()
                    Call nomorOtomatis()
                End Using
            End If
        Catch ex As Exception
            MsgBox(ex.Message) '
            MsgBox("Kesalahan koneksi harap periksa dan ulangi kembali.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Perush_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        Timer1.Start()
        nomorOtomatis()
        bersih()
        butsimpan()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        simdit()
        nomorOtomatis()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_update.Click
        edit()
        nomorOtomatis()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_refresh.Click
        bersih()
        nomorOtomatis()
        butsimpan()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_upload.Click
        browsee()
    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_view.Click
        CariPerusha.MdiParent = RUMAH
        CariPerusha.Show()
    End Sub

    Private Sub TextBox4_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        hapus()
    End Sub

    Private Sub Button3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btn_update.MouseLeave
        Btn_update.Width = 75
        Btn_update.Height = 36
    End Sub

    Private Sub Button3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Btn_update.MouseMove
        Btn_update.Width = 80
        Btn_update.Height = 46
    End Sub

    Private Sub btn_refresh_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_refresh.MouseLeave
        btn_refresh.Width = 75
        btn_refresh.Height = 36
    End Sub

    Private Sub btn_refresh_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn_refresh.MouseMove
        btn_refresh.Width = 80
        btn_refresh.Height = 46
    End Sub

    Private Sub btn_view_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_view.MouseLeave
        btn_view.Width = 75
        btn_view.Height = 36
    End Sub

    Private Sub btn_view_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn_view.MouseMove
        btn_view.Width = 80
        btn_view.Height = 46
    End Sub

    Private Sub btn_delete_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_delete.MouseLeave
        btn_delete.Width = 75
        btn_delete.Height = 36

    End Sub

    Private Sub btn_delete_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn_delete.MouseMove
        btn_delete.Width = 80
        btn_delete.Height = 46
    End Sub
End Class