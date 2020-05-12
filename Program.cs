using System;

namespace RecursiveFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to find the factorial of it:");
            var num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The facotrial of {num} is {Factorial(num)}. ");
        }

        static int Factorial(int aNumber)
        {
            if (aNumber == 1)
            {
                return 1;
            }
            else
            {
                return aNumber * Factorial(aNumber - 1);
            }
        }
    }
}
