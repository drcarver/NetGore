using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class QuestRequireFinishItem : BaseObject, IQuestRequireFinishItem
{
    /// <summary>
    /// The amount of the item required to finish this 
    /// quest.
    /// </summary>
    [Description("The amount of the item required to finish this quest.")]
    public int Amount { get; set; }

    /// <summary>
    /// The template of the item that is required for 
    /// this quest to be finished.
    /// </summary>
    [Description("The template of the item that is required for this quest to be finished.")]
    public ItemTemplate? ItemTemplate { get; set; }

    /// <summary>
    /// The quest that this requirement is for.
    /// </summary>
    [Description("The quest that this requirement is for.")]
    public Quest? Quest { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected QuestRequireFinishItem()
    {
    }
}
