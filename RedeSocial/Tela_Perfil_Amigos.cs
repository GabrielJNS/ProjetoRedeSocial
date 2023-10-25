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
    
    public partial class Tela_Perfil_Amigos : Form
    {
        public int cont;
        public static int contF = 1;
        public static int contI = 0;
        public int segue;
        Pessoa novo = new Pessoa();      
        public static int prov;
        public Tela_Perfil_Amigos()
        {
            InitializeComponent();
            Label_id.Text = Convert.ToString(Login.amigo);
            Label_nome.Text = Login.nomes[Login.amigo];
            Label_data.Text = Login.data_nascimento[Login.amigo];
            Pic_amigo.SizeMode = PictureBoxSizeMode.Zoom;
            Pic_amigo.ImageLocation = Login.foto_perfil[Login.amigo];    
           
        }

        private void Tela_Perfil_Amigos_Load(object sender, EventArgs e)
        {

        }

       
              
        public void Amizade()
        {
            
            
            for (Login.cont_amigo_ini = 0; Login.cont_amigo_ini < Login.cont_amigo; Login.cont_amigo_ini++)
            {
                Login.amigo_geral[Login.cont_amigo] =  Login.nomes[Login.amigo];
                Login.solicita_amigo[Login.cont_amigo] = Login.nomes[Convert.ToInt32(Login.user)];
                Login.confirmar_amigo_geral[Login.cont_amigo] = false;
                
            }
            MessageBox.Show("Convite eviado a:  " + Login.amigo_geral[Login.cont_amigo_ini] + " Esperando Confirmação: " + Login.confirmar_amigo_geral[Login.cont_amigo_ini]);
            Login.cont_amigo_ini++;
            Login.cont_amigo++;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Amizade();                       

        }


        private void label_nome_amigo_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}
