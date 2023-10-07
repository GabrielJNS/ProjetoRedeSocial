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
    public partial class Tela_Postagem : Form
    {
        Tela_BoasVindas novo = new Tela_BoasVindas();
        public static string caminho = System.Environment.CurrentDirectory;
        public static string caminho_foto = caminho + @"\postagem\";
        public Tela_Postagem()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Foto_Postagem();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login.descricao_postagens[Login.contador_Postagens] = text_descricao.Text;
            MessageBox.Show("Postagem Realizada com Sucesso");
            Login.contador_Postagens++;
        }
        public void Foto_Postagem()
        {
            string origemCompleto = "";
            string foto = "";
            string pastaDestino = caminho_foto;
            

            int larguraDesejada = 510; // Defina a largura desejada em pixels
            int alturaDesejada = 686;  // Defina a altura desejada em pixels

            try
            {
                if (novo.openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    origemCompleto = novo.openFileDialog1.FileName;
                    foto = novo.openFileDialog1.SafeFileName;
                    Login.foto_postagens[Login.contador_Postagens] = pastaDestino + foto;
                }
                if (File.Exists(Login.foto_postagens[Login.contador_Postagens]))
                {
                    if (MessageBox.Show("Arquivo já existe, deseja substituir?", "Substituir", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }

                // Copie a imagem para o destino
                System.IO.File.Copy(origemCompleto, Login.foto_postagens[Login.contador_Postagens], true);

                if (File.Exists(Login.foto_postagens[Login.contador_Postagens]))
                {
                    // Configura o PictureBox para exibir a imagem redimensionada
                    foto_postar.SizeMode = PictureBoxSizeMode.Zoom;
                    foto_postar.ImageLocation = Login.foto_postagens[Login.contador_Postagens];
                    

                    // Redimensiona a imagem
                    
                }
                else

                {

                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
