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
    public partial class Tela_BoasVindas : Form
    {
        public static string nome_Perfil;
        public static string nome_Carregado;
        public static string nome_Carregado1;
        public static string nome_Carregado2;
        public static string nome_Carregado3;
        public static string nome_Carregado4;
        public static string nome_final;
        public static string caminho = System.Environment.CurrentDirectory;
        public static string caminho_foto = caminho + @"\postagem\";
        public static int a, b, c, d, z;
        public static int amigo;
        Random rnd = new Random();

        public Tela_BoasVindas()
        {

            Pessoa novo = new Pessoa();
            InitializeComponent();
            Sorteio_Amigos();            
            foto_perfil_usuario.SizeMode = PictureBoxSizeMode.Zoom;
            foto_perfil_usuario.ImageLocation = Login.foto_perfil[Convert.ToInt32(Login.user)];
            

        }
        //Sorteio Amigos
        private void Sorteio_Amigos()
        {
            bt_UsuarioLogado.Text = Login.nomes[Convert.ToInt32(Login.user)];
            nome_Perfil = Login.user;
        novo:
            a = rnd.Next(Login.n);
            Amigo0.Text = Login.nomes[a];
            nome_Carregado = Amigo0.Text;
            b = rnd.Next(Login.n);
            Amigo1.Text = Login.nomes[b];
            nome_Carregado1 = Amigo1.Text;
            c = rnd.Next(Login.n);
            Amigo2.Text = Login.nomes[c];
            nome_Carregado2 = Amigo2.Text;
            d = rnd.Next(Login.n);
            Amigo3.Text = Login.nomes[d];
            nome_Carregado3 = Amigo3.Text;
            z = rnd.Next(Login.n);
            Amigo4.Text = Login.nomes[z];
            nome_Carregado4 = Amigo4.Text;

            if (a == b && a == c && a == d && a == z || b == c && b == d && b == z || c == d && c == z)
            {
                goto novo;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {


        }
        //Botão Amigo Carregado
        private void button1_Click(object sender, EventArgs e)
        {

            if (true)
            {

                nome_final = nome_Carregado;
                Login.amigo = a;
            }

            Tela_Perfil_Amigos novo = new Tela_Perfil_Amigos();
            novo.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //usuário logado chama Tela de Status
        private void bt_UsuarioLogado_Click(object sender, EventArgs e)
        {
            if (true)
            {
                nome_final = nome_Perfil;
            }
            Tela_Perfil nova = new Tela_Perfil();
            this.Close();
            nova.Show();
        }
        //Botão Amigo Carregado
        private void Amigo1_Click(object sender, EventArgs e)
        {
            if (true)
            {
                nome_final = nome_Carregado1;
                Login.amigo = b;
            }
            Tela_Perfil_Amigos novo = new Tela_Perfil_Amigos();
            novo.Show();
        }
        //Botão Amigo Carregado
        private void Amigo2_Click(object sender, EventArgs e)
        {
            if (true)
            {
                nome_final = nome_Carregado2;
                Login.amigo = c;
            }
            Tela_Perfil_Amigos novo = new Tela_Perfil_Amigos();
            novo.Show();
        }
        //Botão Amigo Carregado
        private void Amigo3_Click(object sender, EventArgs e)
        {
            if (true)
            {
                nome_final = nome_Carregado3;
                Login.amigo = d;
            }
            Tela_Perfil_Amigos novo = new Tela_Perfil_Amigos();
            novo.Show();
        }
        //Botão Amigo Carregado
        private void Amigo5_Click(object sender, EventArgs e)
        {
            if (true)
            {
                nome_final = nome_Carregado4;
                Login.amigo = z;
            }
            Tela_Perfil_Amigos novo = new Tela_Perfil_Amigos();
            novo.Show();

        }

        private void Bt_mais_amigos_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                Sorteio_Amigos();
            }
        }


        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Pic_Mostra_Foto_Click(object sender, EventArgs e)
        {

        }

        private void Tela_BoasVindas_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tela_Criar_Comunidades novo = new Tela_Criar_Comunidades();
            novo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tela_Mostrar_Comunidade novo = new Tela_Mostrar_Comunidade();
            novo.Show();
        }
        
        public void mostrar_Postagens()
        {
            denovo:
            int i = rnd.Next(Login.contador_Postagens);
            int j = rnd.Next(Login.contador_Postagens);
            int l = rnd.Next(Login.contador_Postagens);
            try
            {
                if (i == j && i == l && l == j)
                {
                    Pic_Mostra_Foto.SizeMode = PictureBoxSizeMode.Zoom;
                    Pic_Mostra_Foto.ImageLocation = Login.foto_postagens[i];
                    Label_Descrição.Text = Login.descricao_postagens[j];
                    label_Usuario_Postagem.Text = Login.dono_postagem[l];

                }
                else
                {
                    goto denovo;
                }                
                
                
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Deu Ruim");
            }
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            mostrar_Postagens();           
        }
        private void bt_Perfil_Imagem_Click(object sender, EventArgs e)
        {

        }


        
        private void button7_Click_2(object sender, EventArgs e)
        {
            mostrar_Postagens();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_LeftToolStripPanel_Click(object sender, EventArgs e)
        {

        }
        //Botão sobe a foto
        private void button7_Click(object sender, EventArgs e)
        {
            Tela_Postagem novo = new Tela_Postagem();
            novo.Show();
        }
        //Foto de Perfil
        public void Foto_Perfil()
        {
            string origemCompleto = "";
            string foto = "";
            string pastaDestino = caminho_foto;

            Login.foto_postagens[Convert.ToInt32(Login.user)] = "";

            int larguraDesejada = 510; // Defina a largura desejada em pixels
            int alturaDesejada = 686;  // Defina a altura desejada em pixels

            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    origemCompleto = openFileDialog1.FileName;
                    foto = openFileDialog1.SafeFileName;
                    Login.foto_postagens[Convert.ToInt32(Login.user)] = pastaDestino + foto;
                }
                if (File.Exists(Login.foto_postagens[Convert.ToInt32(Login.user)]))
                {
                    if (MessageBox.Show("Arquivo já existe, deseja substituir?", "Substituir", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }

                // Copie a imagem para o destino
                System.IO.File.Copy(origemCompleto, Login.foto_postagens[Convert.ToInt32(Login.user)], true);

                if (File.Exists(Login.foto_postagens[Convert.ToInt32(Login.user)]))
                {
                    // Configura o PictureBox para exibir a imagem redimensionada
                    Pic_Mostra_Foto.SizeMode = PictureBoxSizeMode.StretchImage;
                    Pic_Mostra_Foto.ImageLocation = Login.foto_postagens[Convert.ToInt32(Login.user)];

                    // Redimensiona a imagem
                    RedimensionarImagem(Login.foto_postagens[Convert.ToInt32(Login.user)], larguraDesejada, alturaDesejada);
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
