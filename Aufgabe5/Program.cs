using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aufgabe 5 : Flussdiagramm implementieren (2)");
            Console.WriteLine("**************************************************\n");

            Console.WriteLine("Wie viele Kilometer möchtest du rennen?");
            string input1 = Console.ReadLine();
            if (int.TryParse(input1, out int result))
            {
                if (result > 42)
                {
                    Console.WriteLine("Das schaffst du nicht!");
                    Console.ReadKey();
                }
                float rounds = ((float)result * 1000) / 400;
                Console.WriteLine("Das sind {0} Runden. Bereit für den Lauf? [y/n]", rounds);
                string input2 = Console.ReadLine();
                if (char.TryParse(input2, out char answer) == true)
                {
                    if (answer == 'y' || answer == 'Y')
                    {
                        for (int i = 1; i <= rounds; i++)
                        {
                            Console.WriteLine("Du läufst Runde {0}", i);

                        }
                        Console.WriteLine("Du hast es geschaft!");
                        Console.ReadKey();
                    }
                    else if (answer == 'n' || answer == 'N')
                    {
                        Console.WriteLine("Du hast es geschaft!");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Eingabefehler: Sollte nur y oder n sein.");
                        Console.ReadKey();
                    }


                }
            }


        }
    }
}
