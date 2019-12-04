<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultarDatosEst.aspx.cs" Inherits="RepasoS.Acudiente.WebForm.ConsultarDatosEst" %>

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
            <strong>- Estudiante -</strong><br />
            <br />
            <br />
            Seleccione el usuario del estudiante que deseas consultar<br />
            <br />
            <br />
            Usuario:
            <asp:DropDownList ID="DropDownList1" runat="server"  DataSourceID="SqlDataSource1" DataTextField="IdentificacionEst" DataValueField="IdentificacionEst">
                <asp:ListItem>No tiene estudiantes asignados</asp:ListItem>
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=DESKTOP-GFI9B2I;Initial Catalog=NotasEOH2;Integrated Security=True" SelectCommand="SELECT [IdentificacionEst] FROM [Estudiante] WHERE ([IdentificacionAcu] = @IdentificacionAcu)">
                <SelectParameters>
                    <asp:SessionParameter Name="IdentificacionAcu" SessionField="IdentificacionAcu" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Consultar" />
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
                        <td style="border: thin groove #800000">Curso:<br /> </td>
                        <td style="border: thin groove #800000">
                            <asp:Label ID="Label11" runat="server"></asp:Label>
                                                                                    &nbsp;<asp:Label ID="Label12" runat="server"></asp:Label>
                                                                                    </td>
                    </tr>
                </table>
     
    
            <br />
     
    
        </center>
    </div>
    </form>
    </body>
</html>
