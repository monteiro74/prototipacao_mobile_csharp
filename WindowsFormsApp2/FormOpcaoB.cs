/**
*   Autor: Prof. Dr. Monteiro, Emiliano S.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormOpcaoB : Form
    {
        public FormOpcaoB()
        {
            /// Comentário: Incializa os componentes do formulário de login
            InitializeComponent();
        }

        private void FormOpcaoB_FormClosing(object sender, FormClosingEventArgs e)
        {
           /**
           ** Comentário: Fecha a aplicação
           **/

           /// Application.Exit();
        }

        private void Button_Voltar_opcaoB_Click(object sender, EventArgs e)
        {
            /// Fecha o formulário A

           /**
           ** Comentário: Fecha o formulário B
           **/

           this.Close();
        }

        private void ButtonFormB1_Click(object sender, EventArgs e)
        {
            /// Comentário: Chama o formulário A
            FormB1 formB1 = new FormB1();
            formB1.Show();
        }

        private void FormOpcaoB_Load(object sender, EventArgs e)
        {
          /**
          ** Comentário: Seta as dimensões do formulário
          */
            this.Height = 695;
            this.Width = 362;
        }
    }
}
