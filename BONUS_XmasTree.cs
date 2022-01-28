using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges_Vol4
{
    class BONUS_XmasTree
    {
        static void Main()
        {
            // declare variables here:
            int spaces;   // need to know how many rows and spaces we are dealing with
            int rows;        // 'num' is set to be the number that will actually be writtten on the tree

            Console.WriteLine("XMAS TREE Display (pyramid with decorations):");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("\n");

            Console.Write("Input size of Xmas Tree (rows): ");
            rows = Convert.ToInt32(Console.ReadLine());     // user enters how many rows to work for

            spaces = rows;      // spaces worked out based on how many rows we have.

            // TREE bit...

            for (int i = 1; i <= rows; i++)     // OUTER FOR loop controls how many rows to do this for
            {
                // FOR LOOP - do the spaces on that row first
                for (int k = spaces; k >= 1; k--)
                {
                    Console.Write(" ");
                }
                // FOR LOOP - do the Tree symbols on that row
                for (int j = 1; j <= i * 2; j++)
                {
                    if (j % 6 == 0)     // evry third symbol is an O
                    {
                        Console.Write("*");
                    }
                    else if (j % 3 == 0)     // evry third symbol is an O
                    {
                        Console.Write("O");
                    }
                    else
                    {
                        Console.Write("X");
                    }
                }
                
                Console.Write("\n");    // write a new line command after each row is complete.
                spaces--;       // subtract 1 from spaces for the next row to work properly.
            }

            // TRUNK Bit ...

            int height = (int)(rows/3);      // height worked out based on how many rows we have and divide by 3.

            for (int i = 1; i <= height; i++)     // OUTER FOR loop controls how many rows to do this for
            {
                // FOR LOOP - do the spaces on that row first (half as many as the row itself)
                for (double k = 0; k <= rows/2; k++)
                {
                    Console.Write(" ");
                }
                // FOR LOOP - do the symbols (trunk) on that row (half as wide as the tree in full)
                for (int j = 1; j <= rows; j++)
                {
                    Console.Write("M");
                }
                Console.WriteLine();
            }

        }
    }
}
