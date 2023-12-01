
using System;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace RedeSocial
{
    public partial class Tela_RecSenha : Form
    {
        private int codigoGerado;

        public Tela_RecSenha(int codigoGerado)
        {
            InitializeComponent();
            this.codigoGerado = codigoGerado;
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

        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

