using System;

namespace BasicCoreProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoinFlip f = new CoinFlip();
            f.Flip();

            LeapYear lp = new LeapYear();
            lp.CheckLeap();


            powerof2 p2 = new powerof2();
            p2.Powerof2();


            Harmonic hm=new Harmonic();
            hm.NthHarmonic(8);

            Factors pm=new Factors();
            pm.PrimeFactors();


            QuotientandRemainder qm= new QuotientandRemainder();
            qm.QuoRem();


            SwapTwoNumbers s = new SwapTwoNumbers();
            s.Swap();

            EvenOddNunbers EO = new EvenOddNunbers();
            EO.EvenOrOdd();


            VowelorConsonant VW = new VowelorConsonant();
            VW.VowelCons('o');

            LargestAmongThreeNumbers LN = new LargestAmongThreeNumbers();
            LN.LargestNumber();

        }

    }
}
