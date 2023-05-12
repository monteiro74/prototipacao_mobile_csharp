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
    public partial class FormB1 : Form
    {
        public FormB1()
        {
            InitializeComponent();
        }

        private void button_Voltar_FormB1_Click(object sender, EventArgs e)
        {
            /**
         ** Comentário: Fecha o formulário B
         **/

            this.Close();
        }
    }
}
