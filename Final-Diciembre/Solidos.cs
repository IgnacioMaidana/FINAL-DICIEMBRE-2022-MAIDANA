using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Diciembre
{
    public class Solidos : Ingrediente
    {
        public decimal CantidadGr { get; set; }

        public override string DevolverDescripcion()
        {
            throw new NotImplementedException();
        }
    }
}
