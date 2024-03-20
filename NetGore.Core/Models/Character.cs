using System.Diagnostics.CodeAnalysis;

using Microsoft.Extensions.Logging;

namespace NetGore.Core.Models;

public class Character : Creature
{
    /// <summary>
    /// Create a new Character
    /// </summary>
    [SetsRequiredMembers]
    public Character(ILoggerFactory loggerFactory)
        : base(loggerFactory)
    {
    }
}