using System.Diagnostics.CodeAnalysis;

using D20.Character.Enum;
using D20.Character.Interfaces;
using D20.Core.Models;

namespace D20.Character.Models;

public class ClassFeatureLevelEntry : StandardTableEntry, IClassFeatureLevelEntry
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public ClassFeatureLevelEntry()
    {
    }

    /// <summary>
    /// The class feature level
    /// </summary>
    public int Level { get; set; }

    /// <summary>
    /// The base proficiency for this level
    /// </summary>
    public int BaseProficiency { get; set; }

    /// <summary>
    /// The class features
    /// </summary>
    public List<ClassFeatureEnum>? ClassFeatures { get; set; }
}
