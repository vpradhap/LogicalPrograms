using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PrimeNumber
    {
        public static void Prime()
        {
            //Local variable declaration and user input
            int count = 0;
            Console.Write("\nEnter a Number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            //Logic
            for (int i = 2; i <= num/2; i++)
            {
                if (num % i == 0)
                {
                    count++;
                    Console.WriteLine("\n\t" + num + " is Not a Prime Number");
                    break;
                }    
            }
            if(count == 0)
            {
                Console.WriteLine("\n\t" + num + " is a Prime Number");
            }
        }
    }
}
