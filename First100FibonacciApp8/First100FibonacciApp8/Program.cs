using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First100FibonacciApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //int j = 0;
            //for(int i=0;i<=100;i++)
            //{
            //    j = i + j;
            //    Console.WriteLine(i);
            //}
            int first = 0, second = 1, next = 0;
            for (int c = 0; c < 100;c++ )
            {
                if(next > 100)
                {
                    //break;
                    continue;
                }
                if(c<=1)
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
            }

                Console.ReadKey();
        }
    }
}
