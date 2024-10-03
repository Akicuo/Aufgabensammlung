using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Memory

{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("MEMORY -> Hinter den ? verstecken sich Symbole, die paarweise vorkommen. Finden Sie diese!");
            Console.WriteLine("Zum Aufdecken wählen Sie zwei Positionen in der Form: Zeile1Spalte1Zeile2Spalte2.");
            Console.WriteLine("Z.Bsp.: 2142 deckt das Symbol in Zeile 2 u. Spalte 1 auf sowie das Symbol in Zeile 4 u. Spalte 2.\n");

            string[,] current_board = {
        { "-", "-", "-", "-"},
        { "-", "-", "-", "-"},
        { "-", "-", "-", "-"},
        { "-", "-", "-", "-" }
    };
            bool[,] ExposedBoard = {
        { false, false, false, false},
        { false, false, false, false},
        { false, false, false, false},
        { false, false, false, false}
    };
            current_board = FillBoard(current_board); // Initiated as game starts 
            bool running = true;
            while (running)
            {
                PrintBoard(current_board, ExposedBoard);
                string StringNums = GetInputTillValid(4, "nums");
                // First ccheck if both numbers are not the same, its not out of range in the board
                if (ValidPositions(StringNums, ExposedBoard)[0] == 1)
                {

                }
                else
                {
                    Console.WriteLine($"Position ist nicht Valid");
                }



            }
        }
    











        static int[] ValidPositions(string StringPos, bool[,] ExposedBoard)
        {
            int[] positions = new int[4];
            int index = 0;
            foreach (char c in StringPos)
            {
                positions[index] = c; index++;
            }
            int x1 = positions[0]; int y1 = positions[1]; int x2 = positions[2]; int y2 = positions[3];
            int valid = 1;
            if (x1 == x2 && y1 == y2)
            {
                valid = 0;
            }
            else if (ExposedBoard[x1, y1] || ExposedBoard[x2, y2])
            {
                valid = 0;
            }
            int[] ints = { valid, x1, x2, y1, y2 };
            return ints;
        }
        
        
        static (bool, string, int, int) GetPositionValidity() // return true icon x y
        {
            return (false, "ee", 1, 1);

        }
        static string GetInputTillValid(int length, string type) // checks content and counts 
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input.Length == length)
                {

                    bool ContainsNum = false;
                    for (int i = 0; i < input.Length; i++)
                    {
                        string substring = input.Substring(i);
                        if (int.TryParse(substring, out int number))
                        {
                            ContainsNum = true;

                        }
                    }
                    bool ContainsLetters = false;
                    string[] Stringcollection = Enumerable.Range('a', 'z' - 'a' + 1).Select(x => ((char)x).ToString()).ToArray();

                    foreach (char substring in input)
                    {
                        foreach (string letter in Stringcollection)
                        {
                            if (Convert.ToString(substring).Contains(letter))
                            {
                                ContainsLetters = true;

                            }


                            
                            
                            if (type == "nums" && ContainsNum == true && ContainsLetters == false) // nums = numbers
                            {
                                return input;
                            }
                            else if (type == "lets" && ContainsNum == false && ContainsLetters == true) // lets = letters
                            {
                                return input;
                            }
                            else if (type == "mix") // allows both
                            {
                                return input;
                            }
                            else { } // No nothing 


                        }
                    }
                }
            }
        }
            static (string[], string[]) GetTwoArrays()
        {
            string[] array1 = new string[] { "x" };
            string[] array2 = new string[] { "x" };
            return (array1, array2);
        }
        static void PrintBoard(string[,] CurrentBoard, bool[,] ExposedBoard)
        {
            Console.WriteLine($"     1  2  3  4");
            for (int row = 0; row < 4; row++)
            {
                int instance_int = row;
                instance_int++;
                Console.Write($"  {instance_int} ");
                for (int column = 0; column < 4; column++)
                {
                    if (ExposedBoard[row, column] == false)
                    {
                        Console.Write($"{CurrentBoard[row, column]} ");
                    }
                    else
                    {
                        Console.Write($"❓  ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
        static string[,] FillBoard(string[,] board)
        {
            string[] icons = { "💲", "💩", "🧙", "☃️", "🤖", "🍄", "😿", "🧞" };
            int[] icons_left = { 2, 2, 2, 2, 2, 2, 2, 2 };
            Random random = new Random(); // 

            for (int row = 0; row < 4; row++) // fill row <->
            {
                for (int column = 0; column < 4; column++) // fill column ↕
                {
                    bool filled = false;
                    while (filled == false)
                    {
                        int num = random.Next(0, 8);
                        if (icons_left[num] > 0)
                        {
                            board[row, column] = icons[num];
                            icons_left[num] -= 1;
                            filled = true;
                        }
                    }
                }
            }
            return board;
        }
    }
}
