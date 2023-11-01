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
            Label_Nome_Comunidade.Text = Comunidade.nome_comunidades[Comunidade.contador_de_comunidades];
            Label_Descricao.Text = Comunidade.descricao_comunidades[Comunidade.contador_de_comunidades];
            Foto_Comunidade.SizeMode = PictureBoxSizeMode.Zoom;
            Foto_Comunidade.ImageLocation = Comunidade.foto_comunidades[Comunidade.contador_de_comunidades];
            
            
            

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

        }
        public void ConviteComunidades()
        {

        }
    }
}
