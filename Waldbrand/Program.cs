using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Memory

{

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("MEMORY -> Hinter den ? verstecken sich Symbole, die paarweise vorkommen. Finden Sie diese!");
            Console.WriteLine("Zum Aufdecken wählen Sie zwei Positionen in der Form: Zeile1Spalte1Zeile2Spalte2.");
            Console.WriteLine("Z.Bsp.: 2142 deckt das Symbol in Zeile 2 u. Spalte 1 auf sowie das Symbol in Zeile 4 u. Spalte 2.\n");

            string[,] card_list = {
        { "-", "-", "-", "-"},
        { "-", "-", "-", "-"},
        { "-", "-", "-", "-"},
        { "-", "-", "-", "-" }
    };
            string[,] filled_icon_board = FillBoard(card_list);

            for (int row = 0; row < 4; row++)
            {
                for (int column = 0; column < 4; column++)
                {
                    Console.Write($"{filled_icon_board[row, column]} ");
                }
                Console.WriteLine();
            }









            // ♬ ☢ ⌨ ❒  〄 🦴 💵  🐻‍❄//
        }
        static string[,] FillBoard(string[,] board)
        {
            string[] icons = { "A", "E", "U", "I", "Y", "W", "T", "F"};
            int[] icons_left = { 2, 2, 2, 2, 2, 2, 2, 2 };
            for (int row = 0; row < 4; row++) // fill row <->
            {

                

                for (int column = 0; column < 4; column++) // fill column |
                {
                    bool filled=false;
                    while (filled == false)
                    {
                        int num = new Random().Next(0, 8);
                        Console.WriteLine(num);
                        if (icons_left[num] > 0)
                        {
                            board[row, column] = icons[num];
                            icons_left[num] -= 1;
                            filled = true;

                        }
                        else
                        {
                            
                        }
                        
                    }
                    


                }

            }
            return board;
        }
        static int GenRandomNum(int min, int max)
        {
            Random rnd = new Random(); // Von Stackoverflow.com //
            int randint = rnd.Next(min, max); // Von Stackoverflow.com //
            return randint;
        }
    }
}
