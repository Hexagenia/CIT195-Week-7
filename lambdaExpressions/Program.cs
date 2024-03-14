using System;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Type out the first number (2 numbers total):");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Type out the second number please:");
            double num2 = double.Parse(Console.ReadLine());

        //math functions    
        Func<double, double, double> add = (x, y) => y + x;
        Func<double, double, double> multiply = (x, y) => y * x;
        Func<double, double, double> min = (x, y) => x < y ? x : y;

            
            Console.WriteLine($"The sum of {num1} and {num2} is: {add(num1, num2)}");
            Console.WriteLine($"The product of {num1} and {num2} is: {multiply(num1, num2)}");
            Console.WriteLine($"The smallest value of {num1} and {num2} is: {min(num1, num2)}");
        }
    }
}