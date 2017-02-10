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
    }
}
