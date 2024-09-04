Imports MySql.Data.MySqlClient
Public Class FrmUsuarioConsulta
    Private Sub FrmUsuarioConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If pAdministrador Then
            BtnAlterar.Visible = True
            BtnAdicionar.Visible = True
        End If
        PopulaCampos()
        DataGridView1.DataSource = MostraUsuarios("")
        If DataGridView1.Rows.Count > 0 Then
            ConfiguraGrade()
        End If
    End Sub


    Private Sub ConfiguraGrade()
        With DataGridView1
            .DefaultCellStyle.Font = New Font("Arial", 9)
            .RowHeadersWidth = 25


            .Columns("id").HeaderText = "Código"
            .Columns("id").Visible = False


            .Columns("login").HeaderText = "Usuário"
            .Columns("login").Width = 120


            .Columns("nome").HeaderText = "Nome"
            .Columns("nome").Width = 200

            .Columns("email").HeaderText = "E-mail"
            .Columns("email").Width = 200


            .Columns("administrador").HeaderText = "Admin"
            .Columns("administrador").Width = 50
            .Columns("administrador").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("administrador").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns("ativo").HeaderText = "Ativo"
            .Columns("ativo").Width = 50
            .Columns("ativo").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("ativo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        End With
    End Sub


    Private Function MostraUsuarios(filtro As String) As DataTable
        Dim Sql = "SELECT id, login, nome, email, administrador, ativo FROM usuarios "
        Dim dt = New DataTable

        If filtro <> "" Then
            If CbCampos.Text = "Usuário" Then
                Sql &= "WHERE login LIKE '%" & filtro & "%'"
            ElseIf CbCampos.Text = "Nome" Then
                Sql &= "WHERE nome LIKE '%" & filtro & "%'"
            ElseIf CbCampos.Text = "Email" Then
                Sql &= "WHERE email LIKE '%" & filtro & "%'"
            End If
        End If

        Try
            Using cn = New MySqlConnection(conn)
                cn.Open()
                Using da = New MySqlDataAdapter(Sql, cn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Falha ao tentar conectar" & vbNewLine & ex.Message)
            dt = Nothing
        End Try

        Return dt
    End Function

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter

        With DataGridView1
            'seleciona o id da linha seleciona no dataGrid
            pId = .Rows(.CurrentCell.RowIndex).Cells("Id").Value

        End With



    End Sub

    Private Sub BtnAlterar_Click(sender As Object, e As EventArgs) Handles BtnAlterar.Click
        FrmUsuarioCadastro.Show()
    End Sub

    Private Sub BtnAdicionar_Click(sender As Object, e As EventArgs) Handles BtnAdicionar.Click
        pId = 0
        FrmUsuarioCadastro.Show()
    End Sub

    Private Sub PopulaCampos()
        With CbCampos
            .Items.Clear()
            .Items.Add("Usuário")
            .Items.Add("Nome")
            .Items.Add("Email")
        End With
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        DataGridView1.DataSource = MostraUsuarios(TxtProcurar.Text)
        If DataGridView1.Rows.Count > 0 Then
            ConfiguraGrade()
        End If
    End Sub
End Class