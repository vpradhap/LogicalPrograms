using LogicalPrograms;

Console.WriteLine("Logical Programs\n");
Console.WriteLine("Pick The Program You Want to Execute\n");
Console.WriteLine("1 - Fibonacci Series Program");
Console.WriteLine("2 - Perfect Number Program");
Console.Write("\nEnter your Pick : ");
int pick = Convert.ToInt32(Console.ReadLine());

switch (pick)
{
    case 1:
        FibonacciSeries.Fibonacci();
        break;
    case 2:
        PerfectNumber.Perfect();
        break;
}
