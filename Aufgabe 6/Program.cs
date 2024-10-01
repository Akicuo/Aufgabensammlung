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
            for (int i =1; i != 11 ; i++)
            {
                for (int b = 0 + 1; b != 11; b++)
                {
                    int current_num = b * i;
                    Console.Write($"{current_num}\t");
                }
                Console.Write("\n");
                
            }

        }
    }
}
