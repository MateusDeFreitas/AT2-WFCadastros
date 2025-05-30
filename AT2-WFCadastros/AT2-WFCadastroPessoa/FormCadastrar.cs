﻿using System;
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
    public partial class FormCadastrar : Form
    {
        public FormCadastrar()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.Text = "Tela de Cadastro";
            textTelefone.PlaceholderText = "(__) _____-____";
        }

        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPrincipal Tela = new FormPrincipal();
            Tela.Show();
            this.Hide();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListar Tela = new FormListar();
            Tela.Show();
            this.Hide();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            FormPrincipal Tela = new FormPrincipal();
            Tela.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textCod.Text == "")
            {
                MessageBox.Show("Por favor, preencha o campo código corretamente.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textNome.Text == "")
            {
                MessageBox.Show("Por favor, preencha o campo nome corretamente.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textCPF.Text == "")
            {
                MessageBox.Show("Por favor, preencha o campo CPF corretamente.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textEmail.Text == "")
            {
                MessageBox.Show("Por favor, preencha o campo email corretamente.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textTelefone.Text == "")
            {
                MessageBox.Show("Por favor, preencha o campo telefone corretamente.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!radioComercial.Checked && !radioPessoal.Checked && !radioRecado.Checked)
            {
                MessageBox.Show("Por favor, preencha o campo tipo de telefone corretamente.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string opcaoRadio = "";

                if (radioComercial.Checked)
                {
                    opcaoRadio = "Comercial";
                }
                else if(radioPessoal.Checked)
                {
                    opcaoRadio = "Pessoal";
                }
                else if (radioRecado.Checked)
                {
                    opcaoRadio = "Recado";
                }

                    Pessoas pessoa1 = new Pessoas
                    {
                        codigo = textCod.Text,
                        nomeCompleto = textNome.Text,
                        cpf = textCPF.Text,
                        email = textEmail.Text,
                        tipoTelefone = textTelefone.Text.Substring(1, 2),
                        ddd = textTelefone.Text.Substring(5),
                        celular = textTelefone.Text,
                        possuiFilhos = checkBoxFilhos.Checked
                    };

                Pessoas.AdicionarPessoa(pessoa1);

                textCod.Text = "";
                textNome.Text = "";
                textCPF.Text = "";
                textEmail.Text = "";
                textTelefone.Text = "";

                checkBoxFilhos.Checked = false;

                radioPessoal.Checked = false;
                radioComercial.Checked = false;
                radioRecado.Checked = false;

                MessageBox.Show("O registro foi criado cm sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
