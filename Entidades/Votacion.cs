using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Votacion
    {
        public int VotacionID { get; set; } 
        public string NombreVotacion { get; set; } 
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin {  get; set; }
        public bool Activa { get; set; } 
    }
}
