using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class CoinFlip
    {
        public void Flip()
        {
            Random random = new Random();
            int a = random.Next(0, 2);

            if (a == 0)
            {
                Console.WriteLine("Tails");

            }
            else
            {
                Console.WriteLine("Heads");
            }


        }
    }
}
    
    

