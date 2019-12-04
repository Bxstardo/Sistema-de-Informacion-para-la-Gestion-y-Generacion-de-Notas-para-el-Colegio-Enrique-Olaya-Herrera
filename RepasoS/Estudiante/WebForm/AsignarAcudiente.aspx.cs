using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RepasoS.scripts;
using LogicaV;
using System.Data;

namespace RepasoS.Estudiante.WebForm
{
    public partial class AsignarAcudiente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Estudiantes ObjEstudiante = new Estudiantes();
            try
            {
                ObjEstudiante.IdentificacionEst = int.Parse(Session["IdentificacionEst"].ToString());
                ObjEstudiante.IdentificacionAcu = int.Parse(TextBox1.Text);

                bool respuestasql = ObjEstudiante.AsignarAcu();

                if (respuestasql == true)
                {
                    MessageBox.alert("Se ha asignado el acudiente correctamente");
                }
                else
                {
                    MessageBox.alert("Este acudiente no existe en la base de datos");
                }
            }
            catch (Exception Ex) { MessageBox.alert("Este acudiente no existe en la base de datos"); }

        }
    }
}