using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionASP
{
    public partial class UsuarioVerUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["mail"] != null)
            {
                gvUsuarios.DataSource = Datos.ListarUsuarios();
                gvUsuarios.DataBind();
            }
            else
            {
                Response.Redirect("~/Inicio.aspx");
            }
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Session["mail"] = null;
            Response.Redirect("~/Inicio.aspx");
        }
    }
}