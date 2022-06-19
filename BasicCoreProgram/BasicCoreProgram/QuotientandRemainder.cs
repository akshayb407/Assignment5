using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class QuotientandRemainder
    {
        public void QuoRem()
        {

            Console.WriteLine("Enter Divisor And Dividend");

            int Divisor=Int32.Parse(Console.ReadLine());
            int Dividend=Int32.Parse(Console.ReadLine());

            int Quotient = Divisor / Dividend;
            Console.WriteLine(Quotient);

            int Remainder=Divisor/Dividend;
            Console.WriteLine(Remainder);

        }
    }
}
