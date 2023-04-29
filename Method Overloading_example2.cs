using System;

namespace Method_Overloading_example2
{
    internal class Program
    {
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {

            int myNum1 = PlusMethod(1, 2);
            double myNum2 = PlusMethod(4.3, 6.2);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);

        }
    }
}