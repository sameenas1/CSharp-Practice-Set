using System;

namespace MyString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Your Place: ");
            string place = Console.ReadLine();

            Console.Write("Enter Your Course: ");
            string course = Console.ReadLine();

            int length = name.Length;
            Console.WriteLine("Length of the given string is " + length);
            Console.WriteLine("First character is " + name[0]);
            Console.WriteLine(name.IndexOf('s'));
            Console.WriteLine(name.LastIndexOf('a'));
            Console.WriteLine(name.Substring(6));
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine("My name is " + name);
            Console.WriteLine("I am Coming from " + place);
            Console.WriteLine("Iam studying " + course);


        }
    }
}
