using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class FibonacciSeries
    {
        public static void Fibonacci()
        {
            int first =0 , second = 1 , third;
            Console.Write("\nEnter the End Length of Fibonacci Sries : ");
            int last = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n"+first+" "+second+" ");
            for (int i = 2 ; i <= last ; i++)
            {
                third = first + second;
                Console.Write(+third+" ");
                first = second;
                second = third;
            }
            Console.WriteLine("");
        }
    }
}
