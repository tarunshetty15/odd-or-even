using System;
namespace odd_or_even
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the number");
            if (! int.TryParse(Console.ReadLine(), out int num))
            {
                Console.WriteLine("Invalid number");
                return;
            }
            Console.WriteLine($"{num} is {(num % 2 == 0 ? "Even" : "Odd")}");
        }
    }
}