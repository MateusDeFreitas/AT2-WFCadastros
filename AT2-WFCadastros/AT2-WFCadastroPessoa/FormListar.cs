using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT2_WFCadastroPessoa
{
    public partial class FormListar : Form
    {
        public FormListar()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.Text = "Tela de Listagem";
        }

        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPrincipal Tela = new FormPrincipal();
            Tela.Show();
            this.Hide();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastrar Tela = new FormCadastrar();
            Tela.Show();
            this.Hide();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void FormListar_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            table.Columns.Add("Código", typeof(string));
            table.Columns.Add("Nome Completo", typeof(string));
            table.Columns.Add("CPF", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Tipo de Telefone", typeof(string));
            table.Columns.Add("DDD", typeof(string));
            table.Columns.Add("Celular", typeof(string));
            table.Columns.Add("Possui filhos", typeof(string));

            int cont = 0;
            string possuiFilhos = "";
            foreach (Pessoas pessoa in Pessoas.ListaPessoas)

            {
                if (Pessoas.ListaPessoas[cont].possuiFilhos)
                {
                    possuiFilhos = "Possui";
                }
                else
                {
                    possuiFilhos = "Não possui";
                }

                table.Rows.Add(
                    Pessoas.ListaPessoas[cont].codigo,
                    Pessoas.ListaPessoas[cont].nomeCompleto,
                    Pessoas.ListaPessoas[cont].cpf,
                    Pessoas.ListaPessoas[cont].email,
                    Pessoas.ListaPessoas[cont].tipoTelefone,
                    Pessoas.ListaPessoas[cont].ddd,
                    Pessoas.ListaPessoas[cont].celular,
                    possuiFilhos
                );
                cont++;
            }

            dataGridView1.DataSource = table;
        }
    }
}
