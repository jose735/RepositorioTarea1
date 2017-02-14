using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AsistenciaEventos.Logica;

namespace AsistenciaEventos.Grafica
{
    public partial class Formulario_web16 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                refrescar();
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            MiembroLogica miembroLogica = new MiembroLogica();
            ReportViewer1.LocalReport.Refresh();
            if (miembroLogica.SeleccionarMiembrosPorEvento(Convert.ToInt32(ddlEvento.SelectedValue)).Count > 0)
            {
                cajaError.Visible = false;
                lblError.Text = "";
                ReportViewer1.LocalReport.Refresh();
            }
            else
            {
                cajaError.Visible = true;
                lblError.CssClass = "text-warning";
                lblError.Text = "No se encontró ningún miembro en este evento";
            }
        }

        public void refrescar()
        {
            EventoLogica eventoLogica = new EventoLogica();
            ddlEvento.DataSource = eventoLogica.SeleccionarTodos();
            ddlEvento.DataTextField = "nombre";
            ddlEvento.DataValueField = "codigo";
            ddlEvento.DataBind();
        }
    }
}