using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class EventCountersItemTemplate : BaseObject, IEventCountersItemTemplate
{
    /// <summary>
    /// The event counter.
    /// </summary>
    [Description("The event counter.")]
    [Comment("The event counter.")]
    public int Counter { get; set; }

    /// <summary>
    /// The template of the item the event occured on.
    /// </summary>
    [Required]
    [Description("The template of the item the event occured on.")]
    [Comment("The template of the item the event occured on.")]
    public required ItemTemplate ItemTemplate { get; set; }
}
