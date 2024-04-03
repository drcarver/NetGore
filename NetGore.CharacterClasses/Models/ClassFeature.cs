using System.Diagnostics.CodeAnalysis;

using NetGore.CharacterClasses.Enum;
using NetGore.CharacterClasses.Interfaces;
using NetGore.Core.Base;

namespace NetGore.CharacterClasses.Models;

/// <summary>
/// The class feature
/// </summary>
public class ClassFeature : BaseObject, IClassFeature
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public ClassFeature()
    {
    }
}
