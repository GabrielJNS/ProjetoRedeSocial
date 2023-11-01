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
        // Variáveis de controle e dados do perfil

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
        public static int postagem_atual;
        Random rnd = new Random();

        public Tela_BoasVindas()
        {

            Pessoa novo = new Pessoa();
            InitializeComponent();
            Sorteio_Amigos();
            MostrarComunidades();
            foto_perfil_usuario.SizeMode = PictureBoxSizeMode.Zoom;
            foto_perfil_usuario.ImageLocation = Login.foto_perfil[Convert.ToInt32(Login.user)];           
            ConfigurarCircularPictureBox(foto_perfil_usuario);
            caixa_Procura.BorderStyle = BorderStyle.None;
            Pic_Mostra_Foto.SizeMode = PictureBoxSizeMode.Zoom;        
            
            bt_amigo0.Text = Login.seusAmigos[1];
            bt_amigo1.Text = Login.seusAmigos[2];


        }

        // Função para sortear amigos
        private void Sorteio_Amigos()
        {
            bt_UsuarioLogado.Text = Login.nomes[Convert.ToInt32(Login.user)];
            nome_Perfil = Login.user;
        novo:
            a = rnd.Next(Login.n-1);
            Amigo0.Text = Login.nomes[a];
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.ImageLocation = Login.foto_perfil[a];
            nome_Carregado = Amigo0.Text;
            b = rnd.Next(Login.n-1);
            Amigo1.Text = Login.nomes[b];
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.ImageLocation = Login.foto_perfil[b];
            nome_Carregado1 = Amigo1.Text;
            c = rnd.Next(Login.n-1);
            Amigo2.Text = Login.nomes[c];
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.ImageLocation = Login.foto_perfil[c];
            nome_Carregado2 = Amigo2.Text;
            d = rnd.Next(Login.n-1);
            Amigo3.Text = Login.nomes[d];
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.ImageLocation = Login.foto_perfil[d];
            nome_Carregado3 = Amigo3.Text;
            z = rnd.Next(Login.n-1);
            Amigo4.Text = Login.nomes[z];
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.ImageLocation = Login.foto_perfil[z];
            nome_Carregado4 = Amigo4.Text;

            if (a == b && a == c && a == d && a == z || b == c && b == d && b == z || c == d && c == z || d == z)
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
           Sorteio_Amigos();   
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
           Pic_Mostra_Foto.BackColor = Color.Transparent;


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
           
        }
        // Método para exibir postagens aleatórias
        public void mostrar_Postagens()
        {
            denovo:
            // Seleciona índices aleatórios para postagens

            int i = rnd.Next(Login.contador_Postagens);
            int j = rnd.Next(Login.contador_Postagens);
            int l = rnd.Next(Login.contador_Postagens);
            
            try
            {
                // Verifica se os índices são iguais para evitar a exibição de postagens duplicadas

                if (i == j && i == l && l == j)

                {  
                    // Configura o PictureBox para exibir a imagem 
                    Pic_Mostra_Foto.SizeMode = PictureBoxSizeMode.Zoom;

                    // Define a imagem da postagem 
                    Pic_Mostra_Foto.ImageLocation = Login.foto_postagens[i];

                    // Define a descrição da postagem
                    Label_Descrição.Text = Login.descricao_postagens[j];
                    postagem_atual = j;

                    // Define o nome do usuário que fez a postagem 
                    label_Usuario_Postagem.Text = Login.dono_postagem[l];
                    
                    for(int cont_fotos=0; cont_fotos < Login.contador_Postagens; cont_fotos++)
                    {
                        if (Login.dono_postagem[l].Equals(Login.nomes[cont_fotos]))
                        {
                            foto_quem_postou.ImageLocation = Login.foto_perfil[cont_fotos];
                        }
                    }
                    //Comentario do Post
                    caixa_de_comentarios.Clear();
                    for (int cont = 0; cont < 50; cont++)
                    {

                        if (Login.qual_postagem[cont] == Convert.ToString(l))
                        {
                            caixa_de_comentarios.AppendText(Login.dono_comentario[cont] + ":  " + Login.comentarios_postagens[cont] + Environment.NewLine);
                        }
                    }
                    bt_like.Text = "Likes " + Convert.ToString(Login.contador_Like[postagem_atual]);

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
        public string nome_admin;
        public string qual_comunidade;
        public void MostrarComunidades()
        {
            comunidade0.ImageLocation = Comunidade.foto_comunidades[0];
            nome_admin = Comunidade.adim_comunidade[0];
            qual_comunidade = Comunidade.nome_comunidades[0];
            comunidade1.ImageLocation = Comunidade.foto_comunidades[1];
            comunidade2.ImageLocation = Comunidade.foto_comunidades[2];
            comunidade3.ImageLocation = Comunidade.foto_comunidades[3];
            comunidade4.ImageLocation = Comunidade.foto_comunidades[4];
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_3(object sender, EventArgs e)
        {

            Tela_Fotos novo = new Tela_Fotos();
            novo.Show();
        }

        private void bt_like_Click(object sender, EventArgs e)
        {
            Like(postagem_atual);
        }
        private void Like(int a)
        {
            int post;
            post = a;

            if (Login.quem_deu_like[post] != Login.nomes[Convert.ToInt32(Login.user)])
            {
                Login.contador_Like[post]++;
                Login.quem_deu_like[post] = Login.nomes[Convert.ToInt32(Login.user)];
                bt_like.Text = "Likes " + Convert.ToString(Login.contador_Like[post]);

            }
            else
            {
               
                Login.quem_deu_like[post] = null;
                Login.contador_Like[post] = Login.contador_Like[post] - 1;
                bt_like.Text = "Likes " + Convert.ToString(Login.contador_Like[post]);

            }
            
            
        }

        private void foto_perfil_usuario_Click(object sender, EventArgs e)
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

        private void bt_Foto_Click(object sender, EventArgs e)
        {
            Tela_Fotos novo = new Tela_Fotos();
            novo.Show();
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

        private void bt_amizades_Click(object sender, EventArgs e)
        {
            Tela_Amizades novo = new Tela_Amizades();
            novo.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_Usuario_Postagem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void bt_comentarios_Click(object sender, EventArgs e)
        {
            Comentario(postagem_atual);
            MessageBox.Show("Comentario Número" + Login.contagem_comentarios);
            Login.contagem_comentarios++;
            text_Box_Comentarios.Text = "";

        }
        public void Comentario(int a)
        {
            
            int post;
            char separador = ' ';
            
            post = a;                    
            Login.comentarios_postagens[Login.contagem_comentarios] = text_Box_Comentarios.Text;
            Login.dono_comentario[Login.contagem_comentarios] = Login.nomes[Convert.ToInt32(Login.user)];
            Login.qual_postagem[Login.contagem_comentarios] = Convert.ToString(post);            
            caixa_de_comentarios.Clear();
            for(int i = 0; i < 200; i++) {

                if(Login.qual_postagem[i] == Convert.ToString(post)){
                    caixa_de_comentarios.AppendText(Login.dono_comentario[i] + ":  " + Login.comentarios_postagens[i] + Environment.NewLine + Environment.NewLine);
                }         
             }

        }

        private void bt_home_Click(object sender, EventArgs e)
        {
           
        }

        private void comunidade0_Click(object sender, EventArgs e)
        {
            Tela_Comunidade nova = new Tela_Comunidade();        
                
            nova.Show();
        }

        private void ConfigurarCircularPictureBox(PictureBox pictureBox)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(pictureBox.ClientRectangle);
            pictureBox.Region = new Region(path);
            pictureBox.BackColor = Color.Transparent;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

        }

       
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            bt_D.Visible = true;
            bt_E.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            bt_D.Visible = false;
            bt_E.Visible = false;
        }
    }
}
