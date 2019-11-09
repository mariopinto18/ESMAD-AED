using System;
using System.Linq;

namespace Ex1
{
    class Program
    {
               
        static void Main(string[] args)
        {
            int[] pontuacao = new int[10];
            int[] positivas = new int[0]; // array com pontuações positivas
            int j = 0;
            for (int i=0; i<10; i++)
            {
                Console.Write("Pontuação: ");
                pontuacao[i] = Convert.ToInt16(Console.ReadLine());
                if (pontuacao[i] >=10)
                {
                    j++;
                    Array.Resize(ref positivas, j); // redimensiona array antes de 
                    positivas[j-1] = pontuacao[i];       // acrescentar dados
                  
                 
                }
            }

            for(int i = 0; i<j; i++)
            {
                Console.Write(positivas[i] + "\t");
            }
         
            Console.ReadLine();

        }

    }
}
