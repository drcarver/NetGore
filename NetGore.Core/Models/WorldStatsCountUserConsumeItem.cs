using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class WorldStatsCountUserConsumeItem : BaseObject, IWorldStatsCountUserConsumeItem
{
    /// <summary>
    /// The amount of the item that the user has consumed.
    /// </summary>
    [Description("The amount of the item that the user has consumed.")]
    public int Count { get; set; }

    /// <summary>
    /// The item template that this consumption counter 
    /// is for.
    /// </summary>
    [Description("The item template that this consumption counter is for.")]
    public ItemTemplate? ItemTemplate { get; set; }

    /// <summary>
    /// Character this counter is for. Logically, it 
    /// should be a user (not persistent NPC).
    /// </summary>
    [Description("Character this counter is for. Logically, it should be a user (not persistent NPC).")]
    public PlayerCharacter? User { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected WorldStatsCountUserConsumeItem()
    {
    }
}
