<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Colasignatura.aspx.cs" Inherits="RepasoS.Administrador.WebForm.Colasignatura" %>

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
            <img alt="" class="auto-style1" src="../../imagenes/linea.png" /><span class="auto-style2">- Consultar -</span><img alt="" class="auto-style1" src="../../imagenes/linea.png" /><br />
            <br />
            <strong>- Asignatura -</strong><br />
            <br />
            <br />
            <br />
            <br />
            Asignaturas:
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Ver todo" OnClick="Button1_Click"  />
            <br />
            <br />
            <br />
            <br />
            <img alt="" class="auto-style1" src="../../imagenes/linea.png" /><br />
            <br />
            <br />
            <br />
            Areas:
            <br />
            <br />
            <asp:GridView ID="GridView2" runat="server">
            </asp:GridView>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Ver todo" OnClick="Button2_Click"   />
     
    
            <br />
            <br />
            <br />
            <br />
            <img alt="" class="auto-style1" src="../../imagenes/linea.png" /><br />
            <br />
            <br />
            <br />
            Asignaturas y areas<br />
            <br />
            <asp:GridView ID="GridView3" runat="server">
            </asp:GridView>
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" Text="Ver todo" OnClick="Button3_Click"   />
     
    
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

