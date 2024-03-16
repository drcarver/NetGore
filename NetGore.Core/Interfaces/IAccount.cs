using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IAccount
{
    string? CreatorIp { get; set; }
    string? CurrentIp { get; set; }
    string? Email { get; set; }
    string? Friends { get; set; }
    string? Password { get; set; }
    UserPermissions? Permissions { get; set; }
    DateTime TimeCreated { get; set; }
    DateTime TimeLastLogin { get; set; }
}