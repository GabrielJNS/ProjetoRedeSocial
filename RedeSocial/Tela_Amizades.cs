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
    public partial class Tela_Amizades : Form
    {
        public static int pegaValor = 0;
        public static int pegaValor1 = 0;
        public static int pegaValor2 = 0;
        public Tela_Amizades()
        {
            InitializeComponent();
            ConfirmarAmizade();
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
        public void ConfirmarAmizade()
        {

            Random rnd = new Random();
            int prov, prov1, prov2;
            prov = prov1 = prov2 = Login.cont_amigo;            
            prov = rnd.Next(prov);
            prov1 = rnd.Next(prov1);
            prov2= rnd.Next(prov2);
            if(prov < prov1)
            {
                prov = prov1;
            }
            else if (prov < prov2)
            {
                prov = prov2;
            }
            else
            {
                prov1 = prov2;
            }
            
            
           
            
            {
                if (Login.amigo_geral[prov] == Login.nomes[Convert.ToInt32(Login.user)] && Login.confirmar_amigo_geral[prov] == false)
                {
                    //primeira fila                    
                    for (int i = 0; i < Login.n; i++)
                    {
                        if (Login.solicita_amigo[prov] == Login.nomes[i])
                        {
                            pic_solicita1.ImageLocation = Login.foto_perfil[i];
                        }
                    }
                    label2.Text = Login.solicita_amigo[prov];
                    pegaValor = prov;
                }
                else
                {
                    button1.Hide();
                    button2.Hide();
                    label14.Hide();
                    label2.Hide();
                    pic_solicita1.Hide();
                }
                
            }
            {
                if (Login.amigo_geral[prov1] == Login.nomes[Convert.ToInt32(Login.user)] && Login.confirmar_amigo_geral[prov1] == false && Login.amigo_geral[prov1] != Login.amigo_geral[prov])
                {
                    //segunda fila                    
                    for (int i = 0; i < Login.n; i++)
                    {
                        if (Login.solicita_amigo[prov1] == Login.nomes[i])
                        {
                            pic_solicita2.ImageLocation = Login.foto_perfil[i];
                        }
                    }
                    label5.Text = Login.solicita_amigo[prov1];
                    pegaValor1 = prov1;
                }
                else
                {
                    button4.Hide();
                    button3.Hide();
                    label15.Hide();
                    label5.Hide();
                    pic_solicita2.Hide();
                }
            }
            {
               if (Login.amigo_geral[prov2] == Login.nomes[Convert.ToInt32(Login.user)] && Login.confirmar_amigo_geral[prov2] == false && Login.amigo_geral[prov2] != Login.amigo_geral[prov] && Login.amigo_geral[prov2] != Login.amigo_geral[prov1])
                {
                    //terceira fila                    
                    for (int i = 0; i < Login.n; i++)
                    {
                        if (Login.solicita_amigo[prov2] == Login.nomes[i])
                        {
                            pic_solicita3.ImageLocation = Login.foto_perfil[i];
                        }
                   }
                   label7.Text = Login.solicita_amigo[prov2];
                    pegaValor2 = prov2;

                }
                else
                {
                    button6.Hide();
                    button5.Hide();
                    label16.Hide();
                    label7.Hide();
                    pic_solicita3.Hide();
                }

            }
        }
        public static void VirarAmigos()
        {
            if(Login.amigo_geral[Login.conta_seus_amigos] == Login.nomes[Convert.ToInt32(Login.user)])
            {

                Login.seusAmigos[Login.conta_seus_amigos] = Login.solicita_amigo[pegaValor];
                Login.confirmar_amigo_geral[Login.conta_seus_amigos] = true;
                Login.conta_seus_amigos++;
                
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VirarAmigos();
            MessageBox.Show("Vocês São Amigos "+ Login.conta_seus_amigos);            
            this.Close();
            Tela_Principal novo = new Tela_Principal();
            novo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VirarAmigos();
            MessageBox.Show("Vocês São Amigos " + Login.conta_seus_amigos);
            this.Close();
            Tela_Principal novo = new Tela_Principal();
            novo.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            VirarAmigos();
            MessageBox.Show("Vocês São Amigos " + Login.conta_seus_amigos);
            this.Close();
            Tela_Principal novo = new Tela_Principal();
            novo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NaoAmigos();
        }
        public void NaoAmigos()
        {
            if (Login.amigo_geral[Login.conta_seus_amigos] == Login.nomes[Convert.ToInt32(Login.user)])
            {

                Login.amigo_geral[pegaValor] = "";
                Login.confirmar_amigo_geral[Login.conta_seus_amigos] = false;               
                MessageBox.Show("Não São amigos");
                if(Login.amigo_geral[pegaValor] == "")
                {
                    button1.Hide();
                    button2.Hide();
                    label14.Hide();
                    label2.Hide();
                    pic_solicita3.Hide();
                    pic_solicita1.Hide();
                }
            }
        }

        private void Tela_Amizades_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
