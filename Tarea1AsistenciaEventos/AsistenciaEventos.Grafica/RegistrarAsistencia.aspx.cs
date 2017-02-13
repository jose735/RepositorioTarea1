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
    public partial class Formulario_web12 : System.Web.UI.Page
    {
        EventoLogica eventoLogica = new EventoLogica();
        MiembroLogica miembroLogica = new MiembroLogica();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                refrescar();
            }
        }

        public void refrescar()
        {
            ddlEventos.DataSource = eventoLogica.SeleccionarTodos();
            ddlEventos.DataTextField = "nombre";
            ddlEventos.DataValueField = "codigo";
            ddlEventos.DataBind();
        }

        protected void ddlEventos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Evento evento = eventoLogica.SeleccionarPorIdEvento(Convert.ToInt32(ddlEventos.SelectedValue));

            if (evento.fecha != "")
            {
                String fechaHoy = DateTime.Now.ToString("dd/MM/yyyy");

                if (evento.cierreMesa == "Si")
                {
                    cajaError.Visible = true;
                    lblError.CssClass = "text-warning";
                    lblError.Text = "Ya se ha ejecutado un cierre de mesa en este evento, no se pueden registrar más miembros";
                    btnBuscarMiembro.Visible = false;
                    txtIdentificacion.Text = "";
                    txtNombre.Text = "";
                    txtCorreo.Text = "";
                    txtEstado.Text = "";
                    txtTelefono.Text = "";
                    cajaRegistroMiembro.Visible = false;
                    cajaRegistroMiembro2.Visible = false;
                    cajaRegistroMiembro3.Visible = false;
                }
                else
                {
                    if (evento.fecha == fechaHoy)
                    {
                        cajaError.Visible = false;
                        lblError.Text = "";
                        btnBuscarMiembro.Visible = true;
                    }
                    else
                    {
                        cajaError.Visible = true;
                        lblError.CssClass = "text-warning";
                        lblError.Text = "El evento no ha sido abierto todavia, debe esperar hasta la fecha del evento";
                        btnBuscarMiembro.Visible = false;
                        txtIdentificacion.Text = "";
                        txtNombre.Text = "";
                        txtCorreo.Text = "";
                        txtEstado.Text = "";
                        txtTelefono.Text = "";
                        cajaRegistroMiembro.Visible = false;
                        cajaRegistroMiembro2.Visible = false;
                        cajaRegistroMiembro3.Visible = false;
                    }
                }
            }
        }

        protected void btnBuscarMiembro_Click(object sender, EventArgs e)
        {
            cajaRegistroMiembro.Visible = true;
            cajaRegistroMiembro2.Visible = true;
            cajaRegistroMiembro3.Visible = true;
        }

        protected void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {
            if (txtIdentificacion.Text != "")
            {
                Miembro miembro = miembroLogica.SeleccionarPorIdentificadorMiembro(txtIdentificacion.Text);
                if (miembro.Id != null)
                {
                    txtNombre.Text = miembro.Nombre;
                    txtCorreo.Text = miembro.Correo;
                    txtEstado.Text = miembro.Estado1;
                    txtTelefono.Text = miembro.Telefono;
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('El miembro con este número de identificacion no se encuentra registrado en el padrón');", true);
                }
            }
        }

        protected void btnRegistrarMiembro_Click(object sender, EventArgs e)
        {
            if (txtIdentificacion.Text == "")
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Debe llenar el campo correspondiente a número de identificación');", true);
            }
            else
            {
                Miembro miembro = miembroLogica.SeleccionarPorIdentificadorMiembro(txtIdentificacion.Text);
                if (miembro.Id == null)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('El miembro con este número de identificacion no se encuentra registrado en el padrón');", true);
                }
                else
                {
                    if (miembro.Estado1 == "Inactivo")
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('El miembro que intenta registrar no esta activo, debido a eso no puede ser registrada su asistencia');", true);
                    }
                    else
                    {
                        if (miembro.Estado2 == "No")
                        {
                            ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('El miembro que intenta registrar no ha confirmado su asistencia, debido a eso no puede ser registrada su asistencia');", true);
                        }
                        else
                        {
                            if (eventoLogica.SeleccionarPorIdEventoMiembro(Convert.ToInt32(ddlEventos.SelectedValue), miembro.Id) == true)
                            {
                                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Este miembro ya ha sido registrado anteriormente, registre por favor a otro miembro');", true);
                            }
                            else
                            {
                                int idEvento = Convert.ToInt32(ddlEventos.SelectedValue);
                                String idMiembro = miembro.Id;
                                String estadoAsistencia = "Presente";
                                String horaAsistencia = DateTime.Now.ToString("hh:mm:ss tt");
                                String usuarioAsistencia = InicioSesion.nombreUsuario;
                                eventoLogica.InsertarAsistencia(idEvento, idMiembro, estadoAsistencia, horaAsistencia, usuarioAsistencia);
                                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Registro completado exitosamente');", true);
                                txtIdentificacion.Text = "";
                                txtNombre.Text = "";
                                txtCorreo.Text = "";
                                txtEstado.Text = "";
                                txtTelefono.Text = "";
                            }
                        }
                    }
                }
            }
        }

        protected void btnCierreMesa_Click(object sender, EventArgs e)
        {
            Evento evento = new Evento();
            evento.codigo = Convert.ToInt32(ddlEventos.SelectedValue);
            evento.cierreMesa = "Si";
            eventoLogica.ModificarCierre(evento);
            ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('El cierre de mesa se ha ejecutado en este evento, no se pueden registrar más miembros');", true);
        }
    }
}