<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPendaftaran
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
        components = New ComponentModel.Container()
        lblJudul = New Label()
        lblNIM = New Label()
        lblNama = New Label()
        lblJurusan = New Label()
        lblIpk = New Label()
        lblAngkatan = New Label()
        lblStatus = New Label()
        lblDaftar = New Label()
        txtNim = New TextBox()
        txtNama = New TextBox()
        txtAngkatan = New TextBox()
        txtIpk = New TextBox()
        cboJurusan = New ComboBox()
        lstMahasiswa = New ListBox()
        btnSimpan = New Button()
        btnBersihkan = New Button()
        btnEkspor = New Button()
        errInput = New ErrorProvider(components)
        CType(errInput, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.Location = New Point(31, 21)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(329, 38)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Pendaftaran Mahasiswa"
        ' 
        ' lblNIM
        ' 
        lblNIM.AutoSize = True
        lblNIM.Location = New Point(43, 87)
        lblNIM.Name = "lblNIM"
        lblNIM.Size = New Size(46, 25)
        lblNIM.TabIndex = 1
        lblNIM.Text = "NIM"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(43, 132)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(59, 25)
        lblNama.TabIndex = 2
        lblNama.Text = "Nama"
        ' 
        ' lblJurusan
        ' 
        lblJurusan.AutoSize = True
        lblJurusan.Location = New Point(43, 177)
        lblJurusan.Name = "lblJurusan"
        lblJurusan.Size = New Size(71, 25)
        lblJurusan.TabIndex = 3
        lblJurusan.Text = "Jurusan"
        ' 
        ' lblIpk
        ' 
        lblIpk.AutoSize = True
        lblIpk.Location = New Point(43, 269)
        lblIpk.Name = "lblIpk"
        lblIpk.Size = New Size(37, 25)
        lblIpk.TabIndex = 4
        lblIpk.Text = "IPK"
        ' 
        ' lblAngkatan
        ' 
        lblAngkatan.AutoSize = True
        lblAngkatan.Location = New Point(43, 224)
        lblAngkatan.Name = "lblAngkatan"
        lblAngkatan.Size = New Size(88, 25)
        lblAngkatan.TabIndex = 5
        lblAngkatan.Text = "Angkatan"
        ' 
        ' lblStatus
        ' 
        lblStatus.Location = New Point(43, 378)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(780, 470)
        lblStatus.TabIndex = 6
        lblStatus.Text = "Siap."
        ' 
        ' lblDaftar
        ' 
        lblDaftar.AutoSize = True
        lblDaftar.Location = New Point(456, 34)
        lblDaftar.Name = "lblDaftar"
        lblDaftar.Size = New Size(133, 25)
        lblDaftar.TabIndex = 7
        lblDaftar.Text = "Data tersimpan"
        ' 
        ' txtNim
        ' 
        txtNim.Location = New Point(182, 84)
        txtNim.MaxLength = 9
        txtNim.Name = "txtNim"
        txtNim.Size = New Size(230, 31)
        txtNim.TabIndex = 8
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(182, 132)
        txtNama.MaxLength = 100
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(230, 31)
        txtNama.TabIndex = 9
        ' 
        ' txtAngkatan
        ' 
        txtAngkatan.Location = New Point(182, 232)
        txtAngkatan.MaxLength = 4
        txtAngkatan.Name = "txtAngkatan"
        txtAngkatan.Size = New Size(230, 31)
        txtAngkatan.TabIndex = 10
        ' 
        ' txtIpk
        ' 
        txtIpk.Location = New Point(182, 278)
        txtIpk.MaxLength = 4
        txtIpk.Name = "txtIpk"
        txtIpk.Size = New Size(230, 31)
        txtIpk.TabIndex = 11
        ' 
        ' cboJurusan
        ' 
        cboJurusan.DropDownStyle = ComboBoxStyle.DropDownList
        cboJurusan.FormattingEnabled = True
        cboJurusan.Items.AddRange(New Object() {"Teknik Informatika", "Sistem Informasi", "Manajemen Informatika", "Teknik Komputer"})
        cboJurusan.Location = New Point(182, 183)
        cboJurusan.Name = "cboJurusan"
        cboJurusan.Size = New Size(230, 33)
        cboJurusan.TabIndex = 12
        ' 
        ' lstMahasiswa
        ' 
        lstMahasiswa.FormattingEnabled = True
        lstMahasiswa.HorizontalScrollbar = True
        lstMahasiswa.IntegralHeight = False
        lstMahasiswa.Location = New Point(456, 73)
        lstMahasiswa.Name = "lstMahasiswa"
        lstMahasiswa.Size = New Size(252, 262)
        lstMahasiswa.TabIndex = 13
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(182, 341)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(112, 34)
        btnSimpan.TabIndex = 14
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnBersihkan
        ' 
        btnBersihkan.CausesValidation = False
        btnBersihkan.Location = New Point(300, 341)
        btnBersihkan.Name = "btnBersihkan"
        btnBersihkan.Size = New Size(112, 34)
        btnBersihkan.TabIndex = 15
        btnBersihkan.Text = "Bersihkan"
        btnBersihkan.UseVisualStyleBackColor = True
        ' 
        ' btnEkspor
        ' 
        btnEkspor.CausesValidation = False
        btnEkspor.Location = New Point(456, 358)
        btnEkspor.Name = "btnEkspor"
        btnEkspor.Size = New Size(168, 34)
        btnEkspor.TabIndex = 16
        btnEkspor.Text = "Ekspor ke CSV"
        btnEkspor.UseVisualStyleBackColor = True
        ' 
        ' errInput
        ' 
        errInput.ContainerControl = Me
        ' 
        ' FrmPendaftaran
        ' 
        AcceptButton = btnSimpan
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(758, 414)
        Controls.Add(btnEkspor)
        Controls.Add(btnBersihkan)
        Controls.Add(btnSimpan)
        Controls.Add(lstMahasiswa)
        Controls.Add(cboJurusan)
        Controls.Add(txtIpk)
        Controls.Add(txtAngkatan)
        Controls.Add(txtNama)
        Controls.Add(txtNim)
        Controls.Add(lblDaftar)
        Controls.Add(lblStatus)
        Controls.Add(lblAngkatan)
        Controls.Add(lblIpk)
        Controls.Add(lblJurusan)
        Controls.Add(lblNama)
        Controls.Add(lblNIM)
        Controls.Add(lblJudul)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmPendaftaran"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pendaftaran Mahasiswa"
        CType(errInput, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents lblNIM As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblJurusan As Label
    Friend WithEvents lblIpk As Label
    Friend WithEvents lblAngkatan As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblDaftar As Label
    Friend WithEvents txtNim As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtAngkatan As TextBox
    Friend WithEvents txtIpk As TextBox
    Friend WithEvents cboJurusan As ComboBox
    Friend WithEvents lstMahasiswa As ListBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBersihkan As Button
    Friend WithEvents btnEkspor As Button
    Friend WithEvents errInput As ErrorProvider

    Private Sub txtNim_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNim.Validating
        If txtNim.Text = "" Then Return         ' kosong dicek nanti saat Simpan
        If SemuaDigit(txtNim.Text, 9) Then
            errInput.SetError(txtNim, "")
        Else
            errInput.SetError(txtNim, "NIM harus 9 digit angka.")
            ' e.Cancel = True akan menahan fokus di txtNim. Sengaja tidak dipakai.
        End If
    End Sub


End Class
