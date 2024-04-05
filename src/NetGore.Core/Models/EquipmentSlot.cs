using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class EquipmentSlot : BaseObject, IEquipmentSlot
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected EquipmentSlot()
    {
    }
}