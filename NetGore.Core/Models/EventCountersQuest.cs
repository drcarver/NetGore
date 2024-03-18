using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class EventCountersQuest : BaseObject, IEventCountersQuest
{
    /// <summary>
    /// The event counter.
    /// </summary>
    [Description("The event counter.")]
    public int Counter { get; set; }

    /// <summary>
    /// The ID of the event that the counter is for
    /// </summary>
    [Description("The ID of the event that the counter is for.")]
    public int QuestEventCounter { get; set; }

    /// <summary>
    /// The quest the event occured on.
    /// </summary>
    [Description("The quest the event occured on.")]
    public Quest? Quest { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected EventCountersQuest()
    {
    }
}
