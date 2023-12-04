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

    public partial class Tela_Perfil_Amigos : Form
    {
        public int cont;
        public static int contF = 1;
        public static int contI = 0;
        public int segue;
        Pessoa novo = new Pessoa();
        public static int prov;
        public Tela_Perfil_Amigos()
        {
            InitializeComponent();
            Label_id.Text = Convert.ToString(Login.amigo);
            Label_nome.Text = Login.nomes[Login.amigo];
            Label_data.Text = Login.data_nascimento[Login.amigo];
            Pic_amigo.SizeMode = PictureBoxSizeMode.Zoom;
            Pic_amigo.ImageLocation = Login.foto_perfil[Login.amigo];

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

        private void Tela_Perfil_Amigos_Load(object sender, EventArgs e)
        {

        }



        public void Amizade()
        {


            for (Login.cont_amigo_ini = 0; Login.cont_amigo_ini < Login.cont_amigo; Login.cont_amigo_ini++)
            {
                Login.amigo_geral[Login.cont_amigo] = Login.nomes[Login.amigo];
                Login.solicita_amigo[Login.cont_amigo] = Login.nomes[Convert.ToInt32(Login.user)];
                Login.confirmar_amigo_geral[Login.cont_amigo] = false;

            }
            MessageBox.Show("Convite eviado a:  " + Login.amigo_geral[Login.cont_amigo_ini] + " Esperando Confirmação: " + Login.confirmar_amigo_geral[Login.cont_amigo_ini]);
            Login.cont_amigo_ini++;
            Login.cont_amigo++;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Amizade();

        }


        private void label_nome_amigo_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Label_nome_Click(object sender, EventArgs e)
        {

        }

        private void Label_data_Click(object sender, EventArgs e)
        {

        }

        private void Label_comunidades_Click(object sender, EventArgs e)
        {
        }
        private void Label_id_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvarDescricao_Click(object sender, EventArgs e)
        {

        }

        private void Label_Descricao_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDescricao_user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
