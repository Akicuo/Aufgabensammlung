using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_18
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = FragenSpeichern("Bitte gib ein Geburtsdatum ein:");
            string[] array = new string[3];
            array[0] = input.Split('.')[0]; // day //
            array[1] = input.Split('.')[1]; // month //
            array[2] = input.Split('.')[2]; // year//

            DateTime when = new DateTime(int.Parse(array[2]), int.Parse(array[1]), int.Parse(array[0]), 0, 0, 0);
            TimeSpan ts = DateTime.Now.Subtract(when);
            
            Console.WriteLine("Alter in Jahren: {0}",
                Math.Floor((ts.TotalHours / 8760)));
            Console.WriteLine("Alter in Monaten: {0}",
                Math.Floor(ts.TotalHours * 0.001369));
            Console.WriteLine("Alter in Wochen: {0}",
                Math.Floor((ts.TotalHours / 168)));
            Console.WriteLine("Alter in Days: {0}",
                Math.Floor((ts.TotalDays)));
            
            Console.ReadKey();
        } 
        static string FragenSpeichern(string frage)
        {
            Console.Write(frage + " ");
            return Console.ReadLine();
        }
    }
}
