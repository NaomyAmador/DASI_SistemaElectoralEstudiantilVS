using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios
    {
        public int UsuarioID {  get; set; }
        public string NombreCompleto { get; set; }
        public string Usuario {  get; set; }
        public string PasswordHash { get; set; }
        public string Correo {  get; set; }
        public String Matricula { get; set; }
        public string Curso { get; set; }
        public string Seccion { get; set; }
        public bool YaVoto { get; set; }
        public bool Activo { get; set; }
        public int RolID{ get; set; }
        public int PadronID { get; set; }




    }
}
