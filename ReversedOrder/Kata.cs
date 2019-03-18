using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedOrder

// Create a function that will take an integer and reverse the order

// ex
// Input: 21445 Output: 54412

// Input: 145263 Output: 362541

// Input: 1254859723 Output: 3279584521
{
    public static class Kata
    {
        public static int ReversedOrder(int num)
        {
            // Get the digits of the integer

            // Store the digits into an integer
            int reversed = 0;
           
            while (num > 0)
            {
                // Extract each digit of the integer
                int digit = num % 10;
                // Console.WriteLine("Digit picked: " + digit);

                // Store the digits extracted into a new integer
                reversed = reversed * 10 + digit;
                // Console.WriteLine("Digit: " + reversed);

                // Trim the last digit of the current value of num
                num /= 10;
                // Console.WriteLine("Num: " + num);
            }

            // Console.WriteLine(num);

            return reversed;
        }
    }
}
