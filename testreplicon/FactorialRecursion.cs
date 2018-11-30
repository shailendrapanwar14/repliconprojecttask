using System;
namespace testreplicon
{
    class FactorialRecursion
    {
        public void Run()
        {

            Console.WriteLine("Enter a Non-Negative integer to calculate factorial :->");

            string line = Console.ReadLine();

            int num;

            if (int.TryParse(line, out num))
            {
              
                 if (num >= 0)
                {
                    Console.WriteLine("Factorial of "
                    + num + " is " + factorial(num));
                }

                else
                {
                    Console.WriteLine("Invalid Input ! \nplease Provide an Non-Negative Integer");
                }
            }
            else

                Console.WriteLine("Invalid Input ! \nString is not allowed");

        }

        static int factorial(int n)
        {
            if (n == 0)
                return 1;

            return n * factorial(n - 1);
        }

    }
}
