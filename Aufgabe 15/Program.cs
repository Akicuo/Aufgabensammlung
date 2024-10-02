using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aufgabe 15: Zahlen raten");
            Console.WriteLine(new string('*', 24));

             Random rnd = new Random();
            int randint = rnd.Next(1, 101);

            bool guessed = false;

            while (guessed == false)
            {
                if (int.TryParse(FragenSpeichern("Zahl: "), out int num))
                {
                    if (num == randint)
                    {
                        Console.WriteLine("Diese Zahl ist richtig!");
                        guessed = true;
                    }
                    else if (num < randint)
                    {
                        Console.WriteLine("Die zahl ist grösser!\n");
                    }
                    else if (num > randint)
                    {
                        Console.WriteLine("Die zahl ist kleiner!\n");
                    }
                }
                else
                {
                    Console.WriteLine("Eingabefehler: Bitte nur ganze Zahlen eingeben\n");
                }
            }
        }
        static string FragenSpeichern(string frage)
        {
            Console.Write(frage + " ");
            return Console.ReadLine();
        }
    }
}
