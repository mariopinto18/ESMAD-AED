using System;
using System.Linq;

namespace Ex1
{
    class Program
    {
        static int[] fila = new int[20] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        static int number = 1;

        static void tirar_ticket()
        {
            int i = 0;
            while (fila[i] !=0) 
            {
                i++;
                if (i == 20)
                    break;
            }
            if (i==20)
            {
                Console.SetCursorPosition(20, 17);
                Console.WriteLine("Fila lotada. Pf Aguarde");
            }
            else
            {
                fila[i] = number;
                Console.SetCursorPosition(20, 17);
                Console.WriteLine("Sai a senha número {0}", number);
                number++;
            }
          
            Console.ReadLine();
        }


        static void atendimento()
        {
            if (fila[0]==0)
            {
                Console.SetCursorPosition(20, 17);
                Console.WriteLine("Não há senhas para atender :-)");
            }
            else
            {
                Console.SetCursorPosition(20, 17);
                Console.WriteLine("Atendimento: senha {0}", fila[0]);
                int i = 1;
                while (fila[i] != 0)
                {
                    fila[i - 1] = fila[i];
                    i++;
                }
                fila[i-1] = 0;   // posição livre na fila de 20 posições
            }

            Console.ReadLine();
        }

        static void estado()
        {
            Console.SetCursorPosition(20, 17);
            for (int i=0; i<20; i++)
            {
                Console.Write(fila[i] + "\t");
            }
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
