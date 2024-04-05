using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class InventorySlot : BaseObject, IInventorySlot
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected InventorySlot()
    {
    }
}