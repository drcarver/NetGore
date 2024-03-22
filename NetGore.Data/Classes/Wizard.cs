using System.Diagnostics.CodeAnalysis;

using NetGore.Core;
using NetGore.Core.Base;
using NetGore.Core.Enum;
using NetGore.Core.Interfaces;
using NetGore.Core.Models;

namespace NetGore.Data.Classes;

public class Wizard : DataObject, ICharacterClass
{
    /// <summary>
    /// The class enum
    /// </summary>
    public ClassEnum Class { get; set; }

    /// <summary>
    /// The level in the class (can be different
    /// from the characer level for multiclass 
    /// characters).
    /// </summary>
    public int Level { get; set; }

    /// <summary>
    /// The hit dice for the class
    /// </summary>
    public string HitDice { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Wizard()
    {
        Name = nameof(Wizard);
        Description = "While universalist " +
            "wizards might study to prepare " +
            "themselves for any manner of " +
            "danger, specialist wizards " +
            "research schools of magic that " +
            "make them exceptionally skilled " +
            "within a specific focus. Yet no " +
            "matter their specialty, all " +
            "wizards are masters of the " +
            "impossible and can aid their " +
            "allies in overcoming any danger.";
        HitDice = "1d6";
        Class = ClassEnum.Wizard;
        Level = 1;
    }
}
