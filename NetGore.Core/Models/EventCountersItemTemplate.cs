using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class EventCountersItemTemplate : BaseObject, IEventCountersItemTemplate
{
    /// <summary>
    /// The event counter.
    /// </summary>
    [Description("The event counter.")]
    public int Counter { get; set; }

    /// <summary>
    /// The template of the item the event occured on.
    /// </summary>
    [Description("The template of the item the event occured on.")]
    public ItemTemplate? ItemTemplate { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected EventCountersItemTemplate()
    {
    }
}
