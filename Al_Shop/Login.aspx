<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Al_Shop.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/css/bootstrap.min.css" rel="stylesheet">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <title>Iniciar Sesion</title>
</head>
<body class="bg-light">
    <div>
        <div>
            <form id="formulario_login" runat="server">
            <div class="form-control">
                <div class="col-md-6 text-center mb-5">
                    <asp:Label class="h3" ID="lblBienvenida" runat="server" Text="Bienvenido/a al sistema"></asp:Label>
                </div>
                <div>
                    <asp:Label ID="lblEmail" runat="server" Text="email"></asp:Label>
                    <asp:TextBox ID="tbEmail" CssClass="form-control" runat="server" placeholder="Correo Electronico"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="lblPassword" runat="server" Text="Contrasena"></asp:Label>
                    <asp:TextBox ID="tbPassword" CssClass="form-control" TextMode="Password" runat="server" placeholder="Contraseña"></asp:TextBox>
                </div>
                <div class="row">
                    <asp:Label ID="lblError" runat="server" CssClass="alert-danger" ></asp:Label>
                </div>
                <hr />
                <div class="row">
                    <asp:Button ID="btnIngresar" CssClass="btn btn-primary btn-dark" runat="server" Text="Ingresar" onClick="btnIngresar_Click"/>
                </div>
            </div>
            </form>
        </div>
    </div>
</body>
</html>
