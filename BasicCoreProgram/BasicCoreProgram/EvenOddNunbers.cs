using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class EvenOddNunbers
    {
        public void EvenOrOdd()
        {
            int a = 3;
            if (a %2==0)
            {
                Console.WriteLine(a + " is Even Number");

            }
            else
            {
                Console.WriteLine(a + " is Odd Number");

            }
        }
    }
}
