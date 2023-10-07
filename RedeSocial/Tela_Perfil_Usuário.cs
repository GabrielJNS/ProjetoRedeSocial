using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace RedeSocial
{
    public partial class Tela_Perfil : Form
    {
        int cont;
        public Tela_Perfil()
        {
            InitializeComponent();
            cont = Convert.ToInt32(Login.user);
            Label_Nome.Text = Tela_BoasVindas.nome_final;
            Label_Id.Text = Login.user;
            Label_name.Text = Login.nomes[cont];
            Label_email.Text = Login.email[cont];
            Label_Data.Text = Login.data_nascimento[cont];
            foto_perfil.ImageLocation = Login.foto_perfil[Convert.ToInt32(Login.user)];
            
        }
       

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Label_Nome_Click(object sender, EventArgs e)
        {

        }

        private void Tela_Perfil_Load(object sender, EventArgs e)
        {

        }

        private void Label_Id_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void foto_perfil_Click(object sender, EventArgs e)
        {

        }

        private void Label_name_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
