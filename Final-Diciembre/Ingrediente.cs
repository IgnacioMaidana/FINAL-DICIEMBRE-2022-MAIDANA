using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Diciembre
{
    public abstract class Ingrediente
    {
        public int Codigo { get; set; }

        public string Nombre { get; set; }

        public abstract string DevolverDescripcion();
    }
}
