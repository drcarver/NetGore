namespace NetGore.Core.Interfaces;

public interface IBaseObject
{
    /// <summary>
    /// The Id for the object
    /// </summary>
    Guid Id { get; }

    /// <summary>
    /// The name of the object
    /// </summary>
    string? Name { get; set; }

    /// <summary>
    /// The Description of the object
    /// </summary>
    string? Description { get; set; }

    /// <summary>
    /// Is the object marked for deletion?
    /// </summary>
    bool IsDeleted { get; set; }

    /// <summary>
    /// Date and Time the object was created
    /// </summary>
    DateTime CreatedAt { get; }

    /// <summary>
    /// Date and Time the object was last updated
    /// </summary>
    DateTime UpdatedAt { get; }
}
