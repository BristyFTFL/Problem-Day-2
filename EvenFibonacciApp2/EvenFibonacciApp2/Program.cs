using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenFibonacciApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 1, second = 2, next = 0,sum = 0;
            for (int c = 1; c <= 100; c++)
            {
            
                    if (next >= 400000)
                    {
                        break;
                      
                    }
                    if (c <= 2)
                    {
                        next = c;
                    }
                    else
                    {
                        next = first + second;
                        first = second;
                        second = next;
                    }
                    Console.WriteLine(next);
                if(next%2 == 0)
                {
                    sum = sum + next;
                }

            }
            Console.WriteLine("Sum :"+sum);
            Console.ReadKey();
        }
    }
}
