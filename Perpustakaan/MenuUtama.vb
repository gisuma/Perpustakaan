Public Class MenuUtama
    Sub Terkunci()
        LoginToolStripMenuItem.Visible = True
        LogoutToolStripMenuItem.Visible = False
        KeluearToolStripMenuItem.Visible = True
        MasterToolStripMenuItem.Visible = False
        PetugasToolStripMenuItem.Visible = False
        AnggotaToolStripMenuItem.Visible = False
        BukuToolStripMenuItem.Visible = False
        TransaksiToolStripMenuItem.Visible = False
        PeminjamanToolStripMenuItem.Visible = False
        PengembalianToolStripMenuItem.Visible = False
        ReportToolStripMenuItem.Visible = False
        UtilityToolStripMenuItem.Visible = False
    End Sub


    Private Sub KeluearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluearToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        FormLogin.ShowDialog()
    End Sub

    Private Sub MenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Terkunci()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Call Terkunci()
    End Sub

    Private Sub PetugasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PetugasToolStripMenuItem.Click
        FormManagaPetugas.ShowDialog()
    End Sub

    Private Sub AnggotaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnggotaToolStripMenuItem.Click
        ManageAnggota.ShowDialog()
    End Sub
End Class
