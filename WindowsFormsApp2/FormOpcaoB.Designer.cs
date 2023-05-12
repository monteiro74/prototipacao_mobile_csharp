namespace WindowsFormsApp2
{
    partial class FormOpcaoB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOpcaoB));
            this.pictureBox_androidBackground = new System.Windows.Forms.PictureBox();
            this.label_tituloFormB = new System.Windows.Forms.Label();
            this.button_Voltar_opcaoB = new System.Windows.Forms.Button();
            this.buttonFormB1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_androidBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_androidBackground
            // 
            this.pictureBox_androidBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_androidBackground.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_androidBackground.Image")));
            this.pictureBox_androidBackground.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_androidBackground.Name = "pictureBox_androidBackground";
            this.pictureBox_androidBackground.Size = new System.Drawing.Size(461, 807);
            this.pictureBox_androidBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_androidBackground.TabIndex = 0;
            this.pictureBox_androidBackground.TabStop = false;
            // 
            // label_tituloFormB
            // 
            this.label_tituloFormB.AutoSize = true;
            this.label_tituloFormB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tituloFormB.Location = new System.Drawing.Point(40, 111);
            this.label_tituloFormB.Name = "label_tituloFormB";
            this.label_tituloFormB.Size = new System.Drawing.Size(96, 25);
            this.label_tituloFormB.TabIndex = 1;
            this.label_tituloFormB.Text = "Opção B";
            // 
            // button_Voltar_opcaoB
            // 
            this.button_Voltar_opcaoB.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_Voltar_opcaoB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Voltar_opcaoB.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Voltar_opcaoB.Location = new System.Drawing.Point(23, 588);
            this.button_Voltar_opcaoB.Margin = new System.Windows.Forms.Padding(4);
            this.button_Voltar_opcaoB.Name = "button_Voltar_opcaoB";
            this.button_Voltar_opcaoB.Size = new System.Drawing.Size(411, 74);
            this.button_Voltar_opcaoB.TabIndex = 4;
            this.button_Voltar_opcaoB.Text = "Voltar";
            this.button_Voltar_opcaoB.UseVisualStyleBackColor = false;
            this.button_Voltar_opcaoB.Click += new System.EventHandler(this.Button_Voltar_opcaoB_Click);
            // 
            // buttonFormB1
            // 
            this.buttonFormB1.BackColor = System.Drawing.Color.PapayaWhip;
            this.buttonFormB1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFormB1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFormB1.Location = new System.Drawing.Point(23, 271);
            this.buttonFormB1.Name = "buttonFormB1";
            this.buttonFormB1.Size = new System.Drawing.Size(411, 74);
            this.buttonFormB1.TabIndex = 7;
            this.buttonFormB1.Text = "Sub formulário B1";
            this.buttonFormB1.UseVisualStyleBackColor = false;
            this.buttonFormB1.Click += new System.EventHandler(this.ButtonFormB1_Click);
            // 
            // FormOpcaoB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 807);
            this.Controls.Add(this.buttonFormB1);
            this.Controls.Add(this.button_Voltar_opcaoB);
            this.Controls.Add(this.label_tituloFormB);
            this.Controls.Add(this.pictureBox_androidBackground);
            this.Name = "FormOpcaoB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOpcaoB";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOpcaoB_FormClosing);
            this.Load += new System.EventHandler(this.FormOpcaoB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_androidBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_androidBackground;
        private System.Windows.Forms.Label label_tituloFormB;
        private System.Windows.Forms.Button button_Voltar_opcaoB;
        private System.Windows.Forms.Button buttonFormB1;
    }
}