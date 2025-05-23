<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frmstatusbarang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.kategori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.noseri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggaljam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kondisi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lokasi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.keter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nosj = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tglselesai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pick_ga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kategori, Me.noseri, Me.nama, Me.tanggaljam, Me.dc, Me.kondisi, Me.lokasi, Me.status, Me.keter, Me.nosj, Me.tglselesai, Me.pick_ga})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(657, 245)
        Me.DataGridView1.TabIndex = 4
        '
        'kategori
        '
        Me.kategori.HeaderText = "KATEGORI"
        Me.kategori.Name = "kategori"
        '
        'noseri
        '
        Me.noseri.HeaderText = "NOMOR SERI/AKTIVA"
        Me.noseri.Name = "noseri"
        '
        'nama
        '
        Me.nama.HeaderText = "DESC/NAMA BARANG"
        Me.nama.Name = "nama"
        '
        'tanggaljam
        '
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.tanggaljam.DefaultCellStyle = DataGridViewCellStyle3
        Me.tanggaljam.HeaderText = "TANGGAL SERVICE"
        Me.tanggaljam.Name = "tanggaljam"
        '
        'dc
        '
        Me.dc.HeaderText = "PICK DC"
        Me.dc.Name = "dc"
        '
        'kondisi
        '
        Me.kondisi.HeaderText = "KONDISI"
        Me.kondisi.Name = "kondisi"
        '
        'lokasi
        '
        Me.lokasi.HeaderText = "LOKASI"
        Me.lokasi.Name = "lokasi"
        '
        'status
        '
        Me.status.HeaderText = "STATUS"
        Me.status.Name = "status"
        Me.status.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'keter
        '
        Me.keter.HeaderText = "KETERANGAN"
        Me.keter.Name = "keter"
        '
        'nosj
        '
        Me.nosj.HeaderText = "NOMOR SURAT JALAN"
        Me.nosj.Name = "nosj"
        '
        'tglselesai
        '
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.tglselesai.DefaultCellStyle = DataGridViewCellStyle4
        Me.tglselesai.HeaderText = "TANGGAL SELESAI"
        Me.tglselesai.Name = "tglselesai"
        Me.tglselesai.ReadOnly = True
        '
        'pick_ga
        '
        Me.pick_ga.HeaderText = "PICK GA"
        Me.pick_ga.Name = "pick_ga"
        '
        'Frmstatusbarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 245)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Frmstatusbarang"
        Me.Text = "Frmstatusbarang"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents kategori As DataGridViewTextBoxColumn
    Friend WithEvents noseri As DataGridViewTextBoxColumn
    Friend WithEvents nama As DataGridViewTextBoxColumn
    Friend WithEvents tanggaljam As DataGridViewTextBoxColumn
    Friend WithEvents dc As DataGridViewTextBoxColumn
    Friend WithEvents kondisi As DataGridViewTextBoxColumn
    Friend WithEvents lokasi As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents keter As DataGridViewTextBoxColumn
    Friend WithEvents nosj As DataGridViewTextBoxColumn
    Friend WithEvents tglselesai As DataGridViewTextBoxColumn
    Friend WithEvents pick_ga As DataGridViewTextBoxColumn
End Class
