using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Data.Race;

public class Tiefling
{
    /// <summary>
    /// Set the race traits for the creature.
    /// </summary>
    /// <param name="creature"></param>
    public Tiefling(Creature creature)
    {
        creature.RaceName = nameof(Tiefling);
        creature.RaceDescription =
            "Simultaneously more and less than " +
            "mortal, tieflings are the offspring " +
            "of humans and fiends. With otherworldly " +
            "blood and traits to match, tieflings " +
            "are often shunned and despised out of " +
            "reactionary fear. Most tieflings never " +
            "know their fiendish sire, as the " +
            "coupling that produced their curse " +
            "occurred generations earlier. The taint " +
            "is long-lasting and persistent, often " +
            "manifesting at birth or sometimes later " +
            "in life, as a powerful, though often " +
            "unwanted, boon. Despite their fiendish " +
            "appearance and netherworld origins, " +
            "tieflings have a human’s capacity of " +
            "choosing their fate, and while many " +
            "embrace their dark heritage and side " +
            "with fiendish powers, others reject " +
            "their darker predilections. Though the " +
            "power of their blood calls nearly every " +
            "tiefling to fury, destruction, and wrath, " +
            "even the spawn of a succubus can become " +
            "a saint and the grandchild of a pit fiend " +
            "an unsuspecting hero.";

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