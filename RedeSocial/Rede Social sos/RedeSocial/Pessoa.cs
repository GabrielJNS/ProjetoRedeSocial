using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace RedeSocial
{

    class Pessoa
    {
        public int[] seguir_amigos = new int[50];
       


        public int Seguir(int a, int cont)
        {

            int i = cont;  
          seguir_amigos[i] = Login.amigo;            
                       
          MessageBox.Show("Vetor do Usuário "+ a +" Posição no Vetor " + i + " Amigo Cadastrado " + seguir_amigos[i]);
            
            return seguir_amigos[i]; 

        }
        
        public void Teste_Vetor(int a)
        {
            for(int k = 0; k<10; k++)
            {
                Console.WriteLine("Vetor do Usuário " + a + " Posição no Vetor " + k + " Amigo Cadastrado " + seguir_amigos[k]);
            }
        }
    }



}







