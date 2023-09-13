using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedeSocial
{
    public partial class Login : Form
    {
        public static string user;
        public static int i;
        public static int j = 1;
        public static int n = 2;
        string nome_log;
        string senha_log;
        int cont;
        public static string[] nomes = new string[50];
        public static string[] senha = new string[50];

        
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

            
            nome_log = caixa_nome.Text;
            senha_log = caixa_senha.Text;
            indiceUsuario = Array.IndexOf(nomes, nome_log);
            
            if (indiceUsuario != -1 && senha[indiceUsuario] == senha_log)
            {
                for (cont = 0; cont < 50; cont++)
                {
                    if (nome_log.Equals(nomes[cont]))
                    {
                        user = Convert.ToString(cont);
                        label_Vetor.Text = user;
                    }
                }
                Tela_BoasVindas nova = new Tela_BoasVindas();
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
    }
}
