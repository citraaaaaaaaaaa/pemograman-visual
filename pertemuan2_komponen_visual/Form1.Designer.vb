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
        lblNama = New Label()
        lblNIM = New Label()
        lblKOM = New Label()
        btnTampilkan = New Button()
        btnHapus = New Button()
        btnKeluar = New Button()
        txtNama = New TextBox()
        txtNIM = New TextBox()
        txtKOM = New TextBox()
        SuspendLayout()
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(235, 100)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(59, 25)
        lblNama.TabIndex = 0
        lblNama.Text = "Nama"
        ' 
        ' lblNIM
        ' 
        lblNIM.AutoSize = True
        lblNIM.Location = New Point(235, 148)
        lblNIM.Name = "lblNIM"
        lblNIM.Size = New Size(46, 25)
        lblNIM.TabIndex = 1
        lblNIM.Text = "NIM"
        ' 
        ' lblKOM
        ' 
        lblKOM.AutoSize = True
        lblKOM.Location = New Point(235, 206)
        lblKOM.Name = "lblKOM"
        lblKOM.Size = New Size(51, 25)
        lblKOM.TabIndex = 2
        lblKOM.Text = "KOM"
        ' 
        ' btnTampilkan
        ' 
        btnTampilkan.Location = New Point(296, 266)
        btnTampilkan.Name = "btnTampilkan"
        btnTampilkan.Size = New Size(112, 34)
        btnTampilkan.TabIndex = 3
        btnTampilkan.Text = "Tampilkan"
        btnTampilkan.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(450, 266)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(112, 34)
        btnHapus.TabIndex = 4
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(376, 339)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(112, 34)
        btnKeluar.TabIndex = 5
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(338, 100)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(150, 31)
        txtNama.TabIndex = 6
        ' 
        ' txtNIM
        ' 
        txtNIM.Location = New Point(338, 161)
        txtNIM.Name = "txtNIM"
        txtNIM.Size = New Size(150, 31)
        txtNIM.TabIndex = 7
        ' 
        ' txtKOM
        ' 
        txtKOM.Location = New Point(338, 217)
        txtKOM.Name = "txtKOM"
        txtKOM.Size = New Size(150, 31)
        txtKOM.TabIndex = 8
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtKOM)
        Controls.Add(txtNIM)
        Controls.Add(txtNama)
        Controls.Add(btnKeluar)
        Controls.Add(btnHapus)
        Controls.Add(btnTampilkan)
        Controls.Add(lblKOM)
        Controls.Add(lblNIM)
        Controls.Add(lblNama)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNama As Label
    Friend WithEvents lblNIM As Label
    Friend WithEvents lblKOM As Label
    Friend WithEvents btnTampilkan As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents txtKOM As TextBox

End Class
