using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aufgabe 2 : Anzahl Sekuden eines Monates berechnen");
            Console.WriteLine("**************************************************\n\n");
            Console.WriteLine("Wie viele Tage hat der Monat, für den Sie die Sekundenzahl berechnen wollen?");
            string input = Console.ReadLine();
   
            if (int.TryParse(input, out int AmountOfDays) == true)
            {
                Console.WriteLine("Ein Monat mit {0} Tagen hat {1} Sekunden.", AmountOfDays, GetSeconds(AmountOfDays));
            }
            else
            {
                Console.WriteLine("Eingabefehler. Bitte geben Sie eine Ganzzahl ein.");
                Console.ReadKey();
            }
            
            int GetSeconds(int days)
            {
                days = (days * 24) * 60 * 60;
                return days;
            }

        }
        

    }
}
