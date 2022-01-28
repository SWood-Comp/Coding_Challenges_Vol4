using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges_Vol4
{
    class _1_CountSpaces
    {
        public static int SpaceCount(string str)
        {
            int spaceCount = 0;
            string nextString;
            for (int i = 0; i < str.Length; i++)
            {
                nextString = str.Substring(i, 1);
                if (nextString == " ")
                    spaceCount++;
            }
            return spaceCount;
        }

        public static void Main()
        {
            string originalString;
            Console.Write("\n\nFunction to count number of spaces in a string :\n");
            Console.Write("----------------------------------------------------\n");
            Console.Write("Please input a string : ");
            originalString = Console.ReadLine();
            Console.WriteLine("\"" + originalString + "\"" + " contains {0} spaces", SpaceCount(originalString));
        }
    }
}
