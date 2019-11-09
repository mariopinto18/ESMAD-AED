using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ler texto e remover sequencias de 2 ou mais espaços

            Console.Write("Insira um texto:");
            string text = Console.ReadLine();
            
            for (int i =0; i<=text.Length-2; i++)
            {
               if ((text[i] == ' ') && (text [i+1] == ' '))
                {   // se encontrar 2 espaços seguidos
                    text = text.Remove(i, 1);
                    i--;  // porque o text passou a ter menos 1 caracter
                }
            }
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
