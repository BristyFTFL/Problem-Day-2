using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareDifferenceApp6
{
    class SquareDifferenceApp6
    {
        static void Main(string[] args)
        {
            int Square1, Square2, Sum1 = 0, Sum2 = 0, i,Difference;
            for (i = 1; i <= 100;i++ )
            {
                Square1 =  i * i;
                //Console.WriteLine(Square1);
                Sum1 = Sum1 + Square1;
                //Console.WriteLine(Sum1);
                Sum2 = Sum2 + i;
            }
        
            Square2 = Sum2 * Sum2;
         
            Difference = Square2 - Sum1;
            Console.WriteLine("Difference : " + Difference);
            Console.ReadKey();
        }
        
    }
}
