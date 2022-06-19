using System;
using System.Collections.Generic;       
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class powerof2
    {
        public void Powerof2()
        {
            Console.WriteLine("Please Enter The N Value");
            int N = Int32.Parse(Console.ReadLine());

            for(int i=0;i<N;i++)
            {
                int x = 2 * 1;
                Console.WriteLine(2+"^"+i+"="+x);
            }
        }
    }
}
