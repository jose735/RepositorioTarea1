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
    public partial class InicioSesion2 : System.Web.UI.Page
    {
        UsuarioLogica usuarioLogica = new UsuarioLogica();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("PrincipalMaster.aspx");
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
                    InicioSesion.nombreUsuario = txtUsuario.Text;
                    if (Formulario_web15.accionPantalla == "RegistroEvento")
                    {
                        Response.Redirect("RegistrarEvento.aspx");
                    }

                    if (Formulario_web15.accionPantalla == "RegistroAsistencia")
                    {
                        Response.Redirect("RegistrarAsistencia.aspx");
                    }

                    if (Formulario_web15.accionPantalla == "ReporteEvento")
                    {
                        Response.Redirect("ReporteMiembrosPorEvento.aspx");
                    }
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Usuario y/o contraseña invalido(s)');", true);
                }
            }
        }
    }
}