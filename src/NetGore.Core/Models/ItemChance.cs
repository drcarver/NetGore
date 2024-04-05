using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class ItemChance : BaseObject, IItemChance
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected ItemChance()
    {
    }
}