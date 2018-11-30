using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testreplicon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Program to Run 1: ATM WITHDRAWAL 2: FACTORIAL RECURSIVE 3: FACTORIAL ITERATIVE:");
            int key = Convert.ToInt32(Console.ReadLine());
            switch (key)
            {
                case 1:
                    {
                        var program1 = new ATMWithdrawal();
                        Console.WriteLine("ATM program is Running");
                        program1.Run();
                        break;
                    }
                case 2:
                    {
                        var program2 = new FactorialRecursion();
                        Console.WriteLine("Recusive Factorial program is Running");
                        program2.Run();
                        break;
                    }
                case 3:
                    {
                        var program3 = new FactorialIteration();
                        Console.WriteLine("Iterative Factorial program is Running");
                        program3.Run();
                        break;
                    }
                default:
                    throw new ArgumentOutOfRangeException("Value out of range " + key.ToString());
                    
                    
            }
        }
    }
}
