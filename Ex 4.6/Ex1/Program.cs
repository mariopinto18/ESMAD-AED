using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ler um nome e imprime nome normalizado / abreviado

            Console.Write("Insira um nome:");
            string name = Console.ReadLine();
            // primeiro nome
            int pos = name.IndexOf(" ");
            string name_abr = name.Substring(0, pos);
            
            // iniciais dos restantes nomes
            for (int i =pos; i<name.LastIndexOf(" "); i++)
            {
                if (name[i] == ' ')
                {
                    name_abr = name_abr + " " + name[i + 1] + ".";
                }
            }
            // ultimo nome
            pos = name.LastIndexOf(" ");
            string last_name = name.Substring(pos+1, name.Length- pos-1);
            name_abr = name_abr + " " + last_name;

            Console.WriteLine("Nome Abreviado: {0}", name_abr);
            Console.ReadLine();
        }
    }
}
