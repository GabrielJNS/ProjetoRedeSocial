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
            Random rnd = new Random();             
            InitializeComponent();
            
            bt_UsuarioLogado.Text = Login.nomes[Convert.ToInt32(Login.user)];
        novo:
                Amigo0.Text = Login.nomes[rnd.Next(Login.i)];
               
                Amigo1.Text = Login.nomes[rnd.Next(Login.i)];
               
                Amigo2.Text = Login.nomes[rnd.Next(Login.i)];
            
                Amigo3.Text = Login.nomes[rnd.Next(Login.i)];
                 
                Amigo5.Text = Login.nomes[rnd.Next(Login.i)];
               
            if (Amigo0.Text==Amigo1.Text && Amigo3.Text==Amigo5.Text)
            {
                goto novo;
            }
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tela_Perfil novo = new Tela_Perfil();
            
            novo.Show();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bt_UsuarioLogado_Click(object sender, EventArgs e)
        {

        }

        private void Amigo1_Click(object sender, EventArgs e)
        {
            Tela_Perfil novo = new Tela_Perfil();
            novo.Show();
        }

        private void Amigo2_Click(object sender, EventArgs e)
        {
            Tela_Perfil novo = new Tela_Perfil();
            novo.Show();
        }

        private void Amigo3_Click(object sender, EventArgs e)
        {
            Tela_Perfil novo = new Tela_Perfil();
            novo.Show();
        }

        private void Amigo5_Click(object sender, EventArgs e)
        {
            Tela_Perfil novo = new Tela_Perfil();
            novo.Show();
        }
    }
}
