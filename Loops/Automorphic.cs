//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Loops
//{
//    internal class Automorphic
//    {
//        static void Main(string[] args)
//        {
//            //14.check no is automorphic or not
//            //input n = 25,
//            //output 25 * 25 = 625
//            int n = 25;
//            int square = n * n;
//            int temp = n;

//            while (temp > 0)
//            {
//                if (square % 10 != temp % 10)
//                {
//                    Console.WriteLine("Not Automorphic");
//                    return;
//                }
//                square /= 10; // Remove last digit of square
//                temp /= 10;   // Remove last digit of n
//            }
//            Console.WriteLine("Automorphic");
//        }
//    }
//}
