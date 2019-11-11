using System;
using System.Linq;

namespace Ex1
{
    class Program
    {
        static int dim=0;   

        static int[,] inicializar_matriz(int [,] matriz)
        {
            Random rnd = new Random();
            for (int i=0; i<dim; i++)
            {
                for (int j=0; j<dim; j++)
                {
                    matriz[i, j] = rnd.Next(0, 20);
                    Console.SetCursorPosition(40 + j * 4, 10+ i * 2);
                    Console.WriteLine(matriz[i, j]);
                }
            }
            Console.ReadLine();
            return matriz;
        }

        static int[,] transposta(int[,] matriz)
        {
            
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                   
                    Console.SetCursorPosition(40 + j * 4, 10 + i * 2);
                    Console.WriteLine(matriz[j, i]);
                }
            }
            Console.ReadLine();
            return matriz;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Dimensão da matriz: ");
            dim = Convert.ToInt16(Console.ReadLine()); // pedir dimensão da matriz
            int[,] matriz = new int[dim, dim];  // declara matriz 
            char op = ' ';
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Inicializar matriz");
                Console.WriteLine("2 - Transposta");
                Console.WriteLine("3 - Maior valor");
                Console.WriteLine("4 - Sair");
                Console.WriteLine("     Opção:");
                op = Convert.ToChar(Console.ReadLine());
                switch (op)
                {
                    case '1':
                        matriz = inicializar_matriz(matriz);
                        break;
                    case '2':
                        matriz = transposta(matriz);
                        break;
                }
            }
            while (op != '4');
        }

    }
}
