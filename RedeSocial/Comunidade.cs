using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedeSocial
{
    class Comunidade
    {
        public static int[] ID_Pessoas_Comunidades = new int[50];
        public static string[] nome_comunidades = new string[50];
        public static string[] descricao_comunidades = new string[50];
        public static string[] foto_comunidades = new string[50];
        public static string a, b, d;
        public static int c;
        

        public Comunidade()
        {

        }
        public void Criar_Comunidade(string nome, string descricao, int ID, string foto)
        {
            a = nome;
            b = descricao;
            c = ID;
            d = foto;
            int Inic = 1;
            int fin = 1;
            int i = 1;

            
             
                    ID_Pessoas_Comunidades[0] = c;
                    nome_comunidades[0] = a;
                    descricao_comunidades[0] = b;
                    foto_comunidades[0] = d;
                    MessageBox.Show("Comunidade Cadastrada " + nome_comunidades[i] + " Usuário Administrador: " + ID_Pessoas_Comunidades[i] + " Posição do Vetor: " + i);
                   

      
                
            
          

        }

        
    }
    
    
}
