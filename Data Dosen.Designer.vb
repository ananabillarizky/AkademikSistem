<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_Dosen
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
        Me.SearchTxtBox = New System.Windows.Forms.TextBox()
        Me.DgvBarang = New System.Windows.Forms.DataGridView()
        Me.Matkul = New System.Windows.Forms.TextBox()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.nama_dosen = New System.Windows.Forms.TextBox()
        Me.NIP = New System.Windows.Forms.TextBox()
        Me.LblSatuan = New System.Windows.Forms.Label()
        Me.LblNamaBarang = New System.Windows.Forms.Label()
        Me.LblIdBarang = New System.Windows.Forms.Label()
        Me.LblCRUD = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DgvBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SearchTxtBox
        '
        Me.SearchTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTxtBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SearchTxtBox.Location = New System.Drawing.Point(51, 301)
        Me.SearchTxtBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SearchTxtBox.Name = "SearchTxtBox"
        Me.SearchTxtBox.Size = New System.Drawing.Size(402, 34)
        Me.SearchTxtBox.TabIndex = 66
        '
        'DgvBarang
        '
        Me.DgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBarang.Location = New System.Drawing.Point(51, 352)
        Me.DgvBarang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DgvBarang.Name = "DgvBarang"
        Me.DgvBarang.RowHeadersWidth = 51
        Me.DgvBarang.RowTemplate.Height = 24
        Me.DgvBarang.Size = New System.Drawing.Size(538, 216)
        Me.DgvBarang.TabIndex = 64
        '
        'Matkul
        '
        Me.Matkul.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Matkul.Location = New System.Drawing.Point(281, 196)
        Me.Matkul.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Matkul.Name = "Matkul"
        Me.Matkul.Size = New System.Drawing.Size(308, 34)
        Me.Matkul.TabIndex = 63
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.Red
        Me.BtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.White
        Me.BtnDelete.Location = New System.Drawing.Point(322, 247)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(131, 42)
        Me.BtnDelete.TabIndex = 62
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.MediumBlue
        Me.BtnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.ForeColor = System.Drawing.Color.White
        Me.BtnUpdate.Location = New System.Drawing.Point(187, 247)
        Me.BtnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(131, 42)
        Me.BtnUpdate.TabIndex = 61
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'BtnSimpan
        '
        Me.BtnSimpan.BackColor = System.Drawing.Color.Green
        Me.BtnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpan.ForeColor = System.Drawing.Color.White
        Me.BtnSimpan.Location = New System.Drawing.Point(51, 247)
        Me.BtnSimpan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(131, 42)
        Me.BtnSimpan.TabIndex = 60
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = False
        '
        'nama_dosen
        '
        Me.nama_dosen.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama_dosen.Location = New System.Drawing.Point(281, 153)
        Me.nama_dosen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nama_dosen.Name = "nama_dosen"
        Me.nama_dosen.Size = New System.Drawing.Size(308, 34)
        Me.nama_dosen.TabIndex = 59
        '
        'NIP
        '
        Me.NIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NIP.Location = New System.Drawing.Point(281, 110)
        Me.NIP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NIP.Name = "NIP"
        Me.NIP.Size = New System.Drawing.Size(308, 34)
        Me.NIP.TabIndex = 58
        '
        'LblSatuan
        '
        Me.LblSatuan.AutoSize = True
        Me.LblSatuan.BackColor = System.Drawing.Color.Transparent
        Me.LblSatuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSatuan.ForeColor = System.Drawing.Color.Transparent
        Me.LblSatuan.Location = New System.Drawing.Point(51, 196)
        Me.LblSatuan.Name = "LblSatuan"
        Me.LblSatuan.Size = New System.Drawing.Size(177, 32)
        Me.LblSatuan.TabIndex = 57
        Me.LblSatuan.Text = "Mata Kuliah"
        '
        'LblNamaBarang
        '
        Me.LblNamaBarang.AutoSize = True
        Me.LblNamaBarang.BackColor = System.Drawing.Color.Transparent
        Me.LblNamaBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNamaBarang.ForeColor = System.Drawing.Color.Transparent
        Me.LblNamaBarang.Location = New System.Drawing.Point(51, 153)
        Me.LblNamaBarang.Name = "LblNamaBarang"
        Me.LblNamaBarang.Size = New System.Drawing.Size(219, 32)
        Me.LblNamaBarang.TabIndex = 56
        Me.LblNamaBarang.Text = "Nama Lengkap"
        '
        'LblIdBarang
        '
        Me.LblIdBarang.AutoSize = True
        Me.LblIdBarang.BackColor = System.Drawing.Color.Transparent
        Me.LblIdBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIdBarang.ForeColor = System.Drawing.Color.Transparent
        Me.LblIdBarang.Location = New System.Drawing.Point(51, 112)
        Me.LblIdBarang.Name = "LblIdBarang"
        Me.LblIdBarang.Size = New System.Drawing.Size(64, 32)
        Me.LblIdBarang.TabIndex = 55
        Me.LblIdBarang.Text = "NIP"
        '
        'LblCRUD
        '
        Me.LblCRUD.AutoSize = True
        Me.LblCRUD.BackColor = System.Drawing.Color.Transparent
        Me.LblCRUD.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCRUD.ForeColor = System.Drawing.Color.Transparent
        Me.LblCRUD.Location = New System.Drawing.Point(128, 21)
        Me.LblCRUD.Name = "LblCRUD"
        Me.LblCRUD.Size = New System.Drawing.Size(329, 44)
        Me.LblCRUD.TabIndex = 54
        Me.LblCRUD.Text = "Input Data Dosen"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(458, 247)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 42)
        Me.Button1.TabIndex = 67
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(458, 293)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 42)
        Me.Button2.TabIndex = 68
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Data_Dosen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sistem_Akademik.My.Resources.Resources.Rectangle_26
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(654, 606)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SearchTxtBox)
        Me.Controls.Add(Me.DgvBarang)
        Me.Controls.Add(Me.Matkul)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.nama_dosen)
        Me.Controls.Add(Me.NIP)
        Me.Controls.Add(Me.LblSatuan)
        Me.Controls.Add(Me.LblNamaBarang)
        Me.Controls.Add(Me.LblIdBarang)
        Me.Controls.Add(Me.LblCRUD)
        Me.DoubleBuffered = True
        Me.Name = "Data_Dosen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data_Dosen"
        CType(Me.DgvBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SearchTxtBox As TextBox
    Friend WithEvents DgvBarang As DataGridView
    Friend WithEvents Matkul As TextBox
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents nama_dosen As TextBox
    Friend WithEvents NIP As TextBox
    Friend WithEvents LblSatuan As Label
    Friend WithEvents LblNamaBarang As Label
    Friend WithEvents LblIdBarang As Label
    Friend WithEvents LblCRUD As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
