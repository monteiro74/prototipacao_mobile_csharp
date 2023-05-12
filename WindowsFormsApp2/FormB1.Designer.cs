/**
*   Autor: Prof. Dr. Monteiro, Emiliano S.
*/

namespace WindowsFormsApp2
{
    partial class FormB1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormB1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button_Voltar_FormB1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(461, 807);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(21, 94);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(417, 491);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Url = new System.Uri("https://pt.wikipedia.org/", System.UriKind.Absolute);
            // 
            // button_Voltar_FormB1
            // 
            this.button_Voltar_FormB1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_Voltar_FormB1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Voltar_FormB1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Voltar_FormB1.Location = new System.Drawing.Point(21, 592);
            this.button_Voltar_FormB1.Margin = new System.Windows.Forms.Padding(4);
            this.button_Voltar_FormB1.Name = "button_Voltar_FormB1";
            this.button_Voltar_FormB1.Size = new System.Drawing.Size(411, 74);
            this.button_Voltar_FormB1.TabIndex = 4;
            this.button_Voltar_FormB1.Text = "Voltar";
            this.button_Voltar_FormB1.UseVisualStyleBackColor = false;
            this.button_Voltar_FormB1.Click += new System.EventHandler(this.button_Voltar_FormB1_Click);
            // 
            // FormB1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 807);
            this.Controls.Add(this.button_Voltar_FormB1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormB1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOpcaoB";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button_Voltar_FormB1;
    }
}