Imports System.Data
Imports System.Data.Odbc
Imports System.Data.SqlClient
'Imports MySql.Data.MySqlClient
'Imports MySql.Data.MySqlClient.MySqlConnection
Imports System.Drawing.Image
Imports System.IO


Public Class Form_koridor

    Dim a As New OpenFileDialog
    Dim operan As Integer
    Dim ms As MemoryStream = New MemoryStream
    Private pathFile As String = Nothing

    Sub butsimpan()
        Button3.Enabled = True
        Button4.Enabled = False
        Label18.Visible = False
        Label17.Visible = False
    End Sub

    Sub bersih()
        TNama.Text = ""
        TMk.Text = ""
        TKet.Text = ""
        CmbJalur.Text = ""
        CmbJenis.Text = ""
        CmbKM.Text = ""
        CmbLokasi.Text = ""
        TUkuran1.Text = ""
        TUkuran2.Text = ""
        PictureBox1.Image = Nothing
        TextBox8.Text = ""
        TextBox2.Visible = False
        TextBox3.Visible = False
        TkM.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Label17.Visible = False
        Label18.Visible = False
        no_oto()
        TNama.Focus()
    End Sub

    Sub tamjal()
        CmbJalur.Items.Clear()
        cmd = New OdbcCommand("select  jalur from coridor order by jalur asc", conn)
        dr = cmd.ExecuteReader
        While dr.Read
            CmbJalur.Items.Add(dr.GetString(0))
        End While
    End Sub

    Sub tamjen()
        CmbJenis.Items.Clear()
        cmd = New OdbcCommand("Select  jenis from coridor group by jenis asc", conn)
        dr = cmd.ExecuteReader
        While dr.Read
            CmbJenis.Items.Add(dr.GetString(0))
        End While
    End Sub

    Sub tamlok()
        CmbLokasi.Items.Clear()
        cmd = New OdbcCommand("select  lokasi from coridor order by lokasi asc", conn)
        dr = cmd.ExecuteReader
        While dr.Read
            CmbLokasi.Items.Add(dr.GetString(0))
        End While
    End Sub

    Sub butedit()
        Button3.Enabled = False
        Button4.Enabled = True
        Label17.Visible = True
        Label18.Visible = True
        TextBox2.Visible = True
        TextBox3.Visible = True
    End Sub

    Sub browsee()
        On Error Resume Next
        OpenFileDialog1.Filter = "JPG Files(*.jpg)|*.jpg|JPEG Files(*.jpeg)|*.jpeg|GIF Files(*.gif)|*.gif|PNG Files(*.png)|*.png|BMP Files(*.bmp)|*.bmp|TIFF Files(*.tiff)|*.tiff|All Files(*.*)|*.*"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox1.Image = New Bitmap(OpenFileDialog1.FileName)
            'btn_upload.Enabled = True
            pathFile = OpenFileDialog1.FileName
            'Label15.Text = pathFile.Substring(pathFile.LastIndexOf("\") + 1)
            TextBox8.Text = OpenFileDialog1.FileName
            PictureBox1.Image = Image.FromFile(TextBox8.Text)
        End If
    End Sub

    Sub updatedata()
        Try
            If txt_no.Text = "" Or TNama.Text = "" Or CmbKM.Text = "" Or TkM.Text = "" Or CmbJalur.Text = "" Or CmbJenis.Text = "" Or
                TUkuran1.Text = "" Or TUkuran2.Text = "" Then
                MsgBox("Lengkapi Data")
                Exit Sub
                no_oto()
            Else
                Dim i As Short
                Using cmd As New OdbcCommand("Update coridor set nama_perush = '" & TNama.Text & "', km = '" & CmbKM.Text & " " & Label3.Text & " " & TkM.Text & "'," & _
                                             " jalur = '" & CmbJalur.Text & "',lokasi = '" & CmbLokasi.Text & "',  jenis = '" & CmbJenis.Text & "', " & _
                                                " ukuran = '" & TUkuran1.Text & " " & Label9.Text & " " & TUkuran2.Text & "', " & _
                                                " mk = '" & TMk.Text & "', start_kontrak = '" & DateTimePicker1.Value.ToString("yyyy/MM/dd") & "'," & _
                                                " end_kontrak = '" & DateTimePicker2.Value.ToString("yyyy/MM/dd") & "'," & _
                                                    " ket = '" & TKet.Text & "', gambar = ? where no = '" & txt_no.Text & "'", conn)

                    cmd.Parameters.Add("?", OdbcType.VarChar).Value = TextBox8.Text.Trim
                    i = cmd.ExecuteNonQuery()
                    If (i > 0) Then
                        MsgBox("Data telah terupdate !!", MsgBoxStyle.Information, "Update")
                    End If
                    Call bersih()
                    Call tampil()
                    TextBox2.Visible = False
                    TextBox3.Visible = False
                    no_oto()
                End Using
            End If
        Catch ex As Exception
            MsgBox("Kesalahan koneksi harap periksa dan ulangi kembali.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Sub delet()
        Try
            If txt_no.Text = "" Then
                MsgBox("Isi kode nomer terlebih dahulu")
                txt_no.Focus()
                Exit Sub
            Else
                If MessageBox.Show("Yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    cmd = New OdbcCommand("Delete from coridor where no='" & txt_no.Text & "'", conn)
                    cmd.ExecuteNonQuery()
                    Call bersih()
                    Call tampil()
                    no_oto()
                Else
                    Call bersih()
                    no_oto()
                End If
            End If
        Catch ex As Exception
            MsgBox("Kesalahan koneksi harap periksa dan ulangi kembali.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Sub simpandata()
        Try
            If txt_no.Text = "" Or TNama.Text = "" Or CmbKM.Text = "" Or TkM.Text = "" Or CmbJalur.Text = "" Or CmbJenis.Text = "" Or
                TUkuran1.Text = "" Or TUkuran2.Text = "" Then
                MsgBox("Lengkapi Data")
                Exit Sub
                no_oto()
            Else

                Dim Simpan As String = ("insert into coridor(no,nama_perush,km,jalur,lokasi,jenis, " _
                                       + " ukuran,mk,start_kontrak,end_kontrak,ket,gambar,tanggal) " _
                                      + " VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?)")
                cmd = New OdbcCommand(Simpan, conn)
                With cmd.Parameters
                    .Add("?", OdbcType.VarChar).Value = txt_no.Text.Trim
                    .Add("?", OdbcType.VarChar).Value = TNama.Text.Trim
                    .Add("?", OdbcType.VarChar).Value = CmbKM.Text + Label3.Text + TkM.Text
                    .Add("?", OdbcType.VarChar).Value = CmbJalur.Text.Trim
                    .Add("?", OdbcType.VarChar).Value = CmbLokasi.Text.Trim
                    .Add("?", OdbcType.VarChar).Value = CmbJenis.Text.Trim
                    .Add("?", OdbcType.VarChar).Value = TUkuran1.Text + Label9.Text + TUkuran2.Text
                    .Add("?", OdbcType.VarChar).Value = TMk.Text.Trim
                    .Add("?", OdbcType.Date).Value = DateTimePicker1.Value.ToString("yyyy/MM/dd").Trim
                    .Add("?", OdbcType.Date).Value = DateTimePicker2.Value.ToString("yyyy/MM/dd").Trim
                    .Add("?", OdbcType.Char).Value = TKet.Text.Trim
                    .Add("?", OdbcType.VarChar).Value = TextBox8.Text.Trim
                    .Add("?", OdbcType.Date).Value = Textbox1.Text.Trim
                End With
                cmd.ExecuteNonQuery()
                cmd = Nothing
                MsgBox("Data Telah Disimpan")
                Call bersih()
                Call tampil()
                no_oto()
            End If
        Catch ex As Exception
            MsgBox("Kesalahan koneksi harap periksa dan ulangi kembali.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Sub operasi()
        tspb.Increment(20)
        If tspb.Value = 100 Then
            If operan = 1 Then
                Timer3.Stop()
                simpandata()
                no_oto()
            ElseIf operan = 2 Then
                Timer3.Stop()
                updatedata()
            ElseIf operan = 3 Then
                Timer3.Stop()
                delet()
            ElseIf operan = 4 Then
                Timer3.Stop()
                tampil()
                Caricoridor.Show()
            End If
            tspb.Value = 0
        End if 
    End Sub

    Sub no_otomatis()
        Try
            cmd = New OdbcCommand("select * from coridor where no in (select max(no)from coridor) order by no desc", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                txt_no.Text = Format(Now, "yyMMdd") + "0001"
            Else
                If Microsoft.VisualBasic.Left(dr.GetString(0), 6) <> Format(Now, "yyMMdd") Then
                    txt_no.Text = Format(Now, "yyMMdd") + "0001"
                Else
                    txt_no.Text = dr.GetString(0) + 1
                End If
            End If
        Catch ex As Exception
            MsgBox("Kesalahan koneksi harap periksa dan ulangi kembali.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Sub edit()
        Try
            cmd = New OdbcCommand("SELECT * FROM coridor where no = '" + txt_no.Text + "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                'txt_no.Text = dr.Item("")
                TNama.Text = dr.Item("nama_perush")
                TextBox2.Text = dr.Item("km")
                CmbJalur.Text = dr.Item("jalur")
                CmbLokasi.Text = dr.Item("lokasi")
                CmbJenis.Text = dr.Item("jenis")
                TextBox3.Text = dr.Item("ukuran")
                'TUkuran2.Text = dr.Item("ukuran")
                TMk.Text = dr.Item("mk")
                DateTimePicker1.Text = dr.Item("start_kontrak")
                DateTimePicker2.Text = dr.Item("end_kontrak")
                TKet.Text = dr.Item("ket")
                PictureBox1.ImageLocation = dr.Item("gambar")
                TextBox8.Text = dr.Item("gambar")
            End If
        Catch ex As Exception
            MsgBox("Kesalahan koneksi harap periksa dan ulangi kembali.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Sub no_oto()
        Try
            cmd = New OdbcCommand("Select * from coridor where no in (select max(no) from coridor) order by no desc", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                txt_no.Text = Format(Now, "yyMMdd") + "0001"
            Else
                If Microsoft.VisualBasic.Left(dr.GetString(0), 6) <> Format(Now, "yyMMdd") Then
                    txt_no.Text = Format(Now, "yyMMdd") + "0001"
                Else
                    txt_no.Text = dr.GetString(0) + 1
                End If
            End If
        Catch ex As Exception
            MsgBox("Kesalahan koneksi harap periksa dan ulangi kembali.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Sub tampil()
        Dim dt As DataTable
        Try
            da = New OdbcDataAdapter("select * from coridor", conn)
            dt = New DataTable
            da.Fill(dt)
            Caricoridor.dg.DataSource = dt

            Caricoridor.dg.Columns(0).HeaderText = "No"
            Caricoridor.dg.Columns(1).HeaderText = "Nama Perusahaan"
            Caricoridor.dg.Columns(2).HeaderText = "Kilo Meter"
            Caricoridor.dg.Columns(3).HeaderText = "Jalur"
            Caricoridor.dg.Columns(4).HeaderText = "Lokasi"
            Caricoridor.dg.Columns(5).HeaderText = "Jenis"
            Caricoridor.dg.Columns(6).HeaderText = "Ukuran"
            Caricoridor.dg.Columns(7).HeaderText = "MK"
            Caricoridor.dg.Columns(8).HeaderText = "Start Kontrak"
            Caricoridor.dg.Columns(9).HeaderText = "End Kontrak"
            Caricoridor.dg.Columns(10).HeaderText = "Keterangan"
            Caricoridor.dg.Columns(11).HeaderText = "Gambar"
            Caricoridor.dg.Columns(12).HeaderText = "Tanggal"

            Caricoridor.dg.BorderStyle = AutoSize

        Catch ex As Exception
            MsgBox("Kesalahan koneksi harap periksa dan ulangi kembali.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Timer3.Start()
        operan = 1
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        browsee()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Dim year1 As Date
        Dim tgl2 As Date
        Dim selisih As Date
        year1 = Me.DateTimePicker1.Value
        tgl2 = Me.DateTimePicker2.Value
        selisih = year1.AddYears(1)
        Me.DateTimePicker2.Text = selisih
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Timer3.Start()
        operan = 3
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Textbox1.Text = Format(Now, "dd-MMMM-yyyy")
        Timer1.Start()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Timer3.Start()
        operan = 2
    End Sub

    Private Sub Tno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tno.Click
        Timer3.Start()
        operan = 4
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        bersih()
        no_oto()
        butsimpan()
        tamjal()
        tamjen()
        tamlok()
    End Sub

    Private Sub txt_no_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_no.KeyPress, CmbKM.KeyPress,
        TkM.KeyPress, TUkuran1.KeyPress, TUkuran2.KeyPress, TMk.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack Or e.KeyChar = Chr(46)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub coridor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        butsimpan()
        koneksi()
        Timer1.Start()
        Timer2.Start()
        bersih()
        Call no_oto()
        Call tampil()
        butsimpan()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        tool_waktu.Text = TimeOfDay
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        help_koridor.MdiParent = RUMAH
        help_koridor.Show()
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        operasi()
    End Sub

    Private Sub CmbLokasi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbLokasi.SelectedIndexChanged

    End Sub
End Class