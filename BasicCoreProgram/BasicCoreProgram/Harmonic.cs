using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class Harmonic
    {
        public double NthHarmonic(int N)
        {
         
            
            float harmonic =  1;

            for (int i = 2; i <=N; i++)
            {
                harmonic += (float)1 / i;
            }       
            return harmonic;

             
        }
    }
}
