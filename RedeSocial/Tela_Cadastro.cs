using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RedeSocial
{
    public partial class Tela_Cadastro : Form  {
                
        public Tela_Cadastro()
        {
            InitializeComponent();
            caixa_confirmaEmail.BorderStyle = BorderStyle.None;
            caixa_confirmaSenha.BorderStyle = BorderStyle.None;
            caixa_data.BorderStyle = BorderStyle.None;
            caixa_email.BorderStyle = BorderStyle.None;
            caixa_nome.BorderStyle = BorderStyle.None;
            caixa_senha.BorderStyle = BorderStyle.None;








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

            // Verifica se o email é válido

            if (!IsValidEmail(email))
            {
                MessageBox.Show("O email deve ter o formato igual a 'exemplo@gmail.com' para ser válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Verifica se os emails informados são iguais

            if (!novoEmail.Equals(confirmaEmail))

            {
                MessageBox.Show("Os emails não são iguais.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica se o email já está cadastrado no vetor

            if (EmailJaCadastrado(novoEmail))

            {
                MessageBox.Show("Este email já foi cadastrado por outro usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Loop para cadastrar os dados do usuário

            for (Login.i = Login.j; Login.i < Login.n; Login.i++)
            {   
                {
                    Login.nomes[Login.i] = caixa_nome.Text;
                    Login.email[Login.i] = caixa_email.Text;
                    Login.data_nascimento[Login.i] = caixa_data.Text;
                }
             // Verifica se os emails informados são iguais novamente 

                if (!email.Equals(confirmaEmail))

                {
                    Tela_Erro nova = new Tela_Erro();
                    nova.Show();
                    caixa_confirmaEmail.Text = "";
                    caixa_email.Text = "";


                    return;
                }

            // Loop para garantir que a senha e a confirmação de senha sejam iguais

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

            // Atualiza os contadores de usuários
            Login.j++;
            Login.n++;


            // Verifica se o nome ou a senha estão vazios

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

        // Função para validar o formato do email
        private bool IsValidEmail(string email)
        {
          
            if (email.Contains("@") && email.EndsWith(".com"))
            {
                return true;
            }
            return false;
        }
        // Função para verificar se o email já está cadastrado
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
