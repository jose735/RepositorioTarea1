<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InicioSesion.aspx.cs" Inherits="AsistenciaEventos.Grafica.InicioSesion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Asistencia y Registro de Eventos</title>
    <link href="CSS/loginStyle.css" rel="stylesheet" />
    <script src="JS/index.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="login">
                <h1 class="login-heading">
                    <strong>Bienvenido, </strong>por favor, inicia sesión</h1>
                <br />
                <h4 style="color: white;">Usuario: </h4>
                <asp:TextBox ID="txtUsuario" runat="server" CssClass="input-txt"></asp:TextBox>
                <h4 style="color: white;">Clave de acceso: </h4>
                <asp:TextBox ID="txtContrasenna" TextMode="Password" runat="server" CssClass="input-txt"></asp:TextBox>
                <div class="login-footer">
                    <asp:Button ID="btnIngresar" OnClick="btnIngresar_Click" runat="server" Text="Iniciar Sesión" CssClass="btn btn--right" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
