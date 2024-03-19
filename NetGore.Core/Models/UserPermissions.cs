using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class UserPermissions : BaseObject, IUserPermissions
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public UserPermissions()
    {
    }

}