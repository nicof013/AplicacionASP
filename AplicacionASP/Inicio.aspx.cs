using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionASP
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["mail"] != null)
            {
                txtMail.Text = Session["mail"].ToString();
                Session["mail"] = null;
            }
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            bool acceso = Datos.IniciarSesion(txtMail.Text, txtPassword.Text);

            if (acceso == true)
            {
                Session["mail"] = txtMail.Text;
                Response.Redirect("~/UsuarioInicio.aspx");
            }
            else
            {
                lblAccesoDenegado.Text = "Usuario o contraseña incorrectos.";
            }
        }
    }
}