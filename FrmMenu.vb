Public Class FrmMenu
    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub CadastrarUsuárioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarUsuárioToolStripMenuItem.Click
        If pAdministrador Then
            FrmUsuarioConsulta.Show()
        Else
            MsgBox("Acesso não permitido", vbExclamation, sistema)
        End If
    End Sub

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Using frm = New FrmLogin
            frm.ShowDialog()
            If Not pAcessoPermitido Then
                Application.Exit()
            End If
        End Using

    End Sub

    Private Sub ConsultarUsuárioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarUsuárioToolStripMenuItem.Click
        FrmUsuarioConsulta.Show()
    End Sub

    Private Sub TrocarSenhaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrocarSenhaToolStripMenuItem.Click
        FrmTrocaSenha.Show()
    End Sub

    Private Sub UsuáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuáriosToolStripMenuItem.Click
        FrmUsuarioRelatorio.Show()
    End Sub
End Class