using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RepasoS.scripts;
using System.Data;
using System.Data.SqlClient;
using LogicaV;
using DatosV;



namespace RepasoS
{
    public partial class Sesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
             
            
        }

     
        
        protected void Button1_Click(object sender, EventArgs e)
        {
        string usuario = TextBox1.Text;
        string contraseña = TextBox2.Text;

        int sel = DropDownList1.SelectedIndex;
        bool validacion = false;

            if (TextBox1.Text == "" || TextBox2.Text == "")
            {
                MessageBox.alert("Los campos no pueden estar vacios");
            }
            else
            {
                switch (sel)
                {
                    case 0:

                        try
                        {
                            Estudiantes ObjEstudiante = new Estudiantes();

                            DataSet DatosEstudiante = ObjEstudiante.ConsultarEstudiante(TextBox1.Text, "IdentificacionEst");

                            DataTable DatosConsultados = DatosEstudiante.Tables["DatosConsultados"];

                            int numregistros = DatosConsultados.Rows.Count;

                            if (numregistros == 0)
                            {
                                MessageBox.alert("No existe en la Base de Datos Cliente con esta identificación");

                                TextBox1.Text = "";
                                TextBox2.Text = "";
                            }
                            else
                            {

                                Session["NombresE"] = DatosConsultados.Rows[0]["Nombres"].ToString();
                                Session["ApellidosE"] = DatosConsultados.Rows[0]["Apellidos"].ToString();
                                Session["IdentificacionEst"] = DatosConsultados.Rows[0]["IdentificacionEst"].ToString();


                            }

                            int numero;
                            numero = 0;


                            DataView dvSql = (DataView)SqlDataSource2.Select(DataSourceSelectArguments.Empty);

                            if (dvSql.Count > 0)
                            {
                                numero = 1;
                            }
                            if (numero == 1)
                            {

                                Response.Redirect("Estudiante/index.aspx");

                            }
                            else
                            {
                                MessageBox.alert("Usuario y/o Contraseña Incorrecta");
                                TextBox1.Text = "";
                                TextBox2.Text = "";
                            }
                        }
                        catch (Exception Ex)
                        {
                            MessageBox.alert("Usuario y/o Contraseña Incorrecta");
                            MessageBox.alert("Error!: " + Ex.Message + " ");
                            TextBox1.Text = "";
                            TextBox2.Text = "";
                        }

                        break;
                    case 1:
                        try
                        {
                            Acudientes ObjAcudiente = new Acudientes();

                            DataSet DatosAcudiente = ObjAcudiente.ConsultarAcudiente(TextBox1.Text, "IdentificacionAcu");

                            DataTable DatosConsultados = DatosAcudiente.Tables["DatosConsultados"];

                            int numregistros = DatosConsultados.Rows.Count;

                            if (numregistros == 0)
                            {
                                MessageBox.alert("No existe en la Base de Datos Cliente con esta identificación");
                                TextBox1.Text = "";
                                TextBox2.Text = "";

                            }
                            else
                            {

                                Session["NombresA"] = DatosConsultados.Rows[0]["Nombres"].ToString();
                                Session["ApellidosA"] = DatosConsultados.Rows[0]["Apellidos"].ToString();
                                Session["IdentificacionAcu"] = DatosConsultados.Rows[0]["IdentificacionAcu"].ToString();


                            }

                            int numero;
                            numero = 0;
                            DataView dvSql = (DataView)SqlDataSource2.Select(DataSourceSelectArguments.Empty);

                            if (dvSql.Count > 0)
                            {
                                numero = 1;
                            }
                            if (numero == 1)
                            {

                                Response.Redirect("Acudiente/index.aspx");

                            }
                            else
                            {
                                TextBox1.Text = "";
                                TextBox2.Text = "";
                                MessageBox.alert("Usuario y/o Contraseña Incorrecta");
                            }
                        }
                        catch
                        {
                            TextBox1.Text = "";
                            TextBox2.Text = "";
                            MessageBox.alert("Usuario y/o Contraseña Incorrecta");
                        }
                        break;
                    case 2:
                        try
                        {
                            Docentes ObjDocente = new Docentes();

                            DataSet DatosDocente = ObjDocente.ConsultarDocente(TextBox1.Text, "IdentificacionDoc");

                            DataTable DatosConsultados = DatosDocente.Tables["DatosConsultados"];

                            int numregistros = DatosConsultados.Rows.Count;

                            if (numregistros == 0)
                            {
                                MessageBox.alert("No existe en la Base de Datos Cliente con esta identificación");
                                TextBox1.Text = "";
                                TextBox2.Text = "";

                            }
                            else
                            {

                                Session["NombresD"] = DatosConsultados.Rows[0]["Nombres"].ToString();
                                Session["ApellidosD"] = DatosConsultados.Rows[0]["Apellidos"].ToString();
                                Session["IdentificacionDoc"] = TextBox1.Text;


                            }

                            int numero;
                            numero = 0;
                            DataView dvSql = (DataView)SqlDataSource2.Select(DataSourceSelectArguments.Empty);

                            if (dvSql.Count > 0)
                            {
                                numero = 1;
                            }
                            if (numero == 1)
                            {


                                Response.Redirect("Docente/index.aspx");


                            }
                            else
                            {
                                TextBox1.Text = "";
                                TextBox2.Text = "";
                                MessageBox.alert("Usuario y/o Contraseña Incorrecta");
                            }
                        }
                        catch
                        {
                            TextBox1.Text = "";
                            TextBox2.Text = "";
                            MessageBox.alert("Usuario y/o Contraseña Incorrecta");
                        }
                        break;
                    case 3:
                        try
                        {

                            Administradorr ObjAdministrador = new Administradorr();

                            DataSet DatosAdministrador = ObjAdministrador.ConsultarAdministrador(TextBox1.Text, "IdentificacionAdm");

                            DataTable DatosConsultados = DatosAdministrador.Tables["DatosConsultados"];

                            int numregistros = DatosConsultados.Rows.Count;

                            if (numregistros == 0)
                            {
                                MessageBox.alert("No existe en la Base de Datos Cliente con esta identificación");

                                TextBox1.Text = "";
                                TextBox2.Text = "";
                            }
                            else
                            {

                                Session["NombresAA"] = DatosConsultados.Rows[0]["Nombres"].ToString();
                                Session["ApellidosAA"] = DatosConsultados.Rows[0]["Apellidos"].ToString();
                                Session["IdentificacionAdm"] = DatosConsultados.Rows[0]["IdentificacionAdm"].ToString();


                            }

                            int numero;
                            numero = 0;
                            DataView dvSql = (DataView)SqlDataSource2.Select(DataSourceSelectArguments.Empty);

                            if (dvSql.Count > 0)
                            {
                                numero = 1;
                            }
                            if (numero == 1)
                            {

                                Response.Redirect("Administrador/index.aspx");

                            }
                            else
                            {
                                TextBox1.Text = "";
                                TextBox2.Text = "";
                                MessageBox.alert("Usuario y/o Contraseña Incorrecta");
                            }
                        }
                        catch
                        {
                            TextBox1.Text = "";
                            TextBox2.Text = "";
                            MessageBox.alert("Usuario y/o Contraseña Incorrecta");
                        }

                        break;




                }
            }
        
        
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registrarse.aspx");
        }

     
    }
}