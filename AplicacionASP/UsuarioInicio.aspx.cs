using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionASP
{
    public partial class UsuarioInicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["mail"] != null)
            {
                string mail = Session["mail"].ToString();

                DataTable tabla = Datos.ListarUsuarioLogueado(mail);
                lblNombreUsuario.Text = tabla.Rows[0]["Nombre"].ToString();
                lblApellidoUsuario.Text = tabla.Rows[0]["Apellido"].ToString();
                lblMailUsuario.Text = tabla.Rows[0]["Mail"].ToString();
                lblUltimaConexionUsuario.Text = tabla.Rows[0]["Ultima Conexion"].ToString();

                bool registro = Datos.RegistrarLogUsuario(mail);
                if (registro == false)
                {
                    //CODIGO DE ALERTA
                }
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