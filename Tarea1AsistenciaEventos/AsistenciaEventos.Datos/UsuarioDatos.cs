using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaEventos.Datos
{
    public class UsuarioDatos
    {
        public DataSet SeleccionarTodos(String nombre, String contrasenna)
        {
            Database db = DatabaseFactory.CreateDatabase("Default");

            SqlCommand comando = new SqlCommand("PA_Seleccionar_Usuario");
            // Es requerido indicar que el tipo es un StoreProcedure
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@NombreUsuario", nombre);
            comando.Parameters.AddWithValue("@Contrasenna", contrasenna);

            DataSet ds = db.ExecuteReader(comando, "Usuario");
            return ds;
        }
    }
}
