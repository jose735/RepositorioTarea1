using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaEventos.Entidades
{
    public class Evento
    {
        public int codigo { get; set; }
        public String nombre { get; set; }
        public String fecha { get; set; }
        public String cierreMesa { get; set; }
        public String horaAsistencia { get; set; }
        public String usuarioAsistencia { get; set; }
    }
}
