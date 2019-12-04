<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Moddocente.aspx.cs" Inherits="RepasoS.Administrador.WebForm.Moddocente" %>

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
            height: 45px;
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
     
    
        </center>
    </div>
    <div>
        <center>
            <br />
            <strong>-Docente-</strong><br />
            <br />
            <br />
            <br />
            Ingresa el usuario del docente que deseas modificar o borrar<br />
     
    
            <br />
            Usuario:
            <asp:TextBox ID="TextBox1" runat="server" type="number" placeholder="0000000000" MaxLength="13"  pattern="[0-9 ]+" CssClass="input"></asp:TextBox>
            &nbsp;
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Cargar Datos" />
            <br />
            <br />
                <table style="width:94%; height: 533px;">
                                    <tr>
                    <td>&nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td> <br />
                        Nuevo Dato</td>
                </tr>
                    <tr>
                        <td>Nombres: 
                            <br />
                        </td>
                        <td>
                            <asp:Label ID="Label1" runat="server"></asp:Label>
                        </td>
                                                           <td> 
                                                               <br />
                        <asp:TextBox ID="TextBox18" runat="server"  placeholder="Nombres"  MaxLength="50" type="text" pattern="[aA-zZ ]+" CssClass="input"></asp:TextBox>
                    </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">Apellidos:<br /> </td>
                        <td class="auto-style3">
                            <asp:Label ID="Label2" runat="server"></asp:Label>
                        </td>
                                                           <td class="auto-style3"> <br />
                        <asp:TextBox ID="TextBox19" runat="server" placeholder="Apellidos"  MaxLength="50" type="text" pattern="[aA-zZ ]+" CssClass="input"></asp:TextBox>
                    </td>
                    </tr>
                    <tr>
                        <td>Dirección: 
                            <br />
                        </td>
                        <td>
                            <asp:Label ID="Label3" runat="server"></asp:Label>
                        </td>
                                                          <td> <br />
                        <asp:TextBox ID="TextBox2" runat="server" placeholder="Cll 56...."  MaxLength="50" type="text" CssClass="input"></asp:TextBox>
                    </td>
                    </tr>
                                        <tr>
                        <td>Eps:<br /> </td>
                        <td>
                            <asp:Label ID="Label4" runat="server"></asp:Label>
                                            </td>
                                                          <td> <br />
                        <asp:TextBox ID="TextBox3" runat="server" placeholder="Compensar, medimas...etc"  MaxLength="50" type="text" pattern="[aA-zZ ]+" CssClass="input"></asp:TextBox>
                    </td>
                    </tr>
  
                      <tr>
                        <td>Jornada:<br /> </td>
                        <td>
                            <asp:Label ID="Label5" runat="server"></asp:Label>
                          </td>
                                                          <td> <br />
                                               <asp:DropDownList ID="DropDownList3" runat="server">
                                                   <asp:ListItem>Tarde</asp:ListItem>
                                                   <asp:ListItem>Mañana</asp:ListItem>
                                               </asp:DropDownList>
                    </td>
                    </tr>
                      <tr>
                        <td>Celular:<br /> </td>
                        <td>
                            <asp:Label ID="Label6" runat="server"></asp:Label>
                          </td>
                                                          <td> <br />
                        <asp:TextBox ID="TextBox5" runat="server" placeholder="000-0000-0000"  MaxLength="12" type="text" pattern="[0-9 ]+" CssClass="input"></asp:TextBox>
                    </td>
                    </tr>
                          </tr __designer:mapid="6dc">
                                     
                  
                        
                                                            <tr>
                        <td>Identificación:<br /> </td>
                        <td>
                            <asp:Label ID="Label7" runat="server"></asp:Label>
                                                               <td> <br />
                        <asp:TextBox ID="TextBox6" runat="server"  placeholder="0000000000" MaxLength="13" type="text" pattern="[0-9 ]+" CssClass="input"></asp:TextBox>
                    </td>
                                                                </td>
                       
                    </tr>
                                                                                <tr>
                        <td>Email:<br /> </td>
                        <td>
                            <asp:Label ID="Label8" runat="server"></asp:Label>
                                                               <td> <br />
                        <asp:TextBox ID="TextBox7" runat="server"  placeholder="ejemplo@gmail.com" type="email" MaxLength="50" CssClass="input"></asp:TextBox>
                    </td>
                                                                                    </td>
                       
                    </tr>
                                                                                <tr>
                        <td>Contraseña:<br /> </td>
                        <td>
                            <asp:Label ID="Label9" runat="server"></asp:Label>
                                                                                    </td>
                                                          <td> <br />
                        <asp:TextBox ID="TextBox8" runat="server"  type="password" MaxLength="50" cssClass="input"></asp:TextBox>
                    </td>
                    </tr>
                                                                                <tr>
                        <td>Profesion:<br /> </td>
                        <td>
                            <asp:Label ID="Label10" runat="server"></asp:Label>
                                                                                    </td>
                                                          <td> <br />
                        <asp:TextBox ID="TextBox9" runat="server" placeholder="Profesion"  MaxLength="50" type="text" pattern="[aA-zZ ]+" CssClass="input"></asp:TextBox>
                    </td>
                    </tr>
                                        </tr>
                                                                                </table>
     
    
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Modificar" OnClick="Button1_Click" />
            &nbsp;
            <asp:Button ID="Button2" runat="server" Text="Borrar Usuario" OnClick="Button2_Click" />
     
    
            <br />
            <br />
            <strong>- Ver todos los datos de todos los docentes para modificar -<br />
            </strong>
            <br />
            <asp:Button ID="Button3" runat="server" Text="Ver todo" OnClick="Button3_Click" />
     
    
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
     
    
        </center>
    </div>
    </form>
    </body>
</html>