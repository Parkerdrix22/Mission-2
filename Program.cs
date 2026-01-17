using System;

namespace DiceSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");

            int rolls = int.Parse(Console.ReadLine());

            Dice dice = new Dice();
            int[] results = dice.RollDice(rolls);

            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + rolls + ".\n");

            for (int i = 2; i <= 12; i++)
            {
                int percent = (results[i] * 100) / rolls;

                Console.Write(i + ": ");
                for (int j = 0; j < percent; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
