<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultarDatos.aspx.cs" Inherits="RepasoS.Acudiente.WebForm.ConsultarDatos" %>
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
        </style>
</head>
<body bgcolor="#e8e8e8">
    <form id="form1" runat="server">
    <div>
        <center>
            <img alt="" class="auto-style1" src="../../imagenes/linea.png" /><span class="auto-style2">- Consultar -</span><img alt="" class="auto-style1" src="../../imagenes/linea.png" /><br />
            <br />
            <strong>- Acudiente -</strong><br />
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
                        <td style="border: thin groove #800000">Estudiantes:<br /> </td>
                        <td style="border: thin groove #800000">
                            <asp:GridView ID="GridView1" runat="server">
                            </asp:GridView>
                                                                                    </td>
                    </tr>
                                                                                </table>
     
    
        </center>
    </div>
    </form>
    </body>
</html>
