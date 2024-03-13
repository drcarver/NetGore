namespace NetGore.Core;

public class Dice
{
    private static readonly Random random = new();

    public int[] Rolls { get; private set; } = new int[0];

    public int Total { get; private set; }

    public Dice(string input)
    {
        Total = RollDice(input);
    }

    public int RollDice(string input)
    {
        // Parsing the input string
        string[] parts = input.ToLower().Split('d', '+');
        int numDice = int.Parse(parts[0]);
        int sides = int.Parse(parts[1]);
        int modifier = parts.Length > 2 ? int.Parse(parts[2]) : 0;

        Rolls = new int[numDice];
        for (int i = 0; i < numDice; i++)
        {
            Rolls[i] = random.Next(1, sides + 1);
        }

        int sum = Rolls.Sum() + modifier;
        return sum;
    }
}

