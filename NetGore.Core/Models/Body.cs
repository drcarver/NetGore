using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class Body : BaseObject, IBody
{
    /// <summary>
    /// Create a new Account
    /// </summary>
    [SetsRequiredMembers]
    protected Body()
    {
    }
}