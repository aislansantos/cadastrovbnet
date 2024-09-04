<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTrocaSenha
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtSenhaAtual = New System.Windows.Forms.TextBox()
        Me.TxtConfirmaNovaSenha = New System.Windows.Forms.TextBox()
        Me.TxtNovaSenha = New System.Windows.Forms.TextBox()
        Me.BtnAlterar = New System.Windows.Forms.Button()
        Me.ChkMostrarSenha = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Senha Atual"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nova Senha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Confirma NovaSenha"
        '
        'TxtSenhaAtual
        '
        Me.TxtSenhaAtual.Location = New System.Drawing.Point(160, 11)
        Me.TxtSenhaAtual.Name = "TxtSenhaAtual"
        Me.TxtSenhaAtual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtSenhaAtual.Size = New System.Drawing.Size(268, 20)
        Me.TxtSenhaAtual.TabIndex = 1
        '
        'TxtConfirmaNovaSenha
        '
        Me.TxtConfirmaNovaSenha.Location = New System.Drawing.Point(160, 63)
        Me.TxtConfirmaNovaSenha.Name = "TxtConfirmaNovaSenha"
        Me.TxtConfirmaNovaSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtConfirmaNovaSenha.Size = New System.Drawing.Size(268, 20)
        Me.TxtConfirmaNovaSenha.TabIndex = 3
        '
        'TxtNovaSenha
        '
        Me.TxtNovaSenha.Location = New System.Drawing.Point(160, 37)
        Me.TxtNovaSenha.Name = "TxtNovaSenha"
        Me.TxtNovaSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtNovaSenha.Size = New System.Drawing.Size(268, 20)
        Me.TxtNovaSenha.TabIndex = 2
        '
        'BtnAlterar
        '
        Me.BtnAlterar.Location = New System.Drawing.Point(181, 141)
        Me.BtnAlterar.Name = "BtnAlterar"
        Me.BtnAlterar.Size = New System.Drawing.Size(76, 23)
        Me.BtnAlterar.TabIndex = 5
        Me.BtnAlterar.Text = "Alterar"
        Me.BtnAlterar.UseVisualStyleBackColor = True
        '
        'ChkMostrarSenha
        '
        Me.ChkMostrarSenha.AutoSize = True
        Me.ChkMostrarSenha.Location = New System.Drawing.Point(171, 108)
        Me.ChkMostrarSenha.Name = "ChkMostrarSenha"
        Me.ChkMostrarSenha.Size = New System.Drawing.Size(95, 17)
        Me.ChkMostrarSenha.TabIndex = 4
        Me.ChkMostrarSenha.Text = "Mostrar Senha"
        Me.ChkMostrarSenha.UseVisualStyleBackColor = True
        '
        'FrmTrocaSenha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 180)
        Me.Controls.Add(Me.ChkMostrarSenha)
        Me.Controls.Add(Me.BtnAlterar)
        Me.Controls.Add(Me.TxtNovaSenha)
        Me.Controls.Add(Me.TxtConfirmaNovaSenha)
        Me.Controls.Add(Me.TxtSenhaAtual)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmTrocaSenha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alterar Senha"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtSenhaAtual As TextBox
    Friend WithEvents TxtConfirmaNovaSenha As TextBox
    Friend WithEvents TxtNovaSenha As TextBox
    Friend WithEvents BtnAlterar As Button
    Friend WithEvents ChkMostrarSenha As CheckBox
End Class
