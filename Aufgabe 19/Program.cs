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
                    try { 
                        float num1 = GetNums(calc_text, 0);
                    float num2 = GetNums(calc_text, 1);
                    var op = Operator(calc_text);
                    Console.WriteLine(Calculate(num1, num2, op));
                    Console.WriteLine();
                        // Console.WriteLine($"Die Summe ist: {num1 Convert.ToOperator(op) num2}");//
                    }
                    catch (Exception E)
                    {
                        Console.WriteLine("Error... Try again...");
                    }
                }
                else
                {
                    Console.WriteLine("Error... Try again...");
                }

            }
        }
        static int Calculate(float nume1, float nume2, char Op)
        {
            double num1 = Convert.ToDouble(nume1);
            double num2 = Convert.ToDouble(nume2);
            switch (Op)

            {
                case '*':
                    return (int)(num1 * num2);
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero (avg calc error)");
                        return 0;
                    }
                    return (int)(num1 / num2);
                case '+':
                    return (int)(num1 + num2);
                case '-':
                    return (int)(num1 - num2);
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
