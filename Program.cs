using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter limit: ");
            Console.WriteLine("number of primes is {0}", getPrimes(Convert.ToInt32(Console.ReadLine())));
            Console.ReadLine();
        }

        static int getPrimes(int n)
        {
            int numberOfPrimes = 0;
            for (int i = 2; i < n; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i-1; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                    } 
                }

                if (isPrime)
                {
                    Console.WriteLine("found a prime {0}", i);
                    numberOfPrimes++;
                   
                }
                Console.WriteLine(i);

            }

            return numberOfPrimes;
        }
    }
}
