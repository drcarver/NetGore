using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Data.Race;

public class Gnome
{
    /// <summary>
    /// Set the race traits for the creature.
    /// </summary>
    /// <param name="creature"></param>
    public Gnome(Creature creature)
    {
        creature.RaceName = nameof(Gnome);
        creature.RaceDescription =
            "Your gnome character has certain " +
            "characteristics in common with all " +
            "other gnomes.";

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