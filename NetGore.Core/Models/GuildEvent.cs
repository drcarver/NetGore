using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Enum;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class GuildEvent : BaseObject, IGuildEvent
{
    /// <summary>
    /// The first optional event argument.
    /// </summary>
    [Description("The first optional event argument.")]
    public string? Arg0 { get; set; }

    /// <summary>
    /// The second optional event argument.
    /// </summary>
    [Description("The second optional event argument.")]
    public string? Arg1 { get; set; }

    /// <summary>
    /// The third optional event argument.
    /// </summary>
    [Description("The third optional event argument.")]
    public string? Arg2 { get; set; }

    /// <summary>
    /// The character that invoked the event.
    /// </summary>
    [Description("The character that invoked the event.")]
    public Character? Character { get; set; }

    /// <summary>
    /// The ID of the event that took place.
    /// </summary>
    [Description("The ID of the event that took place.")]
    public GuildEvents Event { get; set; }

    /// <summary>
    /// The guild the event took place on.
    /// </summary>
    [Description("The guild the event took place on.")]
    public Guild? Guild { get; set; }

    /// <summary>
    /// The optional character that the event involves.
    /// </summary>
    [Description("The optional character that the event involves.")]
    public Character? TargetCharacter { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected GuildEvent()
    {
    }
}
