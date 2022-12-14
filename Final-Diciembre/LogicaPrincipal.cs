using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Diciembre
{
    public class LogicaPrincipal
    {
        
        public List<Especias> listaEspecias = new List<Especias>();
        public List<Liquidos> listaLiquidos = new List<Liquidos>();
        public List<Bebidas> listaBebidas = new List<Bebidas>();
        public List<Solidos> listaSolidos = new List<Solidos>();

        public List<Usuario> ListaUsuarios = new List<Usuario>();
        public List<UserPremium> ListaPremium = new List<UserPremium>();
        public void CargarUsuario(string nombre, string nickname, string contrasenia, bool premium)
        {
            if (premium)
            {
                UserPremium usuario = new UserPremium(ListaUsuarios.Count, nombre, nickname, contrasenia, premium);
                ListaPremium.Add(usuario);
            }
            else
            {
                Usuario usuario = new Usuario(ListaUsuarios.Count, nombre, nickname, contrasenia, premium);
                ListaUsuarios.Add(usuario);
            }
        }

        public void CargarUsuario(string nickname, string contrasenia, int nroReceta)
        {
            foreach (UserPremium usuario in ListaPremium)
            {
                if (usuario.ValidarDatos(nickname,contrasenia))
                {
                    usuario.RecetasFavoritas.Add(nroReceta);
                }
            }
        }
        public void CargarUsuario(string nickname, string contrasenia, string usuarioFav)
        {
            foreach (UserPremium usuario in ListaPremium)
            {
                if (usuario.ValidarDatos(nickname, contrasenia))
                {
                    usuario.UsuariosFavoritos.Add(usuarioFav);
                }
            }
        }

        public List<string> DescripcionesIngredientes()
        {
            List<Ingrediente> ListaIngredientes = new List<Ingrediente>();
            ListaIngredientes.AddRange(listaEspecias);
            ListaIngredientes.AddRange(listaLiquidos);
            ListaIngredientes.AddRange(listaBebidas);
            ListaIngredientes.AddRange(listaSolidos);

            List<string> Listado = new List<string>();
            foreach (Ingrediente item in ListaIngredientes)
            {
                Listado.Add(item.DevolverDescripcion());
            }

            return Listado;
        }
    }
}
