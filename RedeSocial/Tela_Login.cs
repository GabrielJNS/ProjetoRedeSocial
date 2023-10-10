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
        private bool senhaVisivel = false;
        private Image olhoAberto = Properties.Resources.olho_aberto; 
        private Image olhoFechado = Properties.Resources.olho_fechado; 
        public static int cont_ami;
        public static int amig_atual = 0;
        public static int amig_fut = 1;
        public static string user;
        public static int i;
        public static int j = 1;
        public static int n = 2;
        string senha_log;
        string email_log;
        int cont;
        public static string[] nomes = new string[50];
        public static string[] senha = new string[50];
        public static string[] email = new string[50];
        public static string[] data_nascimento = new string[50];
        public static string[] foto_perfil = new string[50];
        public static string[] dono_postagem = new string[200];
        public static string[] foto_postagens = new string[200];
        public static string[] descricao_postagens = new string[200];
        public static string[] comunidade_fotos = new string[50];
        public static int contador_Postagens = 0;
        public static int amigo;        
        int indiceUsuario;

        public Login()
        {
            
            InitializeComponent();
            Login.nomes[0] = "Mané Dos Santos";
            Login.email[0] = "mane@gmail.com";
            Login.senha[0] = "123";
            Login.data_nascimento[0] = "15/11/1967";
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

        private void Login_Load(object sender, EventArgs e)
        {
            caixaSenha.PasswordChar = '•'; 
            btnMostrarSenha.BackgroundImage = Properties.Resources.olho_fechado;

        
    }

       

        private void Caixa_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void caixa_senha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

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

        }
    }
}
