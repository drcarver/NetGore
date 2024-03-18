using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class QuestRequireStartQuest : BaseObject, IQuestRequireStartQuest
{
    /// <summary>
    /// The quest that this requirement is for.
    /// </summary>
    [Description("The quest that this requirement is for.")]
    public Quest? Quest { get; set; }

    /// <summary>
    /// The quest that is required to be finished before 
    /// this quest can be started.
    /// </summary>
    [Description("The quest that is required to be finished before this quest can be started.")]
    public Quest? ReqQuest { get; set; }
    
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected QuestRequireStartQuest()
    {
    }
}
