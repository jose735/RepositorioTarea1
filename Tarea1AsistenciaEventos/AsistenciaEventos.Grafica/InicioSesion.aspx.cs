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
        public static String nombreUsuario = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            String nombre = txtUsuario.Text;
            String contrasenna = txtContrasenna.Text;

            if (nombre == "" || contrasenna == "")
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Debe llenar los campos correspondientes a nombre de usuario y contraseña');", true);
            }
            else
            {
                if (usuarioLogica.SeleccionarTodos(nombre, contrasenna).Count > 0)
                {
                    nombreUsuario = txtUsuario.Text;
                    Response.Redirect("Principal.aspx");
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Usuario y/o contraseña invalido(s)');", true);
                }
            }
        }
    }
}