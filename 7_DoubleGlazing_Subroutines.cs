using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges_Vol4
{
    class _7_DoubleGlazing_Subroutines
    {
        static void Main()
        {
            double width, height;
            bool valid;

            do {
                Console.Write("Please enter the height of the window in centimeters(cm): ");
                height = double.Parse(Console.ReadLine());
                Console.Write("Please enter the width of the window in centimeters(cm): ");
                width = double.Parse(Console.ReadLine());
                valid = CheckValues(height, width);
            } while (valid == false);

            Calculate(height, width);
            Console.WriteLine();
        }

        static bool CheckValues(double height, double width)
        {
            if ((height >= 50 && height <= 300) && (width >= 50 && width <= 300))
                return true;
            else
                Console.WriteLine("Invalid Values entered. (50cm - 300cm)");
                return false;
        }

        static void Calculate(double height, double width)
        {
            double totalAreaGlass, totalFrameLength;        // declare totals

            totalAreaGlass = ((height/100) * (width/100)) * 2;    // DOUBLE Glazing - Needs 2 panes of glass.
            Console.WriteLine("Total Area of Glass: {0:F2}m\xB2", totalAreaGlass);     // "\xB2" will give the superscript 2 symbol

            totalFrameLength = ((height/100) * 2) + ((width/100) * 2);      // calculate frame (2 ups, 2 across)
            totalFrameLength = totalFrameLength * 3.25;         // convert to Feet
            Console.WriteLine("Total Wood need for Frame: {0:F2}ft", totalFrameLength);     // {0:F2} rounds to 2 decimal places
        }
    }
}
