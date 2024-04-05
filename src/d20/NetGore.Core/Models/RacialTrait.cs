using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Base;

namespace NetGore.Core.Models;

public class RacialTrait : DataObject
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public RacialTrait(string name)
    {
        Name = name;
    }
}
