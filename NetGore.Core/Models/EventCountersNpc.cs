using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class EventCountersNpc : BaseObject, IEventCountersNpc
{
    /// <summary>
    /// The event counter.
    /// </summary>
    [Description("The event counter.")]
    public int Counter { get; set; }

    /// <summary>
    /// The ID of the event that the counter is for.
    /// </summary>
    [Description("The ID of the event that the counter is for.")]
    public int NPCEventCounter { get; set; }

    /// <summary>
    /// The character template of the NPC the event 
    /// occured on.
    /// </summary>
    [Description("The character template of the NPC the event occured on.")]
    public CharacterTemplate? NPCTemplate { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected EventCountersNpc()
    {
    }
}
