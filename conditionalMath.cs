using System;

namespace ConditionalMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your name");
            String name = Console.ReadLine();
            Console.WriteLine("Write first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write second number");
            int b = Convert.ToInt32(Console.ReadLine());
            int lenght = name.Length;
            int sum = a + b;

            if (lenght < sum)
            {
                Console.WriteLine($"Number {a} un {b} sum is {sum}, which is greater than your name lenght");
            }
            else if (lenght > sum)
            {
                Console.WriteLine($"Number {a} un {b} sum is {sum}, which is less than your name lenght");
            }
            else
                Console.WriteLine($"Number {a} un {b} sum is {sum}, which is eaqual with your name lenght");

            Console.WriteLine("and");

            if (a > b)
            {
                Console.WriteLine($"{a} is greater than {b}");
            }
            else if (a < b)
            {
                Console.WriteLine($"{b} is greater than {a}");
            }
            else
            {
                Console.WriteLine($"{a} is equal with {b}");
            }
        }
    }
}
