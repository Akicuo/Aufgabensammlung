using System;

namespace Aufgabe_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aufgabe 13 : Schaltjahr");
            Console.WriteLine("**************************************************\n");

            Console.Write("Jahr eingeben: ");
            if (int.TryParse(Console.ReadLine(), out int jahr))
            {
                bool isLeapYear = (jahr % 4 == 0 && jahr % 100 != 0) || (jahr % 400 == 0);

                if (isLeapYear)
                {
                    Console.WriteLine("Das ist ein Schaltjahr.");
                }
                else
                {
                    Console.WriteLine("Das ist kein Schaltjahr.");
                }
            }
            else
            {
                Console.WriteLine("Das ist kein Jahr (Eingabefehler)");
            }
        }
    }
}
