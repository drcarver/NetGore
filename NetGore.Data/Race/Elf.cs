using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Data.Race;

public class Elf
{
    /// <summary>
    /// Set the race traits for the creature.
    /// </summary>
    /// <param name="creature"></param>
    public Elf(Creature creature)
    {
        creature.RaceName = nameof(Elf);
        creature.RaceDescription =
            "Your elf character has a variety " +
            "of natural abilities, the result " +
            "of thousands of years of elven refinement.";

        // Your Constitution score increases by 2.
        creature.Constitution.RacialModifier += 2;

        // Size. Elves stand between 4 and 5 feet tall
        // and average about 150 pounds. Your size is Medium.
        creature.Height = GetHeight(creature);
        creature.Weight = GetWeight(creature);
        creature.Size = SizeEnum.Medium;

        // Speed.Your base walking speed is 25 feet.
        // Your speed is not reduced by wearing
        // heavy armor
        creature.Speed = 25;
    }

    /// <summary>
    /// The dwarf weight (randomly generated)
    /// </summary>
    /// <param name="creature"></param>
    /// <returns>weight in pounds</returns>
    private int GetWeight(Creature creature)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// The dwarfs Height
    /// </summary>
    /// <param name="creature">The dwarf</param>
    /// <returns>height in feet and inches</returns>
    /// <exception cref="NotImplementedException"></exception>
    private string GetHeight(Creature creature)
    {
        throw new NotImplementedException();
    }

}