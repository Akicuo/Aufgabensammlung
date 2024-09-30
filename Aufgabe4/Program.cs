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
                    if (n == 1)
                    {
                        return "Januar";
                    }
                    if (n == 2)
                    {
                        return "Februar";
                    }
                    if (n == 3)
                    {
                        return "März";
                    }
                    if (n == 4)
                    {
                        return "April";
                    }
                    if (n == 5)
                    {
                        return "Mai";
                    }
                    if (n == 6)
                    {
                        return "Juni";
                    }
                    if (n == 7)
                    {
                        return "Juli";
                    }
                    if (n == 8)
                    {
                        return "August";
                    }
                    if (n == 9)
                    {
                        return "September";
                    }
                    if (n == 10)
                    {
                        return "Oktober";
                    }
                    if (n == 11)
                    {
                        return "November";
                    }
                    if (n == 12)
                    {
                        return "Dezember";
                    }

                }
                
                
                return "OutOfRange";
                
                       
                        
            }

        }


    }
}
