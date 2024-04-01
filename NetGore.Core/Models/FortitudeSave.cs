using System.Diagnostics.CodeAnalysis;

using Microsoft.Extensions.Logging;

using NetGore.Core.Base;

namespace NetGore.Core.Models;

public class FortitudeSave : SavingThrow
{
    /// <summary>
    /// Fortitude Save
    /// </summary>
    /// <param name="logger">The logger</param>
    /// <param name="creature">The creature the save is for</param>
    [SetsRequiredMembers]
    public FortitudeSave(ILogger logger, Creature creature) 
        : base(logger, creature.Constitution, creature)
    {
        Name = "Fortitude Save";
        Description = "These saves measure your ability " +
            "to stand up to physical punishment or " +
            "attacks against your vitality and health. " +
            "Apply your Constitution modifier to your " +
            "Fortitude saving throws.";
    }
}
