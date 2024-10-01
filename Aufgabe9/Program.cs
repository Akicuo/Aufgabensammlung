using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aufgabe 9 : Quersumme berechnen");
            Console.WriteLine("**************************************************\n");

            Console.WriteLine("Geben Sie eine Ganzzahl ein");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int num))
            {
                Console.WriteLine($"Die Quersumme ist {BerechneQuersumme(num)}");
            }
            else
            {
                Console.WriteLine("Eingabefehler: Sollte nur eine ganze Zahl sein.");
            }

            }
        static int BerechneQuersumme(int zahl)
        {
            int sum = 0;
            if (zahl != 0)
            {
                while (zahl > 0)
                {
                    sum = sum + (zahl % 10);
                    zahl = zahl / 10;
                }
                return sum;
            }
            else
            {
                return sum;
            }
            return 0;
        }
    }
}
