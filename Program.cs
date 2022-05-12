using LogicalPrograms;

Console.WriteLine("Logical Programs\n");
Console.WriteLine("Pick The Program You Want to Execute\n");
Console.WriteLine("0 - Enter zero To Exit ");
Console.WriteLine("1 - Fibonacci Series Program");
Console.WriteLine("2 - Perfect Number Program");
Console.WriteLine("3 - Prime Number Program");
Console.WriteLine("4 - Reverse a Number Program");
Console.WriteLine("5 - StopWatch Program");
Console.WriteLine("6 - Coupon Numbers Program");

int flag = 0;
while(flag == 0)
{
    Console.Write("\nEnter your Pick : ");
    int pick = Convert.ToInt32(Console.ReadLine());
    switch (pick)
    {
        case 0:
            flag = 1;
            break;
        case 1:
            FibonacciSeries.Fibonacci();
            break;
        case 2:
            PerfectNumber.Perfect();
            break;
        case 3:
            PrimeNumber.Prime();
            break;
        case 4:
            ReverseANumber.ReverseNumber();
            break;
        case 5:
            StopWatch.Stop();
            break;
        case 6:
            CouponNumbers.CouponNumber();
            break;
        default:
            Console.WriteLine("Invalid Pick");
            break;
    }
}
