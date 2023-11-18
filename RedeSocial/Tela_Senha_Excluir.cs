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
    
    public partial class Tela_Senha_Excluir : Form
    {
        

        
        public Tela_Senha_Excluir()
        {
            InitializeComponent();
        }
        

        private void ConfirmarExclusao()
        {
            string prov_email;
            string prov_senha;
            prov_email = caixa_email.Text;
            prov_senha = caixa_senha.Text;
            if(prov_email == Login.email[Convert.ToInt32(Login.user)] && prov_senha == Login.senha[Convert.ToInt32(Login.user)])
            {
                MessageBox.Show("Senha Correta");
                Tela_Perfil novo = new Tela_Perfil();
                novo.ExcluirConta();
            }
            else
            {
                MessageBox.Show("Senha Incorreta ou E-mail Incorretos");
            }
        }

        private void caixa_text_Click(object sender, EventArgs e)
        {
            ConfirmarExclusao();
        }
    }
}
