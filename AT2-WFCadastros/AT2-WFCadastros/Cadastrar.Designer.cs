namespace AT2_WFCadastros
{
    partial class Cadastrar
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
            menuStrip1 = new MenuStrip();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            listarToolStripMenuItem = new ToolStripMenuItem();
            textCod = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textNome = new TextBox();
            label3 = new Label();
            textData = new TextBox();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            radioInativo = new RadioButton();
            radioAtivo = new RadioButton();
            buttonCadastrar = new Button();
            textDescricao = new RichTextBox();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem, listarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(50, 20);
            cadastrarToolStripMenuItem.Text = "Menu";
            cadastrarToolStripMenuItem.Click += cadastrarToolStripMenuItem_Click;
            // 
            // listarToolStripMenuItem
            // 
            listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            listarToolStripMenuItem.Size = new Size(47, 20);
            listarToolStripMenuItem.Text = "Listar";
            listarToolStripMenuItem.Click += listarToolStripMenuItem_Click;
            // 
            // textCod
            // 
            textCod.Location = new Point(193, 92);
            textCod.Name = "textCod";
            textCod.Size = new Size(156, 23);
            textCod.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(59, 90);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 3;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(59, 140);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 5;
            label2.Text = "Nome";
            // 
            // textNome
            // 
            textNome.Location = new Point(193, 142);
            textNome.Name = "textNome";
            textNome.Size = new Size(156, 23);
            textNome.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(59, 192);
            label3.Name = "label3";
            label3.Size = new Size(124, 21);
            label3.TabIndex = 9;
            label3.Text = "data de cadastro";
            // 
            // textData
            // 
            textData.Location = new Point(193, 194);
            textData.Name = "textData";
            textData.Size = new Size(156, 23);
            textData.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(398, 90);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 7;
            label4.Text = "Descrição";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(59, 285);
            label5.Name = "label5";
            label5.Size = new Size(0, 21);
            label5.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioInativo);
            groupBox1.Controls.Add(radioAtivo);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(65, 285);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(284, 100);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Status";
            // 
            // radioInativo
            // 
            radioInativo.AutoSize = true;
            radioInativo.Location = new Point(158, 44);
            radioInativo.Name = "radioInativo";
            radioInativo.Size = new Size(75, 25);
            radioInativo.TabIndex = 1;
            radioInativo.TabStop = true;
            radioInativo.Text = "Inativo";
            radioInativo.UseVisualStyleBackColor = true;
            // 
            // radioAtivo
            // 
            radioAtivo.AutoSize = true;
            radioAtivo.Location = new Point(16, 44);
            radioAtivo.Name = "radioAtivo";
            radioAtivo.Size = new Size(64, 25);
            radioAtivo.TabIndex = 0;
            radioAtivo.TabStop = true;
            radioAtivo.Text = "Ativo";
            radioAtivo.UseVisualStyleBackColor = true;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(364, 406);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(105, 32);
            buttonCadastrar.TabIndex = 13;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // textDescricao
            // 
            textDescricao.Location = new Point(398, 140);
            textDescricao.Name = "textDescricao";
            textDescricao.Size = new Size(343, 148);
            textDescricao.TabIndex = 14;
            textDescricao.Text = "";
            // 
            // Cadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textDescricao);
            Controls.Add(buttonCadastrar);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(textData);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(textNome);
            Controls.Add(label1);
            Controls.Add(textCod);
            Controls.Add(menuStrip1);
            Name = "Cadastrar";
            Text = "Cadastrar";
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
        private ToolStripMenuItem listarToolStripMenuItem;
        private TextBox textCod;
        private Label label1;
        private Label label2;
        private TextBox textNome;
        private Label label3;
        private TextBox textData;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private RadioButton radioAtivo;
        private RadioButton radioInativo;
        private Button buttonCadastrar;
        private RichTextBox textDescricao;
    }
}