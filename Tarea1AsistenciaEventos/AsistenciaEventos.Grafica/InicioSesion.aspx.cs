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

            if (nombre == "" || contrasenna == "")
            {
                cajaError.Visible = true;
                lblError.CssClass = "text-warning";
                lblError.Text = "Debe rellenar los campos correspondientes al nombre de usuario y clave de acceso";
            }
            else
            {
                if (usuarioLogica.SeleccionarTodos(nombre, contrasenna).Count > 0)
                {
                    cajaError.Visible = false;
                    lblError.Text = "";
                    Response.Redirect("Principal.aspx");
                }
                else
                {
                    cajaError.Visible = true;
                    lblError.CssClass = "text-warning";
                    lblError.Text = "Usuario o contraseña invalidos";
                }
            }
        }
    }
}