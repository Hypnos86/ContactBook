using System;
using System.Collections.Generic;
using System.Text;

namespace ContactBook
{
    class Repository
    {
        public static void AppWelcome()
        {
            Console.WriteLine("WITAJ W KSIĄŻCE KONTAKTÓW\n");
        }
        public static void AppMenu()
        {
            Console.WriteLine("--- MENU ---\n");
            Console.WriteLine("Wybierz opcję:\n");
            Console.WriteLine("1. Pokaż całą listę");
            Console.WriteLine("2. Dodaj nowy kontakt");
            Console.WriteLine("3. Szukaj kontaktu");
            Console.WriteLine("__________________\n");

            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("Nic nie wybrano");
                    break;

            }
        }
    }
}