using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Base;

/// <summary>
/// The base object for all models
/// </summary>
public class BaseObject : IBaseObject
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
    public string Name { get; set; }

    /// <summary>
    /// The Description of the object
    /// </summary>
    [Description("The Description of the object.")]
    public string Description { get; set; }  = string.Empty;

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public BaseObject()
    {
        Id = Guid.NewGuid();
        Name = string.Empty;
    }
}
