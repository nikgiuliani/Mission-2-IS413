using System;
using System.Collections;
using System.Collections.Generic;
namespace Mission_2
{
    public class DiceRoller
    {
        Dictionary<int, int> numbersRolled = new Dictionary<int, int>();
        public double totalNumberOfRolls;
        public DiceRoller(int numRolls)
        {
            for (int i = 2; i < 13; i++)
            {
                numbersRolled.Add(i, 0);
                totalNumberOfRolls = numRolls;
            }
        }
        public void RollDice(int number)
        {
            int chosenKey = 0;
            foreach(KeyValuePair<int, int> e in numbersRolled)
            {
                if (e.Key == number)
                {
                    chosenKey = number;
                    break;
                }
            }
            numbersRolled[chosenKey]++;
        }
        public ArrayList CalculateAndReturnPercentages()
        {
            string valueToBeAdded;
            ArrayList finalTallies = new ArrayList();
            foreach (KeyValuePair<int, int> e in numbersRolled)
            {
                valueToBeAdded = e.Key + ": " + CalculateStarsReturned(e.Value);
                finalTallies.Add(valueToBeAdded);
            }
            return finalTallies;
        }
        public string CalculateStarsReturned(double numberOfCurrentRolls)
        {
            string returnString = "";
            double percentage = (numberOfCurrentRolls / totalNumberOfRolls) * 100;
            for (int i = 0; i < Math.Floor(percentage); i++)
            {
                returnString += '*';
            }
            return returnString;
        }
    }
}
