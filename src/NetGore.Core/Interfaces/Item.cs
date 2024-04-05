using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public class Item : BaseObject, IItem
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected Item()
    {
    }
}