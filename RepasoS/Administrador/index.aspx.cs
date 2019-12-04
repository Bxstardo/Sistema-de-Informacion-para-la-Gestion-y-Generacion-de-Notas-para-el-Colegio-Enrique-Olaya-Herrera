using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RepasoS.Administrador
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Pagina"] == "yes")
            {
                Response.Redirect("../../Sesion.aspx");
                Session["Pagina"] = "no";
            }

        }

    }
}