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
    public class MiembroLogica
    {
        MiembroDatos miembroDatos = new MiembroDatos();

        public void Insertar(Miembro miembro)
        {
           miembroDatos.Insertar(miembro.Id, miembro.Nombre, miembro.Cedula, miembro.Estado1, miembro.Estado2, miembro.Correo, miembro.Telefono);
        }

        public void Modificar(Miembro miembro)
        {
            miembroDatos.Modificar(miembro.Id, miembro.Nombre, miembro.Cedula, miembro.Estado1, miembro.Estado2, miembro.Correo, miembro.Telefono);
        }

        public void Eliminar()
        {
            miembroDatos.Eliminar();
        }

        public List<Miembro> SeleccionarTodos()
        {
            List<Miembro> lista = new List<Miembro>();
            DataSet ds = miembroDatos.SeleccionarTodos();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Miembro m = new Miembro();
                m.Id = row["Id"].ToString();
                m.Nombre = row["Nombre"].ToString();
                m.Cedula = row["Cedula"].ToString();
                m.Estado1 = row["Estado1"].ToString();
                m.Estado2 = row["Estado2"].ToString();
                m.Correo = row["Correo"].ToString();
                m.Telefono = row["Telefono"].ToString();
                lista.Add(m);
            }
            return lista;
        }

        public List<Miembro> SeleccionarMiembrosPorEvento(int idEvento)
        {
            List<Miembro> lista = new List<Miembro>();
            DataSet ds = miembroDatos.SeleccionarMiembrosPorEvento(idEvento);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Miembro m = new Miembro();
                m.Cedula = row["Cedula"].ToString();
                m.Nombre = row["Nombre"].ToString();
                m.estadoAsistencia = row["Estado"].ToString();
                m.horaAsistencia = row["Hora"].ToString();
                m.usuarioAsistencia = row["Usuario"].ToString();
                lista.Add(m);
            }
            return lista;
        }

        public Miembro SeleccionarPorIdentificadorMiembro(String identificador)
        {
            Miembro m = new Miembro();
            DataSet ds = miembroDatos.SeleccionarPorIdentificadorMiembro(identificador);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                m.Id = row["Id"].ToString();
                m.Nombre = row["Nombre"].ToString();
                m.Cedula = row["Cedula"].ToString();
                m.Estado1 = row["Estado1"].ToString();
                m.Estado2 = row["Estado2"].ToString();
                m.Correo = row["Correo"].ToString();
                m.Telefono = row["Telefono"].ToString();
            }
            return m;
        }
    }
}
