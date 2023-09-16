using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedeSocial
{
    class Pessoa
    {
        public int cont_ami;
        public int amig_atual = 0;
        public int amig_fut = 1;
        public string[] lista_amigos = new string[50]; 
        public static void Seguir(Pessoa p)
        {
            for (Login.cont_ami = p.amig_atual; p.cont_ami < p.amig_fut; p.cont_ami++)
            {
                p.lista_amigos[Convert.ToInt32(Login.user)] = Login.nomes[Login.amigo];
                
            }
            p.amig_atual++;
            p.amig_fut++;
            
        }
    }
    
   
}