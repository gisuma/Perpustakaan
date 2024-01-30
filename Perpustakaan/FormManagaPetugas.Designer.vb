<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormManagaPetugas
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBkodePetugas = New System.Windows.Forms.TextBox()
        Me.TBnamapetugas = New System.Windows.Forms.TextBox()
        Me.TBpassword = New System.Windows.Forms.TextBox()
        Me.CBLevelpetugas = New System.Windows.Forms.ComboBox()
        Me.BSimpan = New System.Windows.Forms.Button()
        Me.Bclear = New System.Windows.Forms.Button()
        Me.BDelete = New System.Windows.Forms.Button()
        Me.BKeluar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(2, 277)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(458, 172)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kode Petugas"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Petugas"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 27)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Password Petugas"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Level Petugas"
        '
        'TBkodePetugas
        '
        Me.TBkodePetugas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBkodePetugas.Location = New System.Drawing.Point(181, 89)
        Me.TBkodePetugas.Name = "TBkodePetugas"
        Me.TBkodePetugas.Size = New System.Drawing.Size(238, 26)
        Me.TBkodePetugas.TabIndex = 5
        '
        'TBnamapetugas
        '
        Me.TBnamapetugas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBnamapetugas.Location = New System.Drawing.Point(181, 113)
        Me.TBnamapetugas.Name = "TBnamapetugas"
        Me.TBnamapetugas.Size = New System.Drawing.Size(238, 26)
        Me.TBnamapetugas.TabIndex = 6
        '
        'TBpassword
        '
        Me.TBpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBpassword.Location = New System.Drawing.Point(181, 137)
        Me.TBpassword.Name = "TBpassword"
        Me.TBpassword.Size = New System.Drawing.Size(238, 26)
        Me.TBpassword.TabIndex = 7
        '
        'CBLevelpetugas
        '
        Me.CBLevelpetugas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBLevelpetugas.FormattingEnabled = True
        Me.CBLevelpetugas.Items.AddRange(New Object() {"admin", "user"})
        Me.CBLevelpetugas.Location = New System.Drawing.Point(181, 163)
        Me.CBLevelpetugas.Name = "CBLevelpetugas"
        Me.CBLevelpetugas.Size = New System.Drawing.Size(238, 28)
        Me.CBLevelpetugas.TabIndex = 8
        '
        'BSimpan
        '
        Me.BSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSimpan.Location = New System.Drawing.Point(12, 231)
        Me.BSimpan.Name = "BSimpan"
        Me.BSimpan.Size = New System.Drawing.Size(82, 29)
        Me.BSimpan.TabIndex = 9
        Me.BSimpan.Text = "SIMPAN"
        Me.BSimpan.UseVisualStyleBackColor = True
        '
        'Bclear
        '
        Me.Bclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bclear.Location = New System.Drawing.Point(125, 231)
        Me.Bclear.Name = "Bclear"
        Me.Bclear.Size = New System.Drawing.Size(82, 29)
        Me.Bclear.TabIndex = 10
        Me.Bclear.Text = "CLEAR"
        Me.Bclear.UseVisualStyleBackColor = True
        '
        'BDelete
        '
        Me.BDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BDelete.Location = New System.Drawing.Point(239, 231)
        Me.BDelete.Name = "BDelete"
        Me.BDelete.Size = New System.Drawing.Size(82, 29)
        Me.BDelete.TabIndex = 11
        Me.BDelete.Text = "DELETE"
        Me.BDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BDelete.UseVisualStyleBackColor = True
        '
        'BKeluar
        '
        Me.BKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BKeluar.Location = New System.Drawing.Point(360, 231)
        Me.BKeluar.Name = "BKeluar"
        Me.BKeluar.Size = New System.Drawing.Size(82, 29)
        Me.BKeluar.TabIndex = 12
        Me.BKeluar.Text = "KELUAR"
        Me.BKeluar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(92, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(282, 31)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "MANAGE PETUGAS"
        '
        'FormManagaPetugas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BKeluar)
        Me.Controls.Add(Me.BDelete)
        Me.Controls.Add(Me.Bclear)
        Me.Controls.Add(Me.BSimpan)
        Me.Controls.Add(Me.CBLevelpetugas)
        Me.Controls.Add(Me.TBpassword)
        Me.Controls.Add(Me.TBnamapetugas)
        Me.Controls.Add(Me.TBkodePetugas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FormManagaPetugas"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TBkodePetugas As TextBox
    Friend WithEvents TBnamapetugas As TextBox
    Friend WithEvents TBpassword As TextBox
    Friend WithEvents CBLevelpetugas As ComboBox
    Friend WithEvents BSimpan As Button
    Friend WithEvents Bclear As Button
    Friend WithEvents BDelete As Button
    Friend WithEvents BKeluar As Button
    Friend WithEvents Label5 As Label
End Class
