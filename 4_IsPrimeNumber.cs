using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges_Vol4
{
    class _4_IsPrimeNumber
    {
        public static bool checkPrime(int num)
        {
            for (int i = 2; i < num; i++)
                if (num % i == 0)
                    return false;
            return true;
        }
        public static void Main()
        {
            Console.Write("\n\nFunction : To check a number is prime or not :\n");
            Console.Write("--------------------------------------------------\n");
            Console.Write("Input a number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (checkPrime(num))
                Console.WriteLine("{0} is a prime number", num);
            else
                Console.WriteLine("{0} is not a prime number", num);
        }
    }
}
