<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="RepasoS.Docente.index" %>

<!DOCTYPE html>

<html>
<head>
<title>Mi Pagina Index</title>
<link href="../estilos/estiloindex.css" rel="stylesheet" type="text/css" />
</head>
<body>
<div id="content">
<div id="cabecera">
<object type="text/html" data="cabecera.aspx" name='cabecera' width="100%" scrolling="No" style="height: 100%"> </object>
</div>
<div id="menu" >
<object type="text/html" data="menu.aspx" name='menu' width="100%" height="100%">
</object>
</div>
<div id="principal">
<object type="text/html" data="bienvenida.aspx" name='principal' width="100%"
height="100%" scrolling="yes"> </object>
</div>
<div id="pie">
<object type="text/html" data="pie.aspx" name='pie' width="100%" height="100%"
scrolling="No"> </object>
</div>
</div>
</body>
</html>