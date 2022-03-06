using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class PrimeNumber
    {
        public void primeNumber()
        {
            //taking input from user
            Console.Write("\nEnter a number : ");
            //convert string value to integer
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            for (int i = 1; i <= num; i++)
            //condition for getting factors
            {
                if (num % i == 0)
                    count = count + 1;
            }
            //if condition for checking number of factors
            if (count == 2)
            {
                Console.WriteLine(num + " is a prime number.");
            }
            else
            {
                Console.WriteLine(num + " is not a prime number.");
            }
        }
    }
}
