using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionASP
{
    public partial class Registrarse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistro_Click(object sender, EventArgs e)
        {

            bool emailValidation = Datos.ExisteMail(txtMail.Text);

            if (txtNombre.Text == string.Empty || txtApellido.Text == string.Empty || txtMail.Text == string.Empty || txtPass.Text == string.Empty || txtPass2.Text == string.Empty)
            {
                LimpiarLabels();
                lblDatosIncompletos.Text = "Debe llenar todos los campos";
            }
            else
            {
                if (emailValidation != true)
                {
                    if (txtPass.Text == txtPass2.Text)
                    {
                        bool registro = Datos.RegistrarUsuario(txtNombre.Text, txtApellido.Text, txtMail.Text, txtPass.Text);
                        if (registro == true)
                        {
                            Session["mail"] = txtMail.Text;
                            Response.Redirect("~/RegistroExitoso.aspx");
                        }
                        else
                        {
                            Response.Write("Hubo un inconveniente, el usuario no fue creado");
                        }
                    }
                    else
                    {
                        LimpiarLabels();
                        lblClavesDiferentes.Text = "Las claves deben ser iguales";
                    }
                }
                else
                {
                    LimpiarLabels();
                    lblEmailExistente.Text = "El email ingresado ya existe en la base de datos";
                }
            }
        }

        protected void LimpiarLabels()
        {
            lblDatosIncompletos.Text = string.Empty;
            lblClavesDiferentes.Text = string.Empty;
            lblEmailExistente.Text = string.Empty;
        }
    }
}