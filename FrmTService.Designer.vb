<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTService
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New MetroFramework.Controls.MetroTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.ComboBox5 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.ComboBox4 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.ComboBox3 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.ComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.kategori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.noseri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pick = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kondisi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lokasi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.keter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.MetroPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.MetroLabel8)
        Me.MetroPanel1.Controls.Add(Me.MetroButton2)
        Me.MetroPanel1.Controls.Add(Me.MetroButton1)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(0, 0)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(757, 47)
        Me.MetroPanel1.TabIndex = 0
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel8.Location = New System.Drawing.Point(11, 10)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(227, 25)
        Me.MetroLabel8.TabIndex = 4
        Me.MetroLabel8.Text = "FORM SERVICE BARANG DC"
        Me.MetroLabel8.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(654, 12)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton2.TabIndex = 3
        Me.MetroButton2.Text = "Batal"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(563, 12)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton1.TabIndex = 2
        Me.MetroButton1.Text = "Simpan"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.MetroLabel7)
        Me.GroupBox1.Controls.Add(Me.ComboBox5)
        Me.GroupBox1.Controls.Add(Me.MetroLabel6)
        Me.GroupBox1.Controls.Add(Me.ComboBox4)
        Me.GroupBox1.Controls.Add(Me.MetroLabel5)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.MetroLabel4)
        Me.GroupBox1.Controls.Add(Me.MetroTextBox1)
        Me.GroupBox1.Controls.Add(Me.MetroLabel3)
        Me.GroupBox1.Controls.Add(Me.MetroLabel2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(757, 234)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detail Service Barang"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox3.FontWeight = MetroFramework.MetroTextBoxWeight.Light
        Me.TextBox3.Location = New System.Drawing.Point(584, 71)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(103, 19)
        Me.TextBox3.TabIndex = 15
        Me.TextBox3.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LawnGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(365, 197)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "add list "
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox2.FontWeight = MetroFramework.MetroTextBoxWeight.Light
        Me.TextBox2.Location = New System.Drawing.Point(365, 142)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(332, 42)
        Me.TextBox2.TabIndex = 13
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(273, 147)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(82, 19)
        Me.MetroLabel7.TabIndex = 12
        Me.MetroLabel7.Text = "Keterangan :"
        '
        'ComboBox5
        '
        Me.ComboBox5.AutoCompleteCustomSource.AddRange(New String() {"SERVICE", "P3AT", "SELESAI"})
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.ItemHeight = 23
        Me.ComboBox5.Items.AddRange(New Object() {"SERVICE", "P3AT", "SELESAI"})
        Me.ComboBox5.Location = New System.Drawing.Point(365, 101)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(102, 29)
        Me.ComboBox5.TabIndex = 11
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(273, 105)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(50, 19)
        Me.MetroLabel6.TabIndex = 10
        Me.MetroLabel6.Text = "Status :"
        '
        'ComboBox4
        '
        Me.ComboBox4.AutoCompleteCustomSource.AddRange(New String() {"DC", "GA", "HO", "SUPPLIER"})
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.ItemHeight = 23
        Me.ComboBox4.Items.AddRange(New Object() {"DC", "GA", "HO", "SUPPLIER"})
        Me.ComboBox4.Location = New System.Drawing.Point(135, 142)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(120, 29)
        Me.ComboBox4.TabIndex = 9
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(29, 147)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(51, 19)
        Me.MetroLabel5.TabIndex = 8
        Me.MetroLabel5.Text = "Lokasi :"
        '
        'ComboBox3
        '
        Me.ComboBox3.AutoCompleteCustomSource.AddRange(New String() {"BAIK", "RUSAK" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.ItemHeight = 23
        Me.ComboBox3.Items.AddRange(New Object() {"BAIK", "RUSAK"})
        Me.ComboBox3.Location = New System.Drawing.Point(135, 101)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(120, 29)
        Me.ComboBox3.TabIndex = 7
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(29, 105)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(57, 19)
        Me.MetroLabel4.TabIndex = 6
        Me.MetroLabel4.Text = "Kondisi :"
        '
        'MetroTextBox1
        '
        Me.MetroTextBox1.FontWeight = MetroFramework.MetroTextBoxWeight.Light
        Me.MetroTextBox1.Location = New System.Drawing.Point(135, 67)
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.ReadOnly = True
        Me.MetroTextBox1.Size = New System.Drawing.Size(332, 23)
        Me.MetroTextBox1.TabIndex = 5
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(29, 67)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(102, 19)
        Me.MetroLabel3.TabIndex = 4
        Me.MetroLabel3.Text = "Nama Barang : "
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(365, 31)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(102, 19)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Nomor Aktiva : "
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.ItemHeight = 23
        Me.ComboBox1.Items.AddRange(New Object() {"ANDALAN UTAMA PRIMA (AUP)", "DISTRIBUSION CENTER (DC)"})
        Me.ComboBox1.Location = New System.Drawing.Point(135, 27)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(214, 29)
        Me.ComboBox1.TabIndex = 1
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(29, 31)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(69, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Kategori : "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 281)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(757, 237)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List Service Barang"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kategori, Me.noseri, Me.nama, Me.tgl, Me.pick, Me.kondisi, Me.lokasi, Me.sts, Me.keter, Me.Column1})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(751, 218)
        Me.DataGridView1.TabIndex = 1
        '
        'kategori
        '
        Me.kategori.HeaderText = "Kategori"
        Me.kategori.Name = "kategori"
        '
        'noseri
        '
        Me.noseri.HeaderText = "Nomor Seri"
        Me.noseri.Name = "noseri"
        '
        'nama
        '
        Me.nama.HeaderText = "Nama Barang"
        Me.nama.Name = "nama"
        '
        'tgl
        '
        DataGridViewCellStyle2.Format = "yyyy-MM-dd"
        DataGridViewCellStyle2.NullValue = "yyyy-MM-dd"
        Me.tgl.DefaultCellStyle = DataGridViewCellStyle2
        Me.tgl.HeaderText = "Tanggal"
        Me.tgl.Name = "tgl"
        '
        'pick
        '
        Me.pick.HeaderText = "pick"
        Me.pick.Name = "pick"
        '
        'kondisi
        '
        Me.kondisi.HeaderText = "Kondisi"
        Me.kondisi.Name = "kondisi"
        '
        'lokasi
        '
        Me.lokasi.HeaderText = "Lokasi"
        Me.lokasi.Name = "lokasi"
        '
        'sts
        '
        Me.sts.HeaderText = "status"
        Me.sts.Name = "sts"
        '
        'keter
        '
        Me.keter.HeaderText = "penjelasan"
        Me.keter.Name = "keter"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Hapus"
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column1.Text = "Hapus"
        Me.Column1.UseColumnTextForButtonValue = True
        Me.Column1.Width = 50
        '
        'ComboBox2
        '
        Me.ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(462, 29)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(225, 27)
        Me.ComboBox2.TabIndex = 16
        '
        'FrmTService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 518)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MetroPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTService"
        Me.Text = "FrmTService"
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents kategori As DataGridViewTextBoxColumn
    Friend WithEvents noseri As DataGridViewTextBoxColumn
    Friend WithEvents nama As DataGridViewTextBoxColumn
    Friend WithEvents tgl As DataGridViewTextBoxColumn
    Friend WithEvents pick As DataGridViewTextBoxColumn
    Friend WithEvents kondisi As DataGridViewTextBoxColumn
    Friend WithEvents lokasi As DataGridViewTextBoxColumn
    Friend WithEvents sts As DataGridViewTextBoxColumn
    Friend WithEvents keter As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewButtonColumn
    Friend WithEvents ComboBox5 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ComboBox4 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ComboBox3 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents TextBox3 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ComboBox2 As ComboBox
End Class
