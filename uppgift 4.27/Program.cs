using System;
using System.Globalization;

namespace Uppgift_4_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett meddelande");
            string meddelande = Console.ReadLine();
            Console.WriteLine("Skriv nu in ett tal så många steg åt höger meddelandet ska stå");
            int steg = int.Parse(Console.ReadLine());


            for(int i = 0; i < meddelande.Length; i++)
            {

                for(int j = 0; j < steg; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(meddelande[i]);
            }

        }
    }
}
