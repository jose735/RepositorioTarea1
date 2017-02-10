using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AsistenciaEventos.Entidades;
using AsistenciaEventos.Logica;
using System.Data;

namespace AsistenciaEventos.Grafica
{
    public partial class Formulario_web11 : System.Web.UI.Page
    {
        EventoLogica eventoLogica = new EventoLogica();
        protected void Page_Load(object sender, EventArgs e)
        {
            txtFechaEvento_CalendarExtender.StartDate = DateTime.Now;
            if (!IsPostBack)
            {
                refrescar();
            }
        }

        public void refrescar()
        {
            dgvEventos.DataSource = eventoLogica.SeleccionarTodos();
            dgvEventos.DataBind();
        }

        protected void btnCrearEvento_Click(object sender, EventArgs e)
        {
            Evento evento = new Evento();
            String nombre = txtNombreEvento.Text;
            String fecha = txtFechaEvento.Text;

            if (nombre == "" || fecha == "")
            {
                cajaError.Visible = true;
                lblError.CssClass = "text-warning";
                lblError.Text = "Debe rellenar los campos correspondientes a la fecha del evento y el nombre del evento";
            }
            else
            {
                evento.nombre = nombre;
                evento.fecha = fecha;
                evento.cierreMesa = "No";
                eventoLogica.Insertar(evento);
                lblError.Text = "";
                cajaError.Visible = false;
                refrescar();
            }
        }

        protected void dgvEventos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            dgvEventos.EditIndex = -1;
            refrescar();
        }

        protected void dgvEventos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(dgvEventos.DataKeys[e.RowIndex].Value.ToString());

            eventoLogica.Eliminar(id);
            dgvEventos.EditIndex = -1;
            refrescar();
        }

        protected void dgvEventos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            dgvEventos.EditIndex = e.NewEditIndex;
            refrescar();
        }

        protected void dgvEventos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Evento evento = new Evento();
            // Se obtiene el TextBox que esta en la celda codigo de la fila por editar en el caso que no
            // se muestre el codigo se obtiene el identificadro de la siguiente manera
            evento.codigo = Convert.ToInt32(dgvEventos.DataKeys[e.RowIndex].Values[0]);
            String nombre = ((Label)dgvEventos.Rows[e.RowIndex].FindControl("lblNombreEdit")).Text;
            String fecha = ((TextBox)dgvEventos.Rows[e.RowIndex].FindControl("txtFechaEventoEdit")).Text;

            if (fecha == "")
            {
                cajaError.Visible = true;
                lblError.CssClass = "text-warning";
                lblError.Text = "Debe rellenar el campo correspondiente a la fecha del evento";
            }
            else
            {
                evento.nombre = nombre;
                evento.fecha = fecha;
                evento.cierreMesa = "No";
                eventoLogica.ModificarFecha(evento);
                lblError.Text = "";
                cajaError.Visible = false;
                dgvEventos.EditIndex = -1;
                refrescar();
            }
        }

        protected void dgvEventos_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //Evento que se encarga de cargar la información correspondiente en
            //el dropdownlist cuando se selecciona editar
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //Find the DropDownList in the Row
                Label lblNombre = (e.Row.FindControl("lblNombreEdit") as Label);
                TextBox txtFecha = (e.Row.FindControl("txtFechaEventoEdit") as TextBox);

                if ((e.Row.RowState & DataControlRowState.Edit) > 0)
                {
                    DataRowView dr = e.Row.DataItem as DataRowView;
                    string nombre = (DataBinder.Eval(e.Row.DataItem, "nombre")).ToString();
                    string fecha = (DataBinder.Eval(e.Row.DataItem, "fecha")).ToString();
                    lblNombre.Text = nombre;
                    txtFecha.Text = fecha;
                }


            }
        }
    }
}