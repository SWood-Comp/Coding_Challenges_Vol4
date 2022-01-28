using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges_Vol4
{
    class _2_CalcArraytotalal
    {
        public static double Sum(double[] numbers)
        {
            double total = 0;
            for (int i = 0; i < numbers.Length; i++)
                total += numbers[i];
            return total;
        }
        public static void Main()
        {
            double[] numbers = new double[5];
            Console.Write("\n\nFunction : Calculate the sum of the elements in an array :\n");
            Console.Write("--------------------------------------------------------------\n");

            Console.WriteLine("Input 5 elements in to the array: ");
            for (int j = 0; j < 5; j++)
            {
                Console.Write("Element - {0} : ", j);
                numbers[j] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("The sum of the elements of the array is {0}", Sum(numbers));
        }
    }
}
