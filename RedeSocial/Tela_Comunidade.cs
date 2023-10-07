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
            int larguraDesejada = 217; // Defina a largura desejada em pixels
            int alturaDesejada = 206;  // Defina a altura desejada em pixels
            InitializeComponent();
            Label_Nome_Comunidade.Text = Comunidade.nome_comunidades[0];
            Label_Descricao.Text = Comunidade.descricao_comunidades[0];            
            RedimensionarImagem(Foto_Comunidade.ImageLocation = Comunidade.foto_comunidades[0], larguraDesejada, alturaDesejada);

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
                // Salve a imagem redimensionada de volta ao caminho
                imagemRedimensionada.Save(caminhoDaImagem, imagemOriginal.RawFormat);

            }
            catch (Exception ex)
            {

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
    }
}
