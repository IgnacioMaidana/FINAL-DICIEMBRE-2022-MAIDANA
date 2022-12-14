using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Diciembre
{
    public class UserPremium : Usuario
    {
        
        public List<int> IngredientesFavoritos { get; set; }

        public List<int> RecetasFavoritas { get; set; }

        public List<string> UsuariosFavoritos { get; set; }

        public UserPremium(int numeroUnico, string nombre, string nickname, string contrasenia, bool premium) : base(numeroUnico, nombre, nickname, contrasenia, premium)
        {

        }
    }
}
