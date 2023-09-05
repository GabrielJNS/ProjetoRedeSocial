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
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = Login.nomes[2];
            label3.Text = Login.nomes[3];
            label4.Text = Login.nomes[4];


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
