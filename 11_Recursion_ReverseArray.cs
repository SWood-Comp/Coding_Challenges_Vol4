using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges_Vol4
{
    class _11_Recursion_ReverseArray
    {
        // Function to print reverse of the passed 'words' Array of strings 
        static void reverseArray(string[] arr, int index)
        {
            if (index >= 1 && index <= 7)
            {
                //Console.WriteLine("Going in again ... level {0}", index);
                reverseArray(arr, index + 1);       // go into the same subroutine, but with one less index.
            }

            //Console.WriteLine("Returning from ... level {0}", index);
            Console.WriteLine(arr[index - 1]);
        }

        static void Main()
        {
            Console.Write("\n\n Recursion : Print the natural numbers from n to 1 :\n");
            Console.Write("--------------------------------------------------------\n");

            string[] words = new string[8];

            for(int x = 0; x < 8; x++)      // add in 8 values to the 'words' array.
            {
                Console.Write("Enter word {0}:  ", x);
                words[x] = Console.ReadLine();
            }

            int ctr = 1;

            // Call recursive method with two parameters.	
            reverseArray(words, ctr);

            // only gets back to here when all levels are returned from
            Console.WriteLine("Done ... \n\n");
        }
    }
}
