namespace NetGore.Core.Models;

/// <summary>
/// The class prerequisites.  The abilities required 
/// for the class
/// </summary>
public class ClassPrerequisite
{
    /// <summary>
    /// The Abbreviation for the ability
    /// </summary>
    public string? Abbreviation { get; set; }

    /// <summary>
    /// The ability score
    /// </summary>
    public int Score { get; set; }

    /// <summary>
    /// Does the ability have a high enough score?
    /// </summary>
    /// <param name="creature">The creature to test</param>
    /// <returns>True if the ability is high enough</returns>
    public bool AbilityAcceptable(Creature creature)
    {
        switch (Abbreviation)
        {
            case "STR":
                return Score >= creature.Strength.BaseAbility +
                    creature.Strength.RacialModifier;
            case "INT":
                return Score >= creature.Intelligence.BaseAbility +
                    creature.Intelligence.RacialModifier;
            case "WIS":
                return Score >= creature.Wisdom.BaseAbility +
                    creature.Wisdom.RacialModifier;
            case "DEX":
                return Score >= creature.Dexterity.BaseAbility +
                    creature.Dexterity.RacialModifier;
            case "CON":
                return Score >= creature.Constitution.BaseAbility +
                    creature.Constitution.RacialModifier;
            case "CHA":
                return Score >= creature.Charisma.BaseAbility +
                    creature.Charisma.RacialModifier;

        }
        return false;
    }
}