using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class ReverseNumber
    {
        public void reverseNumber()
        {
            //taking input from user
            Console.Write("\nEnter a number : ");
            //convert string to integer
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            //variable declaration
            int reverse = 0;
            int rem;

            while (num != 0)
            {
                rem = num % 10;
                //pick last term
                reverse = reverse * 10 + rem;
                num = num / 10;
            }
            //Display reverse number
            Console.WriteLine("Reverse number : " + reverse);

        }
    }
}
