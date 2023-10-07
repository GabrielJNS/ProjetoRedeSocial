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
            string nome = Nome_Comunidade.Text;
            string descricao = Text_Box_Descricao.Text;
            int Id = Convert.ToInt32(Login.user);
            string foto = Picture_Imagem_Comunidade.ImageLocation;
            Comunidade novo = new Comunidade();
            novo.Criar_Comunidade(nome, descricao, Id, foto);
            Tela_Comunidade nova_tela = new Tela_Comunidade();
            nova_tela.Show();
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

            Login.foto_perfil[Convert.ToInt32(Login.user)] = "";

            int larguraDesejada = 510; // Defina a largura desejada em pixels
            int alturaDesejada = 686;  // Defina a altura desejada em pixels

            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    origemCompleto = openFileDialog1.FileName;
                    foto = openFileDialog1.SafeFileName;
                    Comunidade.foto_comunidades[0] = pastaDestino + foto;
                }
                if (File.Exists(Comunidade.foto_comunidades[0]))
                {
                    if (MessageBox.Show("Arquivo já existe, deseja substituir?", "Substituir", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }

                // Copie a imagem para o destino
                System.IO.File.Copy(origemCompleto, Comunidade.foto_comunidades[0], true);

                if (File.Exists(Comunidade.foto_comunidades[0]))
                {
                    // Configura o PictureBox para exibir a imagem redimensionada
                    Picture_Imagem_Comunidade.SizeMode = PictureBoxSizeMode.StretchImage;
                    Picture_Imagem_Comunidade.ImageLocation = Comunidade.foto_comunidades[0];

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
        private void RedimensionarImagem(string caminhoDaImagem, int larguraDesejada, int alturaDesejada)
        {
            try
            {
                Image imagemOriginal = Image.FromFile(caminhoDaImagem);
                Bitmap imagemRedimensionada = new Bitmap(larguraDesejada, alturaDesejada);

                using (Graphics g = Graphics.FromImage(imagemRedimensionada))
                {
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    g.DrawImage(imagemOriginal, 0, 0, larguraDesejada, alturaDesejada);
                }
                 //Salve a imagem redimensionada de volta ao caminho
                imagemRedimensionada.Save(caminhoDaImagem, imagemOriginal.RawFormat);

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
