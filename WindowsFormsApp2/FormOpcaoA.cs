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
    public partial class FormOpcaoA : Form
    {
        public FormOpcaoA()
        {
            /// Comentário: Incializa os componentes do formulário de login
            InitializeComponent();
        }

        private void FormOpcaoA_FormClosing(object sender, FormClosingEventArgs e)
        {
            /**
            ** Comentário: Fecha a aplicação
            **/

           /// Application.Exit();
        }

        private void Button_Voltar_opcaoA_Click(object sender, EventArgs e)
        {
            /// Fecha o formulário A

            /**
            ** Comentário: Fecha o formulário A
            **/

            Close();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            /**
            ** Comentário: Exemplo de mensagem, acionada pelo botão Material Flat
            **/

            string message = "Exemplo de caixa de mensagem";
            string title = "Exemplo 2";
            MessageBox.Show(message, title);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            /**
            ** Comentário: Exemplo de mensagem, acionada pelo botão Material Raised
            **/

            string message = "Exemplo de caixa de mensagem";
            string title = "Exemplo 3";
            MessageBox.Show(message, title);
        }

        private void FormOpcaoA_Load(object sender, EventArgs e)
        {
          /**
          ** Comentário: Seta as dimensões do formulário
          */
            this.Height = 695;
            this.Width = 362;
        }
    }
}
