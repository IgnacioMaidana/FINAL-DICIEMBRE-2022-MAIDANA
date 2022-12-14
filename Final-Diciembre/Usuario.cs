using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Diciembre
{
    public class Usuario
    {
        public int NumeroUnico { get; set; }

        public string Nombre { get; set; }

        public string Nickname { get; set; }

        public string Contrasenia { get; set; }

        public bool EsPremium { get; set; }

        public Usuario(int numeroUnico, string nombre, string nickname, string contrasenia, bool premium)
        {
            NumeroUnico = numeroUnico;
            Nombre = nombre;
            Nickname = nickname;
            Contrasenia = contrasenia;
            EsPremium = premium;
        }

        public bool ValidarDatos(string nickname, string contrasenia)
        {
            if (this.Nickname == nickname && this.Contrasenia == contrasenia)            
                return true;

            return false;
        }

        
            
    }
}
