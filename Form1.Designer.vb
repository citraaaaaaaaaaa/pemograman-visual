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
        lblRole = New Label()
        lblNama = New Label()
        lblNim = New Label()
        pic1 = New PictureBox()
        btnLogin = New Button()
        txtNama = New TextBox()
        txtNim = New TextBox()
        cbRole = New ComboBox()
        CType(pic1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Location = New Point(254, 209)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(55, 25)
        lblRole.TabIndex = 3
        lblRole.Text = "Role :"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(254, 252)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(68, 25)
        lblNama.TabIndex = 4
        lblNama.Text = "Nama :"
        ' 
        ' lblNim
        ' 
        lblNim.AutoSize = True
        lblNim.Location = New Point(254, 291)
        lblNim.Name = "lblNim"
        lblNim.Size = New Size(54, 25)
        lblNim.TabIndex = 5
        lblNim.Text = "Nim :"
        ' 
        ' pic1
        ' 
        pic1.Location = New Point(339, 54)
        pic1.Name = "pic1"
        pic1.Size = New Size(150, 128)
        pic1.SizeMode = PictureBoxSizeMode.Zoom
        pic1.TabIndex = 6
        pic1.TabStop = False
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(361, 349)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(112, 34)
        btnLogin.TabIndex = 7
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(339, 252)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(150, 31)
        txtNama.TabIndex = 9
        ' 
        ' txtNim
        ' 
        txtNim.Location = New Point(339, 291)
        txtNim.Name = "txtNim"
        txtNim.Size = New Size(150, 31)
        txtNim.TabIndex = 10
        ' 
        ' cbRole
        ' 
        cbRole.DropDownStyle = ComboBoxStyle.DropDownList
        cbRole.FormattingEnabled = True
        cbRole.Items.AddRange(New Object() {"Staff", "Manager"})
        cbRole.Location = New Point(339, 201)
        cbRole.Name = "cbRole"
        cbRole.Size = New Size(182, 33)
        cbRole.TabIndex = 11
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(cbRole)
        Controls.Add(txtNim)
        Controls.Add(txtNama)
        Controls.Add(btnLogin)
        Controls.Add(pic1)
        Controls.Add(lblNim)
        Controls.Add(lblNama)
        Controls.Add(lblRole)
        Name = "Form1"
        Text = "Form1"
        CType(pic1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblRole As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblNim As Label
    Friend WithEvents pic1 As PictureBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNim As TextBox
    Friend WithEvents cbRole As ComboBox

End Class
