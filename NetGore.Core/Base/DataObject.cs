using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Base;

/// <summary>
/// The baseobject for all data models
/// </summary>
public class DataObject : BaseObject, IDataObject
{
    /// <summary>
    /// Is the object marked for deletion?
    /// </summary>
    [Description("Is the object marked for deletion?")]
    public required bool IsDeleted { get; set; }

    /// <summary>
    /// Date and Time the object was created
    /// </summary>
    [Description("Date and Time the object was created")]
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Date and Time the object was last updated
    /// </summary>
    [Description("Date and Time the object was last updated")]
    public DateTime UpdatedAt { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public DataObject()
    {
        UpdatedAt = DateTime.UtcNow;
        CreatedAt = DateTime.UtcNow;
        IsDeleted = false;
    }
}
