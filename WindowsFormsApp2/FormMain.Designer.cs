/**
*   Autor: Prof. Dr. Monteiro, Emiliano S.
*/
namespace WindowsFormsApp2
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonOpcaoA = new System.Windows.Forms.Button();
            this.buttonOpcaoC = new System.Windows.Forms.Button();
            this.buttonSair_main = new System.Windows.Forms.Button();
            this.pictureBox_androidBackground = new System.Windows.Forms.PictureBox();
            this.buttonOpcaoD = new System.Windows.Forms.Button();
            this.buttonOpcaoB = new System.Windows.Forms.Button();
            this.buttonSobre_main = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_androidBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpcaoA
            // 
            this.buttonOpcaoA.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonOpcaoA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpcaoA.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpcaoA.Location = new System.Drawing.Point(23, 106);
            this.buttonOpcaoA.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpcaoA.Name = "buttonOpcaoA";
            this.buttonOpcaoA.Size = new System.Drawing.Size(411, 74);
            this.buttonOpcaoA.TabIndex = 0;
            this.buttonOpcaoA.Text = "Opção A";
            this.buttonOpcaoA.UseVisualStyleBackColor = false;
            this.buttonOpcaoA.Click += new System.EventHandler(this.ButtonOpcaoA_Click);
            // 
            // buttonOpcaoC
            // 
            this.buttonOpcaoC.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonOpcaoC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpcaoC.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpcaoC.Location = new System.Drawing.Point(23, 277);
            this.buttonOpcaoC.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpcaoC.Name = "buttonOpcaoC";
            this.buttonOpcaoC.Size = new System.Drawing.Size(411, 74);
            this.buttonOpcaoC.TabIndex = 1;
            this.buttonOpcaoC.Text = "Opção C";
            this.buttonOpcaoC.UseVisualStyleBackColor = false;
            this.buttonOpcaoC.Click += new System.EventHandler(this.ButtonOpcaoC_Click);
            // 
            // buttonSair_main
            // 
            this.buttonSair_main.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSair_main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair_main.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair_main.Location = new System.Drawing.Point(23, 586);
            this.buttonSair_main.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSair_main.Name = "buttonSair_main";
            this.buttonSair_main.Size = new System.Drawing.Size(411, 74);
            this.buttonSair_main.TabIndex = 2;
            this.buttonSair_main.Text = "Sair";
            this.buttonSair_main.UseVisualStyleBackColor = false;
            this.buttonSair_main.Click += new System.EventHandler(this.ButtonSair_main_Click);
            // 
            // pictureBox_androidBackground
            // 
            this.pictureBox_androidBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_androidBackground.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_androidBackground.Image")));
            this.pictureBox_androidBackground.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_androidBackground.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_androidBackground.Name = "pictureBox_androidBackground";
            this.pictureBox_androidBackground.Size = new System.Drawing.Size(461, 807);
            this.pictureBox_androidBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_androidBackground.TabIndex = 3;
            this.pictureBox_androidBackground.TabStop = false;
            // 
            // buttonOpcaoD
            // 
            this.buttonOpcaoD.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonOpcaoD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpcaoD.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpcaoD.Location = new System.Drawing.Point(23, 358);
            this.buttonOpcaoD.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpcaoD.Name = "buttonOpcaoD";
            this.buttonOpcaoD.Size = new System.Drawing.Size(411, 74);
            this.buttonOpcaoD.TabIndex = 4;
            this.buttonOpcaoD.Text = "Opção D";
            this.buttonOpcaoD.UseVisualStyleBackColor = false;
            this.buttonOpcaoD.Click += new System.EventHandler(this.ButtonOpcaoD_Click);
            // 
            // buttonOpcaoB
            // 
            this.buttonOpcaoB.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonOpcaoB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpcaoB.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpcaoB.Location = new System.Drawing.Point(23, 188);
            this.buttonOpcaoB.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpcaoB.Name = "buttonOpcaoB";
            this.buttonOpcaoB.Size = new System.Drawing.Size(411, 81);
            this.buttonOpcaoB.TabIndex = 5;
            this.buttonOpcaoB.Text = "Opção B";
            this.buttonOpcaoB.UseVisualStyleBackColor = false;
            this.buttonOpcaoB.Click += new System.EventHandler(this.ButtonOpcaoB_Click);
            // 
            // buttonSobre_main
            // 
            this.buttonSobre_main.BackColor = System.Drawing.Color.PapayaWhip;
            this.buttonSobre_main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSobre_main.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSobre_main.Location = new System.Drawing.Point(23, 467);
            this.buttonSobre_main.Name = "buttonSobre_main";
            this.buttonSobre_main.Size = new System.Drawing.Size(411, 74);
            this.buttonSobre_main.TabIndex = 6;
            this.buttonSobre_main.Text = "Sobre...";
            this.buttonSobre_main.UseVisualStyleBackColor = false;
            this.buttonSobre_main.Click += new System.EventHandler(this.ButtonSobre_main_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(461, 807);
            this.Controls.Add(this.buttonSobre_main);
            this.Controls.Add(this.buttonOpcaoB);
            this.Controls.Add(this.buttonOpcaoD);
            this.Controls.Add(this.buttonSair_main);
            this.Controls.Add(this.buttonOpcaoC);
            this.Controls.Add(this.buttonOpcaoA);
            this.Controls.Add(this.pictureBox_androidBackground);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App Nota Avulsa - [Menu]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_androidBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpcaoA;
        private System.Windows.Forms.Button buttonOpcaoC;
        private System.Windows.Forms.Button buttonSair_main;
        private System.Windows.Forms.PictureBox pictureBox_androidBackground;
        private System.Windows.Forms.Button buttonOpcaoD;
        private System.Windows.Forms.Button buttonOpcaoB;
        private System.Windows.Forms.Button buttonSobre_main;
    }
}