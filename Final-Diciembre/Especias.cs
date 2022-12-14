using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Diciembre
{
    public class Especias : Ingrediente
    {
        public Paises PaisOrigen { get; set; }

        public Sabores Sabor { get; set; }

        public decimal Gramos { get; set; }

        public override string DevolverDescripcion()
        {
            throw new NotImplementedException();
        }
    }
}
