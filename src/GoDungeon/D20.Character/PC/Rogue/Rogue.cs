using System.Diagnostics.CodeAnalysis;

using D20.Character.Enum;
using D20.Character.Interfaces;
using D20.Character.Models;
using D20.Character.PC.Barbarian;
using D20.Core.Enum;
using D20.Goods.Enum;

using Microsoft.Extensions.Logging;

namespace D20.Character.PC.Rogue;

public class Rogue : CharacterClassBase
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
        var rogueLevelTable = serviceProvider.GetService<IRogueLevelTable>();
    }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Rogue(
        IServiceProvider services,
        ILoggerFactory loggerFactory)
        : base(loggerFactory)
    {
        serviceProvider = services;
        Name = nameof(Rogue);
        Description =
            "Life is an endless adventure for those who live by " +
            "their wits.Ever just one step ahead of danger, rogues " +
             "bank on their cunning, skill, and charm to bend fate " +
            "to their favor. Never knowing what to expect, they prepare " +
            "for everything, becoming masters of a wide variety of skills, " +
            "training themselves to be adept manipulators, agile acrobats, " +
            "shadowy stalkers, or masters of any of dozens of other " +
            "professions or talents. Thieves and gamblers, fast talkers " +
            "and diplomats, bandits and bounty hunters, and explorers " +
            "and investigators all might be considered rogues, as well " +
            "as countless other professions that rely upon wits, prowess, " +
            "or luck. Although many rogues favor cities and the " +
            "innumerable opportunities of civilization, some embrace " +
            "lives on the road, journeying far, meeting exotic people, " +
            "and facing fantastic danger in pursuit of equally fantastic " +
            "riches. In the end, any who desire to shape their fates and " +
            "live life on their own terms might come to be called rogues.";
    }
}
