namespace NetGore.Core.Interfaces;

public interface IDataObject
{
    /// <summary>
    /// Is the object marked for deletion?
    /// </summary>
    bool IsDeleted { get; set; }

    /// <summary>
    /// Date and Time the object was created
    /// </summary>
    DateTime CreatedAt { get; set; }

    /// <summary>
    /// Date and Time the object was last updated
    /// </summary>
    DateTime UpdatedAt { get; set; }
}