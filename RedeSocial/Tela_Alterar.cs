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
    public partial class Tela_Alterar : Form
    {
        string nome, data, email, senha, confirmarsenha;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Tela_Alterar()
        {
            InitializeComponent();
            textBox_Nome_Alterar.Text = Login.nomes[Convert.ToInt32(Login.user)];
            textBox_Email_alterar.Text = Login.email[Convert.ToInt32(Login.user)];
            textBox_data_alterar.Text = Login.data_nascimento[Convert.ToInt32(Login.user)];
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alterar();
        }
        public void Alterar()
        {
            nome = textBox_Nome_Alterar.Text;
            email = textBox_Email_alterar.Text;
            data = textBox_data_alterar.Text;
            senha = textBox_senha_alterar.Text;
            confirmarsenha = textBox_confirmar_senha.Text;
            if (senha.Equals(Login.senha[Convert.ToInt32(Login.user)]) != true)
            {
                MessageBox.Show("Senha Incorreta");
                if (senha.Equals(confirmarsenha) != true || senha.Equals("") == true)
                {

                    MessageBox.Show("Senha e Confirmar senhas diferentes!");
                }


            }
            else
            {
                Login.nomes[Convert.ToInt32(Login.user)] = nome;
                Login.email[Convert.ToInt32(Login.user)] = email;
                Login.data_nascimento[Convert.ToInt32(Login.user)] = data;
                Login.senha[Convert.ToInt32(Login.user)] = senha;
                MessageBox.Show("Cadastro Atualizado");

            }
            
        }

    }
}
