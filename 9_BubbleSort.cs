using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges_Vol4
{
    class _9_BubbleSort
    {
        static void Main()
        {
            List<int> numbers = new List<int> { };

            string input = "";
            int num;

            Console.WriteLine("Enter a number: ");
            input = Console.ReadLine();

            do
            {
                try
                {
                    num = Convert.ToInt32(input);
                    numbers.Add(num);
                }
                catch
                {
                    Console.WriteLine("Not an integer");
                }

                Console.WriteLine("Enter another number: (type 'END' to stop): ");
                input = Console.ReadLine();

            } while (input.ToUpper() != "END");

            BubbleSort(numbers);
        }

        static void BubbleSort(List<int> numbers)   // the Bubble Sort bit
        {
            int temp;

            for (int pass = 0; pass <= numbers.Count - 2; pass++)
            {
                for (int i = 0; i <= numbers.Count - 2; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        temp = numbers[i + 1];          // 3 way swap to handle the switching of values without overwriting
                        numbers[i + 1] = numbers[i];
                        numbers[i] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted:");
            foreach (int p in numbers)
                Console.Write("{0} \t", p);
            Console.Read();
        }
    }
}
