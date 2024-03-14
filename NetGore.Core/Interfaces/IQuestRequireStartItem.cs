using NetGore.Core.Models;

namespace NetGore.Core.Interfaces
{
    public interface IQuestRequireStartItem
    {
        int Amount { get; set; }
        ItemTemplate ItemTemplate { get; set; }
        Quest Quest { get; set; }
    }
}