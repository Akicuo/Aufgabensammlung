using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aufgabe 11 : Eine diagonale Linie zeichnen");
            Console.WriteLine("**************************************************\n");

            Console.WriteLine("Wie lang soll die Linie sein?");
            int n = int.Parse(Console.ReadLine());

            int columns = n;
            int row_length = columns;
            for (int a = 0; a < columns; a++)
            {
                for (int i = 0; i < row_length; i++)
                {
                    if (i != a)
                    { 
                    Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }

                }
                Console.Write("\n");
            }

        }
        
    }
}
