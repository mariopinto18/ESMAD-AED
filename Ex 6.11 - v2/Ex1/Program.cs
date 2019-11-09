using System;
using System.Linq;
using System.Collections;

namespace Ex1
{
    class Program
    {
        static Queue fila = new Queue();
        static int number = 1;

        static void tirar_ticket()
        {
            fila.Enqueue(number);
            Console.SetCursorPosition(20, 17);
            Console.WriteLine("Sai a senha nº {0}", number);
            number++;

            Console.ReadLine();
        }


        static void atendimento()
        {
            if (fila.Count == 0)
            {
                Console.SetCursorPosition(20, 17);
                Console.WriteLine("Não há senhas pata atender");
            }
            else
            {
                Console.SetCursorPosition(20, 17);
                Console.WriteLine("Atendida a senha nº {0}", fila.Dequeue());
            }

            Console.ReadLine();
        }


        static void estado()
        {
            Console.SetCursorPosition(20, 17);
            Console.WriteLine("Estem {0} senhas por atender!!!", fila.Count);
            /*foreach(Object ticket in fila)
            {
                Console.Write(ticket + "\t");
            }*/
            Console.ReadLine();
        }




        // Gerir fila de espera com 20 tickets no máximo
        static void Main(string[] args)
        {


            Console.Title = "Gerir Fila | Tickets";
            
            // MENU
            char op = ' ';
            do
            {
                Console.Clear();
                Console.SetCursorPosition(13, 5);
                Console.WriteLine("MENU");
                Console.SetCursorPosition(10, 6);
                Console.WriteLine("1 - Tirar Ticket");
                Console.SetCursorPosition(10, 7);
                Console.WriteLine("2 - Atendimento");
                Console.SetCursorPosition(10, 8);
                Console.WriteLine("3 - Estado");
                Console.SetCursorPosition(10, 9);
                Console.WriteLine("0 - Sair");
                Console.SetCursorPosition(13, 10);
                Console.Write("Opção: ");
                op = Convert.ToChar(Console.ReadLine());
                switch (op)
                {
                    case '1':
                        tirar_ticket();
                        break;
                    case '2':
                        atendimento();
                        break;
                    case '3':
                        estado();
                        break;

                }
            }
            while (op != '0');

        }

    }
}
