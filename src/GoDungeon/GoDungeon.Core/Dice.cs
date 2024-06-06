using System;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;

namespace GoDungeon.Core
{
    /// <summary>
    /// Roll a dice
    /// </summary>
    public class Dice
    {
        /// <summary>
        /// The dice rolls
        /// </summary>
        public int[] Rolls { get; private set; } = Array.Empty<int>();

        /// <summary>
        /// The total of all dice rolls
        /// </summary>
        public int Total { get; private set; }

        /// <summary>
        /// The number of sides to the dice
        /// </summary>
        public int Sides { get; private set; }

        /// <summary>
        /// The dice to be rolled
        /// </summary>
        /// <param name="input">The dice express</param>
        public Dice(string input)
        {
            Total = RollDice(input);
        }

        /// <summary>
        /// The modifier for the dice roll
        /// </summary>
        private int Modifier { get; set; }

        /// <summary>
        /// Roll the dice
        /// </summary>
        /// <param name="input">The dice expression</param>
        /// <returns>The roll of the dice</returns>
        public int RollDice(string input)
        {
            // Parsing the input string
            string[] rawDie = input.ToLower().Replace(" ", string.Empty).Split('d');
            string[] die;
            string[] parts;
            if (rawDie.Length != 2)
            {
                return 0;
            }
            if (rawDie[1].Contains("-"))
            {
                parts = rawDie[1].Split('-');
            }
            else
            {
                parts = rawDie[1].Split('+');
            }

            int numDice;
            int sides;
            int modifier = 0;
            int.TryParse(rawDie[0].Trim(), out numDice);
            int.TryParse(parts[0].Trim(), out sides);
            if (parts.Length == 2)
            {
                int.TryParse(parts[1].Trim(), out modifier);
            }
            
            Sides = sides;
            Modifier = modifier;
            var rolls = new int[numDice];
            if (sides > 0)
            {
                using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
                {
                    for (int i = 0; i < numDice; i++)
                    {
                        rolls[i] = RandomNumberGenerator.GetInt32(Sides) + 1;
                    }
                }
            }
            else
            {
                return 0;
            }

            Rolls = rolls.OrderByDescending(i => i).ToArray();
            int sum = Rolls.Sum() + Modifier;
            return sum;
        }

        /// <summary>
        /// Return the dice roll as a string
        /// </summary>
        /// <returns>The dice roll as a string</returns>
        public override string ToString()
        {
            string roll;
            if (Modifier > 0)
            {
                roll = $"{Rolls.Length}d{Sides}+{Modifier} Total={Total} ";
            }
            else
            {
                roll = $"{Rolls.Length}d{Sides} Total={Total} ";
            }
            for (int i = 0; i <= Rolls.Length - 1; i++)
            {
                roll += $"Dice {i}={Rolls[i]}, ";
            }
            if (Modifier > 0)
            {
                roll += $" Modifier={Modifier}";
            }
            return roll;
        }
    }

}
