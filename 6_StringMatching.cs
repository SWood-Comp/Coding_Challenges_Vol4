using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges_Vol4
{
    class _6_StringMatching
    {
        static void Main()
        {
            string word1, word2;

            Console.WriteLine("Please enter word 1: ");
            word1 = Console.ReadLine();
            Console.WriteLine("Please enter word 2: ");
            word2 = Console.ReadLine();

            bool checkIt = wordChecker(word1, word2);

            if (checkIt)
                Console.WriteLine("Direct Match!");
            else
                Console.WriteLine("No match.");
        }

        static bool wordChecker(string word1, string word2)
        {
            bool matched = true;
            int length1 = word1.Length;
            int length2 = word2.Length;
            if (length1 != length2)
                matched = false;    // cannot match due to mismatch in length of words
            else
            {
                for(int i = 0; i <= length1 - 1; i++)
                {
                    if (word1[i] != word2[i])
                        matched = false;
                }
            }

            return matched;
        }
    }
}
