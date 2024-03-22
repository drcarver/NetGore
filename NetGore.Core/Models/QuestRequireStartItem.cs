using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class QuestRequireStartItem : BaseObject, IQuestRequireStartItem
{
    /// <summary>
    /// The amount of the item that is required.
    /// </summary>
    [Description("The amount of the item that is required.")]
    public int Amount { get; set; }

    /// <summary>
    /// The template of the item that is required to 
    /// start the quest.
    /// </summary>
    [Description("The template of the item that is required to start the quest.")]
    public ItemTemplate? ItemTemplate { get; set; }

    /// <summary>
    /// Quest that this requirement is for.
    /// </summary>
    [Description("Quest that this requirement is for.")]
    public Quest? Quest { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected QuestRequireStartItem()
    {
    }
}
