<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Modasignatura.aspx.cs" Inherits="RepasoS.Administrador.WebForm.Modasignatura" %>

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
            <strong>- Asignatura -</strong><br />
            <br />
            <br />
            Seleccione la asignatura que desea modificar y asignele el nuevo nombre<br />
            <br />
            <br />
            Asignatura:
                 
          <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource1" DataTextField="Nombre" DataValueField="Nombre">
                                               <asp:ListItem>Matematicas</asp:ListItem>
                <asp:ListItem>Español</asp:ListItem>
                <asp:ListItem>Quimica</asp:ListItem>
                <asp:ListItem>Educacion Fisica</asp:ListItem>
                <asp:ListItem>Ingles</asp:ListItem>
                <asp:ListItem>Artes</asp:ListItem>
                <asp:ListItem>Politica</asp:ListItem>
                <asp:ListItem>Etica</asp:ListItem>
                <asp:ListItem>Tecnologia</asp:ListItem>
                <asp:ListItem>Ciencias Naturales</asp:ListItem>
                <asp:ListItem>Ciencias Sociales</asp:ListItem>
                <asp:ListItem>Fisica</asp:ListItem>
                <asp:ListItem>Informatica</asp:ListItem>
                <asp:ListItem>Economia</asp:ListItem>
                <asp:ListItem>Religion</asp:ListItem>
                <asp:ListItem>Programacion de Software</asp:ListItem>
                <asp:ListItem>Musica</asp:ListItem>
                <asp:ListItem>Ingles(Media Fortalecida)</asp:ListItem>
                <asp:ListItem>Dolca</asp:ListItem>
               
                            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=DESKTOP-GFI9B2I;Initial Catalog=NotasEOH2;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [Nombre] FROM [Asignatura] ORDER BY [Nombre] DESC"></asp:SqlDataSource>
            <br />
            <br />
            Nuevo nombre de Asignatura:
            <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Modificar" OnClick="Button1_Click"  />
            &nbsp;&nbsp;
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Eliminar" />
            <br />
            <br />
            <img alt="" class="auto-style1" src="../../imagenes/linea.png" /><br />
            <br />
            <br />
            Seleccione el area que desea modificar y asignele el nuevo nombre<br />
            <br />
            <br />
            Area:
            <asp:DropDownList ID="DropDownList4" runat="server" DataSourceID="SqlDataSource2" DataTextField="Nombre" DataValueField="Nombre">
                <asp:ListItem>Ciencias Economicas y Politicas</asp:ListItem>
                <asp:ListItem>Ciencias Sociales: Historia Geografia Democracia Constitucion Politica</asp:ListItem>
                <asp:ListItem>Educacion Artistica</asp:ListItem>
                <asp:ListItem>Educacion Fisica, Recreacion y Deporte</asp:ListItem>
                <asp:ListItem>Educacion Religiosa, Etica, En Valores Humanos y Catedra De La Paz</asp:ListItem>
                <asp:ListItem>Matematicas</asp:ListItem>
                <asp:ListItem>Tecnologia e Informatica</asp:ListItem>
                <asp:ListItem>Ciencias Naturales</asp:ListItem>
                <asp:ListItem>Humanidades</asp:ListItem>
                <asp:ListItem>Media Fortalecida</asp:ListItem>
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="Data Source=DESKTOP-GFI9B2I;Initial Catalog=NotasEOH2;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [Nombre] FROM [Area] ORDER BY [Nombre] DESC"></asp:SqlDataSource>
            <br />
            <br />
            Nuevo nombre de Area:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Modificar" OnClick="Button2_Click"   />
     
    
            &nbsp;&nbsp;
            <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Eliminar" />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
     
    
            <br />
            <br />
            <img alt="" class="auto-style1" src="../../imagenes/linea.png" /><br />
            <br />
            Cambie el area de la asignatura que desee<br />
            <br />
            Asignatura:
            <asp:DropDownList ID="DropDownList5" runat="server" DataSourceID="SqlDataSource1" DataTextField="Nombre" DataValueField="Nombre">
                                               <asp:ListItem>No eliminar</asp:ListItem>
                                               <asp:ListItem>Matematicas</asp:ListItem>
                <asp:ListItem>Español</asp:ListItem>
                <asp:ListItem>Quimica</asp:ListItem>
                <asp:ListItem>Educacion Fisica</asp:ListItem>
                <asp:ListItem>Ingles</asp:ListItem>
                <asp:ListItem>Artes</asp:ListItem>
                <asp:ListItem>Politica</asp:ListItem>
                <asp:ListItem>Etica</asp:ListItem>
                <asp:ListItem>Tecnologia</asp:ListItem>
                <asp:ListItem>Ciencias Naturales</asp:ListItem>
                <asp:ListItem>Ciencias Sociales</asp:ListItem>
                <asp:ListItem>Fisica</asp:ListItem>
                <asp:ListItem>Informatica</asp:ListItem>
                <asp:ListItem>Economia</asp:ListItem>
                <asp:ListItem>Religion</asp:ListItem>
                <asp:ListItem>Programacion de Software</asp:ListItem>
                <asp:ListItem>Musica</asp:ListItem>
                <asp:ListItem>Ingles(Media Fortalecida)</asp:ListItem>
                <asp:ListItem>Dolca</asp:ListItem>
               
                            </asp:DropDownList>
            &nbsp;&nbsp;
            <br />
            <br />
            Area:
                        <asp:DropDownList ID="DropDownList6" runat="server" DataSourceID="SqlDataSource2" DataTextField="Nombre" DataValueField="Nombre">
                            <asp:ListItem>No eliminar</asp:ListItem>
                <asp:ListItem>Ciencias Economicas y Politicas</asp:ListItem>
                <asp:ListItem>Ciencias Sociales: Historia Geografia Democracia Constitucion Politica</asp:ListItem>
                <asp:ListItem>Educacion Artistica</asp:ListItem>
                <asp:ListItem>Educacion Fisica, Recreacion y Deporte</asp:ListItem>
                <asp:ListItem>Educacion Religiosa, Etica, En Valores Humanos y Catedra De La Paz</asp:ListItem>
                <asp:ListItem>Matematicas</asp:ListItem>
                <asp:ListItem>Tecnologia e Informatica</asp:ListItem>
                <asp:ListItem>Ciencias Naturales</asp:ListItem>
                <asp:ListItem>Humanidades</asp:ListItem>
                <asp:ListItem>Media Fortalecida</asp:ListItem>
            </asp:DropDownList>
            &nbsp;
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" Text="Modificar" OnClick="Button3_Click" />
            <br />
            <br />
            <br />
            <br />
        </center>
    </div>
    </form>
    </body>
</html>

