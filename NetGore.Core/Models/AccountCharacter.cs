using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class AccountCharacter : DataObject, IAccountCharacter
{
    /// <summary>
    /// The account the character is on.
    /// </summary>
    [Description("The account the character is on.")]
    public Account? Account { get; set; }

    /// <summary>
    /// The character in the account.
    /// </summary>
    [Description("The character in the account.")]
    public Character? Character { get; set; }

    /// <summary>
    /// When the character was removed from the account 
    /// (NULL if not removed).
    /// </summary>
    [Description("When the character was removed from the account (NULL if not removed).")]
    public DateTime? TimeDeleted { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public AccountCharacter()
    {
    }
}
