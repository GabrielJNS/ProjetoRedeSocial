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
            for (int i = 0; i < Login.j; i++)
            {
               if (Comunidade.adim_comunidade[Tela_BoasVindas.comunidades_Tela] == Login.nomes[i])
               {
                    user0.ImageLocation = Login.foto_perfil[i];                   
     
               }
                //if(Comunidade.integrantes_comunidade[])
            }
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
            Comunidade.contador_de_Pessoas++;
        }
        //Convite para entrar na Comunidade
        public void ConviteComunidades()
        {
            if(Comunidade.integrantes_comunidade[Tela_BoasVindas.comunidades_Tela] == Login.nomes[Convert.ToInt32(Login.user)])
            {
                MessageBox.Show("Você já faz parte dessa comunidade");
            }
            else
            {
                for (Comunidade.contador_de_Pessoas = 0; Comunidade.contador_de_Pessoas < Comunidade.contador_de_comunidades; Comunidade.contador_de_Pessoas++) 
                {
                    Comunidade.qual_comunidade[Comunidade.contador_de_Pessoas] = Convert.ToString(Tela_BoasVindas.comunidades_Tela);
                    Comunidade.integrantes_comunidade[Comunidade.contador_de_Pessoas] = Login.nomes[Convert.ToInt32(Login.user)];
                    Comunidade.pertence_comunidade[Comunidade.contador_de_Pessoas] = true;
                    MessageBox.Show("Pessoa Cadastrada! Esperando a Confirmação do Administrador " + Comunidade.contador_de_Pessoas );

                }
            }
            
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
        
        }
    }
}
