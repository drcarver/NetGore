using System.Diagnostics.CodeAnalysis;

namespace NetGore.Core.Models;

public class DungeonObject : World
{
    public Guid ModuleId { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected DungeonObject()
    {
    }
}
