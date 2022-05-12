using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class CouponNumbers
    {
        public static void CouponNumber()
        {
            int distinct = 0, count = 0;

            //User Input
            Console.Write("\nEnter N Distinct Coupon Number : ");
            int couponNo = Convert.ToInt32(Console.ReadLine());

            int[] collected = new int[couponNo]; // Creating new array with couponNo as it's size

            while (distinct < couponNo)  //condition to check distinct count reaches coupon number 
            {
                Random random = new Random();
                int newCoupon = random.Next(couponNo+1);
                count++;
                if (collected.Contains(newCoupon))  //checking newly genetated random value is already present in the array or not 
                {
                    continue;
                }
                else
                {
                    collected[distinct] = newCoupon;  // If not present then new random number gets added to the array
                    distinct++;
                }
            }

            //printing distinct coupon numbers 
            Console.Write("\nDistinct Coupon Numbers : ");
            for (int i = 0; i < collected.Length; i++)
            {
                Console.Write(collected[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("\nTotal Random Numbers Needed : " + count);
        }
    }
}
