using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class StopWatch
    {
        public static void Stop()
        {
            Console.Write("\nTo Start the Stopwatch Enter S or s : ");
            char start = Convert.ToChar(Console.ReadLine());
            Stopwatch sw = Stopwatch.StartNew();
            if (start == 's' || start == 'S')
            {
                sw.Start();
                Console.Write("\nTo Stop the Stopwatch Enter Q or q : ");
                char end = Convert.ToChar(Console.ReadLine());
                if (end == 'q' || end == 'Q')
                {
                    sw.Stop();
                    Console.WriteLine("\n\tThe Time Elapsed : " + sw.Elapsed.TotalSeconds+" seconds");
                }
                else
                {
                    Console.WriteLine("Wrong Input");
                }
            }
            else
            {
                Console.WriteLine("Wrong Input");
            }
        }
    }
}
