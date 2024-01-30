Imports System.Data.Odbc
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class FormManagaPetugas
    Public ketemu As Boolean
    Sub kondisi_awal()
        Call KONEKSI()
        DA = New OdbcDataAdapter("select kode_petugas, nama_petugas, level_petugas from petugas", CONN)
        DS = New DataSet
        DA.Fill(DS, "petugas")
        DataGridView1.DataSource = (DS.Tables("petugas"))
    End Sub

    Private Sub FormManagaPetugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisi_awal()
        TBkodePetugas.MaxLength = 6
        TBnamapetugas.MaxLength = 30
        TBpassword.MaxLength = 20
        TBkodePetugas.Enabled = True
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub


    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBkodePetugas.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                KONEKSI()
                CMD = New OdbcCommand("select * From petugas WHERE kode_petugas = '" & TBkodePetugas.Text & "' ", CONN)
                DR = CMD.ExecuteReader
                If DR.Read Then
                    TBkodePetugas.Text = DR.Item(0)
                    TBnamapetugas.Text = DR.Item(1)
                    TBpassword.Text = DR.Item(2)
                    CBLevelpetugas.SelectedItem = DR.Item(3)
                    TBkodePetugas.Enabled = False
                    ketemu = True
                Else
                    TBkodePetugas.Focus()
                    ketemu = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub BKeluar_Click(sender As Object, e As EventArgs) Handles BKeluar.Click
        Bclear.PerformClick()
        Me.Close()
    End Sub

    Private Sub BEdit_Click(sender As Object, e As EventArgs) Handles Bclear.Click
        TBkodePetugas.Text = ""
        TBnamapetugas.Text = ""
        TBpassword.Text = ""
        CBLevelpetugas.SelectedIndex = -1
        TBkodePetugas.Enabled = True
    End Sub

    Private Sub BSimpan_Click(sender As Object, e As EventArgs) Handles BSimpan.Click
        If TBkodePetugas.Text = "" Or TBnamapetugas.Text = "" Or TBpassword.Text = "" Or CBLevelpetugas.Text = "" Then
            MsgBox("data harus diisi semuanya")
        Else
            KONEKSI()
            If ketemu = True Then
                CMD = New OdbcCommand("UPDATE petugas SET kode_petugas = '" & TBkodePetugas.Text & "', nama_petugas = '" & TBnamapetugas.Text & "', password_petugas = '" & TBpassword.Text & "', level_petugas = '" & CBLevelpetugas.Text & "' WHERE kode_petugas = '" & TBkodePetugas.Text & "'", CONN)
                CMD.ExecuteNonQuery()
                Call kondisi_awal()
                Bclear.PerformClick()
                TBkodePetugas.Enabled = True
                MsgBox("Data Berhasil diUpdate")
            Else
                CMD = New OdbcCommand("INSERT INTO petugas (kode_petugas, nama_petugas, password_petugas, level_petugas) VALUES ( '" & TBkodePetugas.Text & "','" & TBnamapetugas.Text & "','" & TBpassword.Text & "','" & CBLevelpetugas.Text & "' ) ", CONN)
                CMD.ExecuteNonQuery()
                Call kondisi_awal()
                Bclear.PerformClick()
                MsgBox("Simpan Data Sukses!")
            End If
        End If
    End Sub

    Private Sub BDelete_Click(sender As Object, e As EventArgs) Handles BDelete.Click
        CMD = New OdbcCommand("DELETE FROM petugas WHERE kode_petugas = '" & TBkodePetugas.Text & "' ", CONN)
        CMD.ExecuteNonQuery()
        Call kondisi_awal()
        Bclear.PerformClick()
        TBkodePetugas.Enabled = True
        MsgBox("Data Berhasil diHapus")
    End Sub
End Class