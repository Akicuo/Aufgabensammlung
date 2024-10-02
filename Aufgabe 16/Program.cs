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
    public class Text
    {
        public string text { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aufgabe 16 - Witze API");
            Console.WriteLine(new string('*', 24));
            Console.WriteLine(ReturnJoke());
            while (true)
            {
                char nj = char.Parse(FragenSpeichern("Nächsten Witz holen?").ToLower());
                if (nj == 'y')
                {
                    Console.WriteLine(ReturnJoke());
                    Console.WriteLine();
                }
                else
                {
                    Console.ReadKey();
                    }
            }
            
        }
        static string ReturnJoke()
        {
            WebRequest request = WebRequest.Create("https://witzapi.de/api/joke/");
            
            WebResponse response = request.GetResponse();
;
            StreamReader sr = new StreamReader(response.GetResponseStream());
            string json = sr.ReadToEnd().ToString(); 
            
            JArray array = JArray.Parse(json);
            return array[0]["text"].ToString();



        }
        static string FragenSpeichern(string frage)
        {
            Console.Write(frage + " ");
            return Console.ReadLine();
        }
    }
    
}
