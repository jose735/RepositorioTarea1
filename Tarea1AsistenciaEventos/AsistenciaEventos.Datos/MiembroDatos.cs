using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaEventos.Datos
{
    public class MiembroDatos
    {
        public void Insertar(String id, String nombre, String cedula, String estado1, String estado2, String correo, String telefono)
        {
            Database db = DatabaseFactory.CreateDatabase("Default");
            SqlCommand comando = new SqlCommand("PA_Insertar_Miembro");
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id", id);
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Cedula", cedula);
            comando.Parameters.AddWithValue("@Estado1", estado1);
            comando.Parameters.AddWithValue("@Estado2", estado2);
            comando.Parameters.AddWithValue("@Correo", correo);
            comando.Parameters.AddWithValue("@Telefono", telefono);
            db.ExecuteNonQuery(comando);
        }

        public void Modificar(String id, String nombre, String cedula, String estado1, String estado2, String correo, String telefono)
        {
            Database db = DatabaseFactory.CreateDatabase("Default");

            SqlCommand comando = new SqlCommand("PA_Modificar_Miembro");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Id", id);
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Cedula", cedula);
            comando.Parameters.AddWithValue("@Estado1", estado1);
            comando.Parameters.AddWithValue("@Estado2", estado2);
            comando.Parameters.AddWithValue("@Correo", correo);
            comando.Parameters.AddWithValue("@Telefono", telefono);
            db.ExecuteNonQuery(comando);
        }

        public void Eliminar()
        {
            Database db = DatabaseFactory.CreateDatabase("Default");

            SqlCommand comando = new SqlCommand("PA_Eliminar_Miembro");
            comando.CommandType = CommandType.StoredProcedure;

            db.ExecuteNonQuery(comando);
        }

        public DataSet SeleccionarTodos()
        {
            Database db = DatabaseFactory.CreateDatabase("Default");

            SqlCommand comando = new SqlCommand("PA_Seleccionar_Todos_Miembro");
            // Es requerido indicar que el tipo es un StoreProcedure
            comando.CommandType = CommandType.StoredProcedure;

            DataSet ds = db.ExecuteReader(comando, "Miembro");
            return ds;
        }

        public DataSet SeleccionarPorIdentificadorMiembro(String identificador)
        {
            Database db = DatabaseFactory.CreateDatabase("Default");

            SqlCommand comando = new SqlCommand("PA_Seleccionar_Por_Identificador_Miembro");
            // Es requerido indicar que el tipo es un StoreProcedure
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Identificador", identificador);

            DataSet ds = db.ExecuteReader(comando, "Miembro");
            return ds;
        }

        public DataSet SeleccionarMiembrosPorEvento(int idEvento)
        {
            Database db = DatabaseFactory.CreateDatabase("Default");

            SqlCommand comando = new SqlCommand("PA_Seleccionar_Miembros_Por_Evento");
            // Es requerido indicar que el tipo es un StoreProcedure
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id", idEvento);

            DataSet ds = db.ExecuteReader(comando, "Miembro");
            return ds;
        }
    }
}
