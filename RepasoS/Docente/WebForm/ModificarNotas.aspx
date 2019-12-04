<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModificarNotas.aspx.cs" Inherits="RepasoS.Docente.WebForm.ModificarNotas" %>


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
            height: 42px;
        }
        .auto-style4 {
            height: 42px;
            width: 64px;
        }
        .auto-style5 {
            height: 23px;
        }
        .auto-style6 {
            text-align: center;
        }
        .auto-style7 {
            width: 123px;
            height: 117px;
            float: left;
        }
        .auto-style8 {
            width: 124px;
            height: 112px;
            float: right;
        }
        .auto-style9 {
            width: 463px;
        }
        </style>
</head>
<body bgcolor="#e8e8e8">
      <form id="form3" runat="server">
    <asp:Panel ID="Panel1" runat="server">
    <center>

            <img alt="" class="auto-style1" src="../../imagenes/linea.png" /><span class="auto-style2">- Modificar -</span><img alt="" class="auto-style1" src="../../imagenes/linea.png" /><br />
            <br />
            <strong>- Estudiante -<br />
            </strong>
        
                          
            Ingrese el usuario del estudiante que desea modificar
                <br />
        <br />
      
                Usuario:
                <asp:TextBox ID="TextBox2" runat="server" type="number" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
&nbsp;
                <asp:Button ID="Button4" runat="server" Text="Ver Todos los Estudiantes" OnClick="Button4_Click" />
                &nbsp;<asp:Button ID="Button5" runat="server" Text="Quitar Lista de Estudiantes" OnClick="Button5_Click" />
                <br />
                <br />
            <asp:Button ID="Button3" runat="server" Text="Cargar notas" Height="26px" OnClick="Button3_Click" />
                <br />
                <br />
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
                <br />
            Especifica con las siguientes opciones la nota que deseas Modificar<br />
                <br />
            
               
                        <td class="auto-style5">Asignatura: <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Asignatura" DataValueField="Asignatura">
                <asp:ListItem>No tiene asignaturas

                </asp:ListItem>

               
            </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=DESKTOP-GFI9B2I;Initial Catalog=NotasEOH2;Integrated Security=True" SelectCommand="ConsultarAS" SelectCommandType="StoredProcedure">
                    <SelectParameters>
                        <asp:SessionParameter Name="IdentificacionDoc" SessionField="IdentificacionDoc" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
                            <br />
                            <br />
                            Semestre:
            <asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem>Primer Semestre</asp:ListItem>
                <asp:ListItem>Segundo Semestre</asp:ListItem>
            </asp:DropDownList>
                            <br />
                            <br />
                Corte:
            <asp:DropDownList ID="DropDownList3" runat="server">
                <asp:ListItem>Primer Corte</asp:ListItem>
                <asp:ListItem>Segundo Corte</asp:ListItem>
            </asp:DropDownList>
                            <br />
                            <br />
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" type="number"></asp:TextBox>
                            <br />
                            <br />
          
            <asp:Button ID="Button1" runat="server" Text="Modificar" OnClick="Button1_Click"/>
                        </td>
                        <td class="auto-style6">
                            &nbsp;</td>
                  
                   
          
            <br />
            <br />
                
            &nbsp;&nbsp;&nbsp;
                
            <table border="1" style=" border: medium groove #990033; width:100%; ">
                <tr>
                    <td class="auto-style4">Asignatura</td>
                    <td class="auto-style3">Primer Semestre/Primer Corte</td>
                    <td class="auto-style3">Primer Semestre/Segundo Corte</td>
                    <td class="auto-style3">Segundo Semestre/Primer Corte</td>
                    <td class="auto-style3">Segundo Semestre/Segundo Corte</td>
                                        <td class="auto-style3">Primer Semestre</td>
                    <td class="auto-style3">Segundo Semestre</td>
                             <td class="auto-style3">Escala S1</td>
                     <td class="auto-style3">Escala S2</td>
                    <td class="auto-style3">Nota Final</td>
                </tr>
             
                     <div id="Div1" runat="server">
                       


                         </div>
                    
                    

                   
                
                </table>
                <br />
                <asp:Button ID="Button6" runat="server" Text="Generar Boletin" OnClick="Button6_Click" />
            <br />
                    </asp:Panel>
   
