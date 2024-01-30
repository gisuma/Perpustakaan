Imports System.Data.Odbc


Public Class FormLogin
    Sub Users_level()
        MenuUtama.LoginToolStripMenuItem.Visible = False
        MenuUtama.LogoutToolStripMenuItem.Visible = True
        MenuUtama.KeluearToolStripMenuItem.Visible = True
        MenuUtama.MasterToolStripMenuItem.Visible = True
        MenuUtama.PetugasToolStripMenuItem.Visible = False
        MenuUtama.AnggotaToolStripMenuItem.Visible = True
        MenuUtama.BukuToolStripMenuItem.Visible = False
        MenuUtama.TransaksiToolStripMenuItem.Visible = True
        MenuUtama.PeminjamanToolStripMenuItem.Visible = True
        MenuUtama.PengembalianToolStripMenuItem.Visible = True
        MenuUtama.ReportToolStripMenuItem.Visible = False
        MenuUtama.UtilityToolStripMenuItem.Visible = False
    End Sub


    Sub Admin_level()
        MenuUtama.LoginToolStripMenuItem.Visible = False
        MenuUtama.LogoutToolStripMenuItem.Visible = True
        MenuUtama.KeluearToolStripMenuItem.Visible = True
        MenuUtama.MasterToolStripMenuItem.Visible = True
        MenuUtama.PetugasToolStripMenuItem.Visible = True
        MenuUtama.AnggotaToolStripMenuItem.Visible = True
        MenuUtama.BukuToolStripMenuItem.Visible = True
        MenuUtama.TransaksiToolStripMenuItem.Visible = True
        MenuUtama.PeminjamanToolStripMenuItem.Visible = True
        MenuUtama.PengembalianToolStripMenuItem.Visible = True
        MenuUtama.ReportToolStripMenuItem.Visible = True
        MenuUtama.UtilityToolStripMenuItem.Visible = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Blogin.Click
        If TBusername.Text = "" Or TBpassword.Text = "" Then
            MsgBox("username dan password tidak boleh kosong")
        Else
            KONEKSI()
            CMD = New OdbcCommand("SELECT * FROM petugas WHERE kode_petugas = '" & TBusername.Text & "' and password_petugas = '" & TBpassword.Text & "' ", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                MsgBox("Login Berhasil")
                TBusername.Text = ""
                TBpassword.Text = ""
                If DR.Item(3) = "Admin" Then
                    Call Admin_level()
                Else
                    Call Users_level()
                End If

                Me.Close()
            Else
                MsgBox("username atau password salah")
            End If
        End If
    End Sub

    Private Sub Bcancel_Click(sender As Object, e As EventArgs) Handles Bcancel.Click
        Me.Close()
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBpassword.PasswordChar = "*"
        CBshowpassword.Checked = False
    End Sub

    Private Sub BReset_Click(sender As Object, e As EventArgs) Handles BReset.Click
        TBusername.Text = ""
        TBpassword.Text = ""
    End Sub

    Private Sub CBshowpassword_CheckedChanged(sender As Object, e As EventArgs) Handles CBshowpassword.CheckedChanged
        If CBshowpassword.Checked = True Then
            TBpassword.PasswordChar = ""
        Else
            TBpassword.PasswordChar = "*"
        End If
    End Sub



    Private Sub TBpassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBpassword.KeyPress
        If e.KeyChar = Chr(13) Then
            Blogin.PerformClick()
        End If
    End Sub
End Class