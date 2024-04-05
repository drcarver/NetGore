
using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Base;

namespace NetGore.Items;

public class Itembase : BaseObject
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Itembase()
    {
    }

    public int Cost { get; set; }

    public CoinTypeEnum CoinType { get; set; }
}
