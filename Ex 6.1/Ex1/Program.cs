using System;
using System.Linq;

namespace Ex1
{
    class Program
    {
               
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            for (int i=0; i<10; i++)
            {
                Console.Write("Número: ");
                numeros[i] = Convert.ToInt16(Console.ReadLine());
            }
            double media = numeros.Average();
            int cont = 0;
            foreach (int num in numeros)
            {
                if (num > media)
                {
                    cont++;
                }
            }
            Console.WriteLine("Existem {0} números acima da média", cont);
            Console.ReadLine();

        }

    }
}
