using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Diciembre
{
    public abstract class Receta
    {
        public List<Ingrediente> ListadoIngredientes { get; set; }

        public string Nombre { get; set; }

        public int Codigo { get; set; }

        public DateTime FechaEliminacion { get; set; }

        public string Autor { get; set; }

        public abstract string GenerarMensaje();
    }
}
