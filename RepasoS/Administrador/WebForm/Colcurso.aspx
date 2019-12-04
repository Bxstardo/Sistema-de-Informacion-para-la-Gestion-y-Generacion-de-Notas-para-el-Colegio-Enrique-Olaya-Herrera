<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Colcurso.aspx.cs" Inherits="RepasoS.Administrador.WebForm.Colcurso" %>

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
        </style>
</head>
<body bgcolor="#e8e8e8">
    <form id="form1" runat="server">
    <div>
        <center>
            <img alt="" class="auto-style1" src="../../imagenes/linea.png" /><span class="auto-style2">- Consultar -</span><img alt="" class="auto-style1" src="../../imagenes/linea.png" /><br />
            <br />
            <strong>- Curso -</strong><br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <img alt="" class="auto-style1" src="../../imagenes/linea.png" /><br />
            <br />
            Ingresa el numero del curso que desea Consultar<br />
            <br />
            <br />
            Curso:
            <asp:DropDownList ID="DropDownList7" runat="server" DataSourceID="SqlDataSource1" DataTextField="Num_Curso" DataValueField="Num_Curso">
                <asp:ListItem>1101</asp:ListItem>
                <asp:ListItem>1102</asp:ListItem>
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=DESKTOP-GFI9B2I;Initial Catalog=NotasEOH2;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT DISTINCT [Num_Curso] FROM [Curso] ORDER BY [Num_Curso] DESC"></asp:SqlDataSource>
            <br />
            <br />
            Jornada:
            <asp:DropDownList ID="DropDownList3" runat="server">
                <asp:ListItem>Tarde</asp:ListItem>
                <asp:ListItem>Mañana</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Consultar" OnClick="Button1_Click"  />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <br />
            <img alt="" class="auto-style1" src="../../imagenes/linea.png" /></center>
    </div>
    </form>
    </body>
</html>