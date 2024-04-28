using System.Diagnostics.CodeAnalysis;

using GoDungeon.Character.Interfaces;

using Microsoft.Extensions.Logging;
using GoDungeon.Character.ViewModels;

namespace GoDungeon.Character.PC.Druid;

/// <summary>
/// Druids come by their primal power in various ways. One 
/// druid might receive her power from an elemental creature, 
/// and another might learn it from a beast or the fey. 
/// </summary>
public class Druid : CharacterClassBaseViewModel, IDruid
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
        var DruidLevelTable = serviceProvider.GetService<IDruidLevelTable>();
    }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Druid(
        IServiceProvider services,
        ILoggerFactory loggerFactory)
        : base(loggerFactory)
    {
        serviceProvider = services;
        Name = nameof(Druid);
        Description =
            "Druids come by their primal power in various " +
            "ways. One druid might receive her power from " +
            "an elemental creature, and another might learn " +
            "it from a beast or the fey.";
    }
}
