<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AsigCurso.aspx.cs" Inherits="RepasoS.Administrador.WebForm.AsigCurso" %>


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
            Ingrese el usuario del estudiante el cual desea asignar o cambiar el curso seleccionado<br />
            <br />
            Estudiante:
            <asp:TextBox ID="TextBox3" runat="server" type="number"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Ver todos los estudiantes" />
            <br />
            <br />
            <br />
            Curso:
            <asp:DropDownList ID="DropDownList5" runat="server" DataSourceID="SqlDataSource1" DataTextField="Num_Curso" DataValueField="Num_Curso">
       
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=DESKTOP-GFI9B2I;Initial Catalog=NotasEOH2;Integrated Security=True" SelectCommand="SELECT DISTINCT [Num_Curso] FROM [Curso] ORDER BY [Num_Curso] DESC"></asp:SqlDataSource>
            <br />
            <br />
            Jornada:
            <asp:DropDownList ID="DropDownList4" runat="server">
                <asp:ListItem>Tarde</asp:ListItem>
                <asp:ListItem>Mañana</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Asignar" OnClick="Button2_Click" />
            &nbsp;
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <br />
            <img alt="" class="auto-style1" src="../../imagenes/linea.png" /><br />
            <br />
            Ingresa el usuario del docente al cual le desea asignar, cambiar o eliminar el curso como <strong>DIRECTOR</strong><br />
            <br />
            Usuario:
            <asp:TextBox ID="TextBox4" runat="server" type="number"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button5" runat="server" Text="Ver todos los directores" OnClick="Button5_Click" />
            &nbsp;
            <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Ver todos los docentes" />
            <br />
            <br />
            Jornada: <asp:DropDownList ID="DropDownList8" runat="server">
                <asp:ListItem>Tarde</asp:ListItem>
                <asp:ListItem>Mañana</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Curso:
            <asp:DropDownList ID="DropDownList9" runat="server" DataSourceID="SqlDataSource1" DataTextField="Num_Curso" DataValueField="Num_Curso">
         
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button6" runat="server" Text="Asignar" OnClick="Button6_Click"  />
            &nbsp;<asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Eliminar" />
            <br />
            <br />
            <asp:GridView ID="GridView2" runat="server">
            </asp:GridView>
            <br />
            <br />
            <br />
            <br />
            <br />
        </center>
    </div>
    </form>
    </body>
</html>