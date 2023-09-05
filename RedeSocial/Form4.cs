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
    public partial class Tela_Cadastro : Form
    {
        int i;
        int j = 0;
        int n = 1;

        public Tela_Cadastro()
        {
            InitializeComponent();
        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            for (i = j; i < n; i++)
            {
                Login.nomes [i] = caixa_nome.Text;
                Login.senha [i] = caixa_senha.Text;


            }
            j++;
            n++;

        }
    }
}
