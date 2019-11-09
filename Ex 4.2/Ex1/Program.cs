using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            // escrever uma frase e determinar nº de vogais e espaços
            int espacos = 0;
            int vogais = 0;
            
            Console.Write("Insira um texto:");
            string text = Console.ReadLine();
            for (int i=0; i< text.Length; i++)
            {
                if (text[i] ==' ')
                {
                    espacos++;
                }
                if ((text[i].ToString().ToUpper() == "A") ||
                   (text[i].ToString().ToUpper() == "E") ||
                   (text[i].ToString().ToUpper() == "I") ||
                   (text[i].ToString().ToUpper() == "O") ||
                   (text[i].ToString().ToUpper() == "U"))
                {
                    vogais++;
                }
            }
            Console.WriteLine("Nº de caracteres= {0}", text.Length);
            Console.WriteLine("Nº de espaços = {0}", espacos);
            Console.WriteLine("Nº de vogais = {0}", vogais);
            Console.ReadLine();
        }
    }
}
