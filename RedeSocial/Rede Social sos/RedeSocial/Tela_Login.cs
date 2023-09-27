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

        public static int pessoa_logada;
        public static int cont_ami;
        public static int amig_atual = 0;
        public static int amig_fut = 1;
        public static string user;
        public static int i;
        public static int j = 0;
        public static int n = 1;
        string senha_log;
        string email_log;
        int cont;


        public static string[] nomes = new string[50];
        public static string[] senha = new string[50];
        public static string[] email = new string[50];
        public static string[] data_nascimento = new string[50];
        public static string[] foto_perfil = new string[50];
       
        public static int amigo;

        
        int indiceUsuario;

        public Login()
        {
            
            InitializeComponent();            

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
            senha_log = caixa_senha.Text;
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
                Tela_Perfil_Amigos.contF = 1;
                Tela_Perfil_Amigos.contI = 0;
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

        }

       

        private void Caixa_email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
