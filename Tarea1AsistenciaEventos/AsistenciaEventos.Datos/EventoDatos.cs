using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaEventos.Datos
{
    public class EventoDatos
    {
        public void Insertar(String nombre, String fecha, String cierre)
        {
            Database db = DatabaseFactory.CreateDatabase("Default");
            SqlCommand comando = new SqlCommand("PA_Insertar_Evento");
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Fecha", fecha);
            comando.Parameters.AddWithValue("@Cierre", cierre);
            db.ExecuteNonQuery(comando);
        }

        public void InsertarAsistencia(int idEvento, String idMiembro, String estadoAsistencia, String horaAsistencia, String usuarioAsistencia)
        {
            Database db = DatabaseFactory.CreateDatabase("Default");
            SqlCommand comando = new SqlCommand("PA_Insertar_EventoMiembro");
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdEvento", idEvento);
            comando.Parameters.AddWithValue("@IdMiembro", idMiembro);
            comando.Parameters.AddWithValue("@EstadoAsistencia", estadoAsistencia);
            comando.Parameters.AddWithValue("@HoraAsistencia", horaAsistencia);
            comando.Parameters.AddWithValue("@UsuarioAsistencia", usuarioAsistencia);
            db.ExecuteNonQuery(comando);
        }

        public void ModificarFecha(int id, String fecha)
        {
            Database db = DatabaseFactory.CreateDatabase("Default");

            SqlCommand comando = new SqlCommand("PA_Modificar_Evento_Fecha");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Id", id);
            comando.Parameters.AddWithValue("@Fecha", fecha);
            db.ExecuteNonQuery(comando);
        }

        public void ModificarCierre(int id, String cierre)
        {
            Database db = DatabaseFactory.CreateDatabase("Default");

            SqlCommand comando = new SqlCommand("PA_Modificar_Evento_Cierre");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Id", id);
            comando.Parameters.AddWithValue("@Cierre", cierre);
            db.ExecuteNonQuery(comando);
        }

        public void Eliminar(int id)
        {
            Database db = DatabaseFactory.CreateDatabase("Default");

            SqlCommand comando = new SqlCommand("PA_Eliminar_Evento");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Id", id);

            db.ExecuteNonQuery(comando);
        }

        public DataSet SeleccionarTodos()
        {
            Database db = DatabaseFactory.CreateDatabase("Default");

            SqlCommand comando = new SqlCommand("PA_Seleccionar_Todos_Eventos");
            // Es requerido indicar que el tipo es un StoreProcedure
            comando.CommandType = CommandType.StoredProcedure;

            DataSet ds = db.ExecuteReader(comando, "Evento");
            return ds;
        }

        public DataSet SeleccionarPorIdEvento(int id)
        {
            Database db = DatabaseFactory.CreateDatabase("Default");

            SqlCommand comando = new SqlCommand("PA_Seleccionar_Por_Id_Evento");
            // Es requerido indicar que el tipo es un StoreProcedure
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id", id);

            DataSet ds = db.ExecuteReader(comando, "Evento");
            return ds;
        }

        public DataSet SeleccionarPorIdEventoMiembro(int idEvento, String idMiembro)
        {
            Database db = DatabaseFactory.CreateDatabase("Default");

            SqlCommand comando = new SqlCommand("PA_Seleccionar_Por_Id_EventoMiembro");
            // Es requerido indicar que el tipo es un StoreProcedure
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdEvento", idEvento);
            comando.Parameters.AddWithValue("@IdMiembro", idMiembro);

            DataSet ds = db.ExecuteReader(comando, "EventoMiembro");
            return ds;
        }
    }
}
