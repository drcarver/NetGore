using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IAccountService
{
    /// <summary>
    /// Register a new account
    /// </summary>
    /// <param name="account"></param>
    void AddAccount(Account account);

    /// <summary>
    /// Get a list of accounts
    /// </summary>
    /// <returns></returns>
    List<Account> GetAccounts();
}