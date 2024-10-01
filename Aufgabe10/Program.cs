using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aufgabe 10 : Durch Quersumme teilbare Zahlen");
            Console.WriteLine("**************************************************\n");

            Console.WriteLine("Zahl 1:");
            string num1 = Console.ReadLine();
            if (CouldTranslateToInt(num1))
            {
                int number1 = Convert.ToInt32(num1);
                Console.WriteLine("Zahl 2:");
                
                string num2 = Console.ReadLine();
                if (CouldTranslateToInt(num2))
                {
                    int number2 = Convert.ToInt32(num2);
                    number2++;
                    Console.WriteLine("\n");

                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("Zahl\t|Quersumme\t| Zahl / Quersumme");
                    Console.WriteLine("---------------------------------------------------");

                    if (number1 > number2)
                    {
                        Console.WriteLine("Zahl 2 muss kleiner als Zahl 1 sein");
                        Console.ReadKey();
                    }
                    for (int i = number1; i != number2; i++)
                    {
                        float number_3 = (float)i;
                        float quersumme = BerechneQuersumme(i);
                        float e = i / quersumme;
                        if (int.TryParse(Convert.ToString(e), out int n) == true)
                        {
                            Console.WriteLine(GetData(i, (int)quersumme, (int)e));
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Fehlerhafte Eingabe. Bitte nur ganze Zahlen eingeben");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Fehlerhafte Eingabe. Bitte nur ganze Zahlen eingeben");
                Console.ReadKey();
            }
        }
        static string GetData(int number, int quersumme, int qszl)
        {
            return $"{number}\t| {quersumme}\t\t| {qszl}";
        }
        static bool CouldTranslateToInt(string var)
        {
            return int.TryParse(var, out int e);
        }

        

        
        static int BerechneQuersumme(int zahl)
        {
            int sum = 0;
            if (zahl != 0)
            {
                while (zahl > 0)
                {
                    sum = sum + (zahl % 10);
                    zahl = zahl / 10;
                }
                return sum;
            }
            else
            {
                return sum;
            }
        }
    }
}