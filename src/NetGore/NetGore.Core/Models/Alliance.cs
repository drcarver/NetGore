using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class Alliance : DataObject, IAlliance
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Alliance()
    {
    }
}