using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aufgabe 6 : Kleines 1x1");
            Console.WriteLine("**************************************************\n");
            int current_row = 0; int current_column = 0;
            int f = 10;
            for (int i =current_column; i != f; i++)
            {
                for (int b = current_column; b != f; b++)
                {
                    Console.Write($"{b}\t");
                }
                Console.Write("\n");
                // noch nicht fertig //
                // noch nicht fertig //
            }

        }
    }
}
