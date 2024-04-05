using System.Diagnostics.CodeAnalysis;

using Microsoft.Extensions.Logging;

using NetGore.Core.Base;

namespace NetGore.Core.Models;

public class ReflexSave : SavingThrow
{
    /// <summary>
    /// Reflex Save
    /// </summary>
    /// <param name="logger">The logger</param>
    /// <param name="creature">The creature the save is for</param>
    [SetsRequiredMembers]
    public ReflexSave(ILogger logger, Creature creature) 
        : base(logger, creature.Dexterity, creature)
    {
        Name = "Reflex Save";
        Description = "These saves test your ability " +
            "to dodge area attacks and unexpected " +
            "situations. Apply your Dexterity " +
            "modifier to your Reflex saving throws.";
    }
}
