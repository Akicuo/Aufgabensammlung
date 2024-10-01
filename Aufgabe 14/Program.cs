using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Aufgabe_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aufgabe 14: Tannenbaum zeichnen");
            int breite_stamm = int.Parse(FragenSpeichern("Breite des Stammes?"));
            int hoehe_stamm = int.Parse(FragenSpeichern("Höhe des Stammes?"));
            int hoehe_krone = int.Parse(FragenSpeichern("Höhe der Krone?"));
            int breite_krone = hoehe_krone * 2 - 1;

            int totalheight = hoehe_krone + hoehe_stamm;

            // draw the crown part
            for (int i = 1; i <= hoehe_krone; i++)
            {
                string links_space = new string(' ', (breite_krone - (i * 2 - 1)) / 2);
                string sternchen = new string('*', i * 2 - 1);
                string text = links_space + sternchen;
                Console.WriteLine(text);
            }

            // draw the stem
            string stamm_space = new string(' ', (breite_krone - breite_stamm) / 2);
            for (int i = 0; i < hoehe_stamm; i++)
            {
                Console.WriteLine(stamm_space + new string('*', breite_stamm));
            }
        }

        static string FragenSpeichern(string frage)
        {
            Console.Write(frage + " ");
            return Console.ReadLine();
        }
    }
}

