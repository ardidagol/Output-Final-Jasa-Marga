Public Class help_koridor

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_detail.Click
        detail_save.Visible = True
        detail_picsave.Visible = True
        PictureBox2.Visible = True
    End Sub
End Class