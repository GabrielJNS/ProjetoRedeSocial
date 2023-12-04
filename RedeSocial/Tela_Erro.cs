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
    public partial class Tela_Erro : Form
    {
        public Tela_Erro()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            InicializarBordasArredondadas();


        }

        public void InicializarBordasArredondadas()
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = 10;
                Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

                path.AddArc(rect.Left, rect.Top, radius * 2, radius * 2, 180, 90);
                path.AddArc(rect.Right - radius * 2, rect.Top, radius * 2, radius * 2, 270, 90);
                path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
                path.AddArc(rect.Left, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
                path.CloseFigure();

                this.Region = new Region(path);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Tela_Erro_Load(object sender, EventArgs e)
        {

        }
    }
}
