using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IAccountCharacter
{
    Account Account { get; set; }
    Character Character { get; set; }
    DateTime? TimeDeleted { get; set; }
}