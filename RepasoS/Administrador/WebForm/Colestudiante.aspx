<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Colestudiante.aspx.cs" Inherits="RepasoS.Administrador.WebForm.Colestudiante" %>

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
            <img alt="" class="auto-style1" src="../../imagenes/linea.png" /><span class="auto-style2">- Consultar -</span><img alt="" class="auto-style1" src="../../imagenes/linea.png" /><br />
            <br />
            <strong>- Estudiante -</strong><br />
            <br />
            <br />
            Ingresa el usuario del estudiante que deseas consultar<br />
            <br />
            <br />
            Usuario:
            <asp:TextBox ID="TextBox2" runat="server" type="number"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Consultar" OnClick="Button1_Click" />
            <br />
            <br />
                <table style="border: thin groove #990000; width:54%; height: 516px;">
                    <tr>
                        <td style="border: thin groove #800000">Nombres: 
                            <br />
                        </td>
                        <td style="border: thin groove #800000">
                            <asp:Label ID="Label1" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3" style="border: thin groove #800000">Apellidos:<br /> </td>
                        <td class="auto-style3" style="border: thin groove #800000">
                            <asp:Label ID="Label2" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="border: thin groove #800000">Dirección: 
                            <br />
                        </td>
                        <td style="border: thin groove #800000">
                            <asp:Label ID="Label3" runat="server"></asp:Label>
                        </td>
                    </tr>
                                        <tr>
                        <td style="border: thin groove #800000">Eps:<br /> </td>
                        <td style="border: thin groove #800000">
                            <asp:Label ID="Label4" runat="server"></asp:Label>
                                            </td>
                    </tr>
  
                      <tr>
                        <td style="border: thin groove #800000">Jornada:<br /> </td>
                        <td style="border: thin groove #800000">
                            <asp:Label ID="Label5" runat="server"></asp:Label>
                          </td>
                    </tr>
                      <tr>
                        <td style="border: thin groove #800000">Celular:<br /> </td>
                        <td style="border: thin groove #800000">
                            <asp:Label ID="Label6" runat="server"></asp:Label>
                          </td>
                    </tr>
                                     
                  
                        
                                                            <tr>
                        <td style="border: thin groove #800000">Identificación:<br /> </td>
                        <td style="border: thin groove #800000">
                            <asp:Label ID="Label7" runat="server"></asp:Label>
                                                                                      
                    </tr>
                                                                                <tr>
                        <td style="border: thin groove #800000">Email:<br /> </td>
                        <td style="border: thin groove #800000">
                            <asp:Label ID="Label8" runat="server"></asp:Label>
                                                                                      
                    </tr>
                                                                                <tr>
                        <td style="border: thin groove #800000">Contraseña:<br /> </td>
                        <td style="border: thin groove #800000">
                            <asp:Label ID="Label9" runat="server"></asp:Label>
                                                                                    </td>
                    </tr>
                                                                                <tr>
                        <td style="border: thin groove #800000">Acudiente:<br /> </td>
                        <td style="border: thin groove #800000">
                            <asp:Label ID="Label10" runat="server"></asp:Label>
                                                                                    <asp:Label ID="Label13" runat="server"></asp:Label>
                                                                                    </td>
                    </tr>
                                                                                <tr>
                        <td style="border: thin groove #800000">Curso:<br /> </td>
                        <td style="border: thin groove #800000">
                            <asp:Label ID="Label11" runat="server"></asp:Label>
                                                                                    &nbsp;<asp:Label ID="Label12" runat="server"></asp:Label>
                                                                                    </td>
                    </tr>
                </table>
     
    
            <br />
            <br />
            <br />
            <br />
            <strong>- Ver todos los datos de todos los estudiantes -</strong><br />
            <br />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Ver todo" OnClick="Button2_Click"  />
     
    
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
     
    
        </center>
    </div>
    </form>
    </body>
</html>
