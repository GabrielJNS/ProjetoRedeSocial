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

    public partial class Tela_Mostrar_Comunidade : Form
    {
        public int UsuarioID { get; set; }

        public Tela_Mostrar_Comunidade()
        {
            InitializeComponent();
        }
        private void ExemploMetodo()
        {
            int idUsuario = this.UsuarioID;
        }
            private void Tela_Mostrar_Comunidade_Load(object sender, EventArgs e)
        {
          

            listBoxComunidades.Items.Clear();

            int suaIDDeUsuario = this.UsuarioID;

            for (int i = 0; i < Comunidade.ID_Pessoas_Comunidades.Length; i++)
            {
                if (Comunidade.ID_Pessoas_Comunidades[i] == suaIDDeUsuario)
                {
                    listBoxComunidades.Items.Add("Minha Comunidade: " + Comunidade.nome_comunidades[i]);
                }
                else
                {
                    listBoxComunidades.Items.Add("Outras Comunidades: " + Comunidade.nome_comunidades[i]);
                }
            }
        }

        private void btMinhaComunidade_Click(object sender, EventArgs e)
        {
            listBoxComunidades.Items.Clear();
            int suaIDDeUsuario = this.UsuarioID;

            for (int i = 0; i < Comunidade.ID_Pessoas_Comunidades.Length; i++)
            {
                if (Comunidade.ID_Pessoas_Comunidades[i] == suaIDDeUsuario)
                {
                    listBoxComunidades.Items.Add("Minha Comunidade: " + Comunidade.nome_comunidades[i]);
                }
            }
        }

        private void btOutrasComunidades_Click(object sender, EventArgs e)
        {
            listBoxComunidades.Items.Clear();
            int suaIDDeUsuario = this.UsuarioID;

            for (int i = 0; i < Comunidade.ID_Pessoas_Comunidades.Length; i++)
            {
                if (Comunidade.ID_Pessoas_Comunidades[i] != suaIDDeUsuario)
                {
                    listBoxComunidades.Items.Add("Outras Comunidades: " + Comunidade.nome_comunidades[i]);
                }
            }
        }

        private void btMinhaComunidade_Click_1(object sender, EventArgs e)
        {

        }
    }
}
