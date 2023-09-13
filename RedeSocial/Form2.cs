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
        public static string nome_Perfil;
        public static string nome_Carregado;
        public static string nome_Carregado1;
        public static string nome_Carregado2;
        public static string nome_Carregado3;
        public static string nome_Carregado4;
        public static string nome_final;
        public Tela_BoasVindas()
        {
            
            Random rnd = new Random();             
            InitializeComponent();

            
            bt_UsuarioLogado.Text = Login.nomes[Convert.ToInt32(Login.user)];
            nome_Perfil = Login.user;
        novo:
                Amigo0.Text = Login.nomes[rnd.Next(Login.i)];
                nome_Carregado = Amigo0.Text;
                Amigo1.Text = Login.nomes[rnd.Next(Login.i)];
                nome_Carregado1 = Amigo1.Text;
                Amigo2.Text = Login.nomes[rnd.Next(Login.i)];
                nome_Carregado2 = Amigo2.Text;
                Amigo3.Text = Login.nomes[rnd.Next(Login.i)];
                nome_Carregado3 = Amigo3.Text;
                Amigo4.Text = Login.nomes[rnd.Next(Login.i)];
                nome_Carregado4 = Amigo4.Text;

            if (Amigo0.Text==Amigo1.Text && Amigo3.Text==Amigo4.Text)
            {
                goto novo;
            }
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (true)
            {
                nome_final = nome_Carregado;
            }
            Tela_Perfil novo = new Tela_Perfil();            
            novo.Show();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bt_UsuarioLogado_Click(object sender, EventArgs e)
        {
            if (true)
            {
                nome_final = nome_Perfil;
                Tela_Perfil nova = new Tela_Perfil();                
                nova.Show();
            }
        }

        private void Amigo1_Click(object sender, EventArgs e)
        {
            if (true)
            {
                nome_final = nome_Carregado1;
            }
            Tela_Perfil novo = new Tela_Perfil();
           
            novo.Show();
        }

        private void Amigo2_Click(object sender, EventArgs e)
        {
            if (true)
            {
                nome_final = nome_Carregado2;
            }
            Tela_Perfil novo = new Tela_Perfil();
            
            novo.Show();
        }

        private void Amigo3_Click(object sender, EventArgs e)
        {
            if (true)
            {
                nome_final = nome_Carregado3;
            }
            Tela_Perfil novo = new Tela_Perfil();
            
            novo.Show();
        }

        private void Amigo5_Click(object sender, EventArgs e)
        {
            if (true)
            {
                nome_final = nome_Carregado4;
            }
            Tela_Perfil novo = new Tela_Perfil();
            
            novo.Show();
            
        }

        private void Tela_BoasVindas_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_LeftToolStripPanel_Click(object sender, EventArgs e)
        {

        }
    }
}
