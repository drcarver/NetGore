using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public abstract class BaseObject : IBaseObject
{
    /// <summary>
    /// The Id for the object
    /// </summary>
    [Key]
    [Comment("Primary key of the object.")]
    public Guid Id { get; set; } = Guid.NewGuid();

    /// <summary>
    /// The name of the object
    /// </summary>
    [MaxLength(80)]
    [Comment("The Name of the object.")]
    public string? Name { get; set; }

    /// <summary>
    /// The Description of the object
    /// </summary>
    [Comment("The Description of the object.")]
    public string? Description { get; set; }
}
