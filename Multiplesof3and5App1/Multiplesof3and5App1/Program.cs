using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplesof3and5App1
{
    class Program
    {
        static void Main(string[] args)
        {
             int  Sum = 0,i;
            for(i=0;i<1000;i++)
            {
                if(i % 3==0 || i % 5==0)
                {
                    Sum = Sum + i;
                }
            }
            Console.WriteLine("Sum : " + Sum);
            Console.ReadKey();
        }
    }
}
