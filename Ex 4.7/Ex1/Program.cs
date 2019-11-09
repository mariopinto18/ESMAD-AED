using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            // lerum texto e determinar as ocorrências de uma keyword de pesquisa nesse mesmo texto


            Console.SetCursorPosition(5, 5);   // Texto a inserir
            Console.Write("Insira o texto:");
            string text = Console.ReadLine();

            Console.SetCursorPosition(5, 7);  // keyword de pesquisa
            Console.Write("Pesquisar     :");
            string keyword = Console.ReadLine();

            int cont = 0;   // contador de ocorrencias
            string positions = "";
            int caract_removed = 0;    // posições removidas no texto inicial

            bool fim = false;
            while (fim != true)
            {
                int pos = text.IndexOf(keyword);
                if (pos == -1)   // se não encontra a keyword de pesquisa no texto
                {
                    fim = true;
                    continue;
                }
                else
                {
                    if ((pos == 0) || ((pos != 0) && text[pos-1] == ' '))
                    {
                        positions += (pos + 1 + caract_removed) + " ";
                        cont++;
                    }
                    text = text.Remove(pos, keyword.Length);  // sp que encontra uma ocorrenca remove
                    caract_removed += keyword.Length;
                }
            }
            Console.SetCursorPosition(5, 9);
            Console.WriteLine("Nº de ocorrências: {0}", cont);

            Console.SetCursorPosition(5, 11);
            Console.WriteLine("Posições no texto {0}", positions);

            Console.ReadLine();
        }
    }
}
