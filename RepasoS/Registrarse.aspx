<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="RepasoS.Registrarse" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style2 {
            font-size: xx-large;
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
        <asp:Panel ID="Panel1" runat="server" BackColor="#CCCCCC" BorderColor="Black" BorderStyle="Solid" Height="532px" style="margin-left: 0px; margin-right: 0px; margin-top: 145px" Width="541px">
            <br />
            <br />
            <br />
            <asp:Panel ID="Panel2" runat="server" Height="16px" Width="501px">
       
                    <span class="auto-style2">Registrar</span>
                         <asp:Panel ID="Panel3" runat="server">
                &nbsp;<br /> <br /> Tipo de usuario<br />
                <br />
                - Acudiente -<br />
                <br />
                    </asp:Panel>
                <asp:Panel ID="Panel4" runat="server">
                  <table style="width:100%;">
                    <tr>
                        <td>Nombres: 
                            <br />
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" placeholder="Nombres"  MaxLength="50" type="text" pattern="[aA-zZ ]+" CssClass="input" Height="16px"></asp:TextBox>
                        </td>
                        
                    </tr>
                    <tr>
                        <td>Apellidos:<br /> </td>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server" placeholder="Apellidos"  MaxLength="50" type="text" pattern="[aA-zZ ]+" CssClass="input"></asp:TextBox>
                        </td>
                        
                    </tr>
                    <tr>
                        <td class="auto-style4">Dirección: 
                            <br />
                        </td>
                        <td class="auto-style4">
                            <asp:TextBox ID="TextBox3" runat="server" placeholder="Cll 56...."  MaxLength="50" type="text" CssClass="input"></asp:TextBox>
                        </td>
                       
                    </tr>
                                        <tr>
                        <td>Celular:<br /> </td>
                        <td>
                            <asp:TextBox ID="TextBox4" runat="server" placeholder="000-0000-0000"  MaxLength="12" type="text" pattern="[0-9 ]+" CssClass="input"></asp:TextBox>
                                            </td>
                       
                    </tr>
                                        <tr>
                        <td class="auto-style4">Email: 
                            <br />
                                            </td>
                        <td class="auto-style4">
                            <asp:TextBox ID="TextBox5" runat="server" placeholder="ejemplo@gmail.com" type="email" MaxLength="50" CssClass="input"></asp:TextBox>
                                            </td>
                       
                    </tr>
                          </tr>

                                                            <tr>
                        <td>Identificación:<br /> </td>
                        <td>
                            <asp:TextBox ID="TextBox6" runat="server" placeholder="0000000000" MaxLength="13" type="text" pattern="[0-9 ]+" CssClass="input"></asp:TextBox>
                           </td>
                       
                    </tr>
                                                                                <tr>
                        <td>Contraseña<br /> </td>
                        <td>
                            <asp:TextBox ID="TextBox8" runat="server"  type="password" MaxLength="50" cssClass="input"></asp:TextBox>
                           </td>
                       
                    </tr>
                                                                                <tr>
                        <td>Repetir Contraseña<br /> </td>
                        <td>
                            <asp:TextBox ID="TextBox9" runat="server"  type="password" MaxLength="50" cssClass="input"></asp:TextBox>
                           </td>
                       
                    </tr>
                </table>
                </asp:Panel>
                <br />
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Registrar" />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Volver" Visible="False" Width="491px" />
                <br />
                <br />
                &nbsp;</asp:Panel>
        </asp:Panel>

    </center>
    </div>
    </form>
</body>
</html>