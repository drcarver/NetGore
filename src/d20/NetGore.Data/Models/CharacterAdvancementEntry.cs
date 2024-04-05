using System.Diagnostics.CodeAnalysis;
using NetGore.Data.Interfaces;

namespace NetGore.Data.Models;

public class CharacterAdvancementEntry : GameTableEntry, ICharacterAdvancementEntry
{
    /// <summary>
    /// The sides to the dice for the table
    /// </summary>
    public int Level { get; set; }

    /// <summary>
    /// The Proficiency	Bonus for this level
    /// </summary>
    public int ProficiencyBonus { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public CharacterAdvancementEntry()
    {
    }
}
