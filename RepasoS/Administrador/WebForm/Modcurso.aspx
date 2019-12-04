<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Modcurso.aspx.cs" Inherits="RepasoS.Administrador.WebForm.Modcurso" %>
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
            height: 26px;
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
            <img alt="" class="auto-style1" src="../../imagenes/linea.png" /><span class="auto-style2">- Modificar -</span><img alt="" class="auto-style1" src="../../imagenes/linea.png" /><br />
            <br />
            <strong>- Curso -</strong><br />
            <br />
            <img alt="" class="auto-style1" src="../../imagenes/linea.png" /><br />
            <br />
            <br />
            Curso:
            <asp:DropDownList ID="DropDownList4" runat="server" DataSourceID="SqlDataSource1" DataTextField="Num_Curso" DataValueField="Num_Curso">
                <asp:ListItem>1101</asp:ListItem>
                <asp:ListItem>1102</asp:ListItem>
                <asp:ListItem></asp:ListItem>
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
            <asp:Button ID="Button3" runat="server" Text="Cargar Datos" OnClick="Button3_Click" />
            <br />
            <br />
            <table style="width:91%; height: 177px;">
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>Nuevo Dato</td>
                </tr>
                <tr>
                    <td>Curso</td>
                    <td> <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" type="number"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Nivel</td>
                    <td>
            <asp:Label ID="Label2" runat="server"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                  <tr>
                    <td>Jornada</td>
                    <td>
            <asp:Label ID="Label3" runat="server"></asp:Label>
                      </td>
                    <td>
            <asp:DropDownList ID="DropDownList9" runat="server">
                <asp:ListItem>Tarde</asp:ListItem>
                <asp:ListItem>Mañana</asp:ListItem>
            </asp:DropDownList>
                      </td>
                </tr>
                  <tr>
                    <td class="auto-style3">Director</td>
                    <td class="auto-style3">
            <asp:Label ID="Label4" runat="server"></asp:Label>
                      </td>
                    <td class="auto-style3">
                        &nbsp;</td>
                </tr>
            </table>
            <br />
            <asp:GridView ID="GridView2" runat="server">
            </asp:GridView>
            <br />
            <asp:GridView ID="GridView3" runat="server">
            </asp:GridView>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Modificar" OnClick="Button1_Click"  />
            &nbsp;
            <asp:Button ID="Button2" runat="server" Text="Eliminar" OnClick="Button2_Click" />
            <br />
            <br />
            *<br />
            <br />
&nbsp;<asp:Button ID="Button6" runat="server" Text="Ver todos los cursos" OnClick="Button6_Click" />
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