using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aufgabe 4 : Monatsnamen");
            Console.WriteLine("**************************************************\n\n");
            Console.Write("Monat: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int num) == true)
            {
                Console.WriteLine("Monat: {0}", GetMonth(num));
            }
            else
            {
                Console.WriteLine("Eingabefehler. Bitte geben Sie eine Ganzzahl ein von 1 bis und mit 12.");
                Console.ReadKey();
            }

            string GetMonth(int n)
            {
                if (n > 0 && n < 13)
                {

                    string[] months = {"Januar", "Februar", "März", "April", "Mai", "Juni", "Juli", "August", "September", "Oktober", "November", "Dezember"}
                    
                    return months[n+1];

                }
                
                
                return "OutOfRange";
                
                       
                        
            }

        }


    }
}
