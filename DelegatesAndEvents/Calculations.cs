using System;

namespace DelegatesAndEvents
{
    /*
     1. Declaration
     2. Instantiation
     3. Invocation
     */


    public class Calculations
    {
        public void StamInstance()
        {
            Console.WriteLine("Calculation NONE STATIC method");
        }


        public void Add(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }

        public static void Sub(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }

    }

    public delegate void CalcDelegate(int x, int y);

}
