Imports System.ComponentModel
Imports System.Data.Odbc
Imports MySql.Data.MySqlClient

Public Class ManageAnggota
    Public State As String
    Sub ChangeButton()
        BEdit.Text = "Clear"
        BDelete.Text = "Cancel"
        BInput.Text = "Simpan"
    End Sub
    Sub FormTerbuka()
        TBkodeAnggota.Enabled = True
        TBNamaAnggota.Enabled = True
        TBAlamat.Enabled = True
        TBnoTelepon.Enabled = True
        RBPria.Enabled = True
        RBWanita.Enabled = True
    End Sub

    Sub Reset()
        TBkodeAnggota.Text = ""
        TBNamaAnggota.Text = ""
        TBnoTelepon.Text = ""
        TBAlamat.Text = ""
        RBPria.Checked = False
        RBWanita.Checked = False
        State = ""
    End Sub

    Sub Kondisiawal()
        RBPria.Checked = False
        RBWanita.Checked = False
        KONEKSI()
        DA = New OdbcDataAdapter("select * from anggota", CONN)
        DS = New DataSet
        DA.Fill(DS, "anggota")
        DataGridView1.DataSource = (DS.Tables("anggota"))
        TBkodeAnggota.Enabled = False
        TBNamaAnggota.Enabled = False
        TBAlamat.Enabled = False
        TBnoTelepon.Enabled = False
        RBPria.Enabled = False
        RBWanita.Enabled = False
        BInput.Text = "Input"
        BEdit.Text = "Edit"
        BDelete.Text = "Delete"
        BInput.Enabled = True
        BEdit.Enabled = True
        BDelete.Enabled = True
    End Sub
    Private Sub ManageAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBkodeAnggota.MaxLength = 6
        TBNamaAnggota.MaxLength = 50
        TBAlamat.MaxLength = 100
        TBnoTelepon.MaxLength = 20
        Call Kondisiawal()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BKeluar.Click
        Me.Close()
        Kondisiawal()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BInput.Click
        If BInput.Text = "Input" Then
            Call FormTerbuka()
            Call ChangeButton()
            State = "Input"
            KONEKSI()
            CMD = New OdbcCommand("Select * From anggota WHERE kode_anggota in (Select max(kode_anggota) from anggota)", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                Dim auto_kode As String
                Dim kodeanggota As String
                Dim urutan As Integer
                auto_kode = DR.Item(0).Replace("AGT", "")
                urutan = Convert.ToInt32(auto_kode)
                urutan += 1
                kodeanggota = "AGT" + urutan.ToString("000")
                TBkodeAnggota.Text = kodeanggota
                TBkodeAnggota.Enabled = False
            End If
        ElseIf BInput.Text = "Simpan" Then
            Dim jk As String
            Dim jk_checked As Boolean
            jk_checked = RBPria.Checked Or RBWanita.Checked
            If TBAlamat.Text = "" Or TBkodeAnggota.Text = "" Or TBNamaAnggota.Text = "" Or TBnoTelepon.Text = "" Or jk_checked = "False" Then
                MsgBox("Semua Data Harus diisi")
            Else
                Dim Query As String
                KONEKSI()
                If RBPria.Checked = True Then
                    jk = "Pria"
                ElseIf RBWanita.Checked = True Then
                    jk = "Wanita"
                End If
                If State = "Input" Then
                    CMD = New OdbcCommand("INSERT INTO `anggota` (`kode_anggota`, `nama_anggota`, `jenis_kelamin`, `alamat_anggota`, `Telepon_angggota`) VALUES ( '" & TBkodeAnggota.Text & "','" & TBNamaAnggota.Text & "','" & jk & "','" & TBAlamat.Text & "','" & TBnoTelepon.Text & "' ) ", CONN)
                    CMD.ExecuteNonQuery()
                    MsgBox("Input Data Berhasil!")
                ElseIf State = "Edit" Then
                    CMD = New OdbcCommand("UPDATE `anggota` SET `kode_anggota` = '" & TBkodeAnggota.Text & "', `nama_anggota` = '" & TBNamaAnggota.Text & "', `jenis_kelamin` = '" & jk & "' , `alamat_anggota` = '" & TBAlamat.Text & "', `Telepon_angggota` = '" & TBnoTelepon.Text & "' Where `kode_anggota` = '" & TBkodeAnggota.Text & "' ", CONN)
                    CMD.ExecuteNonQuery()
                    MsgBox("Edit Data Berhasil!")
                ElseIf State = "Delete" Then
                    CMD = New OdbcCommand("DELETE FROm `anggota` Where `kode_anggota` = '" & TBkodeAnggota.Text & "' ", CONN)
                    CMD.ExecuteNonQuery()
                    MsgBox("Menghapus Data Berhasil!")
                End If
                Call Reset()
                Call Kondisiawal()
            End If
        End If
    End Sub

    Private Sub BDelete_Click(sender As Object, e As EventArgs) Handles BDelete.Click
        If BDelete.Text = "Cancel" Then
            Call Reset()
            Call Kondisiawal()
        ElseIf BDelete.Text = "Delete" Then
            State = "Delete"
            TBkodeAnggota.Enabled = True
            Call ChangeButton()
        End If
    End Sub

    Private Sub BEdit_Click(sender As Object, e As EventArgs) Handles BEdit.Click
        If BEdit.Text = "Clear" Then
            Call Reset()
        ElseIf BEdit.Text = "Edit" Then
            State = "Edit"
            TBkodeAnggota.Enabled = True
            Call ChangeButton()
        End If
    End Sub



    Private Sub TBkodeAnggota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBkodeAnggota.KeyPress
        If State = "Edit" Or State = "Delete" Then
            If e.KeyChar = Chr(13) Then
                KONEKSI()
                Dim JK As String
                CMD = New OdbcCommand("SELECT * FROM anggota WHERE kode_anggota = '" & TBkodeAnggota.Text & "' ", CONN)
                DR = CMD.ExecuteReader
                If DR.Read Then
                    Call FormTerbuka()
                    TBkodeAnggota.Text = DR.Item(0)
                    TBkodeAnggota.Enabled = False
                    TBNamaAnggota.Text = DR.Item(1)
                    JK = DR.Item(2)
                    If JK = "Pria" Then
                        RBPria.Checked = True
                    ElseIf JK = "Wanita" Then
                        RBWanita.Checked = True
                    End If
                    TBAlamat.Text = DR.Item(3)
                    TBnoTelepon.Text = DR.Item(4)
                    MsgBox("Data Ditemukan")
                Else
                    MsgBox("Maaf, Data Tidak ditemukan")
                    TBkodeAnggota.Focus()
                End If
            End If
        End If
    End Sub
End Class