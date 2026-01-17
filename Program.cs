using System;

namespace dice_simulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dice throwing simulator");
            Console.Write("Number of rolls: ");

            int rollCount = int.Parse(Console.ReadLine());

            Dice cubeGame = new Dice();
            int[] finalNumbers = cubeGame.TossDice(rollCount);

            Console.WriteLine("Results");
            Console.WriteLine("* = 1%");
            Console.WriteLine("Total rolls = " + rollCount);

            for (int faceTotal = 2; faceTotal <= 12; faceTotal++)
            {
                int starAmount = (finalNumbers[faceTotal] * 100) / rollCount;

                Console.Write(faceTotal + ": ");
                for (int starCounter = 0; starCounter < starAmount; starCounter++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Done");
        }
    }
}
