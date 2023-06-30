<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search_Mahasiswa
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SearchTxtBox = New System.Windows.Forms.TextBox()
        Me.LblCRUD = New System.Windows.Forms.Label()
        Me.Dgvmatkul = New System.Windows.Forms.DataGridView()
        CType(Me.Dgvmatkul, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(709, 102)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 42)
        Me.Button2.TabIndex = 84
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'SearchTxtBox
        '
        Me.SearchTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTxtBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SearchTxtBox.Location = New System.Drawing.Point(72, 110)
        Me.SearchTxtBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SearchTxtBox.Name = "SearchTxtBox"
        Me.SearchTxtBox.Size = New System.Drawing.Size(631, 34)
        Me.SearchTxtBox.TabIndex = 83
        '
        'LblCRUD
        '
        Me.LblCRUD.AutoSize = True
        Me.LblCRUD.BackColor = System.Drawing.Color.Transparent
        Me.LblCRUD.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCRUD.ForeColor = System.Drawing.Color.White
        Me.LblCRUD.Location = New System.Drawing.Point(214, 21)
        Me.LblCRUD.Name = "LblCRUD"
        Me.LblCRUD.Size = New System.Drawing.Size(473, 46)
        Me.LblCRUD.TabIndex = 82
        Me.LblCRUD.Text = "Search Data Mahasiswa"
        '
        'Dgvmatkul
        '
        Me.Dgvmatkul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvmatkul.Location = New System.Drawing.Point(72, 166)
        Me.Dgvmatkul.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Dgvmatkul.Name = "Dgvmatkul"
        Me.Dgvmatkul.RowHeadersWidth = 51
        Me.Dgvmatkul.RowTemplate.Height = 24
        Me.Dgvmatkul.Size = New System.Drawing.Size(768, 345)
        Me.Dgvmatkul.TabIndex = 89
        '
        'Search_Mahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sistem_Akademik.My.Resources.Resources.Rectangle_26
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(926, 541)
        Me.Controls.Add(Me.Dgvmatkul)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.SearchTxtBox)
        Me.Controls.Add(Me.LblCRUD)
        Me.DoubleBuffered = True
        Me.Name = "Search_Mahasiswa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search_Mahasiswa"
        CType(Me.Dgvmatkul, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents SearchTxtBox As TextBox
    Friend WithEvents LblCRUD As Label
    Friend WithEvents Dgvmatkul As DataGridView
End Class
