using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace AplicacionASP
{
    public partial class UsuarioVerMensajes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["mail"] != null)
            {
                //MISMO RESULTADO CON ADO.NET usando SP
                //DataTable tabla = Datos.ListarMensajes(txtFiltroMensajes.Text);
                //gvMensajes.DataSource = tabla;
                //gvMensajes.DataBind();

                //USANDO LINQ
                ListarMensajesLINQ(txtFiltroMensajes.Text);
            }
            else
            {
                Response.Redirect("~/Inicio.aspx");
            }
        }

        protected void btnFiltrarMensajes_Click(object sender, EventArgs e)
        {
            ListarMensajesLINQ(txtFiltroMensajes.Text);
        }

        protected void ListarMensajesLINQ(string filtro)
        {
            if (filtro == string.Empty)
            {
                DBDataContext dataContext = new DBDataContext();
                var data = from mjes in dataContext.contacto_mensajes
                           select new
                           {
                               Nombre = mjes.cmje_nombre,
                               Mail = mjes.cmje_mail,
                               Mensaje = mjes.cmje_mensaje,
                               Fecha = mjes.cmje_fecha
                           };
                gvMensajes.DataSource = data;
                gvMensajes.DataBind();
            }
            else
            {
                DBDataContext dataContext = new DBDataContext();
                var data = from mjes in dataContext.contacto_mensajes
                           where mjes.cmje_mail == filtro
                           select new
                           {
                               Nombre = mjes.cmje_nombre,
                               Mail = mjes.cmje_mail,
                               Mensaje = mjes.cmje_mensaje,
                               Fecha = mjes.cmje_fecha
                           };
                gvMensajes.DataSource = data;
                gvMensajes.DataBind();
            }
        }
    }
}