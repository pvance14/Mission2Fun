using Mission2Fun;
using System;
using System.Linq;

namespace Mission2Fun
{
    internal class Program
    {
        private static void Main()
        {
            // start by creating our first integer, how many rolls we'll use.
            int rolls;

            System.Console.WriteLine("Welcome to the dice throwing simulator! ");
            System.Console.WriteLine("");
            System.Console.Write("How many dice would you like to simulate? ");

            string inputrolls = System.Console.ReadLine();

            // change the input to our rolls variable
            rolls = int.Parse(inputrolls);

            //begin printing out the results
            System.Console.WriteLine("");
            System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            System.Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            System.Console.WriteLine("Total number of rolls = " + rolls + ".");

            //bring in the instance of the second class
            DiceClass diceclass = new DiceClass();

            // Call the SimulateDiceRolls method to get the array of results
            int[] results = DiceClass.SimulateDiceRolls(rolls);

            // Print the histogram
            for (int number = 2; number <= 12; number++)
            {
                // this next line is like an arrow function that chatGPT gave me.
                //      it looks for the number that we're seeking and if an entry in the array is similar, it counts it.
                int count = results.Count(result => result == number);
                int percentage = (count * 100) / rolls;

                Console.WriteLine($"{number}: {new string('*', percentage)}");
            }

            // finish the results
            System.Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
