using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges_Vol4
{
    class _5_SumOfDigits
    {
        public static int SumCalc(int num)
        {
            string numString = Convert.ToString(num);
            int sum = 0;
            for (int i = 0; i < numString.Length; i++)
                sum += Convert.ToInt32(numString.Substring(i, 1));
            return sum;
        }

        public static void Main()
        {
            int num;
            Console.Write("\n\nFunction : To calculate the sum of the individual digits of a number :\n");
            Console.Write("--------------------------------------------------------------------------\n");
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum of the digits of the number {0} is : {1} \n", num, SumCalc(num));
        }
    }
}
