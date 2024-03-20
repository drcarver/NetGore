using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class ActiveTradeItem : BaseObject, IActiveTradeItem
{
    /// <summary>
    /// The character that added the item.
    /// </summary>
    [Description("The character that added the item.")]
    public Character? Character { get; set; }

    /// <summary>
    /// The item the character put down.
    /// </summary>
    [Description("The item the character put down.")]
    public required Item? Item { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public ActiveTradeItem()
    {
    }
}
