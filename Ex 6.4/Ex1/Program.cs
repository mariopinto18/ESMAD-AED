using System;
using System.Linq;

namespace Ex1
{
    class Program
    {

        static int[] faturacao = new int[12];

        static int maior_faturacao()
        {
            int maior = faturacao.Max();
            int pos = Array.IndexOf(faturacao, maior);
            return pos;
        }

        static int menor_faturacao()
        {
            int menor = faturacao.Min();
            int pos = Array.IndexOf(faturacao, menor);
            return pos;
        }

        // ler faturacao ao longo dos 12 meses e determinar
        // mês de maior e de menor faturacao
        static void Main(string[] args)
        {
            string[] meses = new string[12] {"Janeiro", "Fevereiro", "Março", "Abril", "Maio",
            "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"};

            Console.Title = "Faturação Mensal";
          
            for (int i = 0; i < 12; i++)
            {   // ler faturacao ao longo dos 12 meses
                Console.SetCursorPosition(10, i + 3);
                Console.Write("Faturação no mês de {0}: ", meses[i]);
                Console.SetCursorPosition(45, i + 3);
                faturacao[i] = Convert.ToInt16(Console.ReadLine());
            }

            int mes_maior = maior_faturacao();
            int mes_menor = menor_faturacao();

            // Imprimir  resultados
            Console.SetCursorPosition(10, 20);
            Console.WriteLine("Mês de maior faturacao  : {0}", meses[mes_maior]);
            Console.SetCursorPosition(10, 21);
            Console.WriteLine("Mês de menor faturacao  : {0}", meses[mes_menor]);
            Console.SetCursorPosition(10, 22);
            Console.WriteLine("Valor média de faturação: {0}", faturacao.Average());


            Console.ReadLine();

        }

    }
}
