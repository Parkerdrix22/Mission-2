using System;

namespace DiceSimulator
{
    internal class Dice
    {
        public int[] RollDice(int rolls)
        {
            int[] results = new int[13];
            Random rand = new Random();

            for (int i = 0; i < rolls; i++)
            {
                int die1 = rand.Next(1, 7);
                int die2 = rand.Next(1, 7);

                results[die1 + die2]++;
            }

            return results;
        }
    }
}

