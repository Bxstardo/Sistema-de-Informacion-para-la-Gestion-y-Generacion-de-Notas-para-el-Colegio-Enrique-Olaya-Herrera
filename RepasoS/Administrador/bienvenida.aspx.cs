using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RepasoS.Administrador
{
    public partial class bienvenida : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Label1.Text = (Session["NombresAA"]).ToString();
                Label2.Text = (Session["ApellidosAA"]).ToString();
            }
         catch
            { }
        }
    }
}