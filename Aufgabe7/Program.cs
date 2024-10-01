using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aufgabe 7 :  Durch 3 oder 5 teilbare Zahlen");
            Console.WriteLine("**************************************************\n");

            Console.WriteLine("Zahlen die durch 30 teilbar 5 oder und 3 teilbar ohne Rest sind");
            Console.WriteLine(DivisableByThreeOrFive()); 
        }
        static string DivisableByThreeOrFive()
        {
            string tk = "";
            for (float i = 1; i != 31; i++)
            { 
                float rest_3 = i - i / 3;
                float rest_5 = i - i / 5;

                if (int.TryParse(Convert.ToString(rest_3), out int n) == true)
                {
                    tk += $"{i}, ";
                }
                else if (int.TryParse(Convert.ToString(rest_5), out int e) == true)
                {
                    tk += $"{i}, ";
                }
            }
            
            return tk.Replace("30, ", "30");
        }

    }

}
