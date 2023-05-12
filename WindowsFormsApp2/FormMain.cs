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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            /// Comentário: Incializa os componentes do formulário de login
            InitializeComponent();
        }

        private void ButtonSair_main_Click(object sender, EventArgs e)
        {
            /// Comentário: Encerra a execução da aplicação
             System.Environment.Exit(0);
        }

        private void ButtonOpcaoA_Click(object sender, EventArgs e)
        {
            /// Comentário: Chama o formulário A
            FormOpcaoA formOpcaoA = new FormOpcaoA();
            formOpcaoA.Show();
        }

        private void ButtonOpcaoB_Click(object sender, EventArgs e)
        {
            /// Comentário: Chama o formulário B
            FormOpcaoB formOpcaoB = new FormOpcaoB();
            formOpcaoB.Show();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
           /**
           ** Comentário: Fecha a aplicação
           **/

            Application.Exit();
        }

        private void ButtonOpcaoC_Click(object sender, EventArgs e)
        {
            /// Inclua aqui o código para chamar outros formulários
            /// por exemplo um formulário C

            /**
            ** Comentário: Espaço para os códigos para o botão C
            **/

            MessageBox.Show("Teste !!");
        }

        private void ButtonOpcaoD_Click(object sender, EventArgs e)
        {
            /// Inclua aqui o código para chamar outros formulários
            /// por exemplo um formulário D

            /**
            ** Comentário: Espaço para os códigos para o botão D
            **/

            string message = "Exemplo de caixa de mensagem";
            string title = "Exemplo 1";
            MessageBox.Show(message, title);
        }

        private void ButtonSobre_main_Click(object sender, EventArgs e)
        {
            /**
            ** Comentário: Informações diversas sobre autoria e propósito deste app
            **/

            MessageBox.Show("Autor: Prof. Dr. Monteiro, Emiliano S. 1 \r\n" +
                            "Exemplo de protótipo para \r\n" +
                            "modelar, prototipar e testar \r\n" +
                            "app para dispositivos móveis\r\n" +
                            "desenvolvido com Windows Forms C# \r\n" +
                            "  \r\n" +
                            "A fonte da figura de fundo é: \r\n" +
                            "https://pixabay.com/pt/vectors/andr%c3%b3ide-nexus-5-telefone-1294370/" +
                            " \r\n"
                            , "Sobre...");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
           /**
           ** Comentário: Seta as dimensões do formulário
           */
            this.Height = 695;
            this.Width = 362;
        }
    }
}
