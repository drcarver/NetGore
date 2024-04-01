using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Base;
using NetGore.Core.Enum;
using NetGore.Core.Interfaces;
using NetGore.Core.Models;

namespace NetGore.Data.Classes;

/// <summary>
/// Wizard The wizard masters magic through constant 
/// study that gives him incredible magical power.
/// </summary>
public class Wizard : DataObject, ICharacterClass
{
    /// <summary>
    /// The ability score prerequisite's for the class.   
    /// </summary>
    public List<ClassPrerequisite> ClassPrerequisites { get; set; } =
    [
        new ClassPrerequisite
        {
            Abbreviation = "INT",
            Score = 13
        },
    ];

    /// <summary>
    /// The class enum
    /// </summary>
    public ClassEnum ClassEnum { get; set; }

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
        ClassEnum = ClassEnum.Wizard;
    }
}
