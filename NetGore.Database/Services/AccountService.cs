using Microsoft.Extensions.Logging;

using NetGore.Core.Interfaces;
using NetGore.Core.Models;

namespace NetGore.Database.Services;

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
    public List<Example> GetExamples()
    {
        logger.LogInformation($"All examples from the database");
        return context.Examples
            .OrderBy(e => e.Name)
            .ToList();
    }

    /// <summary>
    /// Add a example to the database
    /// </summary>
    /// <param name="name">The name of the example.</param>
    /// <param name="description">The description of the example.</param>
    public void AddExample(string name, string? description)
    {
        logger.LogInformation($"Adding example: {name}");

        var example = new Example()
        {
            Name = name,
            Description = description
        };

        context.Examples.Add(example);
        context.SaveChanges();
    }
}
