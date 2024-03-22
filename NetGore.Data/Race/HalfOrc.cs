using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Data.Race;

public class HalfOrc
{
    /// <summary>
    /// Set the race traits for the creature.
    /// </summary>
    /// <param name="creature"></param>
    public HalfOrc(Creature creature)
    {
        creature.RaceName = nameof(HalfOrc);
        creature.RaceDescription =
            "Your half-­orc character has certain " +
            "traits deriving from your orc ancestry.";

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
    /// The character weight (randomly generated)
    /// </summary>
    /// <param name="creature"></param>
    /// <returns>weight in pounds</returns>
    private int GetWeight(Creature creature)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// The character Height
    /// </summary>
    /// <param name="creature">The dwarf</param>
    /// <returns>height in feet and inches</returns>
    /// <exception cref="NotImplementedException"></exception>
    private string GetHeight(Creature creature)
    {
        throw new NotImplementedException();
    }
}