using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsistenciaEventos.Datos;
using AsistenciaEventos.Entidades;

namespace AsistenciaEventos.Logica
{
    public class UsuarioLogica
    {
        UsuarioDatos usuarioDatos = new UsuarioDatos();
        public List<Usuario> SeleccionarTodos(String nombre, String contrasenna)
        {
            List<Usuario> lista = new List<Usuario>();
            DataSet ds = usuarioDatos.SeleccionarTodos(nombre, contrasenna);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Usuario u = new  Usuario();
                u.nombreUsuario = row["NombreUsuario"].ToString();
                u.contrasenna = row["Contrasenna"].ToString();
                lista.Add(u);
            }
            return lista;
        }
    }
}
