<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.label2 = New System.Windows.Forms.Label()
        Me.TBusername = New System.Windows.Forms.TextBox()
        Me.TBpassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Blogin = New System.Windows.Forms.Button()
        Me.BReset = New System.Windows.Forms.Button()
        Me.Bcancel = New System.Windows.Forms.Button()
        Me.CBshowpassword = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(290, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(39, 17)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(95, 24)
        Me.label2.TabIndex = 1
        Me.label2.Text = "username"
        '
        'TBusername
        '
        Me.TBusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBusername.Location = New System.Drawing.Point(43, 44)
        Me.TBusername.Name = "TBusername"
        Me.TBusername.Size = New System.Drawing.Size(191, 29)
        Me.TBusername.TabIndex = 2
        '
        'TBpassword
        '
        Me.TBpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBpassword.Location = New System.Drawing.Point(43, 112)
        Me.TBpassword.Name = "TBpassword"
        Me.TBpassword.Size = New System.Drawing.Size(191, 29)
        Me.TBpassword.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "password"
        '
        'Blogin
        '
        Me.Blogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Blogin.Location = New System.Drawing.Point(12, 176)
        Me.Blogin.Name = "Blogin"
        Me.Blogin.Size = New System.Drawing.Size(74, 23)
        Me.Blogin.TabIndex = 5
        Me.Blogin.Text = "Login"
        Me.Blogin.UseVisualStyleBackColor = True
        '
        'BReset
        '
        Me.BReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BReset.Location = New System.Drawing.Point(106, 176)
        Me.BReset.Name = "BReset"
        Me.BReset.Size = New System.Drawing.Size(74, 23)
        Me.BReset.TabIndex = 6
        Me.BReset.Text = "Reset"
        Me.BReset.UseVisualStyleBackColor = True
        '
        'Bcancel
        '
        Me.Bcancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bcancel.Location = New System.Drawing.Point(196, 176)
        Me.Bcancel.Name = "Bcancel"
        Me.Bcancel.Size = New System.Drawing.Size(74, 23)
        Me.Bcancel.TabIndex = 7
        Me.Bcancel.Text = "Cancel"
        Me.Bcancel.UseVisualStyleBackColor = True
        '
        'CBshowpassword
        '
        Me.CBshowpassword.AutoSize = True
        Me.CBshowpassword.Location = New System.Drawing.Point(43, 147)
        Me.CBshowpassword.Name = "CBshowpassword"
        Me.CBshowpassword.Size = New System.Drawing.Size(102, 17)
        Me.CBshowpassword.TabIndex = 8
        Me.CBshowpassword.Text = "Show Password"
        Me.CBshowpassword.UseVisualStyleBackColor = True
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 228)
        Me.Controls.Add(Me.CBshowpassword)
        Me.Controls.Add(Me.Bcancel)
        Me.Controls.Add(Me.BReset)
        Me.Controls.Add(Me.Blogin)
        Me.Controls.Add(Me.TBpassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TBusername)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormLogin"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents TBusername As TextBox
    Friend WithEvents TBpassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Blogin As Button
    Friend WithEvents BReset As Button
    Friend WithEvents Bcancel As Button
    Friend WithEvents CBshowpassword As CheckBox
End Class
