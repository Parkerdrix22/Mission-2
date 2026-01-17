using System;

namespace dice_simulator
{
    internal class Dice
    {
        public int[] TossDice(int howManyTimes)
        {
            int[] rollTotals = new int[13];
            Random numberPicker = new Random();

            for (int counter = 0; counter < howManyTimes; counter++)
            {
                int firstCube = numberPicker.Next(1, 7);
                int secondCube = numberPicker.Next(1, 7);

                rollTotals[firstCube + secondCube]++;
            }

            return rollTotals;
        }
    }
}

