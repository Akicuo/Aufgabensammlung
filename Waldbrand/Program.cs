using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlTypes;
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

            string[,] card_list = {
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
            string[,] board = FillBoard(card_list);

            PrintBoard(board, ExposedBoard);









           
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
