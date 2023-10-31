using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RedeSocial
{
    public partial class Login : Form
    {
        // Variáveis de controle e dados do usuário

        private bool senhaVisivel = false;
        private Image olhoAberto = Properties.Resources.olho_aberto; 
        private Image olhoFechado = Properties.Resources.olho_fechado; 
        public static int cont_ami;
        public static int amig_atual = 0;
        public static int amig_fut = 1;
        public static string user;
        public static int i;
        public static int j = 8;
        public static int n = 9;
        string senha_log;
        string email_log;
        int cont;

        // Vetores para armazenar informações dos usuários e postagens

        public static string[] nomes = new string[50];
        public static string[] senha = new string[50];
        public static string[] email = new string[50];
        public static string[] data_nascimento = new string[50];
        public static string[] foto_perfil = new string[50];
        //Postagens
        public static string[] dono_postagem = new string[200];
        public static string[] foto_postagens = new string[200];
        public static string[] descricao_postagens = new string[200];
        public static string[] comentarios_postagens = new string[200];
        public static string[] dono_comentario = new string[200];
        public static string[] qual_postagem = new string[200];
        public static int[] contador_Like = new int[200];
        public static int posicao_contador_Like = 0;
        public static int contagem_comentarios = 0;
        //Comunidades
        public static string[] comunidade_fotos = new string[50];
        public static int contador_Postagens = 0;
        public static int amigo;        
        int indiceUsuario;

        // Solicitação de Amizades
        public static int cont_amigo = 1;
        public static int cont_amigo_ini = 0;
        //contagem de amigos geral
        public static string[] solicita_amigo = new string[200];
        public static string[] amigo_geral = new string[200];
        public static bool[] confirmar_amigo_geral = new bool[200];
        public static string[] seusAmigos = new string[200];
        //contagem de amigos pessoais
        public static int conta_seus_amigos = 1; 

        public Login()
        {
            //  exemplo

            InitializeComponent();
            Login.nomes[0] = "Manuel Francisco dos Santos";
            Login.email[0] = "mane@gmail.com";
            Login.senha[0] = "123";
            Login.data_nascimento[0] = "28/10/1933";
            Login.foto_perfil[0] = "C:/Users/User/Desktop/Projeto Enari/Rede Social 2510/RedeSocial/bin/Debug/fotos/garrincha.jpg";
            Login.nomes[1] = "Tom Anjos";
            Login.email[1] = "tom@gmail.com";
            Login.senha[1] = "123";
            Login.data_nascimento[1] = "15/11/2000";
            Login.foto_perfil[1] = "C:/Users/User/Desktop/Projeto Enari/Rede Social 2510/RedeSocial/bin/Debug/fotos/tomanjos.jpg";
            Login.nomes[2] = "Edson Arantes do Nascimento";
            Login.email[2] = "pele@gmail.com";
            Login.senha[2] = "123";
            Login.data_nascimento[2] = "23/10/1940";
            Login.foto_perfil[2] = "C:/Users/User/Desktop/Projeto Enari/Rede Social 2510/RedeSocial/bin/Debug/fotos/pele.jpg";
            Login.nomes[3] = "Diego Armando Maradonna";
            Login.email[3] = "dios@gmail.com";
            Login.senha[3] = "123";
            Login.data_nascimento[3] = "30/10/1960";
            Login.foto_perfil[3] = "C:/Users/User/Desktop/Projeto Enari/Rede Social 2510/RedeSocial/bin/Debug/fotos/maradonna.jpg";
            Login.nomes[4] = "Lionel Messi";
            Login.email[4] = "et@gmail.com";
            Login.senha[4] = "123";
            Login.data_nascimento[4] = "24/06/1987";
            Login.foto_perfil[4] = "C:/Users/User/Desktop/Projeto Enari/Rede Social 2510/RedeSocial/bin/Debug/fotos/messi.jpg";
            Login.nomes[5] = "Steve Jobs";
            Login.email[5] = "maça@gmail.com";
            Login.senha[5] = "123";
            Login.data_nascimento[5] = "24/02/1955";
            Login.foto_perfil[5] = "C:/Users/User/Desktop/Projeto Enari/Rede Social 2510/RedeSocial/bin/Debug/fotos/steve.jpg";
            Login.nomes[6] = "Steve Jobs";
            Login.email[6] = "maça@gmail.com";
            Login.senha[6] = "123";
            Login.data_nascimento[6] = "24/02/1955";
            Login.foto_perfil[6] = "C:/Users/User/Desktop/Projeto Enari/Rede Social 2510/RedeSocial/bin/Debug/fotos/steve.jpg";
            Login.nomes[7] = "Jeff Bezos";
            Login.email[7] = "amazon@gmail.com";
            Login.senha[7] = "123";
            Login.data_nascimento[7] = "12/01/1964";
            Login.foto_perfil[7] = "C:/Users/User/Desktop/Projeto Enari/Rede Social 2510/RedeSocial/bin/Debug/fotos/bezos.jpg";
            Login.nomes[8] = "Pietra Ferrari";
            Login.email[8] = "pietra@gmail.com";
            Login.senha[8] = "123";
            Login.data_nascimento[8] = "12/07/2000";
            Login.foto_perfil[8] = "C:/Users/User/Desktop/Projeto Enari/Rede Social 2510/RedeSocial/bin/Debug/fotos/pietra.jpg";


            caixaSenha.PasswordChar = '•';

        }

        private void Bt_cadastrar_Click(object sender, EventArgs e)
        {       

            Tela_Cadastro nova = new Tela_Cadastro();
            nova.Show();
            
        }

        private void bt_logar_Click(object sender, EventArgs e)
        {
            Logar();
        }
        // Função para efetuar o login
        private void Logar()
        {
            email_log = Caixa_email.Text;
            senha_log = caixaSenha.Text;
            indiceUsuario = Array.IndexOf(email, email_log);

            if (indiceUsuario != -1 && senha[indiceUsuario] == senha_log)
            {
                for (cont = 0; cont < 50; cont++)
                {
            if (email_log.Equals(email[cont]) && senha[indiceUsuario] == senha_log)
                    {
                        user = Convert.ToString(cont);
                        MessageBox.Show("Valor do Vetor:" + cont);                      

                       
                    }
                }
                Tela_BoasVindas nova = new Tela_BoasVindas();
                Tela_Perfil_Amigos.prov = 0;
                nova.Show();

                
            }
            else
            {
                Tela_Erro nova1 = new Tela_Erro();
                nova1.Show();
               
            }
        }
        

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
        //inicialiazar com:
        private void Login_Load(object sender, EventArgs e)
        {
            caixaSenha.PasswordChar = '•'; 
            btnMostrarSenha.BackgroundImage = Properties.Resources.olho_fechado;
            caixaSenha.BorderStyle = BorderStyle.None;
            Caixa_email.BorderStyle = BorderStyle.None;


        }



        private void Caixa_email_TextChanged(object sender, EventArgs e)
        {
            Caixa_email.BorderStyle = BorderStyle.None;

        }

        private void caixa_senha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        // Evento de clique no botão de mostrar/ocultar senha

        private void btnMostrarSenha_Click(object sender, EventArgs e)
        {
            if (senhaVisivel)
            {
                caixaSenha.PasswordChar = '•';
                btnMostrarSenha.BackgroundImage = Properties.Resources.olho_fechado;

            }
            else
            {
                caixaSenha.PasswordChar = '\0'; 
                btnMostrarSenha.BackgroundImage = Properties.Resources.olho_aberto;
                
            }

            senhaVisivel = !senhaVisivel; 
        

    }

        private void pictureBoxOlho_Click(object sender, EventArgs e)
        {

        }

        private void caixaSenha_TextChanged(object sender, EventArgs e)
        {
            caixaSenha.BorderStyle = BorderStyle.None;

        }
    }
}
