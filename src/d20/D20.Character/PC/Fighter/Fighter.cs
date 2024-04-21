using System.Diagnostics.CodeAnalysis;

using D20.Character.Interfaces;
using D20.Character.Models;
using D20.Core.Enum;
using D20.Goods.Enum;

namespace D20.Character.PC.Fighter;

public class Fighter : CharacterClassBase
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
        var FighterLevelTable = serviceProvider.GetService<IFighterLevelTable>();
    }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Fighter(IServiceProvider services)
    {
        serviceProvider = services;
        Name = nameof(Fighter);
        Description =
            "Fighters excel at combat—defeating their enemies, " +
            "controlling the flow of battle, and surviving " +
            "such sorties themselves. While their specific " +
            "weapons and methods grant them a wide variety " +
            "of tactics, few can match fighters for sheer " +
            "battle prowess.";
    }
}
