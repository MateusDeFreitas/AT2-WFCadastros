namespace AT2_WFCadastroPessoa
{
    partial class FormCadastrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastrar));
            menuStrip1 = new MenuStrip();
            principalToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            textCod = new TextBox();
            textCPF = new TextBox();
            label2 = new Label();
            textEmail = new TextBox();
            label3 = new Label();
            textNome = new TextBox();
            label4 = new Label();
            textTelefone = new TextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            radioRecado = new RadioButton();
            radioComercial = new RadioButton();
            radioPessoal = new RadioButton();
            checkBoxFilhos = new CheckBox();
            buttonVoltar = new Button();
            button2 = new Button();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { principalToolStripMenuItem, cadastrarToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // principalToolStripMenuItem
            // 
            principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            principalToolStripMenuItem.Size = new Size(65, 20);
            principalToolStripMenuItem.Text = "Principal";
            principalToolStripMenuItem.Click += principalToolStripMenuItem_Click;
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(47, 20);
            cadastrarToolStripMenuItem.Text = "Listar";
            cadastrarToolStripMenuItem.Click += cadastrarToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 81);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 2;
            label1.Text = "Código";
            // 
            // textCod
            // 
            textCod.Location = new Point(78, 83);
            textCod.Name = "textCod";
            textCod.Size = new Size(128, 23);
            textCod.TabIndex = 3;
            // 
            // textCPF
            // 
            textCPF.Location = new Point(312, 85);
            textCPF.Name = "textCPF";
            textCPF.Size = new Size(128, 23);
            textCPF.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(246, 85);
            label2.Name = "label2";
            label2.Size = new Size(37, 21);
            label2.TabIndex = 4;
            label2.Text = "CPF";
            // 
            // textEmail
            // 
            textEmail.Location = new Point(140, 172);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(300, 23);
            textEmail.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 172);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 8;
            label3.Text = "Email";
            // 
            // textNome
            // 
            textNome.Location = new Point(140, 129);
            textNome.Name = "textNome";
            textNome.Size = new Size(300, 23);
            textNome.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(12, 127);
            label4.Name = "label4";
            label4.Size = new Size(122, 21);
            label4.TabIndex = 6;
            label4.Text = "Nome completo";
            // 
            // textTelefone
            // 
            textTelefone.Location = new Point(140, 218);
            textTelefone.Name = "textTelefone";
            textTelefone.Size = new Size(128, 23);
            textTelefone.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(12, 216);
            label5.Name = "label5";
            label5.Size = new Size(98, 21);
            label5.TabIndex = 10;
            label5.Text = "DDD/Celular";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioRecado);
            groupBox1.Controls.Add(radioComercial);
            groupBox1.Controls.Add(radioPessoal);
            groupBox1.Location = new Point(12, 266);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(256, 123);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo de telefone";
            // 
            // radioRecado
            // 
            radioRecado.AutoSize = true;
            radioRecado.Location = new Point(19, 86);
            radioRecado.Name = "radioRecado";
            radioRecado.Size = new Size(64, 19);
            radioRecado.TabIndex = 2;
            radioRecado.TabStop = true;
            radioRecado.Text = "Recado";
            radioRecado.UseVisualStyleBackColor = true;
            // 
            // radioComercial
            // 
            radioComercial.AutoSize = true;
            radioComercial.Location = new Point(20, 61);
            radioComercial.Name = "radioComercial";
            radioComercial.Size = new Size(79, 19);
            radioComercial.TabIndex = 1;
            radioComercial.TabStop = true;
            radioComercial.Text = "Comercial";
            radioComercial.UseVisualStyleBackColor = true;
            // 
            // radioPessoal
            // 
            radioPessoal.AutoSize = true;
            radioPessoal.Location = new Point(20, 36);
            radioPessoal.Name = "radioPessoal";
            radioPessoal.Size = new Size(64, 19);
            radioPessoal.TabIndex = 0;
            radioPessoal.TabStop = true;
            radioPessoal.Text = "Pessoal";
            radioPessoal.UseVisualStyleBackColor = true;
            // 
            // checkBoxFilhos
            // 
            checkBoxFilhos.AutoSize = true;
            checkBoxFilhos.Location = new Point(293, 220);
            checkBoxFilhos.Name = "checkBoxFilhos";
            checkBoxFilhos.Size = new Size(97, 19);
            checkBoxFilhos.TabIndex = 13;
            checkBoxFilhos.Text = "Possui filhos?";
            checkBoxFilhos.UseVisualStyleBackColor = true;
            // 
            // buttonVoltar
            // 
            buttonVoltar.Image = (Image)resources.GetObject("buttonVoltar.Image");
            buttonVoltar.Location = new Point(483, 377);
            buttonVoltar.Name = "buttonVoltar";
            buttonVoltar.Size = new Size(104, 46);
            buttonVoltar.TabIndex = 14;
            buttonVoltar.Text = "Voltar";
            buttonVoltar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonVoltar.UseVisualStyleBackColor = true;
            buttonVoltar.Click += buttonVoltar_Click;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(615, 377);
            button2.Name = "button2";
            button2.Size = new Size(104, 46);
            button2.TabIndex = 15;
            button2.Text = "Cadastrar";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(buttonVoltar);
            Controls.Add(checkBoxFilhos);
            Controls.Add(groupBox1);
            Controls.Add(textTelefone);
            Controls.Add(label5);
            Controls.Add(textEmail);
            Controls.Add(label3);
            Controls.Add(textNome);
            Controls.Add(label4);
            Controls.Add(textCPF);
            Controls.Add(label2);
            Controls.Add(textCod);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "FormCadastrar";
            Text = "FormCadastrar";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem principalToolStripMenuItem;
        private Label label1;
        private TextBox textCod;
        private TextBox textCPF;
        private Label label2;
        private TextBox textEmail;
        private Label label3;
        private TextBox textNome;
        private Label label4;
        private TextBox textTelefone;
        private Label label5;
        private GroupBox groupBox1;
        private RadioButton radioRecado;
        private RadioButton radioComercial;
        private RadioButton radioPessoal;
        private CheckBox checkBoxFilhos;
        private Button buttonVoltar;
        private Button button2;
    }
}