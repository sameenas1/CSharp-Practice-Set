using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Enter First value: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Second value: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = num1 + num2;
        int mul = num1 * num2;
        int sub = num1 - num2;
        int div = num1 / num2;

        Console.WriteLine("The sum is " + sum);
        Console.WriteLine("The multiplication is " + mul);
        Console.WriteLine("The substraction is " + sub);
        Console.WriteLine("The division is " + div);
    }
}
