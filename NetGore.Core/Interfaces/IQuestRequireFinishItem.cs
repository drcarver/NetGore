using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IQuestRequireFinishItem
{
    int Amount { get; set; }
    ItemTemplate ItemTemplate { get; set; }
    Quest Quest { get; set; }
}