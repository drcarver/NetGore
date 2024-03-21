using Microsoft.Extensions.Logging;
using NetGore.Core.Ablities;
using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Base;
using NetGore.Data.Interfaces;
using NetGore.Core.Enum;

namespace NetGore.Core.Models;

public class ClassInformation : BaseObject
{
    /// <summary>
    /// The class enum
    /// </summary>
    public ClassEnum Class { get; set; }

    /// <summary>
    /// The level in the class (can be different
    /// from the characer level for multiclass 
    /// characters).
    /// </summary>
    public int Level { get; set; }

    /// <summary>
    /// The hit dice for the class
    /// </summary>
    public string HitDice { get; set; } = "1d8";

    /// <summary>
    /// Allowed Alignments
    /// </summary>
    public List<AlignmentEnum> Alignments { get; set; } = new()
    {
        AlignmentEnum.Any
    };

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public ClassInformation()
    {
    }
}