using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AuditoriaAcciones
    {
        public int AuditoriaID { get; set; }
        public int UsuarioID { get; set; }
        public string Accion {  get; set; }
        public DateTime FechaHora { get; set; }
        public string Detalle {  get; set; } 
    }
}
