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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            /// Comentário: Incializa os componentes do formulário de login
            InitializeComponent();
        }


        public static int Sum(int num1, int num2)
        {
            /**
            * Comentário: Exemplo de função de soma
            */

            int total;
            total = num1 + num2;
            return total;
        }


        private void ButtonSair_loging_Click(object sender, EventArgs e)
        {   
            /**
            ** Comentário: Quando este botão é clicado, executa a saída da aplicação
            */

            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {      
            /**
            ** Comentário: Coloca o foco da aplicação do campo textBox1 
            ** e seta as dimensões do formulário
            */

            textBox_userName.Focus();

            this.Height = 695;
            this.Width = 362;
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            //  Exemplo de comentário 1

            /// Comentário: Exemplo de comentário 2, este exemplo é visto pelo doxygen!

            /*  Exemplo de comentário 3  */

            /**
            *   Comentário: Exemplo de comentário 4, este exemplo é visto pelo doxygen !
            */

            FormMain formMain = new FormMain();
            formMain.Show();
            this.Hide();
        }


        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            /**
            ** Comentário: Encerra a execução da aplicação
            **/

            Application.Exit();
        }
    }
}
