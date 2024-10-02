using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Aufgabe_16
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aufgabe 16 - Vokale Zählen");
            string input = FragenSpeichern("Deine Eingabe: ");
            char[] vocals = new char[] {
    'a', 'e', 'i', 'o', 'u', 'ä', 'ö', 'ü',
    'A', 'E', 'I', 'O', 'U', 'Ä', 'Ö', 'Ü'
};
            for (int i = 1; i <= vocals.Length-1; i++)
            {
                
                if (CountVocal(vocals[i], input) > 0)
                {
                    Console.WriteLine($"Der Buchstabe '{vocals[i]}' kommt {CountVocal(vocals[i], input)} mal vor");
                }
            }
            Console.ReadLine();
 



        }
        static int CountVocal(char character, string text)
        {
            int amount = 0;
            foreach (char c in text)
            {
                if (c == character) amount += 1;
            }
            return amount;
        }
        static string FragenSpeichern(string frage)
        {
            Console.Write(frage + " ");
            return Console.ReadLine();
        }
    }
    
}
