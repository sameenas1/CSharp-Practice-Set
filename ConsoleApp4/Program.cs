using System;

namespace MyVar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aInt = 123;
            string bStr = "456";
            bool cBool = true;

            Console.WriteLine("Data type of aInt: " + aInt.GetType());
            Console.WriteLine("Data type of bStr: " + bStr.GetType());
            Console.WriteLine("Data type of cBool: " + cBool.GetType());

            Console.WriteLine("Data type of aInt after conversion: " + (Convert.ToString(aInt)).GetType());
            Console.WriteLine("Data type of bStr after conversion: " + (Convert.ToInt32(bStr)).GetType());
            Console.WriteLine("Data type of cBool after conversion: " + (Convert.ToString(cBool)).GetType());
        }
    }
}
