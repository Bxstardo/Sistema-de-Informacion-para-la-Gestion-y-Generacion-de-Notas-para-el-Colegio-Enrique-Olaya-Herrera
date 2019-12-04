<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CambiarContraseña.aspx.cs" Inherits="RepasoS.Estudiante.WebForm.CambiarContraseña" %>

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
        .auto-style3 {
            text-align: center;
        }
        .auto-style4 {
            height: 23px;
        }
    </style>
</head>
<body bgcolor="#e8e8e8">
    <form id="form1" runat="server">
    <div class="auto-style3">
    
            <img alt="" class="auto-style1" src="../../imagenes/linea.png" /><span class="auto-style2">- Cambiar Contraseña -</span><img alt="" class="auto-style1" src="../../imagenes/linea.png" /></div>
        <p style="text-align: center">
            &nbsp;</p>
        <p style="text-align: center">
            <table style="width: 68%; height: 304px; margin-left: 167px;">
                <tr>
                    <td class="auto-style4">Contraseña Actual</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox1" runat="server"  type="password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Contraseña Nueva</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"  type="password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Confirmar Contraseña Nueva</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"  type="password"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </p>
        <p style="text-align: center">
            <asp:Button ID="Button1" runat="server" Text="Cambiar" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
