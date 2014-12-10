using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargePalindrome3DigitApp
{
    class LargePalindrome3DigitApp
    {
        static void Main(string[] args)
        {
            int i,j,prime,LargePrime,large=0;
            int[] arr = new int[6];
            for(i=100;i<1000;i++)
            {
                for(j=100;j<1000;j++)
                {

                    prime = i * j;
                    string s, revs = "";
                    s = Convert.ToString(prime);
                  
                    for (int p = s.Length - 1; p >= 0; p--) //String Reverse
                    {
                        revs += s[p].ToString();
                    }
                    if (revs == s) // Checking whether string is palindrome or not
                    {
                        LargePrime = Convert.ToInt32(s);
                        if (large < LargePrime)
                        {
                            large = LargePrime;
                        }
                        //Console.WriteLine("String is Palindrome \n Entered String Was {0} and reverse string is {1}", s, revs);
                    }
                    
                }
            }
            Console.WriteLine("The Largest Palindrome of 3 digit is : "+large);
            Console.ReadKey();
        }
    }
}
