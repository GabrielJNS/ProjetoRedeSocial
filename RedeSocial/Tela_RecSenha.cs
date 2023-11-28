
using System;
using System.Windows.Forms;

namespace RedeSocial
{
    public partial class Tela_RecSenha : Form
    {
        private int codigoGerado;

        public Tela_RecSenha(int codigoGerado)
        {
            InitializeComponent();
            this.codigoGerado = codigoGerado;
        }

        public bool CodigoConfirmado { get; internal set; }

        private void buttonVerificar_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (int.TryParse(CodRec.Text, out int codigoDigitado))
                {

                    if (codigoDigitado == codigoGerado)
                    {
                        MessageBox.Show("Código correto. A recuperação foi bem-sucedida!");
                        CodigoConfirmado = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Código incorreto. Tente novamente.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, insira um código válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }
        private void CodRec_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tela_RecSenha_Load(object sender, EventArgs e)
        {

        }
    }
}

