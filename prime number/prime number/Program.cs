using System;

namespace prime_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());

            for (int i = Math.Min(num1, num2); i <= Math.Max(num1, num2); i++)
            {
                bool prime = true;
                for(int j=2;j<i;j++)
                {
                    if (i % j == 0)
                        prime = false;
                }

                if (prime == true && i > 1)
                    Console.WriteLine(i + "is prime");

            }

        }
    }
}
