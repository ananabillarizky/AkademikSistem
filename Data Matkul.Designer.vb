<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_Matkul
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
        Me.Dgvmatkul = New System.Windows.Forms.DataGridView()
        Me.prodi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nama_kuliah = New System.Windows.Forms.TextBox()
        Me.id_matkul = New System.Windows.Forms.TextBox()
        Me.LblSatuan = New System.Windows.Forms.Label()
        Me.LblNamaBarang = New System.Windows.Forms.Label()
        Me.LblIdBarang = New System.Windows.Forms.Label()
        Me.LblCRUD = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SearchTxtBox = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.Dgvmatkul, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgvmatkul
        '
        Me.Dgvmatkul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvmatkul.Location = New System.Drawing.Point(76, 348)
        Me.Dgvmatkul.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Dgvmatkul.Name = "Dgvmatkul"
        Me.Dgvmatkul.RowHeadersWidth = 51
        Me.Dgvmatkul.RowTemplate.Height = 24
        Me.Dgvmatkul.Size = New System.Drawing.Size(538, 218)
        Me.Dgvmatkul.TabIndex = 75
        '
        'prodi
        '
        Me.prodi.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prodi.Location = New System.Drawing.Point(289, 189)
        Me.prodi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.prodi.Name = "prodi"
        Me.prodi.Size = New System.Drawing.Size(325, 34)
        Me.prodi.TabIndex = 74
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(71, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 32)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Program Studi"
        '
        'nama_kuliah
        '
        Me.nama_kuliah.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama_kuliah.Location = New System.Drawing.Point(289, 149)
        Me.nama_kuliah.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nama_kuliah.Name = "nama_kuliah"
        Me.nama_kuliah.Size = New System.Drawing.Size(325, 34)
        Me.nama_kuliah.TabIndex = 68
        '
        'id_matkul
        '
        Me.id_matkul.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_matkul.Location = New System.Drawing.Point(289, 106)
        Me.id_matkul.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.id_matkul.Name = "id_matkul"
        Me.id_matkul.Size = New System.Drawing.Size(325, 34)
        Me.id_matkul.TabIndex = 67
        '
        'LblSatuan
        '
        Me.LblSatuan.AutoSize = True
        Me.LblSatuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSatuan.Location = New System.Drawing.Point(71, 189)
        Me.LblSatuan.Name = "LblSatuan"
        Me.LblSatuan.Size = New System.Drawing.Size(0, 25)
        Me.LblSatuan.TabIndex = 66
        '
        'LblNamaBarang
        '
        Me.LblNamaBarang.AutoSize = True
        Me.LblNamaBarang.BackColor = System.Drawing.Color.Transparent
        Me.LblNamaBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNamaBarang.ForeColor = System.Drawing.Color.White
        Me.LblNamaBarang.Location = New System.Drawing.Point(71, 149)
        Me.LblNamaBarang.Name = "LblNamaBarang"
        Me.LblNamaBarang.Size = New System.Drawing.Size(102, 32)
        Me.LblNamaBarang.TabIndex = 65
        Me.LblNamaBarang.Text = "Nama "
        '
        'LblIdBarang
        '
        Me.LblIdBarang.AutoSize = True
        Me.LblIdBarang.BackColor = System.Drawing.Color.Transparent
        Me.LblIdBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIdBarang.ForeColor = System.Drawing.Color.White
        Me.LblIdBarang.Location = New System.Drawing.Point(71, 108)
        Me.LblIdBarang.Name = "LblIdBarang"
        Me.LblIdBarang.Size = New System.Drawing.Size(44, 32)
        Me.LblIdBarang.TabIndex = 64
        Me.LblIdBarang.Text = "ID"
        '
        'LblCRUD
        '
        Me.LblCRUD.AutoSize = True
        Me.LblCRUD.BackColor = System.Drawing.Color.Transparent
        Me.LblCRUD.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCRUD.ForeColor = System.Drawing.Color.White
        Me.LblCRUD.Location = New System.Drawing.Point(126, 22)
        Me.LblCRUD.Name = "LblCRUD"
        Me.LblCRUD.Size = New System.Drawing.Size(444, 46)
        Me.LblCRUD.TabIndex = 63
        Me.LblCRUD.Text = "Input Data Mata Kuliah"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(483, 286)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 42)
        Me.Button2.TabIndex = 81
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(483, 240)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 42)
        Me.Button1.TabIndex = 80
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'SearchTxtBox
        '
        Me.SearchTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTxtBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SearchTxtBox.Location = New System.Drawing.Point(76, 294)
        Me.SearchTxtBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SearchTxtBox.Name = "SearchTxtBox"
        Me.SearchTxtBox.Size = New System.Drawing.Size(402, 34)
        Me.SearchTxtBox.TabIndex = 79
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(347, 240)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(131, 42)
        Me.Button3.TabIndex = 78
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.MediumBlue
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(212, 240)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(131, 42)
        Me.Button4.TabIndex = 77
        Me.Button4.Text = "Update"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Green
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(76, 240)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(131, 42)
        Me.Button5.TabIndex = 76
        Me.Button5.Text = "Simpan"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Data_Matkul
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sistem_Akademik.My.Resources.Resources.Rectangle_26
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(696, 601)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SearchTxtBox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Dgvmatkul)
        Me.Controls.Add(Me.prodi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nama_kuliah)
        Me.Controls.Add(Me.id_matkul)
        Me.Controls.Add(Me.LblSatuan)
        Me.Controls.Add(Me.LblNamaBarang)
        Me.Controls.Add(Me.LblIdBarang)
        Me.Controls.Add(Me.LblCRUD)
        Me.DoubleBuffered = True
        Me.Name = "Data_Matkul"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data_Matkul"
        CType(Me.Dgvmatkul, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dgvmatkul As DataGridView
    Friend WithEvents prodi As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents nama_kuliah As TextBox
    Friend WithEvents id_matkul As TextBox
    Friend WithEvents LblSatuan As Label
    Friend WithEvents LblNamaBarang As Label
    Friend WithEvents LblIdBarang As Label
    Friend WithEvents LblCRUD As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents SearchTxtBox As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
