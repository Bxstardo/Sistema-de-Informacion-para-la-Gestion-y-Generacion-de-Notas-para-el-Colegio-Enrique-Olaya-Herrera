<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AsigAsignatura.aspx.cs" Inherits="RepasoS.Administrador.WebForm.AsigAsignatura" %>

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
            <img alt="" class="auto-style1" src="../../imagenes/linea.png" /><span class="auto-style2">- Asignar -</span><img alt="" class="auto-style1" src="../../imagenes/linea.png" /><br />
            <br />
            <strong>- Asignatura -</strong><br />
            <br />
            <br />
            <br />
            <br />
            <img alt="" class="auto-style1" src="../../imagenes/linea.png" /><br />
            <br />
            <br />
            Ingrese la identificacion del docente al cual le desea asignar o eliminar la asignatura<br />
            <br />
            Docente:
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
&nbsp;
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Ver Todos los Docentes" />
            <br />
            <br />
            Asignatura:
            <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource1" DataTextField="Nombre" DataValueField="Nombre">
            </asp:DropDownList>
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=DESKTOP-GFI9B2I;Initial Catalog=NotasEOH2;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [Nombre] FROM [Asignatura] ORDER BY [Nombre] DESC"></asp:SqlDataSource>
            <br />
            <br />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Asignar" />
            &nbsp;
            <asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="Eliminar" />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <br />
            <img alt="" class="auto-style1" src="../../imagenes/linea.png" /><br />
            <br />
            <br />
            <br />
        </center>
    </div>
    </form>
    </body>
</html>

