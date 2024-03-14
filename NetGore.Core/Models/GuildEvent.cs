using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

using NetGore.Core.Enum;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class GuildEvent : BaseObject, IGuildEvent
{
    /// <summary>
    /// The first optional event argument.
    /// </summary>
    [Description("The first optional event argument.")]
    [Comment("The first optional event argument.")]
    public string? Arg0 { get; set; }

    /// <summary>
    /// The second optional event argument.
    /// </summary>
    [Description("The second optional event argument.")]
    [Comment("The second optional event argument.")]
    public string? Arg1 { get; set; }

    /// <summary>
    /// The third optional event argument.
    /// </summary>
    [Description("The third optional event argument.")]
    [Comment("The third optional event argument.")]
    public string? Arg2 { get; set; }

    /// <summary>
    /// The character that invoked the event.
    /// </summary>
    [Description("The character that invoked the event.")]
    [Comment("The character that invoked the event.")]
    public required Character Character { get; set; }

    /// <summary>
    /// When the event was created.
    /// </summary>
    [Description("When the event was created.")]
    [Comment("When the event was created.")]
    public DateTime Created { get; set; }

    /// <summary>
    /// The ID of the event that took place.
    /// </summary>
    [Description("The ID of the event that took place.")]
    [Comment("The ID of the event that took place.")]
    public GuildEvents Event { get; set; }

    /// <summary>
    /// The guild the event took place on.
    /// </summary>
    [Required]
    [Description("The guild the event took place on.")]
    [Comment("The guild the event took place on.")]
    public required Guild Guild { get; set; }

    /// <summary>
    /// The optional character that the event involves.
    /// </summary>
    [Description("The optional character that the event involves.")]
    [Comment("The optional character that the event involves.")]
    public Character? TargetCharacter { get; set; }
}
