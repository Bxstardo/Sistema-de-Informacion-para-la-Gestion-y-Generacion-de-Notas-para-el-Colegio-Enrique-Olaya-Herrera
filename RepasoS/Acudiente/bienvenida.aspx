<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bienvenida.aspx.cs" Inherits="RepasoS.Acudiente.bienvenida" %>

<!DOCTYPE html>

<html>
<head>
<title>Bienvenido</title>

<meta charset="ISO-8859-1">
    <style type="text/css">
        .auto-style1 {
            font-size: 50pt;
        }
    </style>
</head>
<body bgcolor="#e8e8e8">
    <form id="form1" runat="server">
    <center>
<p class="auto-style1"> <strong>¡Bienvenido 
    <asp:Label ID="Label1" runat="server"></asp:Label>
    <asp:Label ID="Label2" runat="server"></asp:Label>
    !</strong></p>
<p> - Seleccione una opción del Menú -</p>
        <br />
    </center>
    </form>
</body>
</html>
