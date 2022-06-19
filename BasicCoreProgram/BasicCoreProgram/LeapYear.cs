using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class LeapYear
    {
          public void CheckLeap()
          {
                long year = 2022;
                if (year % 4 == 0)
                    Console.WriteLine(year + " is leap year");


                else
                {
                    Console.WriteLine(year + " is not leap year");
                }
          }
       
    }

}

