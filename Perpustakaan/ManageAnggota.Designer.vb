<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageAnggota
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
        Me.TBkodeAnggota = New System.Windows.Forms.TextBox()
        Me.TBNamaAnggota = New System.Windows.Forms.TextBox()
        Me.TBnoTelepon = New System.Windows.Forms.TextBox()
        Me.TBAlamat = New System.Windows.Forms.TextBox()
        Me.RBPria = New System.Windows.Forms.RadioButton()
        Me.RBWanita = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.Label1.Location = New System.Drawing.Point(165, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Managa Anggota"
        '
        'TBkodeAnggota
        '
        Me.TBkodeAnggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBkodeAnggota.Location = New System.Drawing.Point(240, 43)
        Me.TBkodeAnggota.Name = "TBkodeAnggota"
        Me.TBkodeAnggota.Size = New System.Drawing.Size(100, 26)
        Me.TBkodeAnggota.TabIndex = 2
        '
        'TBNamaAnggota
        '
        Me.TBNamaAnggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNamaAnggota.Location = New System.Drawing.Point(240, 75)
        Me.TBNamaAnggota.Name = "TBNamaAnggota"
        Me.TBNamaAnggota.Size = New System.Drawing.Size(267, 26)
        Me.TBNamaAnggota.TabIndex = 4
        '
        'TBnoTelepon
        '
        Me.TBnoTelepon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBnoTelepon.Location = New System.Drawing.Point(240, 169)
        Me.TBnoTelepon.Name = "TBnoTelepon"
        Me.TBnoTelepon.Size = New System.Drawing.Size(267, 26)
        Me.TBnoTelepon.TabIndex = 9
        '
        'TBAlamat
        '
        Me.TBAlamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBAlamat.Location = New System.Drawing.Point(240, 137)
        Me.TBAlamat.Name = "TBAlamat"
        Me.TBAlamat.Size = New System.Drawing.Size(267, 26)
        Me.TBAlamat.TabIndex = 7
        '
        'RBPria
        '
        Me.RBPria.AutoSize = True
        Me.RBPria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBPria.Location = New System.Drawing.Point(286, 108)
        Me.RBPria.Name = "RBPria"
        Me.RBPria.Size = New System.Drawing.Size(54, 24)
        Me.RBPria.TabIndex = 10
        Me.RBPria.TabStop = True
        Me.RBPria.Text = "Pria"
        Me.RBPria.UseVisualStyleBackColor = True
        '
        'RBWanita
        '
        Me.RBWanita.AutoSize = True
        Me.RBWanita.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBWanita.Location = New System.Drawing.Point(358, 107)
        Me.RBWanita.Name = "RBWanita"
        Me.RBWanita.Size = New System.Drawing.Size(77, 24)
        Me.RBWanita.TabIndex = 11
        Me.RBWanita.TabStop = True
        Me.RBWanita.Text = "Wanita"
        Me.RBWanita.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(2, 277)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(595, 232)
        Me.DataGridView1.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(85, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 23)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Kode Anggota"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(85, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 23)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(85, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 23)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(85, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 23)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Alamat"
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(85, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 23)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "No Telepon"
        '
        'BInput
        '
        Me.BInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BInput.Location = New System.Drawing.Point(80, 222)
        Me.BInput.Name = "BInput"
        Me.BInput.Size = New System.Drawing.Size(86, 27)
        Me.BInput.TabIndex = 19
        Me.BInput.Text = "Input"
        Me.BInput.UseVisualStyleBackColor = True
        '
        'BEdit
        '
        Me.BEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEdit.Location = New System.Drawing.Point(197, 222)
        Me.BEdit.Name = "BEdit"
        Me.BEdit.Size = New System.Drawing.Size(86, 27)
        Me.BEdit.TabIndex = 20
        Me.BEdit.Text = "Edit"
        Me.BEdit.UseVisualStyleBackColor = True
        '
        'BDelete
        '
        Me.BDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BDelete.Location = New System.Drawing.Point(317, 222)
        Me.BDelete.Name = "BDelete"
        Me.BDelete.Size = New System.Drawing.Size(86, 27)
        Me.BDelete.TabIndex = 21
        Me.BDelete.Text = "Delete"
        Me.BDelete.UseVisualStyleBackColor = True
        '
        'BKeluar
        '
        Me.BKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BKeluar.Location = New System.Drawing.Point(438, 222)
        Me.BKeluar.Name = "BKeluar"
        Me.BKeluar.Size = New System.Drawing.Size(86, 27)
        Me.BKeluar.TabIndex = 22
        Me.BKeluar.Text = "Keluar"
        Me.BKeluar.UseVisualStyleBackColor = True
        '
        'ManageAnggota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 507)
        Me.Controls.Add(Me.BKeluar)
        Me.Controls.Add(Me.BDelete)
        Me.Controls.Add(Me.BEdit)
        Me.Controls.Add(Me.BInput)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.RBWanita)
        Me.Controls.Add(Me.RBPria)
        Me.Controls.Add(Me.TBnoTelepon)
        Me.Controls.Add(Me.TBAlamat)
        Me.Controls.Add(Me.TBNamaAnggota)
        Me.Controls.Add(Me.TBkodeAnggota)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ManageAnggota"
        Me.Text = "ManageAnggota"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TBkodeAnggota As TextBox
    Friend WithEvents TBNamaAnggota As TextBox
    Friend WithEvents TBnoTelepon As TextBox
    Friend WithEvents TBAlamat As TextBox
    Friend WithEvents RBPria As RadioButton
    Friend WithEvents RBWanita As RadioButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BInput As Button
    Friend WithEvents BEdit As Button
    Friend WithEvents BDelete As Button
    Friend WithEvents BKeluar As Button
End Class
