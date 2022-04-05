using System;

namespace assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program checks if the sum of two numbers is less than 100");
            bool result = lessThan100();
            Console.WriteLine(result);
        }
        static bool lessThan100()
        {
            Console.Write("Enter the first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double b = double.Parse(Console.ReadLine());
            if(a+b < 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
