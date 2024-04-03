using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Base;

namespace NetGore.Items;

public class ArmorEntry : DataObject
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public ArmorEntry()
    {
    }

    public ArmorProficiencyEnum ArmorProficiencyEnum { get; set; }
    public int? MaxDexterity { get; set; }
    public int? Strength { get; set; }
    public bool Stealth { get; set; }
    public int Weight { get; set; }
    public int Cost { get; set; }
    public CoinTypeEnum CoinType { get; set; }
    public int AC { get; internal set; }
}
