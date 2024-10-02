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

             Random rnd = new Random(); // Von Stackoverflow.com //
            int randint = rnd.Next(1, 101); // Von Stackoverflow.com //

            int versuche = 0;

            bool guessed = false;

            while (guessed == false)
            {
                if (int.TryParse(FragenSpeichern("Zahl [1-100]: "), out int num))
                {
                    versuche++;
                    if (num == randint)
                    {
                        Console.Write("Zahl ist richtig! Du hast {0} Versuche benötigt.", versuche);

                        guessed = true;

                        if (char.TryParse(FragenSpeichern("Noch einmal spielen?"), out char decision))
                        {
                            if (decision == 'y' || decision == 'Y')
                            {
                                guessed = false;
                                randint = rnd.Next(1, 101);
                            }
                            else if (decision == 'n' || decision == 'N')
                            {
                                guessed = true;
                                Console.ReadKey();
                            }
                            else
                            {
                                guessed = true;
                                Console.WriteLine("EingabeFehler: Program hört auf");
                                Console.ReadKey();
                                

                            }


                        }
                        else
                        {
                            Console.WriteLine("\nEingabefehler: Es wird nur Y/y oder N/n akzeptiert");
                        }
                    }
                    else if (num < randint)
                    {
                        Console.WriteLine("Zahl ist zu klein! Nachster Versuch:\n");
                    }
                    else if (num > randint)
                    {
                        Console.WriteLine("Zahl ist zu gross! Nachster Versuch:\n");
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
