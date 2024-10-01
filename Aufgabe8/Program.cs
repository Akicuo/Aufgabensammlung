using System;

namespace Aufgabe8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aufgabe 7 : Eine Ganzzahl binär darstellen");
            Console.WriteLine("**************************************************\n");

            while (true)
            {
                Console.WriteLine("Ganze Dezimalzahl eingeben (q to Quit):");
                string input = Console.ReadLine();

                if (input == "q")
                {
                    break; 
                }

                if (int.TryParse(input, out int num)) 
                {
                    string bin = "";
                    int wert = num;

                    while (wert > 0)
                    {
                        int rest = wert % 2;
                        bin = rest + bin;
                        wert = wert/2;
                    }

                    Console.WriteLine($"Binäre Darstellung: {bin}\n");
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe, bitte eine gültige Ganzzahl eingeben.");
                }
            }
        }
    }
}
