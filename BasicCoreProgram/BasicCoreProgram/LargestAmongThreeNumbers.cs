using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class LargestAmongThreeNumbers
    {
        public void LargestNumber()
        {
            int a = 2;
            int b = 3;
            int c = 4;
            if (a > b && a > c) 
            {
                Console.WriteLine(a +" is Largest Among Given 3 NUMBERS");

            }

            else if (b > c && b > a)
            {
                Console.WriteLine(b + " is Largest Among Given 3 NUMBERS");
            }

            else
            {
               Console.WriteLine(c + " is Largest Among Given 3 NUMBERS");
            }
        }
    }
}
