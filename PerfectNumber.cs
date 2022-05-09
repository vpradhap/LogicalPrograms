using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PerfectNumber
    {
        public static void Perfect()
        {
            //Local variable declaration and user input
            int temp = 0;
            Console.Write("\nEnter The Number to Check : ");
            int num = Convert.ToInt32(Console.ReadLine());

            //Logic
            for (int i = 1; i <= num/2; i++)
            {
                
                if (num % i == 0)
                {
                    temp += i;
                    Console.Write(i+" ");
                }
            }
            Console.Write( "= "+temp);
            
            if (temp == num)
            {
                Console.WriteLine("\n\t"+num+" is a Perfect Number");
            }
            else
            {
                Console.WriteLine("\n\t"+num + " is Not a Perfect Number");
            }
        }
    }
}
