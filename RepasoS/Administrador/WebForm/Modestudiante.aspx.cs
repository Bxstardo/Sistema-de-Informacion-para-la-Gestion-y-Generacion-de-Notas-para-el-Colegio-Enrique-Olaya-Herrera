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
    public partial class Modestudiante : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (TextBox1.Text == "")
            {
                MessageBox.alert("No deje el campo vacio");
            }
            else
            {
                GridView1.DataBind();
                string Estado = "";
                Estudiantes ObjEstudiante = new Estudiantes();
                SesionU ObjSesion = new SesionU();
                Cursos ObjCurso = new Cursos();
                try
                {
                    DataSet DatosEstudiante = ObjEstudiante.ConsultarEstudiante(TextBox1.Text, "IdentificacionEst");

                    DataTable DatosConsultados = DatosEstudiante.Tables["DatosConsultados"];

                    int numregistros = DatosConsultados.Rows.Count;

                    if (numregistros == 0)
                    {
                        MessageBox.alert("No existe en la Base de Datos Estudiante con esta identificación o el Estudiante se encuentra inactivo");

                    }
                    else
                    {
                        Estado = DatosConsultados.Rows[0]["Estado"].ToString();
                    }



                    if (Estado == "Activo")
                    {
                        ObjEstudiante.IdentificacionEst = int.Parse(TextBox6.Text);
                        ObjEstudiante.Nombres = TextBox18.Text;
                        ObjEstudiante.Apellidos = TextBox19.Text;
                        ObjEstudiante.Direccion = TextBox2.Text;
                        ObjEstudiante.Eps = TextBox3.Text;
                        ObjEstudiante.Jornada = DropDownList3.SelectedItem.Text;
                        ObjEstudiante.Num_Contacto = TextBox5.Text;
                        ObjEstudiante.Email = TextBox7.Text;




                        ObjSesion.Usuario = int.Parse(TextBox6.Text);
                        ObjSesion.Contraseña = TextBox8.Text;


                        Label1.Text = TextBox18.Text;
                        Label2.Text = TextBox19.Text;
                        Label3.Text = TextBox2.Text;
                        Label4.Text = TextBox3.Text;
                        Label5.Text = DropDownList3.Text;
                        Label6.Text = TextBox5.Text;
                        Label7.Text = TextBox6.Text;
                        Label8.Text = TextBox7.Text;
                        Label9.Text = TextBox8.Text;
                        Label10.Text = TextBox9.Text;


                        bool respuestaSQL = ObjEstudiante.ActualizarEstudiante();
                        bool respuestaSQL2 = ObjSesion.ActualizarSesion();

                        if (respuestaSQL == true && respuestaSQL2 == true)
                        {


                            try
                            {
                                DataSet DatosCurso = ObjCurso.ConsultarCurso2(DropDownList1.Text, DropDownList3.Text, "JorYCur");

                                DataTable DatosConsultados3 = DatosCurso.Tables["DatosConsultados"];

                                int numregistros3 = DatosConsultados3.Rows.Count;

                                if (numregistros3 == 0)
                                {
                                    MessageBox.alert("Este curso no existe para la jornada " + DatosConsultados.Rows[0]["Jornada"].ToString());
                                }
                                else
                                {

                                    try
                                    {
                                        ObjCurso.Num_Curso = DropDownList1.Text;
                                        ObjCurso.Jornada = DropDownList3.Text;
                                        ObjCurso.IdentificacionEst = int.Parse(TextBox6.Text);

                                        bool RespuestaSql = ObjCurso.InsertarCursoEst();


                                        if (RespuestaSql == true)
                                        {

                                            Label12.Text = DropDownList3.SelectedItem.Text;
                                            Label11.Text = DropDownList1.Text;

                                            MessageBox.alert("Los datos del estudiante fueron actualizados correctamente");


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
                            catch
                           (Exception Ex)
                            { MessageBox.alert("Error!: " + Ex.Message + " " + ObjCurso.Mensaje); }


                        }
                        else { MessageBox.alert(ObjEstudiante.Mensaje); }

                    }
                    else
                    {
                        MessageBox.alert("No se puede actualizar el estudiante porque se encuentra inactivo o no existe");
                    }



                }
                catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjEstudiante.Mensaje); }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            if (TextBox1.Text == "")
            {
                MessageBox.alert("No deje el campo vacio");
            }
            else
            {
                Estudiantes ObjEstudiante = new Estudiantes();

                GridView1.DataBind();
                try
                {
                    bool respuestaSQL = ObjEstudiante.CambiarEstado(TextBox1.Text);


                    if (respuestaSQL == true)
                    {
                        TextBox6.Text = "";
                        TextBox18.Text = "";
                        TextBox19.Text = "";
                        TextBox2.Text = "";
                        TextBox3.Text = "";
                        TextBox5.Text = "";
                        TextBox7.Text = "";
                        TextBox8.Text = "";
                        TextBox18.Text = "";


                        Label12.Text = "";
                        Label1.Text = "";
                        Label2.Text = "";
                        Label3.Text = "";
                        Label4.Text = "";
                        Label5.Text = "";
                        Label6.Text = "";
                        Label7.Text = "";
                        Label8.Text = "";
                        Label9.Text = "";
                        Label10.Text = "";
                        Label11.Text = "";

                        MessageBox.alert("El estudiante ha cambiado su estado a inactivo correctamente");


                    }
                    else { MessageBox.alert(ObjEstudiante.Mensaje); }
                }

                catch (Exception Ex)
                {
                    MessageBox.alert("Error!: " + Ex.Message + " " + ObjEstudiante.Mensaje);

                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Estudiantes ObjEstudiante = new Estudiantes();

            try
            {
                DataSet DatosEstudiante = ObjEstudiante.ConsultarEstudianteTodos();

                DataTable DatosConsultados = DatosEstudiante.Tables["DatosConsultados"];

                int numregistros = DatosConsultados.Rows.Count;

                if (numregistros == 0)
                {
                    MessageBox.alert("No hay datos en la base de datos");
                }
                else
                {
                    GridView1.DataSource = DatosConsultados; GridView1.DataBind();


                }

            }

            catch (Exception ex) { MessageBox.alert("No se ha podido efectuar la consulta debido al siguiente Error: " + ex.Message); }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {


            if (TextBox1.Text == "")
            {
                MessageBox.alert("No deje el campo vacio");
            }
            else
            {

                TextBox6.Text = "";
                TextBox18.Text = "";
                TextBox19.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox5.Text = "";
                TextBox7.Text = "";
                TextBox8.Text = "";
                TextBox18.Text = "";

                GridView1.DataBind();
                Label12.Text = "";
                Label1.Text = "";
                Label2.Text = "";
                Label3.Text = "";
                Label4.Text = "";
                Label5.Text = "";
                Label6.Text = "";
                Label7.Text = "";
                Label8.Text = "";
                Label9.Text = "";
                Label10.Text = "";
                Label11.Text = "";
                Label12.Text = "";

                Estudiantes ObjEstudiante = new Estudiantes();
                Cursos ObjCurso = new Cursos();
                SesionU ObjSesion = new SesionU();
                string identificacion;
                string contraseña;

                try
                {
                    DataSet DatosEstudiante = ObjEstudiante.ConsultarEstudiante(TextBox1.Text, "IdentificacionEst");


                    DataTable DatosConsultados = DatosEstudiante.Tables["DatosConsultados"];


                    int numregistros = DatosConsultados.Rows.Count;


                    if (numregistros == 0 || DatosConsultados.Rows[0]["Estado"].ToString() == "Inactivo")
                    {
                        MessageBox.alert("No existe en la Base de Datos Estudiante con esta identificación o el Estudiante se encuentra inactivo");




                    }

                    else
                    {
                        TextBox18.Text = DatosConsultados.Rows[0]["Nombres"].ToString();
                        Label1.Text = DatosConsultados.Rows[0]["Nombres"].ToString();
                        TextBox19.Text = DatosConsultados.Rows[0]["Apellidos"].ToString();
                        Label2.Text = DatosConsultados.Rows[0]["Apellidos"].ToString();
                        TextBox2.Text = DatosConsultados.Rows[0]["Direccion"].ToString();
                        Label3.Text = DatosConsultados.Rows[0]["Direccion"].ToString();
                        TextBox3.Text = DatosConsultados.Rows[0]["Eps"].ToString();
                        Label4.Text = DatosConsultados.Rows[0]["Eps"].ToString();
                        Label5.Text = DatosConsultados.Rows[0]["Jornada"].ToString();
                        TextBox5.Text = DatosConsultados.Rows[0]["Num_Contacto"].ToString();
                        Label6.Text = DatosConsultados.Rows[0]["Num_Contacto"].ToString();
                        TextBox6.Text = DatosConsultados.Rows[0]["IdentificacionEst"].ToString();
                        Label7.Text = DatosConsultados.Rows[0]["IdentificacionEst"].ToString();
                        TextBox7.Text = DatosConsultados.Rows[0]["Email"].ToString();
                        Label8.Text = DatosConsultados.Rows[0]["Email"].ToString();
                        DropDownList3.SelectedValue = DatosConsultados.Rows[0]["Jornada"].ToString();
                        Label12.Text = DatosConsultados.Rows[0]["Jornada"].ToString();
                        identificacion = DatosConsultados.Rows[0]["IdentificacionEst"].ToString();

                        try
                        {
                            DataSet DatosCurso = ObjCurso.ConsultarCurso(DatosConsultados.Rows[0]["Id_Curso"].ToString(), "Id_Curso");

                            DataTable DatosConsultados3 = DatosCurso.Tables["DatosConsultados"];

                            int numregistros3 = DatosConsultados3.Rows.Count;


                            if (numregistros3 == 0)
                            {
                                Label11.Text = "(Sin Curso)";
                            }
                            else
                            {
                                Label11.Text = DatosConsultados3.Rows[0]["Num_Curso"].ToString();
                                DropDownList1.SelectedValue = DatosConsultados3.Rows[0]["Num_Curso"].ToString();

                                try
                                {
                                    DataSet DatosSesion = ObjSesion.ConsultarSesion(identificacion, "Usuario");

                                    DataTable DatosConsultados2 = DatosSesion.Tables["DatosConsultados"];

                                    int numregistros2 = DatosConsultados2.Rows.Count;

                                    if (numregistros2 == 0)
                                    {


                                    }
                                    else
                                    {

                                        contraseña = DatosConsultados2.Rows[0]["Contraseña"].ToString();
                                        Label9.Text = contraseña;
                                        TextBox8.Text = contraseña;

                                    }
                                }
                                catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjSesion.Mensaje); }
                            }


                        }
                        catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjCurso.Mensaje); }



                    }
                }




                catch (Exception Ex) { MessageBox.alert("Error!: " + Ex.Message + " " + ObjEstudiante.Mensaje); }
            }

            }
    }
}

