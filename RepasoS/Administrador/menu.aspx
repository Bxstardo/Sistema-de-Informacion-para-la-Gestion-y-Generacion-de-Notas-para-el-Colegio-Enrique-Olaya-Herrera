<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menu.aspx.cs" Inherits="RepasoS.Administrador.menu" %>

<!DOCTYPE html>
<html>
<head>
<title>Menu Principal</title>
<link href="../estilos/menu1.css" rel="stylesheet" type="text/css" />
<meta charset="ISO-8859-1">
    <style type="text/css">
        .auto-style3 {
            width: 110px;
            height: 7px;
        }
        .auto-style5 {
            width: 281px;
            height: 7px;
        }
    </style>
</head>
<body 
bgcolor="#a2a2a2";>
    <form id="form1" runat="server">
    <center>

<h3>
<img src="../imagenes/lineaa.png" class="auto-style3" /> Menu
<img src="../imagenes/lineaa.png" class="auto-style3" /></h3>
        <div id="button" class="auto-style1">
<ul class="auto-style4">
<li><a href="bienvenida.aspx" target="principal">Pagina Principal</a></li>
<li><a href="WebForm/MenuMod.aspx" target="menu" class="auto-style2">Modificar</a></li>
<li><a href=" WebForm/MenuCol.aspx" target="menu">Consultar</a></li>
    <li><a href=" WebForm/MenuAg.aspx" target="menu">Agregar</a></li>
        <li><a href=" WebForm/MenuAs.aspx" target="menu">Asignar</a></li>

</ul>
</div>

        <p>
            </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    <p>
        &nbsp;<img src="../imagenes/lineaa.png" class="auto-style5" /></p>
    </center>
    </form>
</body>
</html>