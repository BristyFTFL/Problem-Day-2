using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargePrimeApp
{
    class LargePrimeApp
    {
        static void Main(string[] args)
        {
            double p = 600851475143,i,j;
            bool isPrime = true;
            double large = 0;
            for (i = 1; i <= p; i++)
            {
                for (j = 2; j <= p; j++)
                {
 
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
 
                }
 
                if (isPrime)
                {
                    if (p % i == 0)
                    {
                        if (large < i)
                        {
                            large = i;
                        }
                    }
                    //Console.WriteLine("Prime: " + i);
                }
 
                isPrime = true;
            }
            Console.WriteLine("The largest Prime Number is : " + large);
            Console.ReadKey();
        }
        
    }
}
