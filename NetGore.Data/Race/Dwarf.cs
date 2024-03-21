using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Data.Race;

/// <summary>
/// Dwarves are a stoic but stern race, ensconced 
/// in cities carved from the hearts of mountains 
/// and fiercely determined to repel the depredations 
/// of savage races like orcs and goblins. More than 
/// any other race, dwarves have acquired a 
/// reputation as dour and humorless artisans 
/// of the earth.It could be said that their history 
/// shapes the dark disposition of many dwarves, 
/// for they reside in high mountains and dangerous 
/// realms below the earth, constantly at war with 
/// giants, goblins, and other such horrors.
/// </summary>
public class Dwarf
{
    /// <summary>
    /// Set the race traits for the creature.
    /// </summary>
    /// <param name="creature"></param>
    public Dwarf(Creature creature)
    {
        creature.RaceName = nameof(Dwarf);
        creature.Description = "Dwarves are a stoic " +
            "but stern race, ensconced in cities " +
            "carved from the hearts of mountains and " +
            "fiercely determined to repel the " +
            "depredations of savage races like orcs " +
            "and goblins. More than any other race, " +
            "dwarves have acquired a reputation as " +
            "dour and humorless artisans of the earth. " +
            "It could be said that their history shapes " +
            "the dark disposition of many dwarves, " +
            "for they reside in high mountains and " +
            "dangerous realms below the earth, " +
            "constantly at war with giants, goblins, " +
            "and other such horrors.";

        // Your Constitution score increases by 2.
        creature.Constitution.RacialModifier += 2;

        // Size. Dwarves stand between 4 and 5 feet tall
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
