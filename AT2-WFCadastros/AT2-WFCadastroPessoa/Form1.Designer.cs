namespace AT2_WFCadastroPessoa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelLogin = new Label();
            textLogin = new TextBox();
            textSenha = new TextBox();
            label1 = new Label();
            buttonEntrar = new Button();
            SuspendLayout();
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 12F);
            labelLogin.Location = new Point(357, 79);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(49, 21);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "Login";
            // 
            // textLogin
            // 
            textLogin.Font = new Font("Segoe UI", 12F);
            textLogin.Location = new Point(295, 115);
            textLogin.Name = "textLogin";
            textLogin.Size = new Size(186, 29);
            textLogin.TabIndex = 1;
            // 
            // textSenha
            // 
            textSenha.Font = new Font("Segoe UI", 12F);
            textSenha.Location = new Point(295, 210);
            textSenha.Name = "textSenha";
            textSenha.Size = new Size(186, 29);
            textSenha.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(357, 174);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 2;
            label1.Text = "Senha";
            // 
            // buttonEntrar
            // 
            buttonEntrar.Location = new Point(328, 285);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new Size(124, 28);
            buttonEntrar.TabIndex = 4;
            buttonEntrar.Text = "Entrar";
            buttonEntrar.UseVisualStyleBackColor = true;
            buttonEntrar.Click += buttonEntrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonEntrar);
            Controls.Add(textSenha);
            Controls.Add(label1);
            Controls.Add(textLogin);
            Controls.Add(labelLogin);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLogin;
        private TextBox textLogin;
        private TextBox textSenha;
        private Label label1;
        private Button buttonEntrar;
    }
}
