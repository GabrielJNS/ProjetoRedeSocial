using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace RedeSocial
{
    public partial class Tela_Alterar : Form
    {
        string nome, data, email, senha, confirmarsenha;

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Tela_Alterar_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Tela_Alterar()
        {
            InitializeComponent();
            textBox_Nome_Alterar.Text = Login.nomes[Convert.ToInt32(Login.user)];
            textBox_Email_alterar.Text = Login.email[Convert.ToInt32(Login.user)];
            textBox_data_alterar.Text = Login.data_nascimento[Convert.ToInt32(Login.user)];

            this.FormBorderStyle = FormBorderStyle.None;
            InicializarBordasArredondadas();





        }

        public void InicializarBordasArredondadas()
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = 30;
                Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

                path.AddArc(rect.Left, rect.Top, radius * 2, radius * 2, 180, 90);
                path.AddArc(rect.Right - radius * 2, rect.Top, radius * 2, radius * 2, 270, 90);
                path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
                path.AddArc(rect.Left, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
                path.CloseFigure();

                this.Region = new Region(path);
            }
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
