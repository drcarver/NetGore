using NetGore.Core.Models;

namespace NetGore.Core.Interfaces
{
    public interface IQuestRequireStartQuest
    {
        Quest Quest { get; set; }
        Quest ReqQuest { get; set; }
    }
}