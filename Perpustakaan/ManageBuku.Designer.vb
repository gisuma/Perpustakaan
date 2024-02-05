<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageBuku
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBKodeBuku = New System.Windows.Forms.TextBox()
        Me.TBJudulBuku = New System.Windows.Forms.TextBox()
        Me.TBPengarangBuku = New System.Windows.Forms.TextBox()
        Me.TBPenerbit = New System.Windows.Forms.TextBox()
        Me.TBJumlahBuku = New System.Windows.Forms.TextBox()
        Me.CBtahun = New System.Windows.Forms.ComboBox()
        Me.BInput = New System.Windows.Forms.Button()
        Me.BEdit = New System.Windows.Forms.Button()
        Me.BDelete = New System.Windows.Forms.Button()
        Me.BKeluar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(245, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manage Buku"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(112, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Buku"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(-2, 313)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(705, 214)
        Me.DataGridView1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(112, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Judul Buku"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(112, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Pengarang Buku"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(112, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(183, 23)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Jumlah"
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(112, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(183, 23)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Tahun Terbit"
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(112, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(183, 23)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Penerbit Buku"
        '
        'TBKodeBuku
        '
        Me.TBKodeBuku.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBKodeBuku.Location = New System.Drawing.Point(346, 49)
        Me.TBKodeBuku.Name = "TBKodeBuku"
        Me.TBKodeBuku.Size = New System.Drawing.Size(100, 26)
        Me.TBKodeBuku.TabIndex = 8
        '
        'TBJudulBuku
        '
        Me.TBJudulBuku.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBJudulBuku.Location = New System.Drawing.Point(346, 82)
        Me.TBJudulBuku.Name = "TBJudulBuku"
        Me.TBJudulBuku.Size = New System.Drawing.Size(245, 26)
        Me.TBJudulBuku.TabIndex = 9
        '
        'TBPengarangBuku
        '
        Me.TBPengarangBuku.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBPengarangBuku.Location = New System.Drawing.Point(346, 117)
        Me.TBPengarangBuku.Name = "TBPengarangBuku"
        Me.TBPengarangBuku.Size = New System.Drawing.Size(245, 26)
        Me.TBPengarangBuku.TabIndex = 10
        '
        'TBPenerbit
        '
        Me.TBPenerbit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBPenerbit.Location = New System.Drawing.Point(346, 152)
        Me.TBPenerbit.Name = "TBPenerbit"
        Me.TBPenerbit.Size = New System.Drawing.Size(100, 26)
        Me.TBPenerbit.TabIndex = 11
        '
        'TBJumlahBuku
        '
        Me.TBJumlahBuku.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBJumlahBuku.Location = New System.Drawing.Point(346, 222)
        Me.TBJumlahBuku.Name = "TBJumlahBuku"
        Me.TBJumlahBuku.Size = New System.Drawing.Size(100, 26)
        Me.TBJumlahBuku.TabIndex = 12
        '
        'CBtahun
        '
        Me.CBtahun.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBtahun.FormattingEnabled = True
        Me.CBtahun.Location = New System.Drawing.Point(346, 187)
        Me.CBtahun.Name = "CBtahun"
        Me.CBtahun.Size = New System.Drawing.Size(121, 28)
        Me.CBtahun.TabIndex = 13
        '
        'BInput
        '
        Me.BInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BInput.Location = New System.Drawing.Point(90, 268)
        Me.BInput.Name = "BInput"
        Me.BInput.Size = New System.Drawing.Size(78, 26)
        Me.BInput.TabIndex = 14
        Me.BInput.Text = "Input"
        Me.BInput.UseVisualStyleBackColor = True
        '
        'BEdit
        '
        Me.BEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEdit.Location = New System.Drawing.Point(217, 268)
        Me.BEdit.Name = "BEdit"
        Me.BEdit.Size = New System.Drawing.Size(78, 26)
        Me.BEdit.TabIndex = 15
        Me.BEdit.Text = "Edit"
        Me.BEdit.UseVisualStyleBackColor = True
        '
        'BDelete
        '
        Me.BDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BDelete.Location = New System.Drawing.Point(348, 268)
        Me.BDelete.Name = "BDelete"
        Me.BDelete.Size = New System.Drawing.Size(78, 26)
        Me.BDelete.TabIndex = 16
        Me.BDelete.Text = "Delete"
        Me.BDelete.UseVisualStyleBackColor = True
        '
        'BKeluar
        '
        Me.BKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BKeluar.Location = New System.Drawing.Point(468, 268)
        Me.BKeluar.Name = "BKeluar"
        Me.BKeluar.Size = New System.Drawing.Size(78, 26)
        Me.BKeluar.TabIndex = 17
        Me.BKeluar.Text = "Keluar"
        Me.BKeluar.UseVisualStyleBackColor = True
        '
        'ManageBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 527)
        Me.Controls.Add(Me.BKeluar)
        Me.Controls.Add(Me.BDelete)
        Me.Controls.Add(Me.BEdit)
        Me.Controls.Add(Me.BInput)
        Me.Controls.Add(Me.CBtahun)
        Me.Controls.Add(Me.TBJumlahBuku)
        Me.Controls.Add(Me.TBPenerbit)
        Me.Controls.Add(Me.TBPengarangBuku)
        Me.Controls.Add(Me.TBJudulBuku)
        Me.Controls.Add(Me.TBKodeBuku)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ManageBuku"
        Me.Text = "Manage Buku"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TBKodeBuku As TextBox
    Friend WithEvents TBJudulBuku As TextBox
    Friend WithEvents TBPengarangBuku As TextBox
    Friend WithEvents TBPenerbit As TextBox
    Friend WithEvents TBJumlahBuku As TextBox
    Friend WithEvents CBtahun As ComboBox
    Friend WithEvents BInput As Button
    Friend WithEvents BEdit As Button
    Friend WithEvents BDelete As Button
    Friend WithEvents BKeluar As Button
End Class
