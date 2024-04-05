using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IQuestRequireStartQuest
{
    /// <summary>
    /// The quest that this requirement is for.
    /// </summary>
    Quest? Quest { get; set; }

    /// <summary>
    /// The quest that is required to be finished before 
    /// this quest can be started.
    /// </summary>
    Quest? ReqQuest { get; set; }
}