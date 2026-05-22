using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Votos
    { 
        public int VotoID { get; set; } 
        public int UsuarioID { get; set; } 
        public int PlanchaID { get; set; } 
        public int VotacionID { get; set; } 
        public DateTime FechaHora { get; set; } 
        public bool EsNulo {  get; set; }

    }
}
