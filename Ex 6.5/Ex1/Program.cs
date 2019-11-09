using System;
using System.Linq;

namespace Ex1
{
    class Program
    {

       
        // Determinar se um valor de pesquisa existe num array
      
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            
            for (int i=0; i<10; i++) // ler array
            {
                Console.Write("Número: ");
                numeros[i] = Convert.ToInt16(Console.ReadLine());
            }

            Console.Write("Valor de pesquisa: ");    // ler valor de pesquisa
            int pesquisa = Convert.ToInt16(Console.ReadLine());

            int cont = 0;
            string posicoes = "";
            for (int i = 0; i < 10; i++) // comprarar pesquisa com array
            {
               if (pesquisa == numeros[i])
                {
                    cont++;
                    posicoes += " " + (i+1);
                }
            }
                                      
            if (cont ==0)
            {
                Console.WriteLine("O valor {0} não existe no array", pesquisa);
            }
            else
            {
                Console.WriteLine("O valor {0} ocorre {1} vezes, nas posições {2}",
                    pesquisa, cont, posicoes);
            }

            Console.ReadLine();

        }

    }
}
