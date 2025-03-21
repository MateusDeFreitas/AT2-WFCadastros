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
    public partial class Cadastrar : Form
    {
        

        public Cadastrar()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.Text = "Tela de cadastro";
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Tela = new Form1();
            Tela.Show();
            this.Close();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (textCod.Text == "")
            {
                MessageBox.Show("O campo código não foi preenchido corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textNome.Text == "")
            {
                MessageBox.Show("O campo nome não foi preenchido corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textDescricao.Text == "")
            {
                MessageBox.Show("O campo descrição não foi preenchido corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textData.Text == "")
            {
                MessageBox.Show("O campo data não foi preenchido corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!radioAtivo.Checked && !radioInativo.Checked)
            {
                MessageBox.Show("O campo status não foi preenchido corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (radioAtivo.Checked)
                {
                    Dados.status.Add("Ativo");
                }
                else if (radioInativo.Checked)
                {
                    Dados.status.Add("Inativo");
                }

                Dados.codigos.Add(textCod.Text);
                Dados.nomes.Add(textNome.Text);
                Dados.descricoes.Add(textDescricao.Text);
                Dados.datas.Add(textData.Text);

                textCod.Text = "";
                textNome.Text = "";
                textDescricao.Text = "";
                textData.Text = "";
                radioAtivo.Checked = false;
                radioInativo.Checked = false;

                MessageBox.Show("Os dados foram cadastrados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listar Tela = new Listar();
            Tela.Show();
            this.Hide();
        }
    }
}
