using System;

namespace Mission2InClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // receive number of rolls from user
            Console.WriteLine("Enter the number of rolls: ");
            int numRolls = Convert.ToInt32(Console.ReadLine());

            float[] rollResults = new float[12];

            Random rnd = new Random();

            // 'roll' dice, add up two die values, and increment results array to totall num times a single number was rolled
            for (int i = 0; i < numRolls; i++)
            {
                int rollDie1 = rnd.Next(6);
                int rollDie2 = rnd.Next(6);

                int roll = rollDie1 + rollDie2;
                rollResults[roll]++;
            }
            // calculate percentage of total rolls one number is rolled and print out the asterisk graph to show percentages
            for (int i = 1; i < rollResults.Length; i++)
            {
                double roundedPercent = Math.Round(rollResults[i] / numRolls * 100);
                
                Console.WriteLine((i + 1) + ": " + new string('*', (int)roundedPercent));

                // rollResults[i] + "/" + numRolls + " - " + roundedPercent +
            }
        }
    }
}