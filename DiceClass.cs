using Mission2Fun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Fun
{
    // now create the DiceClass for the Program.cs to call
    public class DiceClass
    {
        public static int[] SimulateDiceRolls(int rolls)
        {
            //call this outside the loop to get a random roll each time
            Random random = new Random();
            int[] results = new int[rolls];

            // start the loop to go through each of the dice
            for (int i = 0; i < rolls; i++)
            {
                //roll the dice and add the numbers, indexing the sum into the array.
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);
                results[i] = (dice1 + dice2);
            }

            return results;
        }
    }
}