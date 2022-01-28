using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges_Vol4
{
    class _8_PowerOf
    {
        static void Main()
        {
            int num1 = GetInput("Enter the number: ");
            int num2 = GetInput("Enter the exponent (Power of): ");

            double result = Math.Pow((double)num1, (double)num2);
            Console.WriteLine("{0} ^ {1} = {2}", num1, num2, result);
        }

        static int GetInput(string command)
        {
            Console.WriteLine(command);
            bool validInput;
            int num = 0;
            do
            {
                validInput = true;
                try
                {
                    num = int.Parse(Console.ReadLine());
                }
                catch
                {
                    validInput = false;
                    Console.WriteLine("Something went wrong.");
                }
            } while (!validInput);

            return num;
        }
        
    }
}
