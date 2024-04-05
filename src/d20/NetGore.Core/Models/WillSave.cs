using System.Diagnostics.CodeAnalysis;

using Microsoft.Extensions.Logging;

using NetGore.Core.Base;

namespace NetGore.Core.Models;

public class WillSave : SavingThrow
{
    /// <summary>
    /// Will Save
    /// </summary>
    /// <param name="logger">The logger</param>
    /// <param name="creature">The creature the save is for</param>
    [SetsRequiredMembers]
    public WillSave(ILogger logger, Creature creature) 
        : base(logger, creature.Wisdom, creature)
    {
        Name = "Will Save";
        Description = "These saves reflect your " +
            "resistance to mental influence as well " +
            "as many magical effects. Apply your " +
            "Wisdom modifier to your Will saving throws.";
    }
}
