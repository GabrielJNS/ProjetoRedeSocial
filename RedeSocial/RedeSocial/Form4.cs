using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;


namespace RedeSocial
{
    public partial class Tela_Cadastro : Form
    {

        string senhaTeste;
        string senhaProv;
        private Imagem[] imagensEnviadas = new Imagem[10]; 
        private int contadorImagens = 0; 

        public Tela_Cadastro()
        {
            InitializeComponent();
        }

       

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            for (Login.i = Login.j; Login.i < Login.n; Login.i++)
            {
                Login.nomes[Login.i] = caixa_nome.Text;
                Login.email[Login.i] = caixa_email.Text;
                Login.data_nascimento[Login.i] = caixa_data.Text;
            volta:
                senhaProv = caixa_senha.Text;
                senhaTeste = caixa_confirmaSenha.Text;

                if (senhaProv.Equals(senhaTeste))
                {
                    Login.senha[Login.i] = senhaProv;
                }
                else
                {
                    Tela_Erro nova = new Tela_Erro();
                    nova.Show();
                    caixa_confirmaSenha.Text = "";
                    caixa_senha.Text = "";
                    goto volta;

                    //erro
                }

            }
            Login.j++;
            Login.n++;
            if (caixa_nome.Text.Equals("") || caixa_senha.Text.Equals(""))
            {
                Tela_Erro novo = new Tela_Erro();
                novo.Show();

            }
            else
            {
                Aviso_Cadastro novo = new Aviso_Cadastro();
                novo.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btEnviarFoto_Click(object sender, EventArgs e)
        {
            if (contadorImagens > 0)
            {
                for (int i = 0; i < contadorImagens; i++)
                {
                    MessageBox.Show($"Imagem '{imagensEnviadas[i].Nome}' enviada com sucesso!");
                }

              
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma imagem antes de enviar.");
            }

        }

        private void btnSelecionarImagem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif|Todos os arquivos|*.*";
                openFileDialog.Title = "Selecionar Imagem";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string caminhoDaImagem = openFileDialog.FileName;

                    string extensao = System.IO.Path.GetExtension(caminhoDaImagem).ToLower();

                    if (extensao == ".jpg" || extensao == ".jpeg" || extensao == ".png" || extensao == ".gif")
                    {
                        try
                        {
                            if (contadorImagens < imagensEnviadas.Length)
                            {
                                Imagem novaImagem = new Imagem
                                {
                                    Nome = "Nome da imagem (opcional)",
                                    Caminho = caminhoDaImagem
                                };
                                imagensEnviadas[contadorImagens] = novaImagem;
                                contadorImagens++;

                                MessageBox.Show($"Caminho da imagem: {caminhoDaImagem}");

                                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                                pictureBox1.Image = Image.FromFile(caminhoDaImagem);
                            }
                            else
                            {
                                MessageBox.Show("Limite máximo de imagens atingido.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao carregar a imagem: " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, selecione um arquivo de imagem válido (jpg, jpeg, png, gif).");
                    }
                }
            }
        }
        public class Imagem
        {
            public string Nome { get; set; }
            public string Caminho { get; set; }
        }
    }
}
    
