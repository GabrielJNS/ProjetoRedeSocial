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
        public Tela_Amizades()
        {
            InitializeComponent();
            ConfirmarAmizade();
        }
        public void ConfirmarAmizade()
        {

            Random rnd = new Random();
            int prov, prov1, prov2, prov3,prov4, prov5, prov6;
            prov = prov1 = prov2 = prov3 = prov4 = prov5 = Login.cont_amigo;
            prov = rnd.Next(prov);
            prov1 = rnd.Next(prov1);
            prov2= rnd.Next(prov2);
            prov3 = rnd.Next(prov3);
            prov4 = rnd.Next(prov4);
            prov5 = rnd.Next(prov5);
            
            {
                if (Login.amigo_geral[prov] == Login.nomes[Convert.ToInt32(Login.user)])
                    //primeira fila                    
                    label2.Text = Login.solicita_amigo[prov];
                button1.Hide();
            }
            {
                if (Login.amigo_geral[prov1] == Login.nomes[Convert.ToInt32(Login.user)])
                    //primeira fila                    
                    label5.Text = Login.solicita_amigo[prov1];
            }
            {
                if (Login.amigo_geral[prov2] == Login.nomes[Convert.ToInt32(Login.user)])
                    //primeira fila                    
                    label7.Text = Login.solicita_amigo[prov2];
            }
            {
                if (Login.amigo_geral[prov3] == Login.nomes[Convert.ToInt32(Login.user)])
                    //primeira fila                    
                    label9.Text = Login.solicita_amigo[prov3];
            }
            {
                if (Login.amigo_geral[prov4] == Login.nomes[Convert.ToInt32(Login.user)])
                    //primeira fila                    
                    label11.Text = Login.solicita_amigo[prov4];
            }
            {
                if (Login.amigo_geral[prov5] == Login.nomes[Convert.ToInt32(Login.user)])
                    //primeira fila                    
                    label13.Text = Login.solicita_amigo[prov5];
            }

        }
        public static void VirarAmigos()
        {
            if(Login.amigo_geral[1] == Login.nomes[Convert.ToInt32(Login.user)])
            {
                Login.seusAmigos[0] = Login.solicita_amigo[1];
                Login.confirmar_amigo_geral[1] = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VirarAmigos();
            MessageBox.Show("Vocês São Amigos");
            this.Close();
        }
    }
}
