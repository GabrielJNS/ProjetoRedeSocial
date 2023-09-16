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

        private void button1_Click(object sender, EventArgs e)
        {
            Pessoa novo = new Pessoa();
            
            Pessoa.Seguir(novo);
            MessageBox.Show("Pessoa" + Login.amigo);
            label5.Text = Convert.ToString(novo.cont_ami);
            
            
        }
    }
}
