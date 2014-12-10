using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestMultipleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            long i, Num = 21,iCount=0;
            bool F = false;
            while(F==false)
            {
                iCount = 0;
                for(i=1;i<=20;i++)
                {
                    if(Num%i == 0)
                    {
                        iCount++;
                    }
                  
                }
                
                if(iCount == 20)
                {
                    F = true;
                    Console.WriteLine("The Number which is divisible by 1 to 20 : "+Num);
                    Console.ReadKey();
                }
           
               
                Num = Num + 1;
              
                
            }
        }
    }
}
