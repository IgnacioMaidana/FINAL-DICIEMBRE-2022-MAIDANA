using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Diciembre
{
    public class RPostre : Receta
    {
        public override string GenerarMensaje()
        {
            return $"{this.Nombre} - {this.Autor}";
        }
    }
}
