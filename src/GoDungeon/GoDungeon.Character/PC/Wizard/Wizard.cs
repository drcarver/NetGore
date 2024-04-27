using System.Diagnostics.CodeAnalysis;

using D20.Character.Models;
using D20.Core.Enum;
using D20.Goods.Enum;

using GoDungeon.Character.Interfaces;

using Microsoft.Extensions.Logging;

namespace D20.Character.PC.Wizard;

/// <summary>
/// Wizards have a talent for song and story, and they come to 
/// their careers by developing this talent as they pick up 
/// on a smattering of other skills. 
/// </summary>
public class Wizard : CharacterClassBase
{
    /// <summary>
    /// The DI service provider
    /// </summary>
    private readonly IServiceProvider serviceProvider;

    /// <summary>
    /// Level up the character with this class
    /// </summary>
    /// <param name="character"></param>
    public override void LevelUp(ICharacter character)
    {
        var WizardLevelTable = serviceProvider.GetService<IWizardLevelTable>();
    }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Wizard(
        IServiceProvider services,
        ILoggerFactory loggerFactory)
        : base(loggerFactory)
    {
        serviceProvider = services;
        Name = nameof(Wizard);
        Description =
            "Wizards have a talent for song and story, and they come to " +
            "their careers by developing this talent as they pick up " +
            "on a smattering of other skills.";
    }
}
