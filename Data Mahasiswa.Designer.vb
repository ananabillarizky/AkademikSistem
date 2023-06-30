<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_Mahasiswa
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
        Me.kelas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.NIM = New System.Windows.Forms.TextBox()
        Me.LblSatuan = New System.Windows.Forms.Label()
        Me.LblNamaBarang = New System.Windows.Forms.Label()
        Me.LblIdBarang = New System.Windows.Forms.Label()
        Me.LblCRUD = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.prodi = New System.Windows.Forms.TextBox()
        Me.chekboxLaki = New System.Windows.Forms.CheckBox()
        Me.chekboxPerempuan = New System.Windows.Forms.CheckBox()
        Me.back = New System.Windows.Forms.Button()
        CType(Me.Dgvmatkul, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgvmatkul
        '
        Me.Dgvmatkul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvmatkul.Location = New System.Drawing.Point(59, 353)
        Me.Dgvmatkul.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Dgvmatkul.Name = "Dgvmatkul"
        Me.Dgvmatkul.RowHeadersWidth = 51
        Me.Dgvmatkul.RowTemplate.Height = 24
        Me.Dgvmatkul.Size = New System.Drawing.Size(724, 216)
        Me.Dgvmatkul.TabIndex = 88
        '
        'kelas
        '
        Me.kelas.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kelas.Location = New System.Drawing.Point(315, 204)
        Me.kelas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.kelas.Name = "kelas"
        Me.kelas.Size = New System.Drawing.Size(315, 34)
        Me.kelas.TabIndex = 87
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(53, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(5)
        Me.Label1.Size = New System.Drawing.Size(102, 42)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "Kelas"
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(652, 254)
        Me.BtnSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(131, 42)
        Me.BtnSearch.TabIndex = 85
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(652, 208)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(131, 42)
        Me.BtnDelete.TabIndex = 84
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(652, 162)
        Me.BtnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(131, 42)
        Me.BtnUpdate.TabIndex = 83
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(652, 116)
        Me.BtnSimpan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(131, 42)
        Me.BtnSimpan.TabIndex = 82
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'nama
        '
        Me.nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama.Location = New System.Drawing.Point(315, 162)
        Me.nama.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(315, 34)
        Me.nama.TabIndex = 81
        '
        'NIM
        '
        Me.NIM.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NIM.Location = New System.Drawing.Point(315, 116)
        Me.NIM.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NIM.Name = "NIM"
        Me.NIM.Size = New System.Drawing.Size(315, 34)
        Me.NIM.TabIndex = 80
        '
        'LblSatuan
        '
        Me.LblSatuan.AutoSize = True
        Me.LblSatuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSatuan.Location = New System.Drawing.Point(53, 189)
        Me.LblSatuan.Name = "LblSatuan"
        Me.LblSatuan.Size = New System.Drawing.Size(0, 25)
        Me.LblSatuan.TabIndex = 79
        '
        'LblNamaBarang
        '
        Me.LblNamaBarang.AutoSize = True
        Me.LblNamaBarang.BackColor = System.Drawing.Color.Transparent
        Me.LblNamaBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNamaBarang.ForeColor = System.Drawing.Color.White
        Me.LblNamaBarang.Location = New System.Drawing.Point(53, 154)
        Me.LblNamaBarang.Name = "LblNamaBarang"
        Me.LblNamaBarang.Padding = New System.Windows.Forms.Padding(5)
        Me.LblNamaBarang.Size = New System.Drawing.Size(229, 42)
        Me.LblNamaBarang.TabIndex = 78
        Me.LblNamaBarang.Text = "Nama Lengkap"
        '
        'LblIdBarang
        '
        Me.LblIdBarang.AutoSize = True
        Me.LblIdBarang.BackColor = System.Drawing.Color.Transparent
        Me.LblIdBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIdBarang.ForeColor = System.Drawing.Color.White
        Me.LblIdBarang.Location = New System.Drawing.Point(53, 108)
        Me.LblIdBarang.Name = "LblIdBarang"
        Me.LblIdBarang.Padding = New System.Windows.Forms.Padding(5)
        Me.LblIdBarang.Size = New System.Drawing.Size(78, 42)
        Me.LblIdBarang.TabIndex = 77
        Me.LblIdBarang.Text = "NIM"
        '
        'LblCRUD
        '
        Me.LblCRUD.AutoSize = True
        Me.LblCRUD.BackColor = System.Drawing.Color.Transparent
        Me.LblCRUD.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCRUD.ForeColor = System.Drawing.Color.White
        Me.LblCRUD.Location = New System.Drawing.Point(205, 27)
        Me.LblCRUD.Name = "LblCRUD"
        Me.LblCRUD.Size = New System.Drawing.Size(368, 38)
        Me.LblCRUD.TabIndex = 76
        Me.LblCRUD.Text = "Input Data Mata Kuliah"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(53, 280)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(5)
        Me.Label2.Size = New System.Drawing.Size(216, 42)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Jenis Kelamin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(53, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(5)
        Me.Label3.Size = New System.Drawing.Size(219, 42)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Program Studi"
        '
        'prodi
        '
        Me.prodi.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prodi.Location = New System.Drawing.Point(315, 246)
        Me.prodi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.prodi.Name = "prodi"
        Me.prodi.Size = New System.Drawing.Size(315, 34)
        Me.prodi.TabIndex = 91
        '
        'chekboxLaki
        '
        Me.chekboxLaki.AutoSize = True
        Me.chekboxLaki.BackColor = System.Drawing.Color.Transparent
        Me.chekboxLaki.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chekboxLaki.Location = New System.Drawing.Point(316, 293)
        Me.chekboxLaki.Name = "chekboxLaki"
        Me.chekboxLaki.Size = New System.Drawing.Size(134, 29)
        Me.chekboxLaki.TabIndex = 92
        Me.chekboxLaki.Text = "Laki - Laki"
        Me.chekboxLaki.UseVisualStyleBackColor = False
        '
        'chekboxPerempuan
        '
        Me.chekboxPerempuan.AutoSize = True
        Me.chekboxPerempuan.BackColor = System.Drawing.Color.Transparent
        Me.chekboxPerempuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chekboxPerempuan.Location = New System.Drawing.Point(486, 293)
        Me.chekboxPerempuan.Name = "chekboxPerempuan"
        Me.chekboxPerempuan.Size = New System.Drawing.Size(144, 29)
        Me.chekboxPerempuan.TabIndex = 93
        Me.chekboxPerempuan.Text = "Perempuan"
        Me.chekboxPerempuan.UseVisualStyleBackColor = False
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(652, 300)
        Me.back.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(131, 42)
        Me.back.TabIndex = 94
        Me.back.Text = "Back"
        Me.back.UseVisualStyleBackColor = True
        '
        'Data_Mahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sistem_Akademik.My.Resources.Resources.Rectangle_26
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(847, 594)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.chekboxPerempuan)
        Me.Controls.Add(Me.chekboxLaki)
        Me.Controls.Add(Me.prodi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Dgvmatkul)
        Me.Controls.Add(Me.kelas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.NIM)
        Me.Controls.Add(Me.LblSatuan)
        Me.Controls.Add(Me.LblNamaBarang)
        Me.Controls.Add(Me.LblIdBarang)
        Me.Controls.Add(Me.LblCRUD)
        Me.DoubleBuffered = True
        Me.Name = "Data_Mahasiswa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data_Mahasiswa"
        CType(Me.Dgvmatkul, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dgvmatkul As DataGridView
    Friend WithEvents kelas As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSearch As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents nama As TextBox
    Friend WithEvents NIM As TextBox
    Friend WithEvents LblSatuan As Label
    Friend WithEvents LblNamaBarang As Label
    Friend WithEvents LblIdBarang As Label
    Friend WithEvents LblCRUD As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents prodi As TextBox
    Friend WithEvents chekboxLaki As CheckBox
    Friend WithEvents chekboxPerempuan As CheckBox
    Friend WithEvents back As Button
End Class
