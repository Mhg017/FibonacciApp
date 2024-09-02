using System;

namespace FibonacciApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the position of the Fibonacci sequence you want (e.g., 5, 10, 20):");

            // Read user input
            if (int.TryParse(Console.ReadLine(), out int position) && position >= 0)
            {
                // Calculate Fibonacci number at the specified position
                long result = Fibonacci(position);
                Console.WriteLine($"Fibonacci({position}) = {result}");
            }
            else
            {
                Console.WriteLine("Please enter a valid non-negative integer.");
            }

            // Keep the console open
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        // Recursive Fibonacci function
        static long Fibonacci(int n)
        {
            if (n <= 1) return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}