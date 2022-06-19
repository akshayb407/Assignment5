using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class SwapTwoNumbers
    {
        public void Swap()
        {
            int a = 3;
            int b = 6;

            int temp;
            temp = b;
            b = a;
            a = temp;

            Console.WriteLine("Swapped Numbers are " + a + "" + b);

        }
    }
}
