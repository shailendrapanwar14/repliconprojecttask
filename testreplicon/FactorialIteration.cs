using System;
namespace testreplicon
{
    class FactorialIteration
    {
        static int factorial(int n)
        {
            int res = 1, i;

            for (i = 2; i <= n; i++)
                res *= i;
            return res;
        }


        public void Run()
        {
            Console.WriteLine("Enter a Non-Negative integer to calculate factorial :->");

            string line = Console.ReadLine();

            int num;
            if (int.TryParse(line, out num))
            {
                if (num >= 0)
                {
                    Console.WriteLine("Factorial of " +
                       num + " is " + factorial(num));
                }
                else
                    Console.WriteLine("Invalid Input! \nPlease Provide only a Non-Negative Integer");
            }
            else
                Console.WriteLine("Invalid Input ! \nString is not allowed");
        }
    }
}
