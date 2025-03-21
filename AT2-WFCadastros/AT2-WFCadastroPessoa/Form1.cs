namespace AT2_WFCadastroPessoa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.Text = "Tela de Login";

            Usuario usuario1 = new Usuario
            {
                codigo = "001",
                login = "admin",
                senha = "12345"
            };

            // Adicionando o usuário à lista estática
            Usuario.AdicionarUsuario(usuario1);
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            string loginInserido = textLogin.Text;
            string senhaInserida = textSenha.Text;
            bool loginAchado = false;

            int cont = 0;

            foreach (Usuario user in Usuario.ListaUsuarios)
            {
                if (Usuario.ListaUsuarios[cont].login == loginInserido)
                {
                    loginAchado = true;
                    if (Usuario.ListaUsuarios[cont].senha == senhaInserida)
                    {
                        FormPrincipal Tela = new FormPrincipal();
                        Tela.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta! Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (!loginAchado)
            {
                MessageBox.Show("Login incorreta! Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
