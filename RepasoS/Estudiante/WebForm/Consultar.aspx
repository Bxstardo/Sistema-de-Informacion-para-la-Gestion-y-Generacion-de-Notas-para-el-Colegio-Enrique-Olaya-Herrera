<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consultar.aspx.cs" Inherits="RepasoS.Estudiante.WebForm.Consultar" %>

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
            width: 311px;
            height: 3px;
        }
        .auto-style4 {
            height: 3px;
        }
          }
        .auto-style7 {
            width: 125px;
            height: 115px;
            float: left;
        }
        .auto-style8 {
            width: 126px;
            height: 118px;
            float: right;
        }
        .auto-style9 {
            width: 463px;
        }
        .auto-style10 {
            text-align: center;
        }
        </style>
</head>
<body bgcolor="#e8e8e8">
       <form id="form1" runat="server">
    <center>
            <img alt="" class="auto-style1" src="../../imagenes/linea.png" /><span class="auto-style2">- Consultar -</span><img alt="" class="auto-style1" src="../../imagenes/linea.png" /><br />
            <br />
            <strong>- Estudiante -</strong><br />
            <br />
            <br />
            Elije 
            la asignatura en la que desees consultar notas<br />
            <br />
            <br />
 
            Asignatura: <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Nombre" DataValueField="Nombre">
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
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=DESKTOP-GFI9B2I;Initial Catalog=NotasEOH2;Integrated Security=True" SelectCommand="SELECT [Nombre] FROM [Asignatura] ORDER BY [Nombre]"></asp:SqlDataSource>
            <br />
            <br />
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
          
            <asp:Button ID="Button1" runat="server" Text="Consultar" OnClick="Button1_Click" />
            <br />
            <br />
&nbsp;<img alt="" class="auto-style3" src="../../imagenes/lineaa.png" />
            <br />
            <br />
            Elije el area en la que desees consultar notas<br />
            <br />
            <br />
            Area:
            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="Nombre" DataValueField="Nombre">
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
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="Data Source=DESKTOP-GFI9B2I;Initial Catalog=NotasEOH2;Integrated Security=True" SelectCommand="SELECT [Nombre] FROM [Area] ORDER BY [Nombre]"></asp:SqlDataSource>
            <br />
            <br />
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

                         <div id="Div2" runat="server">
                       


                         </div>
                    
                </tr>
            </table>
            <br />
            <asp:Button ID="Button3" runat="server" Text="Consultar" OnClick="Button3_Click" />
            <br />
            <br />
            <img alt="" class="auto-style3" src="../../imagenes/lineaa.png" /><br />
            <br />
            <strong>- Boletin virtual -</strong><br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Generar Boletin" OnClick="Button2_Click"   />
     
    
    </form>
        <asp:Panel ID="Panel2" runat="server" style="text-align: left" Visible="False">

            <form id ="form2" runat="server" >
      <div class="auto-style10">
          <div class="auto-style10">
              <img alt="" class="auto-style1" src="../../imagenes/linea.png" />
              <span class="auto-style2"><strong>- Colegio Enrique Olaya Herrera -</strong></span><img alt="" class="auto-style1" src="../../imagenes/linea.png" /><br />
              <br />
          </div>
          <table style="width:100%;">
              <tr>
                  <td>
                      <img src="../../imagenes/eoh.png" style="float: left; height: 111px; width: 125px" />
                  </td>
                  <td></td>
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
             
                     <div id="Div3" runat="server">
                       


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
          <div id="Div4" runat="server">
                       


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
              <td class="auto-style10">&nbsp; ________________________________________________<br /> &nbsp;<asp:Label ID="Label12" runat="server"></asp:Label>
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
 </form>
</asp:Panel>
        </center>
</body>
</html>
