using System;
using System.Collections;

namespace Mission_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");
            int numRolls = UserRollNumberPrompt();
            DiceRoller diceRoller = new DiceRoller(numRolls);

            for (int i = 0; i < numRolls; i++)
            {
                Random rnd = new Random();
                int rndDiceNum = rnd.Next(2, 13);
                diceRoller.RollDice(rndDiceNum);
            }

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = { diceRoller.totalNumberOfRolls }.");

            ArrayList returnPerc = diceRoller.CalculateAndReturnPercentages();
            foreach(string item in returnPerc)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
        private static int UserRollNumberPrompt()
        {
            bool validUserInput = true;
            int numRolls = 0;
            do
            {
                Console.Write("How many dice rolls would you like to simulate? ");
                string rollsInput = Console.ReadLine();
                try
                {
                    numRolls = Int32.Parse(rollsInput);
                    validUserInput = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please Enter a Valid Number");
                    validUserInput = false;
                }
            } while (!validUserInput);
            return numRolls;
        }
    }
}
