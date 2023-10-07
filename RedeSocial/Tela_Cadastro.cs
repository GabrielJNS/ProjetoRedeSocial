using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RedeSocial
{
    public partial class Tela_Cadastro : Form  {
                
        public Tela_Cadastro()
        {
            InitializeComponent();
            
        }
      
        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            cadastro(); 
        }
       
        private void cadastro()
        {
            string senhaTeste;
            string senhaProv;
            string novoEmail = caixa_email.Text;
            string email = caixa_email.Text;
            string confirmaEmail = caixa_confirmaEmail.Text;



            if (!IsValidEmail(email))
            {
                MessageBox.Show("O email deve ter o formato igual a 'exemplo@gmail.com' para ser válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!novoEmail.Equals(confirmaEmail))

            {
                MessageBox.Show("Os emails não são iguais.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            if (EmailJaCadastrado(novoEmail))

            {
                MessageBox.Show("Este email já foi cadastrado por outro usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (Login.i = Login.j; Login.i < Login.n; Login.i++)
            {   
                {
                    Login.nomes[Login.i] = caixa_nome.Text;
                    Login.email[Login.i] = caixa_email.Text;
                    Login.data_nascimento[Login.i] = caixa_data.Text;
                }

                if (!email.Equals(confirmaEmail))

                {
                    Tela_Erro nova = new Tela_Erro();
                    nova.Show();
                    caixa_confirmaEmail.Text = "";
                    caixa_email.Text = "";


                    return;
                }            


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
        private bool IsValidEmail(string email)
        {
          
            if (email.Contains("@") && email.EndsWith(".com"))
            {
                return true;
            }
            return false;
        }
        private bool EmailJaCadastrado(string novoEmail)
        {
            for (int i = 0; i < Login.n; i++)
            {
                if (Login.email[i] == novoEmail)
                {
                    return true;
                }
            }
            return false;
        }
        private void caixa_email_GotFocus(object sender, EventArgs e)
        {
            if (caixa_email.Text == "@exemplo.com")
            {
                caixa_email.Text = "";
            }
        }

        private void caixa_email_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(caixa_email.Text))
            {
                caixa_email.Text = "@exemplo.com";
            }
        }
        private void Tela_Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void caixa_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void caixa_confirmaEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void caixa_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void caixa_senha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
