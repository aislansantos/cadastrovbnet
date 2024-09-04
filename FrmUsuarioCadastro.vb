Imports MySql.Data.MySqlClient

Public Class FrmUsuarioCadastro
    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        If ValidaForm() Then
            SalvarUsuario()
            LimparForm()
            TxtLogin.Focus()
        End If
    End Sub

    Private Sub LimparForm()
        LblId.Text = ""
        TxtLogin.Clear()
        TxtEmail.Clear()
        TxtNome.Clear()
        TxtSenha.Clear()
        ChkAdministrador.Checked = False
        ChkAtivo.Checked = False
    End Sub



    Private Function ValidaForm() As Boolean
        Dim result As Boolean
        If TxtLogin.Text = "" Then
            MsgBox("Informe o login do usuário", vbExclamation, sistema)
            TxtLogin.Focus()
            result = False
        ElseIf TxtNome.Text = "" Then
            MsgBox("Informe o nome do usuário", vbExclamation, sistema)
            TxtLogin.Focus()
            result = False
        ElseIf TxtEmail.Text = "" Then
            MsgBox("Informe o email do usuário", vbExclamation, sistema)
            TxtLogin.Focus()
            result = False
        ElseIf TxtSenha.Text.Length < 4 And TxtSenha.Text <> "" Then
            MsgBox("Informe a senha do usuário", vbExclamation, sistema)
            TxtLogin.Focus()
            result = False
        Else
            result = True
        End If

        Return result
    End Function

    Private Sub SalvarUsuario()
        Dim Sql = ""

        If CLng(0 & LblId.Text) = 0 Then
            Sql = "INSERT INTO usuarios (login, nome, email, senha, administrador, ativo) VALUES (@login, @nome, @email, @senha, @administrador, @ativo)"
        Else
            Sql = "UPDATE usuarios SET login=@login, nome=@nome, email=@email, administrador=@administrador, ativo=@ativo"

            If TxtSenha.Text <> "" Then
                Sql &= ", senha=@senha"
            End If

            Sql &= " WHERE id =" & LblId.Text
        End If

        Using cn = New MySqlConnection(conn)
            cn.Open()
            Using cmd = New MySqlCommand(Sql, cn)
                cmd.Parameters.AddWithValue("@login", TxtLogin.Text)
                cmd.Parameters.AddWithValue("@nome", TxtNome.Text)
                cmd.Parameters.AddWithValue("@email", TxtEmail.Text)
                cmd.Parameters.AddWithValue("@Administrador", If(ChkAdministrador.Checked, 1, 0))
                cmd.Parameters.AddWithValue("@ativo", If(ChkAtivo.Checked, 1, 0))
                If TxtSenha.Text <> "" Then
                    cmd.Parameters.AddWithValue("@senha", TxtSenha.Text)
                End If
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub FrmUsuarioCadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If pId > 0 Then
            MostrarUsuario()
        End If
    End Sub

    Private Sub MostrarUsuario()
        Dim Sql = "SELECT * FROM usuarios WHERE id=@id"

        Try
            Using cn = New MySqlConnection(conn)
                cn.Open()

                Using cmd = New MySqlCommand(Sql, cn)
                    cmd.Parameters.AddWithValue("@id", pId)

                    Using dr = cmd.ExecuteReader()
                        If dr.HasRows Then
                            If dr.Read() Then
                                LblId.Text = dr("id")
                                TxtLogin.Text = dr("login")
                                TxtNome.Text = dr("nome")
                                TxtEmail.Text = dr("email")
                                'TxtSenha.Text = dr("senha")
                                ChkAdministrador.Checked = dr("administrador")
                                ChkAtivo.Checked = dr("ativo")
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception

        End Try
    End Sub
End Class