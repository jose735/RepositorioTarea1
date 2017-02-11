using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AsistenciaEventos.Entidades;
using AsistenciaEventos.Logica;

namespace AsistenciaEventos.Grafica
{
    public partial class InicioSesion : System.Web.UI.Page
    {
        UsuarioLogica usuarioLogica = new UsuarioLogica();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            String nombre = txtUsuario.Text;
            String contrasenna = txtContrasenna.Text;

            Show("Hola");

            //if (nombre == "" || contrasenna == "")
            //{
            //    Show("Debe llenar los campos correspondientes a nombre de usuario y contraseña");
            //}
            //else
            //{
            //    if (usuarioLogica.SeleccionarTodos(nombre, contrasenna).Count > 0)
            //    {
            //        Response.Redirect("Principal.aspx");
            //    }
            //    else
            //    {
            //        Show("Usuario y/o contraseña invalido(s)");
            //    }
            //}
        }

        public static void Show(string message)
        {
            // Cleans the message to allow single quotation marks 
            string cleanMessage = message.Replace("'", "\'");
            string script = "<script type="text / javascript">alert('" + cleanMessage + "');</script>";

            // Gets the executing web page 
            Page page = HttpContext.Current.CurrentHandler as Page;

            // Checks if the handler is a Page and that the script isn't allready on the Page 
            if (page != null && !page.ClientScript.IsClientScriptBlockRegistered("alert"))
            {
                page.ClientScript.RegisterClientScriptBlock(typeof(Alert), "alert", script);
            }
        }
    }
}