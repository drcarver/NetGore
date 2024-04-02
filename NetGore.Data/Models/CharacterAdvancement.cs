using System.Diagnostics.CodeAnalysis;

using NetGore.Core;
using NetGore.Core.Base;
using NetGore.Data.Interfaces;

namespace NetGore.Data.Models;

public class CharacterAdvancement : BaseObject, ICharacterAdvancement
{
    /// <summary>
    /// The number of levels in the table
    /// </summary>
    public int DiceSides { get; set; } = 20;

    /// <summary>
    /// The actual table
    /// </summary>
    public List<CharacterAdvancementEntry>? Table { get; set; }

    /// <summary>
    /// Get a entry from the table based on a random 
    /// dice roll
    /// </summary>
    /// <returns>The selected CharacterAdvancementTableEntry.</returns>
    public virtual CharacterAdvancementEntry? GetRandomEntry()
    {
        Dice dice = new($"1d{DiceSides}");
        return GetEntryByLevel(dice.Total);
    }

    /// <summary>
    /// Get a entry from the table by it's name
    /// </summary>
    /// <returns>The selected CharacterAdvancementTableEntry.</returns>
    public virtual CharacterAdvancementEntry? GetEntryByLevel(int level)
    {
        var te = Table?.First(t => t.Level == level);
        return te;
    }

    /// <summary>
    /// Get a entry from the table by it's name
    /// </summary>
    /// <returns>The selected CharacterAdvancementTableEntry.</returns>
    public virtual CharacterAdvancementEntry? GetEntryByExperiencePoints(int number)
    {
        var te = Table?.First(t =>
                        t.ExperiencePoints.End.Value >= number
                     && t.ExperiencePoints.Start.Value <= number);

        return te;
    }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public CharacterAdvancement()
    {
    }
}
