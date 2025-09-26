using System;

namespace MyVar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aInt = 456;
            float bFlo = 4.56F;

            var c = aInt + bFlo;

            Console.WriteLine("Data type of aInt: " + aInt.GetType());
            Console.WriteLine("Data type of bFlo: " + bFlo.GetType());
            Console.WriteLine("Value of c: " + c);
            Console.WriteLine("Data type of c: " + c.GetType());
        }
    }
}
