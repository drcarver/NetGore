using System.Diagnostics.CodeAnalysis;

using D20.Character.Interfaces;
using D20.Character.Models;
using D20.Core.Enum;
using D20.Goods.Enum;

using Microsoft.Extensions.Logging;

namespace D20.Character.PC.Barbarian;

public class Barbarian : CharacterClassBase, IBarbarian
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
    }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Barbarian(ILoggerFactory loggerFactory, ServiceProvider services)
        : base(loggerFactory)
    {
        serviceProvider = services;

        Name = nameof(Barbarian);
        Description = "Barbarians excel in " +
            "combat, possessing the martial " +
            "prowess and fortitude to take " +
            "on foes seemingly far superior " +
            "to themselves. With rage granting " +
            "them boldness and daring beyond " +
            "that of most other warriors, " +
            "barbarians charge furiously into " +
            "battle and ruin all who would " +
            "stand in their way.";
    }
}
