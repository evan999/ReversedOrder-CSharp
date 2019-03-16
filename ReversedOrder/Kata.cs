using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedOrder

// create a function that will take an integer and reverse the order

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
            
            // int index = 0;
            // int[] digits;
            // int digit = num % 10;
            /*
            while (num > 0)
            {
                digits[index] = num % 10;
                num = num / 10;
                index++;
            }
            */
            int count = 0;
            int result = num;

            while (num > 0)
            {
                int digit = num % 10;
                Console.WriteLine("Digit: " + digit);
                if (digit == 1)
                    count++;
                num /= 10;
                Console.WriteLine("Num: " + num);

            }
            Console.WriteLine(num);

            return 0;
        }
    }
}
