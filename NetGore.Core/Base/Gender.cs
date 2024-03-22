using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Enum;

namespace NetGore.Core.Base;

/// <summary>
/// The gender of the creature
/// </summary>
public class Gender : DataObject
{
    /// <summary>
    /// The gender as a enum
    /// </summary>
    public GenderEnum GenderEnum { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Gender()
    {
    }
}
