//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Loops
//{
//    internal class PrimeNumber
//    {
//        static void Main(string[] args)
//        {
//            //Find all prime numbers< 100.
//            int num = 7;
//            for(int i=2; i<100; i++)
//            {
//                if(isPrime(i))
//                {
//                    Console.WriteLine(i);
//                }
//            }
//        }
//        static bool isPrime(int number)
//        {
//            if (number < 2) return false;
//            for(int i=2; i<=number/2; i++)
//            {
//                if (number % i == 0) return false;
//            }
//            return true;
//        }
//    }
//}
