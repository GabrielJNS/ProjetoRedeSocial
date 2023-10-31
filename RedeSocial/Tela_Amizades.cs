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
    public partial class Tela_Amizades : Form
    {
        public static int pegaValor = 0;
        public static int pegaValor1 = 0;
        public static int pegaValor2 = 0;
        public Tela_Amizades()
        {
            InitializeComponent();
            ConfirmarAmizade();
        }
        public void ConfirmarAmizade()
        {

            Random rnd = new Random();
            int prov, prov1, prov2;
            prov = prov1 = prov2 = Login.cont_amigo;
            
            prov = rnd.Next(prov);
            prov1 = rnd.Next(prov1);
            prov2= rnd.Next(prov2);
           
            
            {
                if (Login.amigo_geral[prov] == Login.nomes[Convert.ToInt32(Login.user)])
                {
                    //primeira fila                    
                    label2.Text = Login.solicita_amigo[prov];
                    pegaValor = prov;
                }
                else
                {
                    button1.Hide();
                    button2.Hide();
                    label14.Hide();
                    label2.Hide();
                }
                
            }
            {
                if (Login.amigo_geral[prov1] == Login.nomes[Convert.ToInt32(Login.user)] && Login.amigo_geral[prov1] != Login.amigo_geral[prov])
                {
                    //segunda fila                    
                    label5.Text = Login.solicita_amigo[prov1];
                    pegaValor1 = prov1;
                }
                else
                {
                    button4.Hide();
                    button3.Hide();
                    label15.Hide();
                    label5.Hide();
                }
            }
            {
                if (Login.amigo_geral[prov2] == Login.nomes[Convert.ToInt32(Login.user)] && Login.amigo_geral[prov2] != Login.amigo_geral[prov] && Login.amigo_geral[prov2] != Login.amigo_geral[prov1])
                {
                    //terceira fila                    
                    label7.Text = Login.solicita_amigo[prov2];
                    pegaValor2 = prov2;

                }
                else
                {
                    button6.Hide();
                    button5.Hide();
                    label16.Hide();
                    label7.Hide();
                }

            }
        }
        public static void VirarAmigos()
        {
            if(Login.amigo_geral[Login.conta_seus_amigos] == Login.nomes[Convert.ToInt32(Login.user)])
            {

                Login.seusAmigos[Login.conta_seus_amigos] = Login.solicita_amigo[pegaValor];
                Login.confirmar_amigo_geral[Login.conta_seus_amigos] = true;
                Login.conta_seus_amigos++;
                MessageBox.Show(Login.seusAmigos[1]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VirarAmigos();
            MessageBox.Show("Vocês São Amigos "+ Login.conta_seus_amigos);            
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VirarAmigos();
            MessageBox.Show("Vocês São Amigos " + Login.conta_seus_amigos);
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            VirarAmigos();
            MessageBox.Show("Vocês São Amigos " + Login.conta_seus_amigos);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NaoAmigos();
        }
        public void NaoAmigos()
        {
            if (Login.amigo_geral[Login.conta_seus_amigos] == Login.nomes[Convert.ToInt32(Login.user)])
            {

                Login.amigo_geral[pegaValor] = "";
                Login.confirmar_amigo_geral[Login.conta_seus_amigos] = false;               
                MessageBox.Show("Não São amigos");
                if(Login.amigo_geral[pegaValor] == "")
                {
                    button1.Hide();
                    button2.Hide();
                    label14.Hide();
                    label2.Hide();
                }
            }
        }
    }
}
