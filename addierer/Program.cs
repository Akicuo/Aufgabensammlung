using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addierer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aufgabe 01 Addierer");
            Console.WriteLine("***************************************");

            Console.Write("Zahl 1: ");
            int zahl1 = int.Parse(Console.ReadLine());

            Console.Write("Zahl 2: ");
            int zahl2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Die Summe ist {0}", BerechneSumme(zahl1, zahl2));
            int BerechneSumme(int zawhl1, int zwahl2)
            {
                return (zawhl1 + zwahl2);
        }


        }
        
    }
}
