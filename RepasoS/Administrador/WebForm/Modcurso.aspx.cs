using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RepasoS.scripts;
using System.Data;
using LogicaV;

namespace RepasoS.Administrador.WebForm
{
    public partial class Modcurso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void Button3_Click(object sender, EventArgs e)
        {
         
            Cursos ObjCurso = new Cursos();
            Docentes ObjDocente = new Docentes();
            try
            {
                DataSet DatosCurso = ObjCurso.ConsultarCurso2(DropDownList4.Text, DropDownList3.Text, "JorYCur");

                DataTable DatosConsultados = DatosCurso.Tables["DatosConsultados"];

                int numregistros3 = DatosConsultados.Rows.Count;

                if (numregistros3 == 0)
                {
                    MessageBox.alert("Este curso no existe para la jornada " + DropDownList3.Text);
                }
                else
                {
                    try
                    {
                        Session["Id_Curso"] = DatosConsultados.Rows[0]["Id_Curso"].ToString();
                        DataSet DatosCurso2 = ObjCurso.ConsultarCurso(DatosConsultados.Rows[0]["Id_Curso"].ToString(), "Id_Curso");

                        DataTable DatosConsultados2 = DatosCurso2.Tables["DatosConsultados"];

                        int numregistros2 = DatosConsultados2.Rows.Count;

                        if (numregistros2 == 0)
                        {
                            MessageBox.alert("Este curso no existe para la jornada " + DropDownList3.Text);
                        }

                        Label1.Text = DatosConsultados2.Rows[0]["Num_Curso"].ToString();
                        TextBox2.Text = DatosConsultados2.Rows[0]["Num_Curso"].ToString();
                        Label2.Text = DatosConsultados2.Rows[0]["Nivel"].ToString();
                        Label3.Text = DatosConsultados2.Rows[0]["Jornada"].ToString();
                        DropDownList9.SelectedValue = DatosConsultados2.Rows[0]["Jornada"].ToString();

                        try
                        {
                            DataSet DatosDocente = ObjDocente.ConsultarDocenteC(DatosConsultados.Rows[0]["Id_Curso"].ToString());

                            DataTable DatosConsultados3 = DatosDocente.Tables["DatosConsultados"];

                            int numregistros = DatosConsultados3.Rows.Count;

                            if (numregistros == 0)
                            {
                                MessageBox.alert("El curso "+ DropDownList4.Text + " no tiene director");
                                MessageBox.alert(ObjDocente.Mensaje);
                            }
                            else
                            {
                                Label4.Text = DatosConsultados3.Rows[0]["IdentificacionDoc"].ToString();
                               
                            }
                        }
                        catch
                          (Exception Ex)
                        { MessageBox.alert("Error!: " + Ex.Message + " " + ObjDocente.Mensaje); }
                    }
                   
                     catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjCurso.Mensaje); }

                }
            }
            catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjCurso.Mensaje); }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView2.Visible = false;
            string Nivel;
            Cursos ObjCurso = new Cursos();
       
            if (int.Parse(TextBox2.Text) < 1000 && int.Parse(TextBox2.Text) >= 100)
            {
                Nivel = "Educacion Basica";
            }
            else if (int.Parse(TextBox2.Text) >= 1000)
            {
                Nivel = "Educacion Media";
            }
            else
            {
                Nivel = "Preescolar";
            }
            try
            {
                DataSet DatosCurso = ObjCurso.ConsultarCurso2(TextBox2.Text, DropDownList9.SelectedItem.Text, "JorYCur");

                DataTable DatosConsultados = DatosCurso.Tables["DatosConsultados"];

                int numregistros = DatosConsultados.Rows.Count;

                if (numregistros == 0)
                {
                    try
                    {
                        ObjCurso.Id_Curso = int.Parse(Session["Id_Curso"].ToString());
                        ObjCurso.Num_Curso = TextBox2.Text;
                        ObjCurso.Jornada = DropDownList9.Text;
                        ObjCurso.Nivel = Nivel;



                        bool RespuestaSql = ObjCurso.ActualizarCurso();

                        if (RespuestaSql == true)
                        {
                            Label1.Text = TextBox2.Text;
                            Label3.Text = DropDownList9.Text;
                            Label2.Text = Nivel;

                            DropDownList4.DataBind();
                     
                            GridView1.DataBind();

                            MessageBox.alert("El curso se ha modificado correctamente");                            
                        }
                        else
                        {
                            MessageBox.alert(ObjCurso.Mensaje);
                        }
                    }
                    catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjCurso.Mensaje); }

                }
                else
                {
                    MessageBox.alert("Este curso ya existe");
                }

             
            }
            catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjCurso.Mensaje); }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            GridView2.Visible = false;
            Cursos ObjCurso = new Cursos();
            TextBox2.Text = "";
            Label1.Text = "";
            Label3.Text = "";
            Label2.Text = "";
            Label4.Text = "";

            try
            {
                ObjCurso.Id_Curso = int.Parse(Session["Id_Curso"].ToString());

                bool RespuestaSql = ObjCurso.EliminarCurso();

                if (RespuestaSql == true)
                {
                    TextBox2.Text = "";
                    Label1.Text = "";
                    Label3.Text = "";
                    Label2.Text = "";
                    Label4.Text = "";
                    MessageBox.alert("Se ha eliminado el curso correctamente");
                }
                else
                {
                    MessageBox.alert("Para eliminar este curso elimine las asignaciones que se muestran en la tabla");
                    try
                    {

                        DataSet DatosCurso = ObjCurso.ConsultarDocenteCurso(Session["Id_Curso"].ToString());

                        DataTable DatosConsultados = DatosCurso.Tables["DatosConsultados"];

                        int numregistros2 = DatosConsultados.Rows.Count;

                        if (numregistros2 == 0)
                        {
                         

                        }
                        else
                        {
                            GridView2.Visible = true;
                            GridView2.DataSource = DatosConsultados;
                            GridView2.DataBind();
                        }

                    }

                    catch
                    {

                    }
                    try
                    {

                        DataSet DatosCurso = ObjCurso.ConsultarEstudianteCurso(Session["Id_Curso"].ToString());

                        DataTable DatosConsultados = DatosCurso.Tables["DatosConsultados"];

                        int numregistros2 = DatosConsultados.Rows.Count;

                        if (numregistros2 == 0)
                        {
                            

                        }
                        else
                        {
                            GridView2.Visible = true;
                            GridView2.DataSource = DatosConsultados;
                            GridView2.DataBind();
                        }

                    }

                    catch
                    {

                    }


                }
            }
            catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjCurso.Mensaje); }



        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            MessageBox.alert("Se han guardado cambios con exito!");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Cursos ObjCurso = new Cursos();

            try
            {
                DataSet DatosCurso = ObjCurso.ConsultarCursoTodos();

                DataTable DatosConsultados = DatosCurso.Tables["DatosConsultados"];

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

     

        
    }
}