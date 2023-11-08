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
        
        public static string[] adim_comunidade = new string[50];
        public static string[] nome_comunidades = new string[50];
        public static string[] descricao_comunidades = new string[50];
        public static string[] foto_comunidades = new string[50];
        public static string[] integrantes_comunidade = new string[50];
        public static string[] qual_comunidade = new string[50];
        public static bool[] pertence_comunidade = new bool[50];
        public static int contador_de_comunidades = 0;
        public static string a, b, d, c;
        
        

        public Comunidade()
        {

        }
        public void Criar_Comunidade(string nome, string descricao, string adim, string foto)
        {
            a = nome;
            b = descricao;
            c = adim;
            d = foto;
            
            

            
             
                    adim_comunidade[contador_de_comunidades] = c;
                    nome_comunidades[contador_de_comunidades] = a;
                    descricao_comunidades[contador_de_comunidades] = b;
                    foto_comunidades[contador_de_comunidades] = d;
                    MessageBox.Show("Comunidade Cadastrada " + nome_comunidades[contador_de_comunidades] + " Usuário Administrador: " + adim_comunidade[contador_de_comunidades] + " Posição do Vetor: " + contador_de_comunidades);
                   

      
                
            
          

        }

        
    }
    
    
}
