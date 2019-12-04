<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AsignarAcudiente.aspx.cs" Inherits="RepasoS.Estudiante.WebForm.AsignarAcudiente" %>


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
            text-align: center;
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
    <div class="auto-style3">
    
            <img alt="" class="auto-style1" src="../../imagenes/linea.png" /><span class="auto-style2">- Asignar Acudiente -</span><img alt="" class="auto-style1" src="../../imagenes/linea.png" /></div>
        <p style="text-align: center">
            &nbsp;</p>
        <p style="text-align: center">
            &nbsp;</p>
        <p style="text-align: center">
            &nbsp;</p>
        <p style="text-align: center">
            <img alt="" class="auto-style1" src="../../imagenes/linea.png" /></p>
        <p style="text-align: center">
            &nbsp;</p>
        <p style="text-align: center">
            Ingrese la identificacion de su acudiente</p>
        <p style="text-align: center">
            &nbsp;</p>
        <p style="text-align: center">
     
              
                    Acudiente:&nbsp;
                
                        <asp:TextBox ID="TextBox1" runat="server" MaxLength="13" type="number" pattern="[0-9 ]+" CssClass="input"></asp:TextBox>
               
               
                
        </p>
        <p style="text-align: center">
            <asp:Button ID="Button1" runat="server" Text="Asignar" OnClick="Button1_Click" />
        </p>
        <p style="text-align: center">
            &nbsp;</p>
        <p style="text-align: center">
            <img alt="" class="auto-style1" src="../../imagenes/linea.png" /></p>
    </form>
</body>
</html>
