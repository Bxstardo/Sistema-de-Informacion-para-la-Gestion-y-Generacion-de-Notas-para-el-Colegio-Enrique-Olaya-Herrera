using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RepasoS.scripts;
using LogicaV;
using System.Data;

namespace RepasoS.Administrador.WebForm
{
    public partial class Agcurso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
            

        }

      

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text == "")
            {
                MessageBox.alert("No deje el campo vacio");
            }
            else
            {
                string Nivel;
            //Session["Msj"] = "m";
            Cursos ObjCurso = new Cursos();
            try
            {
                DataSet DatosCurso = ObjCurso.ConsultarCurso2(TextBox2.Text, DropDownList3.SelectedItem.Text, "JorYCur");

                DataTable DatosConsultados = DatosCurso.Tables["DatosConsultados"];

                int numregistros = DatosConsultados.Rows.Count;

                if (int.Parse(TextBox2.Text) < 1000 && int.Parse(TextBox2.Text) >= 100)
                {
                    Nivel = "Educacion Basica";
                }
                else if(int.Parse(TextBox2.Text) >= 1000 )
                {
                    Nivel = "Educacion Media";
                }
                else 
                {
                    Nivel = "Preescolar";
                }

                if (numregistros == 0)
                {

                    

                    ObjCurso.Num_Curso = TextBox2.Text;
                    ObjCurso.Nivel = Nivel;
                    ObjCurso.Jornada = DropDownList3.SelectedItem.Text;

                    bool RespuestaSql = ObjCurso.InsertarCurso();
                    if (RespuestaSql == true)
                    {
                        MessageBox.alert("Se agrego el curso correctamente");


                        TextBox2.Text = "";


                    }
                    else
                    {
                        MessageBox.alert(ObjCurso.Mensaje);
                    }
                }
                else
                {
                    MessageBox.alert("Este curso ya existe");
                }
                


            }
            catch
            (Exception Ex)
            { MessageBox.alert("Error!: " + Ex.Message + " " + ObjCurso.Mensaje); }
            }
                
        }

      
    }
}