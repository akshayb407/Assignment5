using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class Factors
    {
        public void PrimeFactors()
        {
            Console.WriteLine("Enter a Number");
            int number = Int32.Parse(Console.ReadLine());

            for (int i = 2; i < number; i++)
            {
                while (number % i == 0)
                {
                    Console.WriteLine(i + "");
                    number = number / i;
                }
            }
            if (number > 2)
            {
                Console.WriteLine(number);
            }
        }

    }
}