<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPajak
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
        btnHitung = New Button()
        btnKeluar = New Button()
        txtRp = New TextBox()
        lblPajak1 = New Label()
        lblPajak2 = New Label()
        lblPajak3 = New Label()
        lblMasukkanPendapatan = New Label()
        lblRp = New Label()
        SuspendLayout()
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(338, 333)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(112, 34)
        btnHitung.TabIndex = 0
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(338, 382)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(112, 34)
        btnKeluar.TabIndex = 1
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' txtRp
        ' 
        txtRp.Location = New Point(320, 269)
        txtRp.Name = "txtRp"
        txtRp.Size = New Size(150, 31)
        txtRp.TabIndex = 2
        ' 
        ' lblPajak1
        ' 
        lblPajak1.AutoSize = True
        lblPajak1.Location = New Point(231, 72)
        lblPajak1.Name = "lblPajak1"
        lblPajak1.Size = New Size(321, 25)
        lblPajak1.TabIndex = 3
        lblPajak1.Text = "Pendapatan lebih dari 5 juta, 10% Pajak"
        ' 
        ' lblPajak2
        ' 
        lblPajak2.AutoSize = True
        lblPajak2.Location = New Point(231, 107)
        lblPajak2.Name = "lblPajak2"
        lblPajak2.Size = New Size(331, 25)
        lblPajak2.TabIndex = 4
        lblPajak2.Text = "Pendapatan lebih dari 30 juta, 20% Pajak"
        ' 
        ' lblPajak3
        ' 
        lblPajak3.AutoSize = True
        lblPajak3.Location = New Point(231, 144)
        lblPajak3.Name = "lblPajak3"
        lblPajak3.Size = New Size(341, 25)
        lblPajak3.TabIndex = 5
        lblPajak3.Text = "Pendapatan lebih dari 100 juta, 30% Pajak"
        ' 
        ' lblMasukkanPendapatan
        ' 
        lblMasukkanPendapatan.AutoSize = True
        lblMasukkanPendapatan.Location = New Point(304, 186)
        lblMasukkanPendapatan.Name = "lblMasukkanPendapatan"
        lblMasukkanPendapatan.Size = New Size(190, 25)
        lblMasukkanPendapatan.TabIndex = 6
        lblMasukkanPendapatan.Text = "Masukkan Pendapatan"
        ' 
        ' lblRp
        ' 
        lblRp.AutoSize = True
        lblRp.Location = New Point(231, 272)
        lblRp.Name = "lblRp"
        lblRp.Size = New Size(38, 25)
        lblRp.TabIndex = 7
        lblRp.Text = "Rp."
        ' 
        ' FormPajak
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblRp)
        Controls.Add(lblMasukkanPendapatan)
        Controls.Add(lblPajak3)
        Controls.Add(lblPajak2)
        Controls.Add(lblPajak1)
        Controls.Add(txtRp)
        Controls.Add(btnKeluar)
        Controls.Add(btnHitung)
        Name = "FormPajak"
        Text = "FormPajak"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnHitung As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents txtRp As TextBox
    Friend WithEvents lblPajak1 As Label
    Friend WithEvents lblPajak2 As Label
    Friend WithEvents lblPajak3 As Label
    Friend WithEvents lblMasukkanPendapatan As Label
    Friend WithEvents lblRp As Label
End Class
