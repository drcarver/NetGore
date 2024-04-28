using System.Diagnostics.CodeAnalysis;
using GoDungeon.Core.Enum;
using GoDungeon.Goods.Enum;

using GoDungeon.Character.Interfaces;

using Microsoft.Extensions.Logging;
using GoDungeon.Character.ViewModels;

namespace GoDungeon.Character.PC.Sorcerer;

/// <summary>
/// Sorcerers have a talent for song and story, and they come to 
/// their careers by developing this talent as they pick up 
/// on a smattering of other skills. 
/// </summary>
public class Sorcerer : CharacterClassBaseViewModel
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
        var SorcererLevelTable = serviceProvider.GetService<ISorcererLevelTable>();
    }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Sorcerer(
        IServiceProvider services,
        ILoggerFactory loggerFactory)
        : base(loggerFactory)
    {
        serviceProvider = services;
        Name = nameof(Sorcerer);
        Description =
            "Sorcerers have a talent for song and story, and they come to " +
            "their careers by developing this talent as they pick up " +
            "on a smattering of other skills.";
    }
}
