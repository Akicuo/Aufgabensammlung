using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string calc_text = FragenSpeichern("Make your calculation (or press Q to quit)\n").Replace(" ", "");
                if (Operator(calc_text) != 'x')
                {
                    
                    int num1 = GetNums(calc_text, 0);
                    int num2 = GetNums(calc_text, 1);
                    var op = Operator(calc_text);
                    Console.WriteLine(Calculate(num1, num2, op));
                    Console.WriteLine();
                    // Console.WriteLine($"Die Summe ist: {num1 Convert.ToOperator(op) num2}");//
                }
                else
                {
                    Console.WriteLine("Error... Try again...");
                }

            }
        }
        static int Calculate(int num1, int num2, char Op)
        {
            switch (Op)

            {
                case '*':
                    return num1 * num2;
                case '/':
                    return num1 / num2;
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                default:
                    return 'x';
            }
        }
        static int GetNums(string text, int num)
        {
            int res = int.Parse(text.Split(Operator(text))[num]);

            return res;


        }
        static char Operator(string calc_text)
        {
            if (calc_text.Contains('*'))
            {
                return '*';
            }
            else if (calc_text.Contains('/'))
            {
                return '/';
            }
            else if (calc_text.Contains('+'))
            {
                return '+';
            }
            else if (calc_text.Contains('-'))
            {
                return '-';
            }
            else
            {
                return 'x';
            }
        }
    
        
        static string FragenSpeichern(string frage)
        {
            Console.Write(frage + " ");
            return Console.ReadLine();
        }
    }

}
