Imports MySql.Data.MySqlClient

Public Class FrmTrocaSenha
    Private Sub ChkMostrarSenha_CheckedChanged(sender As Object, e As EventArgs) Handles ChkMostrarSenha.CheckedChanged

        If ChkMostrarSenha.Checked Then
            TxtSenhaAtual.PasswordChar = ""
            TxtNovaSenha.PasswordChar = ""
            TxtConfirmaNovaSenha.PasswordChar = ""
        Else
            TxtSenhaAtual.PasswordChar = "*"
            TxtNovaSenha.PasswordChar = "*"
            TxtConfirmaNovaSenha.PasswordChar = "*"
        End If
    End Sub

    Private Sub BtnAlterar_Click(sender As Object, e As EventArgs) Handles BtnAlterar.Click
        If ValidaFormulario() Then
            salvarSenhaNova()
            MsgBox("Senha alterada.", vbExclamation, sistema)
            Me.Close()
        End If
    End Sub

    Private Function ValidaFormulario() As Boolean
        Dim result As Boolean

        If Not ValidaSenhaAtual() Then
            MsgBox("Senha atual invalida", vbExclamation, sistema)
            TxtNovaSenha.Focus()
            result = False
        ElseIf TxtNovaSenha.TextLength < 4 Then
            MsgBox("A senha deve conter pelo menos 4 caracteres", vbExclamation, sistema)
            TxtNovaSenha.Focus()
            result = False
        ElseIf TxtConfirmaNovaSenha.Text = "" Then
            MsgBox("Infome novamente a nova senha", vbExclamation, sistema)
            result = False
        ElseIf TxtNovaSenha.Text <> TxtConfirmaNovaSenha.Text Then
            MsgBox("Informe as senhas novamente não coincide a senha com a confirmação", vbExclamation, sistema)
            TxtNovaSenha.Focus()
            result = False
        Else
            result = True
        End If

        Return result
    End Function

    Private Function ValidaSenhaAtual()
        Dim Sql = "SELECT senha FROM  usuarios WHERE id = @id"
        Dim result As Boolean

        Try
            Using cn = New MySqlConnection(conn)
                cn.Open()

                Using cmd = New MySqlCommand(Sql, cn)
                    cmd.Parameters.AddWithValue("@id", pIdUsuario)

                    Using dr = cmd.ExecuteReader()
                        If dr.HasRows Then
                            If dr.Read() Then
                                If TxtSenhaAtual.Text = dr("senha") Then
                                    result = True
                                Else
                                    result = False
                                End If
                            End If
                        End If
                    End Using

                End Using
            End Using
        Catch ex As Exception
            MsgBox("Falha: " & ex.Message, vbExclamation, sistema)
        End Try

        Return result

    End Function


    Private Sub SalvarSenhaNova()
        Dim Sql = ("UPDATE usuarios SET senha=@senha WHERE id=" & pIdUsuario)

        Try
            Using cn = New MySqlConnection(conn)
                cn.Open()

                Using cmd = New MySqlCommand(Sql, cn)
                    cmd.Parameters.AddWithValue("@senha", TxtNovaSenha.Text)
                    cmd.ExecuteNonQuery()
                End Using

            End Using
        Catch ex As Exception
            MsgBox("Falha: " & ex.Message, vbExclamation, sistema)
        End Try
    End Sub

End Class