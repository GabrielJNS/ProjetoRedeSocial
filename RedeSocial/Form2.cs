using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedeSocial
{
    public partial class Tela_BoasVindas : Form
    {
        public Tela_BoasVindas()
        {
            
            InitializeComponent();
            bt_UsuarioLogado.Text = Login.nomes[Convert.ToInt32(Login.user)];
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
           


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bt_UsuarioLogado_Click(object sender, EventArgs e)
        {

        }
    }
}
