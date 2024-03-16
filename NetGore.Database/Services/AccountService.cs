using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

using NetGore.Core.Interfaces;

namespace NetGore.Database.Services;

public class AccountService
{
    private readonly IConfigurationRoot? config;
    private readonly ILogger<IExampleService> logger;
    private readonly NETGoreDbContext context;

    public AccountService(ILoggerFactory loggerFactory,
        IConfigurationRoot? configurationRoot,
        NETGoreDbContext dbContext)
    {
        logger = loggerFactory.CreateLogger<ExampleService>();
        config = configurationRoot;
        context = dbContext;
    }

    //public void GetExamples()
    //{
    //    logger.LogInformation($"All examples from database: {config?["ConnectionStrings:DefaultConnection"]}");

    //    var examples = context.Examples
    //        .OrderBy(e => e.Name)
    //        .ToList();

    //    foreach (var example in examples)
    //    {
    //        logger.LogInformation($"Name: {example.Name}");
    //    }
    //}

    //public void AddExample(string name)
    //{
    //    logger.LogInformation($"Adding example: {name}");

    //    var example = new Example()
    //    {
    //        Name = name
    //    };

    //    context.Examples.Add(example);
    //    context.SaveChanges();
    //}
}
