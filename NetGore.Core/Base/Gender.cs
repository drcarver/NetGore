using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Enum;

namespace NetGore.Core.Base;

public class Gender : BaseObject
{
    public GenderEnum GenderEnum { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Gender()
    {
    }
}
