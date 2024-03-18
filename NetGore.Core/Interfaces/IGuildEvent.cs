using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IGuildEvent
{
    /// <summary>
    /// The first optional event argument.
    /// </summary>
    string? Arg0 { get; set; }

    /// <summary>
    /// The second optional event argument.
    /// </summary>
    string? Arg1 { get; set; }

    /// <summary>
    /// The third optional event argument.
    /// </summary>
    string? Arg2 { get; set; }

    /// <summary>
    /// The character that invoked the event.
    /// </summary>
    Character? Character { get; set; }

    /// <summary>
    /// The ID of the event that took place.
    /// </summary>
    GuildEvents Event { get; set; }

    /// <summary>
    /// The guild the event took place on.
    /// </summary>
    Guild? Guild { get; set; }

    /// <summary>
    /// The optional character that the event involves.
    /// </summary>
    Character? TargetCharacter { get; set; }
}