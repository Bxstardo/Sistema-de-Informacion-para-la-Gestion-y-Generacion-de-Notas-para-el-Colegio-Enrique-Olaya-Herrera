<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sesion.aspx.cs" Inherits="RepasoS.Sesion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 181px;
            height: 157px;
        }
        .auto-style2 {
            font-size: xx-large;
        }
        .auto-style3 {
            width: 490px;
            height: 7px;
        }
          .input:invalid{
            border: 1px solid red;
        }
        .input:valid{
            border: 1px solid green;
        }
    </style>
</head>
<body bgcolor="#676767">
    <form id="form1" runat="server">
    <div>
    <center>

        <br />
        <br />
        <asp:Panel ID="Panel1" runat="server" BackColor="#CCCCCC" BorderColor="Black" BorderStyle="Solid" Height="423px" style="margin-left: 0px; margin-right: 0px; margin-top: 145px" Width="563px">
            <br />
            <img alt="" class="auto-style3" src="imagenes/linea.png" />
            <br />
            <br />
            <asp:Panel ID="Panel2" runat="server" Height="16px" Width="501px">
                <asp:Panel ID="Panel3" runat="server">
                    <span class="auto-style2">Inicio de sesión</span></asp:Panel>
                <img class="auto-style1" src="imagenes/eoh.png" />
                <br />
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>Estudiante</asp:ListItem>
                    <asp:ListItem>Acudiente</asp:ListItem>
                    <asp:ListItem>Docente</asp:ListItem>
                    <asp:ListItem>Administrador</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                Usuario
                <asp:TextBox ID="TextBox1" runat="server"  MaxLength="13"  pattern="[0-9 ]+" CssClass="input"></asp:TextBox>
                &nbsp;Contraseña
                <asp:TextBox ID="TextBox2" runat="server" type="password"  MaxLength="50" cssClass="input"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Iniciar Sesión" />
                &nbsp;
                <asp:Button ID="Button2" runat="server" Text="Registrarme" OnClick="Button2_Click" />
                <br />
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="Data Source=DESKTOP-GFI9B2I;Initial Catalog=NotasEOH2;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="ConsultaLogin" SelectCommandType="StoredProcedure" >
                    <SelectParameters>
                        <asp:ControlParameter ControlID="TextBox1" Name="Usuario" PropertyName="Text" Type="Int32" />
                        <asp:ControlParameter ControlID="DropDownList1" Name="Tipo_Usuario" PropertyName="SelectedValue" Type="String" />
                        <asp:ControlParameter ControlID="TextBox2" Name="Contraseña" PropertyName="Text" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <br />
                <img alt="" class="auto-style3" src="imagenes/linea.png" />
                <br />
                <br />
            </asp:Panel>
        </asp:Panel>

    </center>
    </div>
    </form>
</body>
</html>
