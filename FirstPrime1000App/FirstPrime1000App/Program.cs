using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPrime1000App
{
    class FirstPrime1000App
    {
        static void Main(string[] args)
        {
            long i,j,prime = 0, n = 0;
            bool T = true;
            for ( i = 2; i < 10000; i++)
            {
                for(j = i-1; 2<=j ; j--)
                {
                    if(i%j == 0)
                    {
                        T = false;
                    }
                   
                }
                if(T == false)
                {
                    T = true;
                }
                else if (T == true)
                {
                    n++;
                    if (n == 1001)
                    {
                        prime = i;
                       
                        Console.WriteLine("The 1001st Prime Number is : " + prime);
                    }
                   
                }
            }
            Console.ReadKey();

           
        }
    }

}