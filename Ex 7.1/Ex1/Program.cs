using System;
using System.Linq;

namespace Ex1
{
    class Program
    {
               
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];  // declara matriz 3x3
            for (int i=0; i<3; i++)          // lê as linhas / colunas da matriz
            {
                for (int j=0; j<3; j++)
                {
                    Console.Write("linha {0}, Coluna {1}  ->", i+1, j+1);
                    matriz[i, j] = Convert.ToInt16(Console.ReadLine());
                }

            }
            // Matriz Original
            Console.Clear();
            Console.SetCursorPosition(10, 4);
            Console.WriteLine("Matriz Original:");

            Console.SetCursorPosition(40, 4);
            Console.WriteLine("Matriz Transposta:");

            for (int i = 0; i < 3; i++)          // lê as linhas / colunas da matriz
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition(10 + j * 5, i+10);  // IMPRIME MATRIZ INICIAL
                    Console.WriteLine(matriz[i, j]);
                    // IMPRIME TRANSPOSTA
                    Console.SetCursorPosition(40 + j * 5, i + 10);
                    Console.WriteLine(matriz[j, i]);
                }

            }
            Console.ReadLine();


        }

    }
}
