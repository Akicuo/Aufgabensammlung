using System;
using System.Runtime.InteropServices.ComTypes;

namespace Aufgabe_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = FragenSpeichern("Bitte gib dein Geburtsdatum ein:");
            string[] array = new string[3];
            array[0] = input.Split('.')[0]; // day
            array[1] = input.Split('.')[1]; // month
            array[2] = input.Split('.')[2]; // year

            DateTime birthDate = new DateTime(int.Parse(array[2]), int.Parse(array[1]), int.Parse(array[0]));

            TimeSpan ts = DateTime.Now.Subtract(birthDate);

            DateTime today = DateTime.Today;
           
            int years = DateTime.Now.Year - birthDate.Year;
            if (birthDate.Date > today.AddYears(-years)) years--; // https://stackoverflow.com/questions/9/how-do-i-calculate-someones-age-based-on-a-datetime-type-birthday


            

            // https://stackoverflow.com/questions/9/how-do-i-calculate-someones-age-based-on-a-datetime-type-birthday
            int months = 12 * (today.Year - birthDate.Year) + today.Month - birthDate.Month;
          // https://dotnetcodr.com/2015/10/30/calculate-the-number-of-months-between-two-dates-with-c/
            if (birthDate.Date > today.AddMonths(-months)) months--;
            Console.WriteLine("Alter in Jahren: {0}", years);
            Console.WriteLine("Alter in Monaten: {0}", Math.Floor(Convert.ToDecimal(months)));
            Console.WriteLine("Alter in Wochen: {0}", Math.Floor(ts.TotalDays / 7));
            Console.WriteLine("Alter in Tagen: {0}", Math.Floor(ts.TotalDays));

            Console.ReadKey();
        }

        static string FragenSpeichern(string frage)
        {
            Console.Write(frage + " ");
            return Console.ReadLine();
        }
    }
}
