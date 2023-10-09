using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;



namespace RedeSocial
{
    public partial class Tela_Perfil : Form
    {
        public static string caminho = System.Environment.CurrentDirectory;
        public static string caminho_foto = caminho + @"\fotos\";
        int cont;
        public Tela_Perfil()
        {
            InitializeComponent();
            cont = Convert.ToInt32(Login.user);
            Label_Nome.Text = Tela_BoasVindas.nome_final;
            Label_Id.Text = Login.user;
            Label_name.Text = Login.nomes[cont];
            Label_email.Text = Login.email[cont];
            Label_Data.Text = Login.data_nascimento[cont];
            foto_perfil.SizeMode = PictureBoxSizeMode.Zoom;
            foto_perfil.ImageLocation = Login.foto_perfil[Convert.ToInt32(Login.user)];
            
        }
       

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Label_Nome_Click(object sender, EventArgs e)
        {

        }

        private void Tela_Perfil_Load(object sender, EventArgs e)
        {

        }

        private void Label_Id_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void foto_perfil_Click(object sender, EventArgs e)
        {

        }

        private void Label_name_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
             
        private void button2_Click(object sender, EventArgs e)
        {
            
            Foto_Perfil();
            MessageBox.Show("Foto Alterada");
            Tela_BoasVindas novo = new Tela_BoasVindas();
            novo.Show();
            
        }
        public void atualizarDados()
        {

        }

        public void Foto_Perfil()
        {
            string origemCompleto = "";
            string foto = "";
            string pastaDestino = caminho_foto;
            Login.foto_perfil[Convert.ToInt32(Login.user)] = "";
            int larguraDesejada = 510; // Defina a largura desejada em pixels
            int alturaDesejada = 686;  // Defina a altura desejada em pixels

            try
            {
                if (openFileDialog1_foto_perfil.ShowDialog() == DialogResult.OK)
                {
                    origemCompleto = openFileDialog1_foto_perfil.FileName;
                    foto = openFileDialog1_foto_perfil.SafeFileName;
                    Login.foto_perfil[Convert.ToInt32(Login.user)] = pastaDestino + foto;
                }
                if (File.Exists(Login.foto_perfil[Convert.ToInt32(Login.user)]))
                {
                    if (MessageBox.Show("Arquivo já existe, deseja substituir?", "Substituir", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }

                // Copie a imagem para o destino
                System.IO.File.Copy(origemCompleto, Login.foto_perfil[Convert.ToInt32(Login.user)], true);

                if (File.Exists(Login.foto_perfil[Convert.ToInt32(Login.user)]))
                {
                    // Configura o PictureBox para exibir a imagem redimensionada
                    foto_perfil.SizeMode = PictureBoxSizeMode.Zoom;
                    foto_perfil.ImageLocation = Login.foto_perfil[Convert.ToInt32(Login.user)];
                    Tela_BoasVindas novo = new Tela_BoasVindas();
                    novo.foto_perfil_usuario.SizeMode = PictureBoxSizeMode.Zoom;
                    novo.foto_perfil_usuario.ImageLocation = Login.foto_perfil[Convert.ToInt32(Login.user)];

                    // Redimensiona a imagem
                    RedimensionarImagem(Login.foto_perfil[Convert.ToInt32(Login.user)], larguraDesejada, alturaDesejada);
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
