using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT2_WFCadastros
{
    public partial class Listar : Form
    {
        public Listar()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Tela = new Form1();
            Tela.Show();
            this.Hide();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrar Tela = new Cadastrar();
            Tela.Show();
            this.Hide();
        }

        private void Listar_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            table.Columns.Add("id", typeof(string));
            table.Columns.Add("nome", typeof(string));
            table.Columns.Add("data", typeof(string));
            table.Columns.Add("descrição", typeof(string));
            table.Columns.Add("status", typeof(string));

            int cont = 0;
            foreach (string cod in Dados.codigos)
            {
                table.Rows.Add(Dados.codigos[cont], Dados.nomes[cont], Dados.datas[cont], Dados.descricoes[cont], Dados.status[cont]);
                cont++;
            }

            dataGridView1.DataSource = table;
        }
    }
}
