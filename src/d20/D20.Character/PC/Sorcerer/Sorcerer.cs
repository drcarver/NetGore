using System.Diagnostics.CodeAnalysis;

using D20.Character.Interfaces;
using D20.Character.Models;
using D20.Core.Enum;
using D20.Goods.Enum;

namespace D20.Character.PC.Sorcerer;

/// <summary>
/// Sorcerers have a talent for song and story, and they come to 
/// their careers by developing this talent as they pick up 
/// on a smattering of other skills. 
/// </summary>
public class Sorcerer : CharacterClassBase
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
    public Sorcerer(IServiceProvider services)
    {
        serviceProvider = services;
        Name = nameof(Sorcerer);
        Description =
            "Sorcerers have a talent for song and story, and they come to " +
            "their careers by developing this talent as they pick up " +
            "on a smattering of other skills.";
    }
}
