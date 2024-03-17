using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IAccountCharacter
{
    /// <summary>
    /// The account the character is on.
    /// </summary>
    Account? Account { get; set; }

    /// <summary>
    /// The character in the account.
    /// </summary>
    Character? Character { get; set; }

    /// <summary>
    /// When the character was removed from the account 
    /// (NULL if not removed).
    /// </summary>
    DateTime? TimeDeleted { get; set; }
}