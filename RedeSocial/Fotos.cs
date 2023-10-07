using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace RedeSocial
    
{
    class Fotos
    {
        public static string caminho = System.Environment.CurrentDirectory;
        public static string caminho_foto = caminho + @"\postagem\";
        Tela_BoasVindas novo = new Tela_BoasVindas();
        public void Foto_Perfil(string lugar)
        {
            string origemCompleto = "";
            string foto = "";
            string pastaDestino = caminho_foto;
            string a;
            string b;
            
            b = lugar;

            Login.foto_postagens[Convert.ToInt32(Login.user)] = "";

            int larguraDesejada = 510; // Defina a largura desejada em pixels
            int alturaDesejada = 686;  // Defina a altura desejada em pixels

            try
            {
                if (novo.openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    origemCompleto = novo.openFileDialog1.FileName;
                    foto = novo.openFileDialog1.SafeFileName;
                    b = pastaDestino + foto;
                }
                if (File.Exists(b))
                {
                    if (MessageBox.Show("Arquivo já existe, deseja substituir?", "Substituir", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }

                // Copie a imagem para o destino
                System.IO.File.Copy(origemCompleto, b, true);

                if (File.Exists(b))
                {
                    // Configura o PictureBox para exibir a imagem redimensionada
                    Tela_Postagem novo = new Tela_Postagem();
                    novo.foto_postar.SizeMode = PictureBoxSizeMode.StretchImage;
                    novo.foto_postar.ImageLocation = b;

                   
                }
                else

                {

                }
            }
            catch (Exception ex)
            {

            }
        }
        public void RedimensionarImagem(string caminhoDaImagem, int larguraDesejada, int alturaDesejada)
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
                // Salve a imagem redimensionada de volta ao caminho
                imagemRedimensionada.Save(caminhoDaImagem, imagemOriginal.RawFormat);

            }
            catch (Exception ex)
            {

            }

        }
    }
}
