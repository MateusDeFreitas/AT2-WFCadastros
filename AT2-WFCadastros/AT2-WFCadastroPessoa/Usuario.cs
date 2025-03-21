using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT2_WFCadastroPessoa
{
    public class Usuario
    {
        public string codigo { get; set; }
        public string login { get; set; }
        public string senha { get; set; }

        public static List<Usuario> ListaUsuarios = new List<Usuario>();

        public static void AdicionarUsuario(Usuario usuario)
        {
            ListaUsuarios.Add(usuario);
        }

    }
}
