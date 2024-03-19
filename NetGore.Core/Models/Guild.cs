using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class Guild : BaseObject, IGuild
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected Guild()
    {
    }
}