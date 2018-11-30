using System;
namespace testreplicon
{
    public class ATMWithdrawal
    {
        // define one time max limit to withdraw
        static readonly int maxlimit = 50000;

        public static void countCurrency(int amount)
        {
            if (amount % 5 == 0)
            {

                int[] notes = new int[] { 500, 100, 50, 10, 5 };
                int len = notes.Length;

                int[] noteCount = new int[len];


                for (int i = 0; i < len; i++)
                {
                    if (amount >= notes[i])
                    {
                        noteCount[i] = amount / notes[i];
                        amount = amount - noteCount[i] * notes[i];
                    }
                }


                Console.WriteLine("Currency Count ->");
                for (int i = 0; i < len; i++)
                {
                    if (noteCount[i] != 0)
                    {
                        Console.WriteLine(notes[i] + " * "
                            + noteCount[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid Amount! \nPlease Enter the amount in multiple of 5");

            }
        }


        public void Run()
        {

            Console.WriteLine("Enter Amount To Withdraw: ->");
            string line = Console.ReadLine();

            int amount;
            // TryParse will read the keyboard value whether it is integer or not
            if (int.TryParse(line, out amount))
            {
                // condition for max amount and minimum amount 
                if (amount > 0 && amount <= maxlimit)
                {
                    countCurrency(amount);
                }
                else
                {
                    Console.WriteLine("Invalid Input! \nPlease Enter the amount in Range");
                }
            }
            // There is No way to enter any value other than numeric values from ATM keyboard but handling as it maybe passed by some underline system !!
            else
            {
                Console.WriteLine("Invalid Input! \nString is not allowed");
            }
        }
    }
}
