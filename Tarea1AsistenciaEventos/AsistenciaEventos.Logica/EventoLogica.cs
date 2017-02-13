using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsistenciaEventos.Datos;
using AsistenciaEventos.Entidades;
using System.Data;

namespace AsistenciaEventos.Logica
{
    public class EventoLogica
    {
        public EventoDatos eventoDatos = new EventoDatos();
        public void Insertar(Evento evento)
        {
            eventoDatos.Insertar(evento.nombre, evento.fecha, evento.cierreMesa);
        }

        public void InsertarAsistencia(int idEvento, String idMiembro, String estadoAsistencia, String horaAsistencia, String usuarioAsistencia)
        {
            eventoDatos.InsertarAsistencia(idEvento, idMiembro, estadoAsistencia, horaAsistencia, usuarioAsistencia);
        }

        public void ModificarFecha(Evento evento)
        {
            eventoDatos.ModificarFecha(evento.codigo, evento.fecha);
        }

        public void ModificarCierre(Evento evento)
        {
            eventoDatos.ModificarCierre(evento.codigo, evento.cierreMesa);
        }

        public void Eliminar(int id)
        {
            eventoDatos.Eliminar(id);
        }

        public List<Evento> SeleccionarTodos()
        {
            List<Evento> lista = new List<Evento>();
            DataSet ds = eventoDatos.SeleccionarTodos();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Evento e = new Evento();
                e.codigo = Convert.ToInt32(row["Id"]);
                e.nombre = row["Nombre"].ToString();
                e.fecha = row["FechaEvento"].ToString();
                e.cierreMesa = row["CierreMesa"].ToString();
                lista.Add(e);
            }
            return lista;
        }

        public Evento SeleccionarPorIdEvento(int id)
        {
            Evento e = new Evento();
            DataSet ds = eventoDatos.SeleccionarPorIdEvento(id);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                e.codigo = Convert.ToInt32(row["Id"]);
                e.nombre = row["Nombre"].ToString();
                e.fecha = row["FechaEvento"].ToString();
                e.cierreMesa = row["CierreMesa"].ToString();
            }
            return e;
        }

        public Boolean SeleccionarPorIdEventoMiembro(int idEvento, String idMiembro)
        {
            Boolean existe = false;
            DataSet ds = eventoDatos.SeleccionarPorIdEventoMiembro(idEvento, idMiembro);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                existe = true;
            }
            return existe;
        }
    }
}
