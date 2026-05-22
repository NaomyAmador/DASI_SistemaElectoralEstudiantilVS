using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Planchas
    {
        public int PlanchaID {  get; set; }
        public string NombrePlancha { get; set; }
        public byte[] Logo { get; set; }
        public string Descripcion { get; set; }
        public bool Activa { get; set; }

    }
}
