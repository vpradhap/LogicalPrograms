using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class ReverseANumber
    {
        public static void ReverseNumber()
        {
            //Local variable declaration and user input
            int reverse = 0, remainder;
            Console.Write("\nEnter a Number to Reverse : ");
            int num = Convert.ToInt32(Console.ReadLine());

            //Logic
            while (num > 0)
            {
                remainder = num % 10;
                reverse = (reverse * 10) + remainder;
                num /= 10;
            }
            Console.WriteLine("\n\tReverse Number is : "+reverse);
        }
    }
}
