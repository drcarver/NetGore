using Microsoft.Extensions.Logging;

using NetGore.Core.Interfaces;
using NetGore.Core.Models;

namespace NetGore.Data.Services;

public class ExampleService : IExampleService
{
    /// <summary>
    /// The injected logger for the service. 
    /// </summary>
    private readonly ILogger<IExampleService> logger;

    /// <summary>
    /// The injected database context
    /// </summary>
    private readonly NETGoreDbContext context;

    /// <summary>
    /// The Example service gets or updates the
    /// example table
    /// </summary>
    /// <param name="loggerFactory"></param>
    /// <param name="dbContext"></param>
    public ExampleService(ILoggerFactory loggerFactory, 
        NETGoreDbContext dbContext)
    {
        logger = loggerFactory.CreateLogger<ExampleService>();
        context = dbContext;
    }

    /// <summary>
    /// Get the list of examples
    /// </summary>
    public List<Example> GetExamples()
    {
        logger.LogInformation($"All examples from database");
        
        return context.Examples
            .OrderBy(e => e.Name)
            .ToList();
    }

    /// <summary>
    /// Add a new example to the database
    /// </summary>
    /// <param name="name">The name of the example</param>
    /// <param name="description">The description of the example</param>
    public void AddExample(string name, string? description = null)
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
