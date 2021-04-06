using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionASP
{
    public partial class Contacto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviarContacto_Click(object sender, EventArgs e)
        {
            if (txtNombreContacto.Text != string.Empty && txtMailcontacto.Text != string.Empty && txtMensajeContacto.Text != string.Empty)
            {
                bool mensajeGuardado = Datos.InsertarMensajeContacto(txtNombreContacto.Text, txtMailcontacto.Text, txtMensajeContacto.Text);

                if (mensajeGuardado == true)
                {
                    lblGuardadoMensaje.Text = "Su mensaje fue enviado con exito";
                    lblGuardadoMensaje.ForeColor = Color.Green;
                }
                else
                {
                    lblGuardadoMensaje.Text = "Su mensaje no pudo enviarse, intente nuevamente.";
                    lblGuardadoMensaje.ForeColor = Color.Red;
                }
            }
            else
            {
                lblGuardadoMensaje.Text = "Debe completar todos los datos.";
                lblGuardadoMensaje.ForeColor = Color.Red;
            }
            LimpiarCampos();
        }

        protected void LimpiarCampos()
        {
            txtNombreContacto.Text = string.Empty;
            txtMailcontacto.Text = string.Empty;
            txtMensajeContacto.Text = string.Empty;
        }
    }
}