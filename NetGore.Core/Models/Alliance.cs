using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class Alliance : BaseObject, IAlliance
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Alliance()
    {
    }
}