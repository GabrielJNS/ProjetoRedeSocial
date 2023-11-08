using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace RedeSocial
{
    public partial class Tela_Comunidade : Form
    {
        
        public Tela_Comunidade()
        {
           
            InitializeComponent();
            
            Label_Nome_Comunidade.Text = Comunidade.nome_comunidades[Tela_BoasVindas.comunidades_Tela];
            Label_Descricao.Text = Comunidade.descricao_comunidades[Tela_BoasVindas.comunidades_Tela];
            Foto_Comunidade.SizeMode = PictureBoxSizeMode.Zoom;
            Foto_Comunidade.ImageLocation = Comunidade.foto_comunidades[Tela_BoasVindas.comunidades_Tela];
            
        }
       
        private void Tela_Comunidade_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Foto_Comunidade_Click(object sender, EventArgs e)
        {

        }

        private void bt_convite_comunidade_Click(object sender, EventArgs e)
        {
            ConviteComunidades();
        }
        
        public void ConviteComunidades()
        {
            if(Comunidade.integrantes_comunidade[Tela_BoasVindas.comunidades_Tela] == Login.nomes[Convert.ToInt32(Login.user)])
            {
                MessageBox.Show("Você já faz parte dessa comunidade");
            }
            else
            {
               
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
                    }
    }
}
