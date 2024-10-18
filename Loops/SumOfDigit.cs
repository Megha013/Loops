using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class SumOfDigit
    {
        static void Main(string[] args)
        {
            //Display the sum of digits of number
            int num = 1234;
            int sum = 0;
            for(int i=num; i>0; i=i/10)
            {
                int digit = i % 10;
                sum += digit;
            }
            Console.WriteLine("Sum is : "+sum);
            Console.ReadLine();
        }
    }
}
