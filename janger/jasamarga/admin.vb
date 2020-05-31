Imports System.Data.Odbc
Imports MySql.Data

Public Class admin

    Sub tampil()
        Try
            Dim dt As DataTable
            da = New OdbcDataAdapter("select kode, nama, username,password,status from user", conn)
            dt = New DataTable
            da.Fill(dt)
            DGV.DataSource = dt
            DGV.Columns(3).Visible = False
            DGV.Columns(0).Width = 250
            DGV.Columns(1).Width = 250
            DGV.Columns(2).Width = 150
            DGV.Columns(4).Width = 150

        Catch ex As Exception
            MsgBox("Kesalahan koneksi harap periksa dan ulangi kembali.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Sub bersih()
        t_nama.Text = ""
        pass.Text = ""
        username.Text = ""
    End Sub

    Sub nomorOtomatis()
        Try
            cmd = New OdbcCommand("Select * from user where kode in (select max(kode) from user) order by kode desc", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                T_Id_admin.Text = Format(Now, "yyMMdd") + "0001"
            Else
                If Microsoft.VisualBasic.Left(dr.GetString(0), 6) <> Format(Now, "yyMMdd") Then
                    T_Id_admin.Text = Format(Now, "yyMMdd") + "0001"
                Else
                    T_Id_admin.Text = dr.GetString(0) + 1
                End If
            End If
        Catch ex As Exception
            MsgBox("Kesalahan koneksi harap periksa dan ulangi kembali.", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Sub simdit()
        Try
            If T_Id_admin.Text = "" Or pass.Text = "" Then
                MsgBox("Lengkapi Data")
                Exit Sub
            Else
                cmd = New OdbcCommand("select * from user where kode ='" & T_Id_admin.Text & "'", conn)
                dr = cmd.ExecuteReader
                dr.Read()
                If Not dr.HasRows Then
                    Dim Simpan As String = ("insert into user (kode,nama,username,password,status) " _
                                          + " VALUES (?,?,?,?,?)")
                    cmd = New OdbcCommand(Simpan, conn)
                    With cmd.Parameters
                        .Add("?", OdbcType.VarChar).Value = T_Id_admin.Text.Trim
                        .Add("?", OdbcType.VarChar).Value = t_nama.Text.Trim
                        .Add("?", OdbcType.VarChar).Value = username.Text.Trim
                        .Add("?", OdbcType.VarChar).Value = pass.Text.Trim
                        .Add("?", OdbcType.VarChar).Value = cmbstatus.Text.Trim
                    End With

                    cmd.ExecuteNonQuery()
                    cmd = Nothing
                    MsgBox("Data Telah Disimpan")
                    Call bersih()
                    Call tampil()
                    nomorOtomatis()
                Else
                    Dim sqledit As String = "Update user set " & _
                                            "nama='" & t_nama.Text & "', " & _
                                            "username='" & username.Text & "', " & _
                                            " password = '" & pass.Text & "'," & _
                                            " status = '" & cmbstatus.Text & "'," & _
                                            " where kode = '" & T_Id_admin.Text & "'"
                    cmd = New OdbcCommand(sqledit, conn)
                    cmd.ExecuteNonQuery()
                    Call bersih()
                    Call tampil()
                    nomorOtomatis()
                End If
            End If
        Catch ex As Exception
            MsgBox("Kesalahan koneksi harap periksa dan ulangi kembali.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Sub AturKolomBarang()
        DGV.Columns(0).Width = 200
        DGV.Columns(1).Width = 150
        DGV.Columns(2).Width = 150
        DGV.Columns(3).Width = 150
        DGV.Columns(3).Visible = False
    End Sub

    Sub hapush()
        Try
            If T_Id_admin.Text = "" Then
                MsgBox("Kode user harap di isi.!", MsgBoxStyle.Critical, "Hapus")
                T_Id_admin.Focus()
                Exit Sub
            Else
                cmd = New OdbcCommand("select * from user where kode ='" & T_Id_admin.Text & "'", conn)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    If MessageBox.Show("Yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                        cmd = New OdbcCommand("Delete from user where kode='" & T_Id_admin.Text & "'", conn)
                        cmd.ExecuteNonQuery()
                        Call bersih()
                        Call tampil()
                        Call nomorOtomatis()
                        t_nama.Focus()
                    Else
                        Call bersih()
                        Call tampil()
                        Call nomorOtomatis()
                        t_nama.Focus()
                    End If
                Else
                    MsgBox("Kode user tidak terdaftar, harap pilih data yang akan dihapus.!", MsgBoxStyle.Critical, "Hapus")
                End If
            End If
        Catch ex As Exception
            MsgBox("Kesalahan koneksi harap periksa dan ulangi kembali.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Sub kunci()
        T_Id_admin.Enabled = False
    End Sub

    Sub carinama()
        Try
            cmd = New OdbcCommand("select* from user where nama like '%" & cari_nama.Text & "%'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                da = New OdbcDataAdapter("select * from user where nama like'%" & cari_nama.Text & "%'", conn)
                ds = New DataSet
                da.Fill(ds, "cari")
                DGV.DataSource = ds.Tables("cari")
                DGV.ReadOnly = True
            End If
        Catch ex As Exception
            MsgBox("Kesalahan koneksi harap periksa dan ulangi kembali.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Sub cari()
        Try
            cmd = New OdbcCommand("select* from user where nama like '%" & cari_nama.Text & "%'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                da = New OdbcDataAdapter("select * from user where nama like'%" & cari_nama.Text & "%'", conn)
                ds = New DataSet
                da.Fill(ds, "cari")
                DGV.DataSource = ds.Tables("cari")
                DGV.ReadOnly = True
            End If
        Catch ex As Exception
            MsgBox("Kesalahan koneksi harap periksa dan ulangi kembali.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer3.Start()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        hapush()
    End Sub

    Private Sub T_Id_admin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles T_Id_admin.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ToolStripTextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cari_nama.Click
        cari()
    End Sub

    Private Sub admin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call bersih()
        Call tampil()
        Call nomorOtomatis()
        Call kunci()
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            pass.PasswordChar = ""
        Else
            pass.PasswordChar = "*"
        End If
    End Sub

    Private Sub DGV_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellClick
        Try
            T_Id_admin.Text = DGV.Item(0, e.RowIndex).Value
            t_nama.Text = DGV.Item(1, e.RowIndex).Value
            username.Text = DGV.Item(2, e.RowIndex).Value
            pass.Text = DGV.Item(3, e.RowIndex).Value
            cmbstatus.Text = DGV.Item(4, e.RowIndex).Value
        Catch ex As Exception
            MsgBox("Hanya klik 2 kali", MsgBoxStyle.Exclamation, "Klik")
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        carinama()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Tool_waktu.Text = TimeOfDay
        Timer1.Start()
    End Sub

    Private Sub ToolStripProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tspb1.Click
        If Button1.Visible = True Then
            ToolStripButton1.Visible = True
        End If
        tspb1.PerformStep()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Tool_tanggal.Text = Format(Now, "dd-MMMM-yyyy")
        Timer2.Start()
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        tspb1.Increment(10)
        If tspb1.Value = 100 Then
            Timer3.Stop()
            Call simdit()
            Call bersih()
            Call AturKolomBarang()
            Call tampil()
            Call nomorOtomatis()
            tspb1.Value = 0
            'MsgBox("Data telah disimpan.. !!", MsgBoxStyle.Information, "Simpan")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        bersih()
        nomorOtomatis()
    End Sub

    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub
End Class