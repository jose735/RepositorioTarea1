using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AsistenciaEventos.Grafica
{
    public partial class Formulario_web15 : System.Web.UI.Page
    {
        public static String accionPantalla = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistroEvento_Click(object sender, EventArgs e)
        {
            accionPantalla = "RegistroEvento";
            Response.Redirect("InicioSesion2.aspx");
        }

        protected void btnRegistroAsistencia_Click(object sender, EventArgs e)
        {
            accionPantalla = "RegistroAsistencia";
            Response.Redirect("RegistroAsistenciaMaster.aspx");
        }

        protected void btnReporteEventos_Click(object sender, EventArgs e)
        {
            accionPantalla = "ReporteEvento";
            Response.Redirect("InicioSesion2.aspx");
        }
    }
}