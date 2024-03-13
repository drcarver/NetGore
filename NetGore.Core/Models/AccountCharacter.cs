using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class AccountCharacter : BaseObject, IAccountCharacter
{
    /// <summary>
    /// The account the character is on.
    /// </summary>
    [Required]
    [Description("The account the character is on.")]
    [Comment("The account the character is on.")]
    public required Account Account { get; set; }

    /// <summary>
    /// The character in the account.
    /// </summary>
    [Required]
    [Description("The character in the account.")]
    [Comment("The character in the account.")]
    public required Character Character { get; set; }

    /// <summary>
    /// When the character was removed from the account 
    /// (NULL if not removed).
    /// </summary>
    [Description("When the character was removed from the account (NULL if not removed).")]
    [Comment("When the character was removed from the account (NULL if not removed).")]
    public DateTime? TimeDeleted { get; set; }
}
