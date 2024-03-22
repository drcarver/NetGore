using Microsoft.Extensions.Logging;

using NetGore.Core.Models;

namespace NetGore.Data.Services;

public class AccountService
{
    private readonly ILogger<AccountService> logger;
    private readonly NETGoreDbContext context;

    /// <summary>
    /// The Account Service
    /// </summary>
    /// <param name="loggerFactory">The logger factory</param>
    /// <param name="dbContext">The DBContext</param>
    public AccountService(ILoggerFactory loggerFactory,
        NETGoreDbContext dbContext)
    {
        logger = loggerFactory.CreateLogger<AccountService>();
        context = dbContext;
    }

    /// <summary>
    /// Get the list of examples from the database
    /// </summary>
    public List<Account> GetAccounts()
    {
        logger.LogInformation($"All accounts from the database");
        return context.Accounts
            .OrderBy(e => e.Name)
            .ToList();
    }

    /// <summary>
    /// Add a Account to the database
    /// </summary>
    /// <param name=account>The account to be added.</param>
    public void AddAccount(Account account)
    {
        logger.LogInformation($"Adding account: {account?.Name}");

        if (account != null)
        {
            _ = context.Accounts.Contains(account)
                ? context.Accounts.Update(account)
                : context.Accounts.Add(account);
            context.SaveChanges();
        }
    }
}
