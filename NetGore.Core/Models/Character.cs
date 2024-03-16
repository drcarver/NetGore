using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class Character : BaseObject, ICharacter
{
    /// <summary>
    /// Create a new Character
    /// </summary>
    [SetsRequiredMembers]
    protected Character()
    {
    }
}