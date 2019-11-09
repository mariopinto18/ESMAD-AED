using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Capicua

            Console.Write("Insira um texto:");
            string text = Console.ReadLine();
            string text1 = "";
            for (int i =text.Length-1; i>=0 ; i--)
            {
                text1 += text[i];
            }
            if (text==text1)
            {
                Console.WriteLine("O texto {0} é capicua", text);
            }
            else
            {
                Console.WriteLine("O texto {0} não é capicua", text);
            }
            Console.ReadLine();
        }
    }
}
