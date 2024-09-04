Imports MySql.Data.MySqlClient
Public Class FrmLogin
    Private Sub BtnEntrar_Click(sender As Object, e As EventArgs) Handles BtnEntrar.Click
        If Not ValidaUsuario() Then
            MsgBox("Usário ou senha inválido ou usuário inativo.", vbExclamation, sistema)
        Else
            Me.Close()
        End If
    End Sub

    Private Function ValidaUsuario() As Boolean
        Dim Sql = "SELECT * FROM usuarios WHERE login=@login AND senha=@senha"
        Dim result = False

        Try
            Using cn = New MySqlConnection(conn)
                cn.Open()

                Using cmd = New MySqlCommand(Sql, cn)

                    cmd.Parameters.AddWithValue("@login", TxtLogin.Text)
                    cmd.Parameters.AddWithValue("@senha", TxtSenha.Text)

                    Using dr = cmd.ExecuteReader()
                        If dr.HasRows Then
                            If dr.Read() Then
                                pIdUsuario = dr("id")
                                pNomeUsuario = dr("login")
                                pAdministrador = dr("administrador")
                                If dr("ativo") = True Then
                                    pAcessoPermitido = True
                                    result = True
                                Else
                                    pAcessoPermitido = False
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
End Class