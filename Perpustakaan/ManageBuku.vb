Imports Mysqlx.Crud
Imports Mysqlx.Datatypes.Scalar.Types
Imports System.Data.Odbc
Imports System.Reflection
Imports System.Windows

Public Class ManageBuku
    Public State As String
    Sub ChangeButton()
        BEdit.Text = "Clear"
        BDelete.Text = "Cancel"
        BInput.Text = "Simpan"
    End Sub
    Sub FormTerbuka()
        TBKodeBuku.Enabled = True
        TBJudulBuku.Enabled = True
        TBPenerbit.Enabled = True
        TBPengarangBuku.Enabled = True
        CBtahun.Enabled = True
        TBJumlahBuku.Enabled = True
    End Sub

    Sub Reset()
        TBKodeBuku.Text = ""
        TBJudulBuku.Text = ""
        TBPenerbit.Text = ""
        TBPengarangBuku.Text = ""
        CBtahun.SelectedIndex = -1
        TBJumlahBuku.Text = ""
        State = ""
    End Sub

    Public Sub kondisiawal()
        KONEKSI()
        DA = New OdbcDataAdapter("select * from buku", CONN)
        DS = New DataSet
        DA.Fill(DS, "buku")
        DataGridView1.DataSource = (DS.Tables("buku"))
        TBKodeBuku.Enabled = False
        TBJudulBuku.Enabled = False
        TBPengarangBuku.Enabled = False
        TBPenerbit.Enabled = False
        CBtahun.Enabled = False
        TBJumlahBuku.Enabled = False
        BInput.Text = "Input"
        BEdit.Text = "Edit"
        BDelete.Text = "Delete"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BKeluar.Click
        Me.Close()
    End Sub

    Private Sub ManageBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBKodeBuku.MaxLength = 6
        TBJudulBuku.MaxLength = 100
        TBPengarangBuku.MaxLength = 50
        TBPenerbit.MaxLength = 100
        TBJumlahBuku.MaxLength = 10
        For i = 0 To 20
            CBtahun.Items.Add(DateTime.Now.Year - i)
        Next
        Call kondisiawal()
    End Sub

    Private Sub BInput_Click(sender As Object, e As EventArgs) Handles BInput.Click
        If BInput.Text = "Input" Then
            Call FormTerbuka()
            Call ChangeButton()
            State = "Input"
            KONEKSI()
            CMD = New OdbcCommand("Select * From buku WHERE kode_buku in (Select max(kode_buku) from buku)", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                Dim auto_kode As String
                Dim kodebuku As String
                Dim urutan As Integer
                auto_kode = DR.Item(0).Replace("BK", "")
                urutan = Convert.ToInt32(auto_kode)
                urutan += 1
                kodebuku = "BK" + urutan.ToString("0000")
                TBKodeBuku.Text = kodebuku
                TBKodeBuku.Enabled = False
            End If


        ElseIf BInput.Text = "Simpan" Then
                If TBKodeBuku.Text = "" Or TBJudulBuku.Text = "" Or TBPengarangBuku.Text = "" Or TBPenerbit.Text = "" Or CBtahun.Text = "" Or TBJumlahBuku.Text = "" Then
                If State = "Delete" Then
                    CMD = New OdbcCommand("DELETE From `buku` Where `kode_buku` = '" & TBKodeBuku.Text & "' ", CONN)
                    CMD.ExecuteNonQuery()
                    MsgBox("Menghapus Data Berhasil!")
                    Call Reset()
                    Call kondisiawal()
                Else
                    MsgBox("Semua Data Harus diisi")
                End If

            Else
                Dim Query As String
                KONEKSI()
                If State = "Input" Then
                    CMD = New OdbcCommand("INSERT INTO `buku` (`kode_buku`, `judul_buku`, `pengarang_buku`, `penerbit_buku`, `Tahun_buku`,`Jumlah`) VALUES ( '" & TBKodeBuku.Text & "','" & TBJudulBuku.Text & "','" & TBPengarangBuku.Text & "','" & TBPenerbit.Text & "','" & CBtahun.Text & "', '" & TBJumlahBuku.Text & "' ) ", CONN)
                    CMD.ExecuteNonQuery()
                    MsgBox("Input Data Berhasil!")
                ElseIf State = "Edit" Then
                    Try
                        CMD = New OdbcCommand("UPDATE `buku` SET `judul_buku` = '" & TBJudulBuku.Text & "', `pengarang_buku` = '" & TBPengarangBuku.Text & "', `penerbit_buku` = '" & TBPenerbit.Text & "', `Tahun_buku` = '" & CBtahun.Text & "', `Jumlah` = '" & TBJumlahBuku.Text & "' Where kode_buku = '" & TBKodeBuku.Text & "' ", CONN)
                        CMD.ExecuteNonQuery()
                        MsgBox("Edit Data Berhasil!")
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                ElseIf State = "Delete" Then
                    CMD = New OdbcCommand("DELETE FROm `buku` Where kode_buku = '" & TBKodeBuku.Text & "' ", CONN)
                    CMD.ExecuteNonQuery()
                    MsgBox("Menghapus Data Berhasil!")
                End If
                Call Reset()
                Call kondisiawal()
            End If

        End If
    End Sub

    Private Sub BEdit_Click(sender As Object, e As EventArgs) Handles BEdit.Click
        If BEdit.Text = "Clear" Then
            Call Reset()
        ElseIf BEdit.Text = "Edit" Then
            State = "Edit"
            TBKodeBuku.Enabled = True
            TBKodeBuku.Focus()
            Call ChangeButton()
        End If
    End Sub

    Private Sub BDelete_Click(sender As Object, e As EventArgs) Handles BDelete.Click
        If BDelete.Text = "Cancel" Then
            Call Reset()
            Call kondisiawal()
        ElseIf BDelete.Text = "Delete" Then
            State = "Delete"
            TBKodeBuku.Enabled = True
            TBKodeBuku.Focus()
            Call ChangeButton()
        End If
    End Sub

    Private Sub TBKodeBuku_TextChanged(sender As Object, e As EventArgs) Handles TBKodeBuku.TextChanged

    End Sub

    Private Sub TBKodeBuku_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBKodeBuku.KeyPress
        If State = "Edit" Or State = "Delete" Then
            If e.KeyChar = Chr(13) Then
                KONEKSI()
                CMD = New OdbcCommand("SELECT * FROM buku WHERE kode_buku = '" & TBKodeBuku.Text & "' ", CONN)
                DR = CMD.ExecuteReader
                If DR.Read Then
                    Call FormTerbuka()
                    TBKodeBuku.Enabled = False
                    TBJudulBuku.Text = DR.Item(1)
                    TBPengarangBuku.Text = DR.Item(2)
                    TBPenerbit.Text = DR.Item(3)
                    CBtahun.Text = DR.Item(4)
                    TBJumlahBuku.Text = DR.Item(5)
                    MsgBox("Data Ditemukan")
                Else
                    MsgBox("Maaf, Data Tidak ditemukan")
                    TBKodeBuku.Focus()
                End If
            End If
        End If
    End Sub
End Class