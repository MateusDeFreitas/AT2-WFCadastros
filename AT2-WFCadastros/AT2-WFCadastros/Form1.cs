namespace AT2_WFCadastros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Tela principal";
            this.MaximizeBox = false;  
            this.MinimizeBox = false;  
            this.FormBorderStyle = FormBorderStyle.FixedSingle; 
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrar Tela = new Cadastrar();
            Tela.Show();
            this.Hide();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listar Tela = new Listar();
            Tela.Show();
            this.Hide();
        }
    }
}
