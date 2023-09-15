using System;
using System.Windows.Forms;

namespace RedeSocial
{
    public partial class Tela_Cadastro : Form
    {

        

        public Tela_Cadastro()
        {
            InitializeComponent();
        }
        //Botão Cadastro
        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            cadastro(); 
        }
        //Cadastro
        private void cadastro()
        {
            string senhaTeste;
            string senhaProv;
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
            this.Close();
        }

        private void Tela_Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void caixa_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void caixa_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void caixa_data_TextChanged(object sender, EventArgs e)
        {

        }

        private void caixa_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void caixa_confirmaSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void caixa_tel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