<asp:Panel ID="Panel2" runat="server" style="text-align: left" Visible="False">

      <div class="auto-style6">
          <img alt="" class="auto-style1" src="../../imagenes/linea.png" />
          <span class="auto-style2"><strong>- Colegio Enrique Olaya Herrera -</strong></span><img alt="" class="auto-style1" src="../../imagenes/linea.png" /><br />
          <br />
          <table style="width:100%;">
              <tr>
                  <td>
                      <img class="auto-style7" src="../../imagenes/eoh.png" />
                  </td>
                  <td>
                    
                  </td>
                  <td>
                      <img class="auto-style8" src="../../imagenes/escudo-alcaldia-mayor-de-bogota.png" />
                  </td>
                  
              </tr>
          </table>
          <br />
          <span class="auto-style2">- Informe Academico -</span><br />
          <br />
      </div>
      <table style="width:100%;  border: medium groove #990033; ">
          <tr>
              <td style="text-align: left"><strong>Estudiante:</strong>
                  <asp:Label ID="Label1" runat="server"></asp:Label>
                  <asp:Label ID="Label8" runat="server"></asp:Label>
              </td>
              <td class="auto-style9">&nbsp;</td>
              <td style="text-align: left"><strong>Identificacion: </strong>
                  <asp:Label ID="Label2" runat="server"></asp:Label>
              </td>
          </tr>
          <tr>
              <td style="text-align: left"><strong>Grado:</strong>
                  <asp:Label ID="Label3" runat="server"></asp:Label>
              </td>
              <td style="text-align: left" class="auto-style9"><strong>Curso: </strong>
                  <asp:Label ID="Label4" runat="server"></asp:Label>
                  /Jornada
                  <asp:Label ID="Label9" runat="server"></asp:Label>
              </td>
              <td style="text-align: left"><strong>Director: </strong>
                  <asp:Label ID="Label5" runat="server"></asp:Label>
                  <asp:Label ID="Label10" runat="server"></asp:Label>
              </td>
          </tr>
      </table>
      <br />
    &nbsp;<table border="1" style=" border: medium groove #990033; width:100%; ">
                <tr>
                    <td class="auto-style4">Asignatura</td>
                    <td class="auto-style3">Primer Semestre/Primer Corte</td>
                    <td class="auto-style3">Primer Semestre/Segundo Corte</td>
                    <td class="auto-style3">Segundo Semestre/Primer Corte</td>
                    <td class="auto-style3">Segundo Semestre/Segundo Corte</td>
                                        <td class="auto-style3">Primer Semestre</td>
                    <td class="auto-style3">Segundo Semestre</td>
                             <td class="auto-style3">Escala S1</td>
                     <td class="auto-style3">Escala S2</td>
                    <td class="auto-style3">Nota Final</td>
                </tr>
             
                     <div id="Div2" runat="server">
                       


                         </div>
                    
                    

                   
                
                </table>
      <br />
      <table border="1" style=" border: medium groove #990033; width:100%; ">
          <tr>
              <td class="auto-style4">Areas</td>
              <td class="auto-style3">Primer Semestre/Primer Corte</td>
              <td class="auto-style3">Primer Semestre/Segundo Corte</td>
              <td class="auto-style3">Segundo Semestre/Primer Corte</td>
              <td class="auto-style3">Segundo Semestre/Segundo Corte</td>
              <td class="auto-style3">Primer Semestre</td>
              <td class="auto-style3">Segundo Semestre</td>
              <td class="auto-style3">Escala S1</td>
              <td class="auto-style3">Escala S2</td>
              <td class="auto-style3">Nota Final</td>

              
                     
          </tr>
          <div id="Div3" runat="server">
                       


                         </div>
      </table>
    <br />
    <br />

    <strong>Observaciones Generales:<br /> Promedio Areas en Primer Semestre: <asp:Label ID="Label6" runat="server"></asp:Label> &nbsp;,
    <br />
    Promedio Areas en Segundo Semestre: <asp:Label ID="Label7" runat="server"></asp:Label>
      ,<br />
      Promedio Areas Final :
      <asp:Label ID="Label11" runat="server"></asp:Label>
      <br />
    <br />
    <br />
    <table style="width:100%; border="1">
        <tr>
            <td class="auto-style5">Escala institucional</td>
            <td class="auto-style5">Bajo: 0 A 59</td>
            <td class="auto-style5">Basico: 60 A 70</td>
               <td class="auto-style5">Alto: 71 A 89</td>
            <td class="auto-style5">Superior: 90 A 100</td>
        </tr>
    </table>
      <br />
      <br />
      <br />
      <br />
      <br />
      <br />
      <table style="width:100%;">
          <tr>
              <td class="auto-style6">&nbsp; ________________________________________________<br /> &nbsp;<asp:Label ID="Label12" runat="server"></asp:Label>
                  <asp:Label ID="Label13" runat="server"></asp:Label>
                  <br />
                  <br />
                  Director de curso</td>
              <td>&nbsp;</td>
              
          </tr>
      </table>
      <br />
    </strong>
    
    <br />

</asp:Panel>


    </form>
        </center>
</body>
</html>
