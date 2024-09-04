Imports MySql.Data.MySqlClient

Module Module1

    Private ReadOnly server = "localhost"
    Private ReadOnly user = "aislan"
    Private ReadOnly password = "Augusto@2211"
    Private ReadOnly database = "cadastro"

    Public conn = $"server={server};user={user};password={password};database={database}"

    Public sistema = "Controle de acesso"

    Public pIdUsuario As Integer
    Public pNomeUsuario As String
    Public pAdministrador As Boolean
    Public pAcessoPermitido = False

    Public pId As Long

End Module
