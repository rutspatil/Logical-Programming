using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class FibonacciSeries
    {
        public void fibonacci()
        {
            //input from user
            Console.WriteLine("Enter the limit : ");
            int lim = Convert.ToInt32(Console.ReadLine());  //converting from string to integer

            if (lim > 0)
            {
                //Variable declaration
                int y = 0;
                int z = 1;
                int s;
                //Displaying starting two points
                Console.WriteLine("Fibonacci series :  " + y + " " + z + " ");
                //perform iterations till limit reaches
                while (z <= lim)
                {
                    s = y + z;
                    y = z;
                    z = s;
                    //condition for forcing z that it should not be printed when its value is greater than limit
                    if (z <= lim)
                        Console.WriteLine(z + "  ");
                }
            }

            else
                Console.WriteLine("Wrong Input");
        }
    }
}
