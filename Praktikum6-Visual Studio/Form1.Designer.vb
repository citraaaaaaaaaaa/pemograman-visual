<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        txtNama = New TextBox()
        txtNIM = New TextBox()
        txtJurusan = New TextBox()
        lblNama = New Label()
        lblNIM = New Label()
        lblJurusan = New Label()
        btnTampilkan = New Button()
        btnTambah = New Button()
        dgvMahasiswa = New DataGridView()
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(535, 113)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(150, 31)
        txtNama.TabIndex = 0
        ' 
        ' txtNIM
        ' 
        txtNIM.Location = New Point(535, 176)
        txtNIM.Name = "txtNIM"
        txtNIM.Size = New Size(150, 31)
        txtNIM.TabIndex = 1
        ' 
        ' txtJurusan
        ' 
        txtJurusan.Location = New Point(535, 253)
        txtJurusan.Name = "txtJurusan"
        txtJurusan.Size = New Size(150, 31)
        txtJurusan.TabIndex = 2
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(445, 113)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(63, 25)
        lblNama.TabIndex = 3
        lblNama.Text = "Nama:"
        ' 
        ' lblNIM
        ' 
        lblNIM.AutoSize = True
        lblNIM.Location = New Point(445, 176)
        lblNIM.Name = "lblNIM"
        lblNIM.Size = New Size(50, 25)
        lblNIM.TabIndex = 4
        lblNIM.Text = "NIM:"
        ' 
        ' lblJurusan
        ' 
        lblJurusan.AutoSize = True
        lblJurusan.Location = New Point(445, 259)
        lblJurusan.Name = "lblJurusan"
        lblJurusan.Size = New Size(75, 25)
        lblJurusan.TabIndex = 5
        lblJurusan.Text = "Jurusan:"
        ' 
        ' btnTampilkan
        ' 
        btnTampilkan.Location = New Point(188, 355)
        btnTampilkan.Name = "btnTampilkan"
        btnTampilkan.Size = New Size(112, 34)
        btnTampilkan.TabIndex = 6
        btnTampilkan.Text = "Tampilkan"
        btnTampilkan.UseVisualStyleBackColor = True
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(492, 323)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(112, 34)
        btnTambah.TabIndex = 7
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' dgvMahasiswa
        ' 
        dgvMahasiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMahasiswa.Location = New Point(42, 92)
        dgvMahasiswa.Name = "dgvMahasiswa"
        dgvMahasiswa.RowHeadersWidth = 62
        dgvMahasiswa.Size = New Size(360, 225)
        dgvMahasiswa.TabIndex = 8
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgvMahasiswa)
        Controls.Add(btnTambah)
        Controls.Add(btnTampilkan)
        Controls.Add(lblJurusan)
        Controls.Add(lblNIM)
        Controls.Add(lblNama)
        Controls.Add(txtJurusan)
        Controls.Add(txtNIM)
        Controls.Add(txtNama)
        Name = "Form1"
        Text = "Form1"
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents txtJurusan As TextBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblNIM As Label
    Friend WithEvents lblJurusan As Label
    Friend WithEvents btnTampilkan As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents dgvMahasiswa As DataGridView

    Private Sub btnTampil_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        dgvMahasiswa.AutoGenerateColumns = True
        dgvMahasiswa.DataSource = ModQuery.TampilkanData()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblNama.Click

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If ModQuery.TambahData(
        txtJurusan.Text,
        txtNama.Text,
        txtJurusan.Text
        ) Then
            MessageBox.Show("Data berhasil ditambahkan")
        End If
        txtJurusan.Clear()
        txtNIM.Clear()
        txtNama.Clear()
    End Sub
End Class
