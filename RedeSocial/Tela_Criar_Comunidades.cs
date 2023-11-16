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
    public partial class Tela_Criar_Comunidades : Form

    {
        public static string caminho = System.Environment.CurrentDirectory;
        public static string caminho_foto_comunidade = caminho + @"\fotos_comunidade\";
        public Tela_Criar_Comunidades()
        {
            InitializeComponent();           
            
        }

        private void Tela_Criar_Comunidades_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Nome_Comunidade.Text == "")
            {
                MessageBox.Show("Comunidade sem Nome");
            }
            else
            {
                string nome = Nome_Comunidade.Text;
                string descricao = Text_Box_Descricao.Text;
                string Id = Login.nomes[Convert.ToInt32(Login.user)];
                string foto = Picture_Imagem_Comunidade.ImageLocation;
                Comunidade novo = new Comunidade();
                novo.Criar_Comunidade(nome, descricao, Id, foto);
                //Tela_Comunidade nova_tela = new Tela_Comunidade();
                Tela_Principal.comunidades_Tela = Comunidade.contador_de_comunidades;
                //Comunidade.integrantes_comunidade[Comunidade.contador_de_comunidades] = Login.nomes[Convert.ToInt32(Login.user)];
                //Comunidade.pertence_comunidade[Comunidade.contador_de_comunidades] = true;
                Comunidade.contador_de_comunidades++;
                Tela_Principal.comunidades_Tela = Comunidade.contador_de_comunidades;
                //nova_tela.Show();
                Tela_Principal nova = new Tela_Principal();
                nova.comunidade0.Show();
                this.Close();
                nova.Show();
                MessageBox.Show("Comunidade Criada com Sucesso!!!");
            }
        }

        private void Bt_Carrega_Imagem_Click(object sender, EventArgs e)
        {
            Foto_Perfil();
            
        }
        private void Foto_Perfil()
        {
            string origemCompleto = "";
            string foto = "";
            string pastaDestino = caminho_foto_comunidade;

            

           

            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    origemCompleto = openFileDialog1.FileName;
                    foto = openFileDialog1.SafeFileName;
                    Comunidade.foto_comunidades[Comunidade.contador_de_comunidades] = pastaDestino + foto;
                }
                if (File.Exists(Comunidade.foto_comunidades[Comunidade.contador_de_comunidades]))
                {
                    if (MessageBox.Show("Arquivo já existe, deseja substituir?", "Substituir", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }

                // Copie a imagem para o destino
                System.IO.File.Copy(origemCompleto, Comunidade.foto_comunidades[Comunidade.contador_de_comunidades], true);

                if (File.Exists(Comunidade.foto_comunidades[Comunidade.contador_de_comunidades]))
                {
                    // Configura o PictureBox para exibir a imagem redimensionada
                    Picture_Imagem_Comunidade.SizeMode = PictureBoxSizeMode.Zoom;
                    Picture_Imagem_Comunidade.ImageLocation = Comunidade.foto_comunidades[Comunidade.contador_de_comunidades];

                    // Redimensiona a imagem
                    //RedimensionarImagem(Comunidade.foto_comunidades[0], larguraDesejada, alturaDesejada);
                }
                else

                {

                }
            }
            catch (Exception ex)
            {

            }
        }
        

        private void Picture_Imagem_Comunidade_Click(object sender, EventArgs e)
        {

        }
    }
}
