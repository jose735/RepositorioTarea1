using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AsistenciaEventos.Grafica
{
    public partial class Formulario_web11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtFechaEvento_CalendarExtender.StartDate = DateTime.Now;
        }

        protected void btnCrearEvento_Click(object sender, EventArgs e)
        {

        }

        protected void dgvEventos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }

        protected void dgvEventos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void dgvEventos_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void dgvEventos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void dgvEventos_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }
    }
}