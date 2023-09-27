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
            Pic_amigo.ImageLocation = Login.foto_perfil[Login.amigo];
            
           

        }

        private void Tela_Perfil_Amigos_Load(object sender, EventArgs e)
        {

        }

       
              
        public void Seguindo()
        {           
                segue = Convert.ToInt32(Login.user);  
                contI = prov;
                contF = prov + 1;      
                for (cont = contI; cont < contF; cont++)
                {
                    novo.Seguir(segue, cont);
                }
                contF++;
                contI++;
                prov = contI;             
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Seguindo();
            

            

        }


        private void label_nome_amigo_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            novo.Teste_Vetor(segue);
        }
    }
}
