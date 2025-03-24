using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT2_WFCadastroPessoa
{
    public class Pessoas
    {
        public string codigo { get; set; }
        public string nomeCompleto { get; set; }
        public string cpf { get; set; }
        public string email { get; set; }
        public string tipoTelefone { get; set; }
        public string ddd { get; set; }
        public string celular { get; set; }
        public bool possuiFilhos { get; set; }

        public static List<Pessoas> ListaPessoas = new List<Pessoas>();

        public static void AdicionarPessoa(Pessoas pessoa)
        {
            ListaPessoas.Add(pessoa);
        }
    }
}
