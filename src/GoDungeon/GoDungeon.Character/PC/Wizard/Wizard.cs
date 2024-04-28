using System.Diagnostics.CodeAnalysis;
using GoDungeon.Core.Enum;
using GoDungeon.Goods.Enum;

using GoDungeon.Character.Interfaces;

using Microsoft.Extensions.Logging;
using GoDungeon.Character.ViewModels;

namespace GoDungeon.Character.PC.Wizard;

/// <summary>
/// Wizards have a talent for song and story, and they come to 
/// their careers by developing this talent as they pick up 
/// on a smattering of other skills. 
/// </summary>
public class Wizard : CharacterClassBaseViewModel
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
