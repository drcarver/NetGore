using System.ComponentModel.DataAnnotations;

using NetGore.Core.Interfaces;

namespace NetGore.Database.Entities;

public abstract class BaseEntity : IBaseObject
{
    /// <summary>
    /// THe Key for the entity
    /// </summary>
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    /// <summary>
    /// The name of the Entity
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// The Description of the Entity
    /// </summary>
    public string? Description { get; set; }
}
