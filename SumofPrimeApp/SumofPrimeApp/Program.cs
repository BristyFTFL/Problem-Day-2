using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofPrimeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            long Num = 2, i, prime = 0;
            bool notPrime = true;
            while (Num < 2000000)
            {
                notPrime = true;
                for (i = 2; i <= Num; i++) 
                {
                    if (Num % i == 0 && i != Num)
                    {
                        notPrime = false;
                    }
                   
                }
                if (notPrime != false)
                {
                    Console.WriteLine("Prime number is : " + Num);
                    prime = prime + Num;
                   
                }
                //else
                //{
                //    notPrime = true;
                //}
                Num++;
            }
            Console.WriteLine("The summation of Prime number is : "+prime);
            Console.ReadKey();
        }
    }
}