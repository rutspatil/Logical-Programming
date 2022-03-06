using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Program Number : ");
            Console.WriteLine();
            Console.WriteLine("1 = Fibonacci Number Series \n2 = Perfect Number \n3 = Prime Number \n4 = Reverse Number \n5 = StopWatch");
            Console.Write("\nProgram number : ");
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    FibonacciSeries series = new FibonacciSeries();
                    series.fibonacci();
                    break;
        }   }
    }
}
