using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

/// <summary>
/// The baseobject for all models
/// </summary>
public abstract class BaseObject : IBaseObject
{
    /// <summary>
    /// The Id for the object
    /// </summary>
    [Description("Primary key of the object.")]
    public Guid Id { get; }

    /// <summary>
    /// The name of the object
    /// </summary>
    [MaxLength(80)]
    [Description("The Name of the object.")]
    public string? Name { get; set; }

    /// <summary>
    /// The Description of the object
    /// </summary>
    [Description("The Description of the object.")]
    public string? Description { get; set; }

    /// <summary>
    /// Is the object marked for deletion?
    /// </summary>
    [Description("Is the object marked for deletion?")]
    public required bool IsDeleted { get; set; }

    /// <summary>
    /// Date and Time the object was created
    /// </summary>
    [Description("Date and Time the object was created")]
    public DateTime CreatedAt { get; set;  }

    /// <summary>
    /// Date and Time the object was last updated
    /// </summary>
    [Description("Date and Time the object was last updated")]
    public DateTime UpdatedAt { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected BaseObject()
    {
        Id = Guid.NewGuid();
        UpdatedAt = DateTime.UtcNow;
        CreatedAt = DateTime.UtcNow;
        IsDeleted = false;
    }
}
