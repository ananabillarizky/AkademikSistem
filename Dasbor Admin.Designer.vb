<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dasbor_Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dasbor_Admin))
        Me.BtnNilai = New System.Windows.Forms.Button()
        Me.BtnMatkul = New System.Windows.Forms.Button()
        Me.BtnDosen = New System.Windows.Forms.Button()
        Me.BtnMahasiswa = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnNilai
        '
        Me.BtnNilai.BackColor = System.Drawing.Color.Maroon
        Me.BtnNilai.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNilai.ForeColor = System.Drawing.Color.White
        Me.BtnNilai.Location = New System.Drawing.Point(380, 282)
        Me.BtnNilai.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNilai.Name = "BtnNilai"
        Me.BtnNilai.Size = New System.Drawing.Size(237, 94)
        Me.BtnNilai.TabIndex = 11
        Me.BtnNilai.Text = "Data Nilai"
        Me.BtnNilai.UseVisualStyleBackColor = False
        '
        'BtnMatkul
        '
        Me.BtnMatkul.BackColor = System.Drawing.Color.Maroon
        Me.BtnMatkul.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMatkul.ForeColor = System.Drawing.Color.White
        Me.BtnMatkul.Location = New System.Drawing.Point(380, 159)
        Me.BtnMatkul.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnMatkul.Name = "BtnMatkul"
        Me.BtnMatkul.Size = New System.Drawing.Size(237, 94)
        Me.BtnMatkul.TabIndex = 10
        Me.BtnMatkul.Text = "Data Mata Kuliah"
        Me.BtnMatkul.UseVisualStyleBackColor = False
        '
        'BtnDosen
        '
        Me.BtnDosen.BackColor = System.Drawing.Color.Maroon
        Me.BtnDosen.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDosen.ForeColor = System.Drawing.Color.White
        Me.BtnDosen.Location = New System.Drawing.Point(94, 282)
        Me.BtnDosen.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDosen.Name = "BtnDosen"
        Me.BtnDosen.Size = New System.Drawing.Size(237, 94)
        Me.BtnDosen.TabIndex = 9
        Me.BtnDosen.Text = "Data Dosen"
        Me.BtnDosen.UseVisualStyleBackColor = False
        '
        'BtnMahasiswa
        '
        Me.BtnMahasiswa.BackColor = System.Drawing.Color.Maroon
        Me.BtnMahasiswa.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMahasiswa.ForeColor = System.Drawing.Color.White
        Me.BtnMahasiswa.Location = New System.Drawing.Point(94, 159)
        Me.BtnMahasiswa.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnMahasiswa.Name = "BtnMahasiswa"
        Me.BtnMahasiswa.Size = New System.Drawing.Size(237, 94)
        Me.BtnMahasiswa.TabIndex = 8
        Me.BtnMahasiswa.Text = "Data Mahasiswa"
        Me.BtnMahasiswa.UseVisualStyleBackColor = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Bernard MT Condensed", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(46, 26)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(617, 81)
        Me.label1.TabIndex = 7
        Me.label1.Text = "Selamat Datang Admin"
        '
        'back
        '
        Me.back.BackColor = System.Drawing.Color.Maroon
        Me.back.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.ForeColor = System.Drawing.Color.White
        Me.back.Location = New System.Drawing.Point(225, 394)
        Me.back.Margin = New System.Windows.Forms.Padding(4)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(237, 94)
        Me.back.TabIndex = 12
        Me.back.Text = "Logout"
        Me.back.UseVisualStyleBackColor = False
        '
        'Dasbor_Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sistem_Akademik.My.Resources.Resources.Rectangle_26
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(709, 531)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.BtnNilai)
        Me.Controls.Add(Me.BtnMatkul)
        Me.Controls.Add(Me.BtnDosen)
        Me.Controls.Add(Me.BtnMahasiswa)
        Me.Controls.Add(Me.label1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Dasbor_Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dasbor_Admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnNilai As Button
    Friend WithEvents BtnMatkul As Button
    Friend WithEvents BtnDosen As Button
    Friend WithEvents BtnMahasiswa As Button
    Friend WithEvents label1 As Label
    Friend WithEvents back As Button
End Class
