using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class ItemTemplate : BaseObject, IItemTemplate
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected ItemTemplate()
    {
    }
}