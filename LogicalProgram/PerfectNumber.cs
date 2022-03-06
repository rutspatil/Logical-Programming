using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class PerfectNumber
    {
        public void perfectNumber()
        {
            //taking user input
            Console.Write("\nEnter a number : ");
            //converting string to integer value
            int num = Convert.ToInt32(Console.ReadLine());
            //declare variable for store sum of factors
            int sum = 0;

            //for loop for calculating factors of number
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                    sum = sum + i;
            }
            //comparing whether sum is equal to given number or not
            if (sum == num)
            {
                Console.WriteLine(num + " is a Perfect Number");
            }
            else
                Console.WriteLine(num + " is not a Perfect Number");
        }
    }
}
