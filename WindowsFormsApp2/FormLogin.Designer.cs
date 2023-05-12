namespace WindowsFormsApp2
{
    partial class FormLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pictureBox_androidBackground = new System.Windows.Forms.PictureBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonSair_loging = new System.Windows.Forms.Button();
            this.label_nome = new System.Windows.Forms.Label();
            this.label_senha = new System.Windows.Forms.Label();
            this.textBox_userName = new System.Windows.Forms.TextBox();
            this.textBox_senha = new System.Windows.Forms.TextBox();
            this.label_titulo = new System.Windows.Forms.Label();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.label_descricao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_androidBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_androidBackground
            // 
            this.pictureBox_androidBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_androidBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_androidBackground.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_androidBackground.Image")));
            this.pictureBox_androidBackground.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_androidBackground.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_androidBackground.Name = "pictureBox_androidBackground";
            this.pictureBox_androidBackground.Size = new System.Drawing.Size(461, 807);
            this.pictureBox_androidBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_androidBackground.TabIndex = 0;
            this.pictureBox_androidBackground.TabStop = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(31, 487);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(399, 81);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // buttonSair_loging
            // 
            this.buttonSair_loging.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSair_loging.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair_loging.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair_loging.Location = new System.Drawing.Point(31, 574);
            this.buttonSair_loging.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSair_loging.Name = "buttonSair_loging";
            this.buttonSair_loging.Size = new System.Drawing.Size(399, 81);
            this.buttonSair_loging.TabIndex = 2;
            this.buttonSair_loging.Text = "Sair";
            this.buttonSair_loging.UseVisualStyleBackColor = false;
            this.buttonSair_loging.Click += new System.EventHandler(this.ButtonSair_loging_Click);
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nome.ForeColor = System.Drawing.Color.DarkBlue;
            this.label_nome.Location = new System.Drawing.Point(196, 271);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(66, 24);
            this.label_nome.TabIndex = 3;
            this.label_nome.Text = "Nome";
            // 
            // label_senha
            // 
            this.label_senha.AutoSize = true;
            this.label_senha.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_senha.ForeColor = System.Drawing.Color.DarkBlue;
            this.label_senha.Location = new System.Drawing.Point(196, 345);
            this.label_senha.Name = "label_senha";
            this.label_senha.Size = new System.Drawing.Size(70, 24);
            this.label_senha.TabIndex = 4;
            this.label_senha.Text = "Senha";
            // 
            // textBox_userName
            // 
            this.textBox_userName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_userName.Location = new System.Drawing.Point(31, 297);
            this.textBox_userName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_userName.Name = "textBox_userName";
            this.textBox_userName.Size = new System.Drawing.Size(397, 32);
            this.textBox_userName.TabIndex = 5;
            this.textBox_userName.Text = "john doe";
            this.textBox_userName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_senha
            // 
            this.textBox_senha.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_senha.Location = new System.Drawing.Point(31, 370);
            this.textBox_senha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_senha.Name = "textBox_senha";
            this.textBox_senha.Size = new System.Drawing.Size(397, 32);
            this.textBox_senha.TabIndex = 6;
            this.textBox_senha.Text = "******";
            this.textBox_senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Roboto Bk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(172, 106);
            this.label_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(151, 24);
            this.label_titulo.TabIndex = 7;
            this.label_titulo.Text = "Sistema para....";
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.Image")));
            this.pictureBox_logo.Location = new System.Drawing.Point(31, 106);
            this.pictureBox_logo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(133, 123);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_logo.TabIndex = 8;
            this.pictureBox_logo.TabStop = false;
            // 
            // label_descricao
            // 
            this.label_descricao.AutoSize = true;
            this.label_descricao.Location = new System.Drawing.Point(180, 149);
            this.label_descricao.Name = "label_descricao";
            this.label_descricao.Size = new System.Drawing.Size(240, 16);
            this.label_descricao.TabIndex = 9;
            this.label_descricao.Text = "Prototipação de navegação entre telas";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(461, 807);
            this.Controls.Add(this.label_descricao);
            this.Controls.Add(this.pictureBox_logo);
            this.Controls.Add(this.label_titulo);
            this.Controls.Add(this.textBox_senha);
            this.Controls.Add(this.textBox_userName);
            this.Controls.Add(this.label_senha);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.buttonSair_loging);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.pictureBox_androidBackground);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulação de app - [Login]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_androidBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_androidBackground;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonSair_loging;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.Label label_senha;
        private System.Windows.Forms.TextBox textBox_userName;
        private System.Windows.Forms.TextBox textBox_senha;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Label label_descricao;
    }
}

