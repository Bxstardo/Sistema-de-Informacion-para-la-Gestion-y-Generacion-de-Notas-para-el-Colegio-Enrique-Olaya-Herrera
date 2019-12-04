using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogicaV;
using System.Data;
using RepasoS.scripts;

namespace RepasoS.Administrador.WebForm
{
    public partial class AsigCurso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button6_Click(object sender, EventArgs e)
        {

            if (TextBox4.Text == "")
            {
                MessageBox.alert("No deje el campo vacio");
            }
            else
            {

                GridView2.Visible = false;
                string Estado = "";
                Docentes ObjDocente = new Docentes();
                SesionU ObjSesion = new SesionU();
                Cursos ObjCurso = new Cursos();
                try
                {
                    DataSet DatosDocente = ObjDocente.ConsultarDocente(TextBox4.Text, "IdentificacionDoc");

                    DataTable DatosConsultados = DatosDocente.Tables["DatosConsultados"];

                    int numregistros = DatosConsultados.Rows.Count;

                    if (numregistros == 0)
                    {
                        MessageBox.alert("No existe en la Base de Datos Cliente con esta identificación o el Docente se encuentra inactivo");

                    }
                    else
                    {
                        Estado = DatosConsultados.Rows[0]["Estado"].ToString();
                    }



                    if (Estado == "Activo")
                    {

                        try
                        {
                            DataSet DatosCurso = ObjCurso.ConsultarCurso2(DropDownList9.SelectedItem.Text, DropDownList8.SelectedItem.Text, "JorYCur");

                            DataTable DatosConsultados2 = DatosCurso.Tables["DatosConsultados"];

                            int numregistros2 = DatosConsultados2.Rows.Count;

                            if (numregistros2 == 0)
                            {
                                MessageBox.alert("No existe el curso para la jornada " + DropDownList8.Text);

                            }
                            else
                            {

                                try
                                {
                                    ObjCurso.Num_Curso = DropDownList9.SelectedItem.Text;
                                    ObjCurso.Jornada = DropDownList8.SelectedItem.Text;
                                    ObjCurso.IdentificacionDoc = int.Parse(TextBox4.Text);

                                    bool RespuestaSql = ObjCurso.InsertarCursoDoc();


                                    if (RespuestaSql == true)
                                    {


                                        GridView1.DataBind();
                                        MessageBox.alert("Se ha asignado el curso correctamente");
                                        TextBox4.Text = "";


                                    }
                                    else
                                    {
                                        MessageBox.alert("Error desconocido");
                                    }
                                }
                                catch
                                (Exception Ex)
                                { MessageBox.alert("Error!: " + Ex.Message + " " + ObjCurso.Mensaje); }

                            }
                        }




                        catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjCurso.Mensaje); }

                    }
                    else
                    {
                        MessageBox.alert("No se puede asignar el curso al docente porque se encuentra inactivo o no existe");


                    }



                }
                catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjDocente.Mensaje); }

            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {

            if (TextBox4.Text == "")
            {
                MessageBox.alert("No deje el campo vacio");
            }
            else
            {

                GridView2.Visible = false;
                string Estado = "";
                Docentes ObjDocente = new Docentes();
                Cursos ObjCurso = new Cursos();
                try
                {
                    DataSet DatosDocente = ObjDocente.ConsultarDocente(TextBox4.Text, "IdentificacionDoc");

                    DataTable DatosConsultados = DatosDocente.Tables["DatosConsultados"];

                    int numregistros = DatosConsultados.Rows.Count;

                    if (numregistros == 0)
                    {
                        MessageBox.alert("No existe en la Base de Datos Cliente con esta identificación o el Docente se encuentra inactivo");

                    }
                    else
                    {
                        Estado = DatosConsultados.Rows[0]["Estado"].ToString();
                    }



                    if (Estado == "Activo")
                    {

                        try
                        {
                            DataSet DatosCurso = ObjCurso.ConsultarCurso2(DropDownList9.SelectedItem.Text, DropDownList8.SelectedItem.Text, "JorYCur");

                            DataTable DatosConsultados2 = DatosCurso.Tables["DatosConsultados"];

                            int numregistros2 = DatosConsultados2.Rows.Count;

                            if (numregistros2 == 0)
                            {
                                MessageBox.alert("No existe el curso para la jornada " + DropDownList8.Text);

                            }
                            else
                            {

                                try
                                {
                                    ObjCurso.Num_Curso = DropDownList9.SelectedItem.Text;
                                    ObjCurso.Jornada = DropDownList8.SelectedItem.Text;
                                    ObjCurso.IdentificacionDoc = int.Parse(TextBox4.Text);

                                    bool RespuestaSql = ObjCurso.EliminarCursoD();


                                    if (RespuestaSql == true)
                                    {


                                        GridView1.DataBind();
                                        MessageBox.alert("Se ha eliminado la asignacion del curso correctamente");
                                        TextBox4.Text = "";


                                    }
                                    else
                                    {
                                        MessageBox.alert(ObjCurso.Mensaje);
                                    }
                                }
                                catch
                                (Exception Ex)
                                { MessageBox.alert("Error!: " + Ex.Message + " " + ObjCurso.Mensaje); }

                            }
                        }




                        catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjCurso.Mensaje); }

                    }
                    else
                    {
                        MessageBox.alert("No se puede asignar el curso al docente porque se encuentra inactivo o no existe");


                    }



                }
                catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjDocente.Mensaje); }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            if (TextBox3.Text == "")
            {
                MessageBox.alert("No deje el campo vacio");
            }
            else
            {

                string Estado = "";
                Estudiantes ObjEstudiante = new Estudiantes();
                SesionU ObjSesion = new SesionU();
                Cursos ObjCurso = new Cursos();
                try
                {
                    DataSet DatosEstudiante = ObjEstudiante.ConsultarEstudiante(TextBox3.Text, "IdentificacionEst");

                    DataTable DatosConsultados = DatosEstudiante.Tables["DatosConsultados"];

                    int numregistros = DatosConsultados.Rows.Count;

                    if (numregistros == 0)
                    {
                        MessageBox.alert("No existe en la Base de Datos Cliente con esta identificación o el Estudiante se encuentra inactivo");

                    }
                    else
                    {
                        Estado = DatosConsultados.Rows[0]["Estado"].ToString();
                    }



                    if (Estado == "Activo")
                    {

                        try
                        {
                            DataSet DatosCurso = ObjCurso.ConsultarCurso2(DropDownList5.SelectedItem.Text, DropDownList4.SelectedItem.Text, "JorYCur");

                            DataTable DatosConsultados2 = DatosCurso.Tables["DatosConsultados"];

                            int numregistros2 = DatosConsultados2.Rows.Count;

                            if (numregistros2 == 0)
                            {
                                MessageBox.alert("No existe el curso para la jornada " + DropDownList4.Text);

                            }
                            else
                            {

                                try
                                {
                                    ObjCurso.Num_Curso = DropDownList5.SelectedItem.Text;
                                    ObjCurso.Jornada = DropDownList4.SelectedItem.Text;
                                    ObjCurso.IdentificacionEst = int.Parse(TextBox3.Text);

                                    bool RespuestaSql = ObjCurso.InsertarCursoEst();


                                    if (RespuestaSql == true)
                                    {


                                        GridView1.DataBind();
                                        MessageBox.alert("Se ha asignado el curso correctamente");
                                        TextBox3.Text = "";


                                    }
                                    else
                                    {
                                        MessageBox.alert(ObjCurso.Mensaje);
                                    }
                                }
                                catch
                                (Exception Ex)
                                { MessageBox.alert("Error!: " + Ex.Message + " " + ObjCurso.Mensaje); }

                            }
                        }




                        catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjCurso.Mensaje); }

                    }
                    else
                    {
                        MessageBox.alert("No se puede asignar el curso al estudiante porque se encuentra inactivo o no existe");
                    }



                }
                catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjEstudiante.Mensaje); }

            }


        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Estudiantes ObjEstudiante = new Estudiantes();

            try
            {
                DataSet DatosEstudiante = ObjEstudiante.ConsultarEstudianteTodos2();

                DataTable DatosConsultados = DatosEstudiante.Tables["DatosConsultados"];

                int numregistros = DatosConsultados.Rows.Count;

                if (numregistros == 0)
                {
                    MessageBox.alert("No hay datos en la base de datos");
                }
                else
                {
                    GridView1.DataSource = DatosConsultados;
                    GridView1.DataBind();


                }

            }

            catch (Exception ex) { MessageBox.alert("No se ha podido efectuar la consulta debido al siguiente Error: " + ex.Message); }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Docentes ObjDocente = new Docentes();

            try
            {
                DataSet DatosDocente = ObjDocente.ConsultarDocenteTodos5();

                DataTable DatosConsultados = DatosDocente.Tables["DatosConsultados"];

                int numregistros = DatosConsultados.Rows.Count;

                if (numregistros == 0)
                {
                    MessageBox.alert("No hay datos en la base de datos");
                }
                else
                {

                    GridView2.Visible = true;
                    GridView2.DataSource = DatosConsultados;
                    GridView2.DataBind();
                    

                }

            }

            catch (Exception ex) { MessageBox.alert("No se ha podido efectuar la consulta debido al siguiente Error: " + ex.Message); }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Docentes ObjDocente = new Docentes();

            try
            {
                DataSet DatosDocente = ObjDocente.ConsultarDocenteTodos2();

                DataTable DatosConsultados = DatosDocente.Tables["DatosConsultados"];

                int numregistros = DatosConsultados.Rows.Count;

                if (numregistros == 0)
                {
                    MessageBox.alert("No hay datos en la base de datos");
                }
                else
                {

                    GridView2.Visible = true;
                    GridView2.DataSource = DatosConsultados;
                    GridView2.DataBind();


                }

            }

            catch (Exception ex) { MessageBox.alert("No se ha podido efectuar la consulta debido al siguiente Error: " + ex.Message); }
        }
    }
}