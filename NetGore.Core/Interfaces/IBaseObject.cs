namespace NetGore.Core.Interfaces;

public interface IBaseObject
{
    /// <summary>
    /// The Id for the object
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// The name of the object
    /// </summary>
    string? Name { get; set; }

    /// <summary>
    /// The Description of the object
    /// </summary>
    string? Description { get; set; }
}
