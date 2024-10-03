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
            PrintBoard(current_board, ExposedBoard);
            int tries = 0;
            bool running = true;
            bool first_iteration = false;
            
            while (running)
            {
                if (!first_iteration)
                {
                    Console.Clear(); // Clear at the start once first iteration finishes | issue lies within the printboard called before while loop
                }
                
                PrintBoard(current_board, ExposedBoard); 

                
                string StringNums = GetInputTillValid(4, "nums");

                int check = ValidPositions(StringNums, ExposedBoard)[0];
                if (check == 1)
                {
                    int[] positions = ValidPositions(StringNums, ExposedBoard);
                    bool[,] TemporaryExposedBoard = UpdateTempBoard(current_board, ExposedBoard, positions);

                    int x1 = positions[1]; int y1 = positions[2]; int x2 = positions[3]; int y2 = positions[4];
                    PrintBoard(current_board, TemporaryExposedBoard);

                    string wol = ReturnAndPrintHitOrFail(current_board, positions); 

                    Console.ReadKey();


                    if (wol == "hit")
                    {
                        
                        ExposedBoard[x1, y1] = true;
                        ExposedBoard[x2, y2] = true;
                    }
                    else
                    {
                        //reset if it’s a miss
                        ExposedBoard[x1, y1] = false;
                        ExposedBoard[x2, y2] = false;
                    }

                    Console.Clear(); 
                    tries++;
                }
                else if (check == 8)
                {
                    Console.WriteLine($"Position is not valid.. : At least one position is out of range.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (check == 4)
                {
                    Console.WriteLine($"Position is not valid.. : 2x the same position.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (check == 6)
                {
                    Console.WriteLine($"Position is not valid.. : At least one position is already flipped over.");
                    Console.ReadKey();
                    Console.Clear();
                }

                if (IsGameFinished(ExposedBoard))
                {
                    Console.WriteLine($"Congrats! You have finished the memory! | You used {tries} attempts until you made it.");
                    Console.ReadKey();
                    break;
                }
            }


        }










        static string ReturnAndPrintHitOrFail(string[,] current_board, int[] positions)
        {
            int x1 = positions[1]; int y1 = positions[2]; int x2 = positions[3]; int y2 = positions[4];
            if (current_board[x1, y1] == current_board[x2, y2])
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write("That was a successful hit!");
                Console.ResetColor();
                Console.WriteLine();
                return "hit";
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("That was not a hit. Try again!");
                Console.ResetColor();
                Console.WriteLine();
                return "not";
            }
        }
        static bool[,] UpdateTempBoard(string[,] current_board, bool[,] ExposedBoard, int[] positions)
        {
            int x1 = positions[1]; int y1 = positions[2]; int x2 = positions[3]; int y2 = positions[4];

            ExposedBoard[x1, y1] = true;
            ExposedBoard[x2, y2] = true;

            

            return ExposedBoard;
        }
        static int[] ValidPositions(string StringPos, bool[,] ExposedBoard)
        {
            int[] positions = new int[5]; // Initialize with 5 elements

            for (int index = 0; index < StringPos.Length; index++)
            {
                positions[index] = Convert.ToInt32(StringPos.Substring(index, 1));
            }
            int x1 = positions[0]; int y1 = positions[1]; int x2 = positions[2]; int y2 = positions[3];
            x1--;
            y1--;
            x2--;
            y2--; 
            int valid = 1;
            int[] values = {x1, y1, x2, y2};
            for (int i = 0; i < 4; i++)
            {
                // Console.WriteLine("Debug Values:"+values[i]);
                if (values[i] <= 4)
                {
                    
                }
                else
                {
                    valid = 8; // 2x The same Position
                    int[] cant_continue = { valid, x1, y1, x2, y2 };
                    return cant_continue;
                    // Console.WriteLine("Debug Values not higher than 4:" + values[i]);
                }

            }
            if ($"{x1}{y1}" == $"{x2}{y2}")
            {
                valid = 4; // 2x The same Position
            }
            else if (ExposedBoard[x1, y1] == true || ExposedBoard[x2, y2] == true)
            {
                valid = 6; // 2x in one position its atleast alrêady flipped over

            }
            int[] ints = { valid, x1, y1, x2, y2 };
            return ints;
        }
        static bool IsGameFinished(bool[,] ExposedBoard)
        {
            for (int row = 0; row < 4; row++) // fill row <->
            {
                for (int column = 0; column < 4; column++) // fill column ↕
                {
                    if (ExposedBoard[row, column] == false)
                    {
                        return false;
                    }

                }

                
            }
            return true;
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
                    if (ExposedBoard[row, column] == true)
                    {
                        Console.Write($"{CurrentBoard[row, column]} ");
                    }
                    else
                    {
                        Console.Write($"❓");
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
