using System;

namespace perfect_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());

            for(int i=Math.Min(num1 ,num2);i<=Math.Max(num1,num2);i++ )
            {
                int sum = 0;
                for(int j=1;j<i;j++)
                {
                    if (i % j == 0)
                        sum += j;
                }
                if (sum == i)
                    Console.WriteLine(i + "is a perfect number");
            }
               
        }
    }
}
