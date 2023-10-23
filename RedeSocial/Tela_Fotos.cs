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
    public partial class Tela_Fotos : Form
    {
        Random rnd = new Random();
        public Tela_Fotos()
        {
            InitializeComponent();
            MostrarFotos();
        }
        public void MostrarFotos()
        {
            
            int i;            
            string[] mostrarFotos = new string[50];

            for (i = 0; i < Login.contador_Postagens; i++) {
                if (Login.nomes[Convert.ToInt32(Login.user)] == Login.dono_postagem[i])
                {
                    mostrarFotos[i] = Login.foto_postagens[i];
                }
                        }     


            
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox1.ImageLocation = mostrarFotos[0];
                    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox2.ImageLocation = mostrarFotos[1];
                    pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox3.ImageLocation = mostrarFotos[2];
                    pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox4.ImageLocation = mostrarFotos[3];
                    pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox5.ImageLocation = mostrarFotos[4];
                    pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox6.ImageLocation = mostrarFotos[5];
                    pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox7.ImageLocation = mostrarFotos[6];
                    pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox8.ImageLocation = mostrarFotos[7];
                    pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox9.ImageLocation = mostrarFotos[8];
                    pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox10.ImageLocation = mostrarFotos[9];
                    pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox11.ImageLocation = mostrarFotos[10];
                    pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox12.ImageLocation = mostrarFotos[11];
                    pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox13.ImageLocation = mostrarFotos[12];
                    pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox14.ImageLocation = mostrarFotos[13];
                    pictureBox15.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox15.ImageLocation = mostrarFotos[14];
                    pictureBox16.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox16.ImageLocation = mostrarFotos[15];
                    pictureBox17.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox17.ImageLocation = mostrarFotos[16];
                    pictureBox18.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox18.ImageLocation = mostrarFotos[17];








        }
    }
}
