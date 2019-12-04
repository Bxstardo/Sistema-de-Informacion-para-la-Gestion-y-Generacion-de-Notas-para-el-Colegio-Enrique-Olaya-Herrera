<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Agcurso.aspx.cs" Inherits="RepasoS.Administrador.WebForm.Agcurso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 375px;
            height: 6px;
        }
        .auto-style2 {
            font-size: x-large;
        }
        .input:invalid{
            border: 1px solid red;
        }
        .input:valid{
            border: 1px solid green;
        }
        </style>
</head>
<body bgcolor="#e8e8e8">
    <form id="form1" runat="server">
    <div>
        <center>
            <img alt="" class="auto-style1" src="../../imagenes/linea.png" /><span class="auto-style2">- Agregar -</span><img alt="" class="auto-style1" src="../../imagenes/linea.png" /><br />
            <br />
            <strong>- Curso -</strong><br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <img alt="" class="auto-style1" src="../../imagenes/linea.png" /><br />
            <br />
            <br />
            Ingresa el numero del curso que desea agregar (sin usar el guion. Ej: 1101 )<br />
            <br />
            Curso:
            <asp:TextBox ID="TextBox2" runat="server" MaxLength="12" type="number" pattern="[0-9 ]+" CssClass="input"></asp:TextBox>
            <br />
            <br />
            Jornada:
            <asp:DropDownList ID="DropDownList3" runat="server">
                <asp:ListItem>Tarde</asp:ListItem>
                <asp:ListItem>Mañana</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Agregar" OnClick="Button1_Click"  />
            <br />
            <br />
            <br />
            <img alt="" class="auto-style1" src="../../imagenes/linea.png" /><br />
            <br />
        </center>
    </div>
    </form>
    </body>
</html>