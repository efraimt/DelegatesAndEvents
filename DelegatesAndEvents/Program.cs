using System;

namespace DelegatesAndEvents
{

    class Program
    {
        static int x = 1;
        public static void Stam()
        {
            Console.WriteLine("X={0}", x++);
        }

        static void Main(string[] args)
        {
            Calculations myCalc = new Calculations();
            myCalc.Add(1, 2);
            Calculations.Sub(2, 1);

            Stam();//1
            Program.Stam();//2

            //Points on static method
            MyDelegate myDelegate1 = new MyDelegate(Stam);
            myDelegate1();//3


            //Points on instance metthod
            MyDelegate myDelegate2 = new MyDelegate(new Calculations().StamInstance);

            Console.WriteLine(myDelegate2.Method);
            Console.WriteLine(myDelegate2.Target);

            myDelegate2();

            /************************************/
            var student1 = new Student() { Id = 1, Name = "Avihai" };
            var student2 = new Student() { Id = 2, Name = "Ariel" };

            MyDelegate myDelegate3 = new MyDelegate(student1.Go);
            MyDelegate myDelegate4 = new MyDelegate(student2.Go);

            myDelegate3();
            myDelegate4();


            Console.WriteLine("--------------------------");
            var myDelegate5 = new MyDelegate(student1.Go);
            myDelegate5 += student2.Go;
            myDelegate5 += Stam;
            myDelegate5();


            Console.WriteLine("--------------------------");
            Console.WriteLine("--------------------------");
            CalcDelegate calcDelegate1 = new CalcDelegate(new Calculations().Add);
            calcDelegate1 += Calculations.Sub;


            calcDelegate1(10, 20);
        }
    }
}
